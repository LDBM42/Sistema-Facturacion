using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using Sistema_de_Venta.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int childFormNumber = 0;
        private bool cerrarSeccion = false;


       private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Ventas>();
            //FRM_Ventas frmVenta = FRM_Ventas.GetInstance();
            //frmVenta.ShowDialog(this);
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Cliente>();
            //FRM_Cliente frmCliente = FRM_Cliente.GetInstance();
            //frmCliente.ShowDialog(this);
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Producto>();
            //FRM_Producto frmProducto = FRM_Producto.GetInscance();
            //frmProducto.ShowDialog(this);
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Categoria>();
            //FRM_Categoria frmCategoria = FRM_Categoria.GetInstance();
            //frmCategoria.ShowDialog(this);

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Usuario>();
            //FRM_Usuario Usuario = new FRM_Usuario();
            //Usuario.ShowDialog(this);
        }

        private void cERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSeccion = true;
            if (MessageBox.Show("¿Estás seguro de cerrar sección " + 
                Usuario.Nombre + " " + Usuario.Apellido + "?", "Cerrar Sección",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Usuario.Logged = 0; // para desactivar autologgin
                //DESLOGEARSE
                if (!(FLogin.AutoLoginSet(Usuario.Nombreusuario, Usuario.Password, Usuario.Logged) == 1))
                {
                    MessageBox.Show("No se pudo hacer el cerrado de sección", "Cerado Sección");
                }

                Application.Exit();
            }
            else
                cerrarSeccion = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Usuario.Tipo != "Admin")
            {
                cONFIGURACIONESToolStripMenuItem.Visible = false;
            }
            toolStripStatusLabel1.Text = "Usuario - " + Usuario.Nombre + " " + Usuario.Apellido;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!cerrarSeccion)
            { 
                //Mejora para asegurar que el usuario si quiere salir del programa
                if (MessageBox.Show("¿Estás seguro de salir del programa " +
                Usuario.Nombre + " " + Usuario.Apellido + "?", "Salir del Programa",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Environment.Exit(1);
                }
                else e.Cancel = true;
            }
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
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_Formularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl_Formularios.Controls.Add(formulario);
                pnl_Formularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }


        }
    }
}
