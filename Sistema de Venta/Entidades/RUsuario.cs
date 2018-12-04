using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Entidades
{
    public class RUsuario
    {
     
    
        public int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string _ncf;

        public string Ncf
        {
            get { return _ncf; }
            set {  _ncf = value; }
        }
        public  string _nombre;

        public  string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public   string _apellido;

        public   string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public   string _direccion;

        public   string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public   string _telefono;

        public   string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public   string _nombreusuario;

        public   string Nombreusuario
        {
            get { return _nombreusuario; }
            set { _nombreusuario = value; }
        }
        public   string _password;

        public   string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public   string _tipo;

        public   string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public static int _logged;

        public static int Logged
        {
            get { return _logged; }
            set { _logged = value; }
        }

    }
}
