/*
 Universidad: UNED
Curso:        Programación Avanzada
Código:       00830
Tema:         Tarea 2
Estudiante:   Carlos Garita Campos
Periodo:      II Cuatrimestre 2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarea2_CarlosGarita
{
    //Clase que muestra el menú principal en pantalla
    public partial class MenuPrincipal : Form
    {
        //Método constructor
        public MenuPrincipal()
        {
            InitializeComponent(); //Inicializa todos los componentes
        }

        //Método para manejar el botón que abre el formulario de registro de cajeros
        private void cajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea el objeto "frm" de la clase "RegistroCajeros" para tener acceso a los métodos de la clase
            RegistroCajeros frm = new RegistroCajeros();
            frm.MdiParent = this; //Define al menú principal como el formulario padre
            frm.Show(); //Muestra en pantalla al formulario hijo 
        }

        //Método para manejar el botón que abre el formulario de registro de categorías
        private void mitCategorias_Click(object sender, EventArgs e)
        {
            //Crea el objeto "frm" de la clase "RegistroCategorias" para tener acceso a los métodos de la clase
            RegistroCategorias frm = new RegistroCategorias();
            frm.MdiParent = this; //Define al menú principal como el formulario padre
            frm.Show(); //Muestra en pantalla al formulario hijo 
        }

        //Método para manejar el botón que abre el formulario de registro de productos
        private void mitProductos_Click(object sender, EventArgs e)
        {
            //Crea el objeto "frm" de la clase "RegistroProductos" para tener acceso a los métodos de la clase
            RegistroProductos frm = new RegistroProductos();
            frm.MdiParent = this; //Define al menú principal como el formulario padre
            frm.Show(); //Muestra en pantalla al formulario hijo 
        }

        //Método para manejar el botón que abre el formulario para mostrar los datos de cajeros registrados
        private void mitCajerosRegistrados_Click(object sender, EventArgs e)
        {
            //Crea el objeto "frm" de la clase "MostrarCajeros" para tener acceso a los métodos de la clase
            MostrarCajeros frm = new MostrarCajeros();
            frm.MdiParent = this; //Define al menú principal como el formulario padre
            frm.Show(); //Muestra en pantalla al formulario hijo 
        }

        //Método para manejar el botón que abre el formulario para mostrar los datos de categorías registradas
        private void mitCategoriasRegistradas_Click(object sender, EventArgs e)
        {
            //Crea el objeto "frm" de la clase "MostrarCategorias" para tener acceso a los métodos de la clase
            MostrarCategorias frm = new MostrarCategorias();
            frm.MdiParent = this; //Define al menú principal como el formulario padre
            frm.Show(); //Muestra en pantalla al formulario hijo
        }

        //Método para manejar el botón que abre el formulario para mostrar los datos de productos registrados
        private void mitProductosRegistrados_Click(object sender, EventArgs e)
        {
            //Crea el objeto "frm" de la clase "MostrarProductos" para tener acceso a los métodos de la clase
            MostrarProductos frm = new MostrarProductos();
            frm.MdiParent = this; //Define al menú principal como el formulario padre
            frm.Show(); //Muestra en pantalla al formulario hijo
        }

        //Método para manejar el botón que cierra el menú principal y sale del programa
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Cierra el formulario padre correspondiente el Menú principal
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
