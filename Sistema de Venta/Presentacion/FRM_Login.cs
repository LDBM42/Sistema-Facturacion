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

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }

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

                Form1 principal = new Form1();
                
                principal.ShowDialog();

                FRM_Login login = new FRM_Login();
                login.Hide();

            }
            else
            {
                
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                text_Password.Text = "";
                pictureBox1.Visible = true;
                
                mostrarOcultar(false);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mostrarOcultar(bool t)
        {
            pictureBox1.Visible = !t;
            groupBox1.Visible = !t;
           
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Excedio el maximo de tiempo de espera, por motivo de seguridad el programa sera cerrado", "Tiempo Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
            Close();
        }
    }
}
