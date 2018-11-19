using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        int countDownTimer;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataSet ds = FLogin.ValidarLogin(text_Usuario.Text, text_Password.Text);
            DataTable dt = ds.Tables[0];


            if (dt.Rows.Count > 0)
            {
                Usuario.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                Usuario.Nombre = dt.Rows[0]["Nombre"].ToString();
                Usuario.Apellido = dt.Rows[0]["Apellido"].ToString();
                Usuario.Dni = Convert.ToInt32(dt.Rows[0]["Dni"]);
                Usuario.Direccion = dt.Rows[0]["Direccion"].ToString();
                Usuario.Telefono = dt.Rows[0]["Telefono"].ToString();
                Usuario.Nombreusuario = dt.Rows[0]["Usuario"].ToString();
                Usuario.Tipo = dt.Rows[0]["Tipo"].ToString();
                Usuario.Password = dt.Rows[0]["Password"].ToString();
                Usuario.Logged = 1; // para activar autologgin

                //Guardar Datos Autologgin
                if (FLogin.AutoLoginSet(Usuario.Nombreusuario, Usuario.Password, Usuario.Logged) == 1)
                {
                    this.DialogResult = DialogResult.OK; //terminar loggin y abrir Principal
                }
            }
            else
            {
                
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                text_Password.Text = "";
                pictureBox1.Visible = true;
                
                mostrarOcultar(false);

            }
        }

        private void mostrarOcultar(bool t)
        {
            pictureBox1.Visible = !t;

        }



        private void FRM_Login_Load(object sender, EventArgs e)
        {
            DataSet ds = FLogin.AutoLoginGet();
            DataTable dt = ds.Tables[0];


            if (dt.Rows.Count > 0)
            {
               text_Usuario.Text = dt.Rows[0]["Usuario"].ToString();
               text_Password.Text = dt.Rows[0]["Contraseña"].ToString();

                btnEntrar.PerformClick();
            }
            else
            {
                countDownTimer = 30;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countDownTimer != 0)
            {
                lbl_CountDown.Text = Convert.ToString(countDownTimer);
                countDownTimer--;

                if (!this.Visible)
                {
                    timer1.Stop();
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Excedio el máximo de tiempo de espera, por motivo de seguridad el programa sera cerrado", "Tiempo Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FRM_Login_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 40, 40, 40),2);
            e.Graphics.DrawLine(pen, 310, 125, 711, 125);

            Pen pen2 = new Pen(Color.FromArgb(255, 40, 40, 40), 2);
            e.Graphics.DrawLine(pen2, 310, 190, 711, 190);
        }

        private void text_Usuario_MouseEnter(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "USUARIO")
            {
                text_Usuario.Text = "";
                text_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void text_Usuario_MouseLeave(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "" && text_Usuario.Focused == false)
            {
                text_Usuario.Text = "USUARIO";
                text_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void text_Password_MouseEnter(object sender, EventArgs e)
        {
            if (text_Password.Text == "PASSWORD")
            {
                text_Password.Text = "";
                text_Password.ForeColor = Color.LightGray;
                text_Password.UseSystemPasswordChar = true;
            }
        }

        private void text_Password_MouseLeave(object sender, EventArgs e)
        {
            if (text_Password.Text == "" && text_Password.Focused == false)
            {
                text_Password.Text = "PASSWORD";
                text_Password.ForeColor = Color.DimGray;
                text_Password.UseSystemPasswordChar = false;
            }
        }
        

        private void text_Usuario_Click(object sender, EventArgs e)
        {
            if (text_Password.Text == "")
            {
                text_Password.Text = "PASSWORD";
                text_Password.ForeColor = Color.DimGray;
                text_Password.UseSystemPasswordChar = false;
            }
        }

        private void text_Password_Click(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "")
            {
                text_Usuario.Text = "USUARIO";
                text_Usuario.ForeColor = Color.DimGray;
            }
            text_Password.UseSystemPasswordChar = true;
        }

        private void text_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 'e' almacena la tecla presionada
            if (e.KeyChar == (char)13) //si la tecla pesionada es igual a ENTER (13)
            {
                e.Handled = true; //.Handled significa que nosotros nos haremos cargo del codigo
                                  //al ser true, evita que apareca la tecla presionada
                btnEntrar_Click(null, null);
            }
        }

        private void text_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 'e' almacena la tecla presionada
            if (e.KeyChar == (char)13) //si la tecla pesionada es igual a ENTER (13)
            {
                e.Handled = true; //.Handled significa que nosotros nos haremos cargo del codigo
                                  //al ser true, evita que apareca la tecla presionada
                SendKeys.Send("{TAB}"); //hace que se presione la tecla TAB por código
            }
        }

    }
}
