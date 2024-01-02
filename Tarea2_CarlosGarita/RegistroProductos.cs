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
    //Clase para registrar productos en la base de datos
    public partial class RegistroProductos : Form
    {
        //Crea el objeto "bldr" de la clase "SqlConnectionStringBuilder" para tener acceso a los métodos de la clase
        SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();

        //Método constructor
        public RegistroProductos()
        {
            InitializeComponent(); //Inicializa los componentes del formulario
        }

        //Método para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
        }

        //Método para controlar el registro de productos en la base de datos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
            if (this.txtCodigo.Text.Equals("") || this.txtPrecio.Text.Equals("") || this.txtCantidad.Text.Equals("") || this.cbxCategoria.Text.Equals("Seleccione una opción") || this.txtDescripcion.Text.Equals(""))
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Es necesario que ingrese la información en todos los campos solicitados antes de proceder a registrar la información del producto", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (Double.Parse(this.txtPrecio.Text) == 0) //Condicional para controlar que no se ingrese un precio de cero por parte del usuario
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Es necesario que el precio del producto sea mayor a cero", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Declaración de variables
                String categoria = "", aux; 
                bool error;

                Producto datos = new Producto(); //Crea el objeto "datos" de la clase "Producto" para tener acceso a los métodos de la clase
                MetodosVarios limpiar = new MetodosVarios(); //Crea el objeto "limpiar" de la clase "MetodosVarios" para tener acceso a los métodos de la clase

                //Prueba sección de código y captura error en caso de presentarse
                try
                {
                    //Asignación del valor ingresado por el usuario al objeto "datos"
                    datos.Codigo = Int32.Parse(this.txtCodigo.Text);
                    datos.Precio = Double.Parse(this.txtPrecio.Text);
                    datos.Cantidad_Existente = Int32.Parse(this.txtCantidad.Text);

                    error = false; //Asigna un valor a la variable correspondiente
                }
                catch (Exception err)
                {                    
                    error = true; //Asigna un valor a la variable correspondiente
                }

                if (error == true)
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("Uno de los números ingresados no es correcto o es demasiado grande, favor ingrese números válidos", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    aux = this.cbxCategoria.Text; //Asigna valor seleccionado por el usuario a la variable

                    //Ciclo para extraer el código de la categoría seleccionada por el usuario
                    for (int i = 0; i < aux.Length; i++)
                    {
                        if (aux.Substring(i, 1).Equals(" "))
                        {
                            break;
                        }
                        else
                        {
                            categoria += aux.Substring(i, 1);
                        }
                    }

                    //Asignación del valor ingresado por el usuario al objeto "datos"
                    datos.Codigo_Categoria = Int32.Parse(categoria);
                    datos.Descripcion = this.txtDescripcion.Text;

                    //Manejo de la base de datos, apertura de la conexión e ingreso de datos a la base de datos
                    bldr.DataSource = ".\\SQLEXPRESS";
                    bldr.InitialCatalog = "BuenPrecio";
                    bldr.IntegratedSecurity = true;
                    SqlConnection conx = new SqlConnection(bldr.ConnectionString);
                    String SQL = "INSERT into Producto(Codigo, Descripcion, Precio, Cantidad, CodigoCategoria)";
                    SQL += " VALUES ('" + datos.Codigo + "', '" + datos.Descripcion + "', '" + datos.Precio + "', '" + datos.Cantidad_Existente + "', '" + datos.Codigo_Categoria + "')";
                    try
                    {
                        conx.Open();
                        SqlCommand comandoInsertar = new SqlCommand(SQL, conx);
                        comandoInsertar.ExecuteNonQuery();

                        MessageBox.Show("Se registró el producto correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiar.LimpiarDatos(this); //Limpia los datos de los campos de ingreso de información en pantalla que haya ingresado el usuario
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("El código ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conx.Close(); //Cierra la conexión  
                }                
            }
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla, a excepción del punto decimal
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosDecimales(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método que se ejecuta en la carga inicial del formulario
        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxCategoria_DropDown(object sender, EventArgs e)
        {
            //Limpia el listado del comboBox
            this.cbxCategoria.Items.Clear();

            //Manejo de la base de datos y apertura de la conexión
            bldr.DataSource = ".\\SQLEXPRESS";
            bldr.InitialCatalog = "BuenPrecio";
            bldr.IntegratedSecurity = true;
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Categoria", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al comboBox
            while (registro.Read())
            {
                this.cbxCategoria.Items.Add(registro["Codigo"].ToString() + " - " + registro["Descripcion"].ToString());
            }

            conx.Close(); //Cierra la conexión
        }
    }    
}
