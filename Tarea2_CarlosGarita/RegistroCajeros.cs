using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tarea2_CarlosGarita
{
    //Clase para registrar cajeros en la base de datos
    public partial class RegistroCajeros : Form
    {
        //Método constructor
        public RegistroCajeros()
        {
            InitializeComponent(); //Inicializa los componentes del formulario
        }

        //Método para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Método para controlar el registro de cajeros en la base de datos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
            if (this.txtID.Text.Equals("") || this.txtNombre.Text.Equals("") || this.txtApellido1.Text.Equals("") || this.txtApellido2.Text.Equals("") || this.txtCaja.Text.Equals(""))
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Es necesario que ingrese la información en todos los campos solicitados antes de proceder a registrar la información del cajero","¡Alto!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                //Declaración de variable
                bool error;

                Cajero datos = new Cajero(); //Crea el objeto "datos" de la clase "Cajero" para tener acceso a los métodos de la clase
                MetodosVarios limpiar = new MetodosVarios(); //Crea el objeto "limpiar" de la clase "MetodosVarios" para tener acceso a los métodos de la clase
                SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder(); //Crea el objeto "bldr" de la clase "SqlConnectionStringBuilder" para tener acceso a los métodos de la clase

                //Asignación del valor ingresado por el usuario al objeto "datos"
                datos.Identificacion = this.txtID.Text;
                datos.Nombre = this.txtNombre.Text;
                datos.Primer_Apellido = this.txtApellido1.Text;
                datos.Segundo_Apellido = this.txtApellido2.Text;

                //Prueba sección de código y captura error en caso de presentarse
                try
                {
                    //Asignación del valor ingresado por el usuario al objeto "datos"
                    datos.Caja_Asignada = Int32.Parse(this.txtCaja.Text);

                    error = false; //Asigna un valor a la variable correspondiente
                }
                catch (Exception err)
                {
                    error = true; //Asigna un valor a la variable correspondiente
                }

                if (error == true)
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("El número ingresado no es correcto o es demasiado grande, favor ingrese números válidos", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Manejo de la base de datos, apertura de la conexión e ingreso de datos a la base de datos
                    bldr.DataSource = ".\\SQLEXPRESS";
                    bldr.InitialCatalog = "BuenPrecio";
                    bldr.IntegratedSecurity = true;
                    SqlConnection conx = new SqlConnection(bldr.ConnectionString);
                    String SQL = "INSERT into Cajero(Identificacion, Nombre, PrimerApellido, SegundoApellido, CajaAsignada)";
                    SQL += " VALUES ('" + datos.Identificacion + "', '" + datos.Nombre + "', '" + datos.Primer_Apellido + "', '" + datos.Segundo_Apellido + "', '" + datos.Caja_Asignada + "')";
                    try
                    {
                        conx.Open();
                        SqlCommand comandoInsertar = new SqlCommand(SQL, conx);
                        comandoInsertar.ExecuteNonQuery();

                        MessageBox.Show("Se registró el cajero correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiar.LimpiarDatos(this); //Limpia los datos de los campos de ingreso de información en pantalla que haya ingresado el usuario
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("La identificación ya se encuentra registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conx.Close(); //Cierra la conexión         
                }                       
            }            
        }

        //Método para restringir el ingreso de números en el campo de ingreso de nombre en pantalla
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de números en el campo de ingreso de primer apellido en pantalla
        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de números en el campo de ingreso de segundo apellido en pantalla
        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de caja en pantalla
        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }
    }
}
