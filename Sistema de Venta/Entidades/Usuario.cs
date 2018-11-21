using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Entidades
{
    public class Usuario
    {
        private static int _id;

        public static int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private static int _ncf;

        public static int Ncf
        {
            get { return _ncf; }
            set { _ncf = value; }
        }
        private static string _nombre;

        public static string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private static string _apellido;

        public static string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private static string _direccion;

        public static string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private static string _telefono;

        public static string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private static string _nombreusuario;

        public static string Nombreusuario
        {
            get { return _nombreusuario; }
            set { _nombreusuario = value; }
        }
        private static string _password;

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private static string _tipo;

        public static string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private static int _logged;

        public static int Logged
        {
            get { return _logged; }
            set { _logged = value; }
        }
    }
}
