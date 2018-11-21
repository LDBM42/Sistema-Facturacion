using System;

namespace Sistema_de_Venta.Entidades
{
    public class Venta
    {
        //Id, ClienteId, FechaVenta, NumeroDocumento, TipoDocumento
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Cliente _cliente;

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        DateTime _fechaVenta;

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }
        private string _numeroDocumento;

        public string NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; }
        }

        public Venta()
        {
            _cliente = new Cliente();
        }
      
    }
}
