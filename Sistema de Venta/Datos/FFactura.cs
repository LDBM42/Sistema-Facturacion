using Sistema_de_Venta.Entidades;
using SisVenttas.Datos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_Venta.Datos
{
    class FFactura
    {

        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FacturaPDF_GetAll", dbParams);
        }


        public static int Insertar(Factura factura)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@FechaFactura", SqlDbType.Date, 0, factura.FechaFactura),
                    FDBHelper.MakeParam("@NombreArchivo", SqlDbType.VarChar, 0, factura.NombreArchivo),
                    FDBHelper.MakeParam("@FacturaEnPDF", SqlDbType.VarBinary, 0, factura.Archivo)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FacturaPDF_Insertar", dbParams));

        }
    }
}
