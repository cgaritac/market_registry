using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2_CarlosGarita
{
    //Clase para manejar la información de los cajeros
    class Cajero
    {
        //Definición de variables globales
        private string identificacion, nombre, apellido1, apellido2;
        private int caja;

        //Constructor
        public Cajero() { }

        //Metodo de get y set de la variable correspondiente
        public string Identificacion
        {
            get { return identificacion; }

            set { identificacion = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Primer_Apellido
        {
            get { return apellido1; }

            set { apellido1 = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Segundo_Apellido
        {
            get { return apellido2; }

            set { apellido2 = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public int Caja_Asignada
        {
            get { return caja; }

            set { caja = value; }
        }
    }
}
