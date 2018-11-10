using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Entidades
{
    public class Cliente
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _domicilio;

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public Cliente()
        {

        }
        public Cliente (int id, string nombre, string apellido, string domicilio, string telefono, int dni)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._domicilio = domicilio;
            this._telefono = telefono;
            this._dni = dni;
        }

    }
}
