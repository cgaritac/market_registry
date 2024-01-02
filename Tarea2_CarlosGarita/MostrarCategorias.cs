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
    //Clase para mostrar el listado completo de registros de categorías almacenadas en la base de datos
    public partial class MostrarCategorias : Form
    {
        //Crea el objeto "bldr" de la clase "SqlConnectionStringBuilder" para tener acceso a los métodos de la clase
        SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();        

        //Método constructor
        public MostrarCategorias()
        {
            InitializeComponent(); //Inicializa los componentes del formulario
        }

        //Método para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
        }

        //Método que se ejecuta en la carga inicial del formulario
        private void MostrarCategorias_Load(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Categoria>" para tener acceso a los métodos de la clase
            List<Categoria> lista = new List<Categoria>();

            //Manejo de la base de datos y apertura de la conexión
            bldr.DataSource = ".\\SQLEXPRESS";
            bldr.InitialCatalog = "BuenPrecio";
            bldr.IntegratedSecurity = true;
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Categoria", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto categoria para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Codigo = Convert.ToInt32(registro["Codigo"]);
                categoria.Descripcion = registro["Descripcion"].ToString();

                lista.Add(categoria); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCategorias.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCategorias.Columns[0].HeaderText = "Código";
            this.dgvCategorias.Columns[1].HeaderText = "Descripción";
        }

        //Método para actualizar los datos mostrados en la tabla después de que se haya ingresado una nueva categoría mientras el formulario "MostrarCategorias" aun está abierta
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Categoria>" para tener acceso a los métodos de la clase
            List<Categoria> lista = new List<Categoria>();

            //Manejo de la base de datos y apertura de la conexión
            bldr.DataSource = ".\\SQLEXPRESS";
            bldr.InitialCatalog = "BuenPrecio";
            bldr.IntegratedSecurity = true;
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Categoria", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto categoria para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Codigo = Convert.ToInt32(registro["Codigo"]);
                categoria.Descripcion = registro["Descripcion"].ToString();

                lista.Add(categoria); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCategorias.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCategorias.Columns[0].HeaderText = "Código";
            this.dgvCategorias.Columns[1].HeaderText = "Descripción";

            //Muestra mensaje en pantalla
            MessageBox.Show("Datos actualizados con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
