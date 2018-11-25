using Sistema_de_Venta.Entidades;
using SisVenttas.Datos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVentas.Datos
{
    public class FClientes
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_FCliente_GetAll", dbParams);

        }


        public static int Insertar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                    FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, cliente.Apellido),
                    FDBHelper.MakeParam("@Ncf", SqlDbType.Int, 0, cliente.Ncf),
                    FDBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    FDBHelper.MakeParam("@TipoCliente", SqlDbType.VarChar, 0, cliente.TipoCliente),
                    FDBHelper.MakeParam("@RNC", SqlDbType.Int, 0, cliente.Rnc),
                    FDBHelper.MakeParam("@NoRSocial", SqlDbType.VarChar, 0, cliente.NoRSocial),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCliente_Insertar", dbParams));

        }

        public static int Actualizar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                    FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, cliente.Apellido),
                    FDBHelper.MakeParam("@Ncf", SqlDbType.Int, 0, cliente.Ncf),
                    FDBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    FDBHelper.MakeParam("@TipoCliente", SqlDbType.VarChar, 0, cliente.TipoCliente),
                    FDBHelper.MakeParam("@RNC", SqlDbType.Int, 0, cliente.Rnc),
                    FDBHelper.MakeParam("@NoRSocial", SqlDbType.VarChar, 0, cliente.NoRSocial),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCliente_Actualizar", dbParams));

        }

        public static int Eliminar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id),

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCliente_Eliminar", dbParams));

        }

    }
}
