using Sistema_de_Venta.Entidades;
using SisVenttas.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta.Datos
{
   public class FUsuario
    {

        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_FUsuario_GetAll", dbParams);
        }



        public static int Insertar(RUsuario Rusuario)
        {
            MessageBox.Show(Rusuario.Nombreusuario);
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Nombre",SqlDbType.VarChar, 0, Rusuario.Nombre),
                    FDBHelper.MakeParam("@Apellido",SqlDbType.VarChar, 0,Rusuario.Apellido),
                    FDBHelper.MakeParam("@Ncf",SqlDbType.VarChar, 0, Rusuario.Ncf),
                    FDBHelper.MakeParam("@Direccion",SqlDbType.VarChar, 0, Rusuario.Direccion),
                    FDBHelper.MakeParam("@Telefono",SqlDbType.VarChar, 0, Rusuario.Telefono),
                    FDBHelper.MakeParam("@Usuario",SqlDbType.VarChar, 0, Rusuario.Nombreusuario),
                    FDBHelper.MakeParam("@Password",SqlDbType.VarChar, 0, Rusuario.Password),
                    FDBHelper.MakeParam("@Tipo",SqlDbType.VarChar, 0, Rusuario.Tipo)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_Insertar", dbParams));
        }

        public static int Actualizar(RUsuario Rusuario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id",SqlDbType.Int, 0, Rusuario.Id),
                    FDBHelper.MakeParam("@Nombre",SqlDbType.VarChar, 0, Rusuario.Nombre),
                    FDBHelper.MakeParam("@Apellido",SqlDbType.VarChar, 0,Rusuario.Apellido),
                    FDBHelper.MakeParam("@Ncf",SqlDbType.VarChar, 0, Rusuario.Ncf),
                    FDBHelper.MakeParam("@Direccion",SqlDbType.VarChar, 0, Rusuario.Direccion),
                    FDBHelper.MakeParam("@Telefono",SqlDbType.VarChar, 0, Rusuario.Telefono),
                    FDBHelper.MakeParam("@Usuario",SqlDbType.VarChar, 0, Rusuario.Nombreusuario),
                    FDBHelper.MakeParam("@Password",SqlDbType.VarChar, 0, Rusuario.Password),
                    FDBHelper.MakeParam("@Tipo",SqlDbType.VarChar, 0, Rusuario.Tipo)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_Actualizar", dbParams));
        }

        public static int Eliminar(RUsuario Rusuario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id",SqlDbType.Int, 0, Rusuario.Id),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_Eliminar", dbParams));
        }

        public static int VerificarNCF(string Ncf)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Ncf",SqlDbType.VarChar, 0, Ncf),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_VerificarNCF", dbParams));
        }
    }
}
