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
    public partial class RegistrarUsuario : Form
    {
        string[] users;
        bool UserDispon = true;
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string mensaje = validarDatos();
            if (mensaje == "")
            {
                FRM_Usuario frUsu = FRM_Usuario.GetInstance();
          
               //frUsu.setUser(txtUsuario1.Text, txtPassword1.Text);
               //frUsu.Show();
               // this.Close();
               
            }
            else MessageBox.Show(mensaje);
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Aceptar;
        }

        public void SetUsers(string[] value)
        {
            users = value;
        }


        private string validarDatos()
        {
            string mensaje = "";
            if (txtUsuario1.Text == "" || txtUsuario1.Text.Length < 5)
            {
                mensaje += "El Nombre de usuario debe tener minimo 5 caracteres,\n";

            }
            if (!UserDispon)
            {   mensaje += "El Nombre de usuario no esta disponible,\n";
                }
            //if (txtPassword1.Text == "")
            //{
            //    mensaje += "Debe introducir la contraseña,\n";
            //}
         
            return mensaje;
        }
        private bool validarUsuarios()
        {
            foreach (string user in users)
            {
                if (txtUsuario1.Text == user) return UserDispon = false;
            }
            return UserDispon = true;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!validarUsuarios() || txtUsuario1.Text == "" || txtUsuario1.Text.Length < 5)
            { }
        }
    }
}
