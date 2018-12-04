using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta
{
    class Validadores
    {
        //validador Generico
        public static bool Validador(char e, string caracteresPermitidos)
        {
            bool existe;

            existe = caracteresPermitidos.Contains(e);//contains devuelve true si el caracter esta dentro de la cadena

            if (existe == true)
            {
                return false; //permite escribir el caracter
            }
            else
            {
                return true; //evita escribir el caracter
            }
        }

        //validador 
        public static bool CantidadCaracteres(KeyPressEventArgs e, string texto, int limite)
        {
            if (texto.Length < limite || e.KeyChar == (char)8)
            {
                return false; //permite escribir el caracter
            }
            else
            {
                if(e.KeyChar != (char)13)
                    SendKeys.Send("{TAB}"); //hace que se presione la tecla TAB por código

                return true; //evita escribir el caracter
            }
        }




        public static void EnterPress_TabyValidar(KeyPressEventArgs e, string caracteresPermitidos) // detecta al presionar enter
        {
            // 'e' almacena la tecla presionada
            if (e.KeyChar == (char)13) //si la tecla pesionada es igual a ENTER (13)
            {
                e.Handled = true; //.Handled significa que nosotros nos haremos cargo del codigo
                                  //al ser true, evita que apareca la tecla presionada
                SendKeys.Send("{TAB}"); //hace que se presione la tecla TAB por código
            }
            else
            {
                //si el caracter presionado es numerico o borrar lo permite, sino no
                e.Handled = Validadores.Validador(e.KeyChar, caracteresPermitidos);//\b es igual a retroceder
            }
        }

        public static void EnterPress_TabyValidarLetras(KeyPressEventArgs e)
        {
            // 'e' almacena la tecla presionada
            if (e.KeyChar == (char)13) //si la tecla pesionada es igual a ENTER (13)
            {
                e.Handled = true; //.Handled significa que nosotros nos haremos cargo del codigo
                                  //al ser true, evita que apareca la tecla presionada
                SendKeys.Send("{TAB}"); //hace que se presione la tecla TAB por código
            }
            else
            {
                //acepta las letras, espacios y caracteres de control como enter y backspace
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public static void EnterPress_Tab(KeyPressEventArgs e)
        {
            // 'e' almacena la tecla presionada
            if (e.KeyChar == (char)13) //si la tecla pesionada es igual a ENTER (13)
            {
                e.Handled = true; //.Handled significa que nosotros nos haremos cargo del codigo
                                  //al ser true, evita que apareca la tecla presionada
                SendKeys.Send("{TAB}"); //hace que se presione la tecla TAB por código
            }
        }
    }
}
