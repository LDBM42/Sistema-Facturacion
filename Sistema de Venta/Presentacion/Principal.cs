using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using Sistema_de_Venta.Presentacion;
using SisVenttas.Datos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sistema_de_Venta
{
    public partial class Form1 : Form
    {
        private static Form1 _Instancia;

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new BlueRenderer();
        }

        private int childFormNumber = 0;
        FRM_Login login = new FRM_Login();
        string UserTemp = Usuario.Nombre;
        string prodOrServ;
        string prodOrServ_Before;
        int minimizar = 0;

        public static Form1 GetInscance()
        {
            if (_Instancia == null)
                _Instancia = new Form1();
            return _Instancia;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Ventas>(0);
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Cliente>(0);
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodOrServ_Before = prodOrServ;
            prodOrServ = "P";
            AbrirFormulario<FRM_Producto>(0);
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodOrServ_Before = prodOrServ;
            prodOrServ = "S";
            AbrirFormulario<FRM_Producto>(1);
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Categoria>(0);

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Usuario>(0);
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab_encabezado.Text = "Auritoría               ";
            AbrirFormulario<FRM_Auditoria>(0);
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Factura factura = FRM_Factura.GetInscance();
            factura.ShowDialog();
        }


        private void cERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para saber si es el mismo usuario
            UserTemp = Usuario.Nombre;

            if (MessageBox.Show("¿Estás seguro de cerrar sección " +
                Usuario.Nombre + " " + Usuario.Apellido + "?", "Cerrar Sección",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form1.Log(Usuario.Nombreusuario, "Cerrar Sesion");
                Usuario.Logged = 0; // para desactivar autologgin
                //DESLOGEARSE
                if (!(FLogin.AutoLoginSet(Usuario.Nombreusuario, Usuario.Password, Usuario.Logged) == 1))
                {
                    MessageBox.Show("No se pudo hacer el cerrado de sección", "Cerado Sección");
                }
                else
                {
                    OpenSettings();
                }

            }
        }




        //Este es el metodo para hacer el LOG
        public static void Log(string usuario, string accion)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@usuario",SqlDbType.VarChar, 0, usuario),
                    FDBHelper.MakeParam("@fechaHora",SqlDbType.DateTime, 0, DateTime.Now),
                    FDBHelper.MakeParam("@accion", SqlDbType.VarChar, 0, accion)
                };
            FDBHelper.ExecuteDataSet("usp_Data_FLogin_LogLogin", dbParams);
        }






        private void OpenSettings()
        {

            try
            {   // para saber si el formulario existe, o sea si está abierto o cerrado
                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_Login").SingleOrDefault<Form>();

                if (existe != null)
                {
                    existe.Close();
                }


                pnl_Formularios.Controls.Clear(); // para cerrar todas las ventanas abiertas
                pnl_Formularios.Controls.Add(pbx_Logo);



                FRM_Login login = new FRM_Login();
                login.reOpened++;
                this.Hide();
                login.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.95;

            if (Usuario.Tipo != "Admin")
            {
                cONFIGURACIONESToolStripMenuItem.Visible = false;
            }
            else
            {
                cONFIGURACIONESToolStripMenuItem.Visible = true;
            }

            toolStripStatusLabel1.Text = "Usuario - " + Usuario.Nombre + " " + Usuario.Apellido;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mejora para asegurar que el usuario si quiere salir del programa
            if (MessageBox.Show("¿Estás seguro de salir del programa " +
            Usuario.Nombre + " " + Usuario.Apellido + "?", "Salir del Programa",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else e.Cancel = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            // to put the windows normal
            this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            // to maximize the windows
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        #region Funcionalidades del form
        // to be able to move the windows-------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            //cambiar boton a Restore, al mover el formulario
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnlMain.Region = region;
            this.Invalidate();
        }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 56, 117));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //------------------------------------------------
        #endregion

        //Form dentro del panel
        public void AbrirFormulario<MiForm>(params object[] args) where MiForm : Form, IFormulario, new()
        {
            Form formulario0;
            formulario0 = pnl_Formularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el formulario

            if (formulario0 != null)
            {
                if (formulario0.Text == "Mantenimiento de Producto")
                {
                    if (prodOrServ_Before != prodOrServ)
                    {
                        formulario0.Close();
                    }
                }
            }

            formulario0 = null; // destruyendo formulario0 ya que solo es para pruebas


            Form formulario;
            formulario = pnl_Formularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el formulario


            //si el formulario/instancia no existe
            if (formulario == null)
            {
                try
                {
                    formulario = new MiForm();
                    ((IFormulario)formulario).InicializarParametros(args); // para pasarle parametros
                    this.AddOwnedForm(formulario); //establecer form principal como padre
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnl_Formularios.Controls.Add(formulario);
                    pnl_Formularios.Tag = formulario;
                    formulario.Show();

                    formulario.BringToFront();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());

                }
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        
        private void Form1_Activated(object sender, EventArgs e)
        {
            //detecta si se cambión de usuario para volver a cargar el form.
            if (UserTemp != Usuario.Nombre)
            {
                UserTemp = Usuario.Nombre;
                Form1_Load(sender, e);
            }
        }


        // cambia botón restaurar por maximizar, al cambiar el tamaño
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (minimizar <= 4)
            {
                minimizar++;
            }
            else
            {
                btnMaximize.Visible = true;
                btnRestore.Visible = false;
                minimizar = 0;
            }
        }        
    }

    // para sobreescibir el menustrip
    class CustomProfessionalColors : ProfessionalColorTable
    {

    }
    /*
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        public CustomToolStripRenderer() { }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = Color.MediumBlue;
            using (SolidBrush brush = new SolidBrush(c))
                e.Graphics.FillRectangle(brush, rc);


            //LinearGradientMode mode = LinearGradientMode.Horizontal;

            //using (LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, ColorTable.MenuStripGradientBegin, ColorTable.MenuStripGradientEnd, mode))
            //{
            //    e.Graphics.FillRectangle(b, e.AffectedBounds);
            //}
        }

    }*/

    public class BlueRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = Color.FromArgb(0, 56, 117);
            using (SolidBrush brush = new SolidBrush(c))
                e.Graphics.FillRectangle(brush, rc);
        }
    }
}
