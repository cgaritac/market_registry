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
    //Clase para mostrar el listado completo de registros de productos almacenados en la base de datos
    public partial class MostrarProductos : Form
    {
        //Crea el objeto "bldr" de la clase "SqlConnectionStringBuilder" para tener acceso a los métodos de la clase
        SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();

        //Método constructor
        public MostrarProductos()
        {
            InitializeComponent(); //Inicializa los componentes del formulario
        }

        //Método para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
        }

        //Método que se ejecuta en la carga inicial del formulario
        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            //Establece el estado de los radiobuttons
            this.rdbRegistradosCategoria.Checked = false;
            this.rdbRegistradosTotales.Checked = false;            
        }

        //Método para controlar el estado de los radioButtons
        private void rdbRegistradosCategoria_CheckedChanged(object sender, EventArgs e)
        {
            //Condicional para controlar el estado de los radioButtons
            if (this.rdbRegistradosCategoria.Checked == true)
            {
                this.cbxCategoria.Enabled = true;
                this.lblCategoria.Enabled = true;
            }

            //Condicional para controlar el estado de los radioButtons
            if (this.rdbRegistradosCategoria.Checked == false)
            {
                this.cbxCategoria.Enabled = false;
                this.lblCategoria.Enabled = false;
            }
        }

        //Método para mostrar los datos en la tabla después de que se haya seleccionado la opción correspondiente por parte del usuario
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Producto>" para tener acceso a los métodos de la clase
            List<Producto> lista = new List<Producto>();

            //Manejo de la base de datos
            bldr.DataSource = ".\\SQLEXPRESS";
            bldr.InitialCatalog = "BuenPrecio";
            bldr.IntegratedSecurity = true;
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);

            //Condicional para controlar la operación dependiendo de la selección del radioButton por parte del usuario y mostrar mensaje en pantalla en caso de que no haya selección aún
            if (this.rdbRegistradosCategoria.Checked == false && this.rdbRegistradosTotales.Checked == false)
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Debe seleccionar una opción antes de continuar", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (this.rdbRegistradosCategoria.Checked == true)
            {                
                String categoria = "", aux; //Declaración de variable

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

                //Condicional para presentar mensaje en caso de que el usuario no seleccione una categoría
                if (categoria.Equals(""))
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("Debe seleccionar una categoría antes de continuar", "¡Alto!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    //Manejo de la base de datos y apertura de la conexión
                    SqlCommand comando = new SqlCommand("Select Producto.Codigo, Producto.Descripcion, Precio, Cantidad, CodigoCategoria, Categoria.Descripcion as DescripcionCategoria from Producto Inner Join Categoria On Producto.CodigoCategoria = Categoria.Codigo Where Producto.CodigoCategoria = " + categoria, conx);
                    conx.Open();
                    SqlDataReader registro = comando.ExecuteReader();

                    //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto producto para agregarlo a la colección generica lista de objetos
                    while (registro.Read())
                    {
                        Producto producto = new Producto();
                        producto.Codigo = Convert.ToInt32(registro["Codigo"]);
                        producto.Descripcion = registro["Descripcion"].ToString();
                        producto.Precio = Convert.ToDouble(registro["Precio"]);
                        producto.Cantidad_Existente = Convert.ToInt32(registro["Cantidad"]);
                        producto.Codigo_Categoria = Convert.ToInt32(registro["CodigoCategoria"]);
                        producto.Descripcion_Categoria = registro["DescripcionCategoria"].ToString();

                        lista.Add(producto); //Agrega el objeto a la lista
                    }
                    conx.Close(); //Cierra la conexión

                    //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
                    this.dgvProductos.DataSource = lista;

                    //Cambia los títulos de columnas específicas de la tabla
                    this.dgvProductos.Columns[0].HeaderText = "Código Producto";
                    this.dgvProductos.Columns[1].HeaderText = "Descripción Producto";
                    this.dgvProductos.Columns[3].HeaderText = "Cantidad Existente";
                    this.dgvProductos.Columns[4].HeaderText = "Código Categoría";
                    this.dgvProductos.Columns[5].HeaderText = "Descripción Categoría";
                }                
            } else if (this.rdbRegistradosTotales.Checked == true)
            {
                //Manejo de la base de datos y apertura de la conexión
                SqlCommand comando = new SqlCommand("Select Producto.Codigo, Producto.Descripcion, Precio, Cantidad, CodigoCategoria, Categoria.Descripcion as DescripcionCategoria from Producto Inner Join Categoria On Producto.CodigoCategoria = Categoria.Codigo", conx);
                conx.Open();
                SqlDataReader registro = comando.ExecuteReader();

                //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto producto para agregarlo a la colección generica lista de objetos
                while (registro.Read())
                {
                    Producto producto = new Producto();
                    producto.Codigo = Convert.ToInt32(registro["Codigo"]);
                    producto.Descripcion = registro["Descripcion"].ToString();
                    producto.Precio = Convert.ToDouble(registro["Precio"]);
                    producto.Cantidad_Existente = Convert.ToInt32(registro["Cantidad"]);
                    producto.Codigo_Categoria = Convert.ToInt32(registro["CodigoCategoria"]);
                    producto.Descripcion_Categoria = registro["DescripcionCategoria"].ToString();

                    lista.Add(producto); //Agrega el objeto a la lista
                }
                conx.Close(); //Cierra la conexión

                //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
                this.dgvProductos.DataSource = lista;

                //Cambia los títulos de columnas específicas de la tabla
                this.dgvProductos.Columns[0].HeaderText = "Código Producto";
                this.dgvProductos.Columns[1].HeaderText = "Descripción Producto";
                this.dgvProductos.Columns[3].HeaderText = "Cantidad Existente";
                this.dgvProductos.Columns[4].HeaderText = "Código Categoría";
                this.dgvProductos.Columns[5].HeaderText = "Descripción Categoría";

                //Establece el estado de los radiobuttons
                this.cbxCategoria.Enabled = false;
                this.lblCategoria.Enabled = false;
            }            
        }

        private void cbxCategoria_DropDownClosed(object sender, EventArgs e)
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
