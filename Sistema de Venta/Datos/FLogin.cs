using SisVenttas.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Datos
{
    public class FLogin
    {
        public static DataSet ValidarLogin(string sUsuario, string sPassword)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Usuario",SqlDbType.VarChar, 0, sUsuario),
                    FDBHelper.MakeParam("@Password",SqlDbType.VarChar, 0, sPassword)
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FLogin_ValidarLogin", dbParams);
        }

        public static DataSet AutoLoginGet()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FUsuario_Logged", dbParams);
        }

        public static int AutoLoginSet(string sUsuario, string sPassword, int sLogged)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Usuario",SqlDbType.VarChar, 0, sUsuario),
                    FDBHelper.MakeParam("@Password",SqlDbType.VarChar, 0, sPassword),
                    FDBHelper.MakeParam("@Logged",SqlDbType.Int, 0, sLogged)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_Logged_Actualizar", dbParams));
        }
               
    }
}
