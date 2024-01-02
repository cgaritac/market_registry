using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarea2_CarlosGarita
{
    class MetodosVarios
    {
        public void LimpiarDatos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Text = "Seleccione una opción";
                }
            }
        }
    }
}
