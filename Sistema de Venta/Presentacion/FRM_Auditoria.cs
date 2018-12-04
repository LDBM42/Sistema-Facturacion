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
    public partial class FRM_Auditoria : Form, IFormulario
    {
        private static DataTable dt = new DataTable();
        string buscar;

        public FRM_Auditoria()
        {
            InitializeComponent();
        }

        public void InicializarParametros(params object[] parametros)
        {
            if (parametros.Length == 1)
            {
                int parametro1 = (int)parametros[0];
            }
        }

        private void BT_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Auditoria_Load(object sender, EventArgs e)
        {
            CMB_Buscar.Text = "Usuario";
            // TODO: This line of code loads data into the 'dbSFacturacionDataSetAuditoria.auditoria_log' table. You can move, or remove it, as needed.
            this.auditoria_logTableAdapter.Fill(this.dbSFacturacionDataSetAuditoria.auditoria_log);

            DataSet ds = dbSFacturacionDataSetAuditoria;
            dt = ds.Tables[0];
        }

        private void FRM_Auditoria_Enter(object sender, EventArgs e)
        {
            //Carga el Header del form Activo
            Form1 principal = Owner as Form1;
            principal.lab_encabezado.Text = "Auritoría               ";
            this.BringToFront();
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            if(CMB_Buscar.Text == "Usuario")
            {
                buscar = "Usuario";
            }
            else if (CMB_Buscar.Text == "Acción")
            {
                buscar = "Accion";
            }

            try
            {
                DataView dv = new DataView(dt.Copy());
                try
                {
                    dv.RowFilter = buscar + " Like '" + Buscar.Text + "%'";
                }
                catch (Exception)
                {                    
                    MessageBox.Show("Favor escribir un valor correcto", "Texto incorrecto");
                    Buscar.Text = "";
                    Buscar.Focus();
                }

                dgv_Auditoria.DataSource = dv;

                if (dv.Count == 0)
                {
                    noencontrado.Visible = true;
                }

                else
                {
                    noencontrado.Visible = false;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Favor escribir un valor correcto", "Texto incorrecto");
                Buscar.Text = "";
                Buscar.Focus();
            }
        }

        private void FRM_Auditoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 principal = Owner as Form1;
            try
            {
                principal.lab_encabezado.Text = "";
            }
            catch (Exception)
            {
            }
        }
    }
}
