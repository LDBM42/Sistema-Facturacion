using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Entidades
{
   public class DetalleVenta
    {
        //Id, VentaId, ProductoId, Cantidad, PrecioUnitario

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
       private Venta _venta;

       public Venta Venta
       {
           get { return _venta; }
           set { _venta = value; }
       }
       private Producto _producto;

       internal Producto Producto
       {
           get { return _producto; }
           set { _producto = value; }
       }
       private int _cantidad;

       public int Cantidad
       {
           get { return _cantidad; }
           set { _cantidad = value; }
       }
       private double _precioUnitario;

       public double PrecioUnitario
       {
           get { return _precioUnitario; }
           set { _precioUnitario = value; }
       }

        private string _descripcionVenta;

        public string DescripcionVenta
        {
            get { return _descripcionVenta; }
            set { _descripcionVenta = value; }
        }

        

       public DetalleVenta()
       {
           _producto = new Producto();
           _venta = new Venta();
       }
    }
}
