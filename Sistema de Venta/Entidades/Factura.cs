using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Entidades
{
    public class Factura
    {
        private DateTime _fechaFactura;

        public DateTime FechaFactura
        {
            get { return _fechaFactura; }
            set { _fechaFactura = value; }
        }

        private string _nombreArchivo;

        public string NombreArchivo
        {
            get { return _nombreArchivo; }
            set { _nombreArchivo = value; }
        }

        private byte[] _archivo;

        public byte[] Archivo
        {
            get { return _archivo; }
            set { _archivo = value; }
        }
    }
}
