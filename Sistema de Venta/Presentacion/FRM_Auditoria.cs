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
    public partial class FRM_Auditoria : Form
    {
        public FRM_Auditoria()
        {
            InitializeComponent();
        }

        private void BT_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Auditoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSFacturacionDataSetAuditoria.auditoria_log' table. You can move, or remove it, as needed.
            this.auditoria_logTableAdapter.Fill(this.dbSFacturacionDataSetAuditoria.auditoria_log);

        }
    }
}
