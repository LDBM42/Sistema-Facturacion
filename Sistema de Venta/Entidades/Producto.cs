using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Entidades
{
    class Producto
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Categoria _categoria;

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        private double _precioCompra;

        public double PrecioCompra
        {
            get { return _precioCompra; }
            set { _precioCompra = value; }
        }
        private double _precioVenta;

        public double PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }
        private DateTime _fechaVencimiento;
        
        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }
        private byte[] _imagen;

        public byte[] Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }


        private string _prodServ;

        public string ProdServ
        {
            get { return _prodServ; }
            set { _prodServ = value; }
        }

        public Producto()
        {
            _categoria = new Categoria();
        }

        public Producto(int id, Categoria categoria, string nombre, string descripcion, int stock, double precioCompra, double precioVenta, DateTime fechaVencimiento, byte[] imagen, string prodServ)

        {
            Id = id;
            Categoria = categoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Stock = stock;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            FechaVencimiento = fechaVencimiento;
            Imagen = imagen;
            ProdServ = prodServ;
        }




    }

}
