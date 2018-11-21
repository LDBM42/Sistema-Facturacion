using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Venta.Presentacion;

namespace Sistema_de_Venta
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            FRM_Login login = new FRM_Login();
            login.ShowDialog();

            //
            // Si el login es correcto, procedo con la apetura normal
            // de la aplicacion
            //
            if (login.DialogResult == DialogResult.OK)
                Application.Run(new Form1());
           // Application.Run(new FRM_Login());





           
          //Application.Run(FRM_Ventas.GetInstance());
           //Application.Run(new FRM_Usuario());
          //Application.Run(new FRM_Producto());
          //Application.Run(FRM_DetalleVenta.GetInstance());
        }
    } 
}
