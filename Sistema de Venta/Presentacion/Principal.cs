using Sistema_de_Venta.Entidades;
using Sistema_de_Venta.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


       private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Ventas frmVenta = FRM_Ventas.GetInstance();
            //frmVenta.MdiParent = this;
            frmVenta.ShowDialog(this);
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Cliente frmCliente = FRM_Cliente.GetInstance();
            //frmCliente.MdiParent = this;
            frmCliente.ShowDialog(this);
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Producto frmProducto = FRM_Producto.GetInscance();
            //frmProducto.MdiParent = this;
            frmProducto.ShowDialog(this);
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FRM_Categoria frmCategoria = FRM_Categoria.GetInstance();
            //frmCategoria.MdiParent = this;
            frmCategoria.ShowDialog(this);

        }

        private void cERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Login frmlogin = new FRM_Login();
            frmlogin.Show();
            this.Hide();
        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcion aun esta en mantenimiento, por favor comuniquece con el administrador del programa.", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Usuario.Tipo != "Administrador")
            {
                cONFIGURACIONESToolStripMenuItem.Visible = false;
            }
            toolStripStatusLabel1.Text = "Usuario - " + Usuario.Nombre + " " + Usuario.Apellido;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mejora para asegurar que el usuario si quiere salir del programa
            if (MessageBox.Show("¿Seguro que desea salir del programa?", "Salir del Programa",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(1);
            }
            else e.Cancel = true;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Usuario Usuario = new FRM_Usuario();
            //Usuario.MdiParent = this;
            Usuario.ShowDialog(this);
        }

 
    } 
}
