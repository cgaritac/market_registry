using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tarea2_CarlosGarita
{
    //Clase para mostrar el listado completo de registros de cajeros almacenados en la base de datos
    public partial class MostrarCajeros : Form
    {
        //Crea el objeto "bldr" de la clase "SqlConnectionStringBuilder" para tener acceso a los métodos de la clase
        SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();
        
        //Constructor
        public MostrarCajeros()
        {
            InitializeComponent(); //Inicializa los componentes del formulario
        }

        //Método para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Método para actualizar los datos mostrados en la tabla después de que se haya ingresado un nuevo cajero mientras el formulario "MostrarCajeros" aun está abierto
        private void button1_Click(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Cajero>" para tener acceso a los métodos de la clase
            List<Cajero> lista = new List<Cajero>();

            //Manejo de la base de datos y apertura de la conexión
            bldr.DataSource = ".\\SQLEXPRESS"; 
            bldr.InitialCatalog = "BuenPrecio"; 
            bldr.IntegratedSecurity = true; 
            SqlConnection conx = new SqlConnection(bldr.ConnectionString); 
            SqlCommand comando = new SqlCommand("SELECT * FROM Cajero", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto cajero para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Cajero cajero = new Cajero();
                cajero.Identificacion = registro["Identificacion"].ToString();
                cajero.Nombre = registro["Nombre"].ToString();
                cajero.Primer_Apellido = registro["PrimerApellido"].ToString();
                cajero.Segundo_Apellido = registro["SegundoApellido"].ToString();
                cajero.Caja_Asignada = Convert.ToInt32(registro["CajaAsignada"]);

                lista.Add(cajero); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCajeros.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCajeros.Columns[0].HeaderText = "Identificación";
            this.dgvCajeros.Columns[2].HeaderText = "Primer Apellido";
            this.dgvCajeros.Columns[3].HeaderText = "Segundo Apellido";
            this.dgvCajeros.Columns[4].HeaderText = "Caja Asignada";

            //Muestra mensaje en pantalla
            MessageBox.Show("Datos actualizados con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Método que se ejecuta en la carga inicial del formulario
        private void MostrarCajeros_Load(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Cajero>" para tener acceso a los métodos de la clase
            List<Cajero> lista = new List<Cajero>();

            //Manejo de la base de datos y apertura de la conexión
            bldr.DataSource = ".\\SQLEXPRESS";
            bldr.InitialCatalog = "BuenPrecio";
            bldr.IntegratedSecurity = true;
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Cajero", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto cajero para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Cajero cajero = new Cajero();
                cajero.Identificacion = registro["Identificacion"].ToString(); 
                cajero.Nombre = registro["Nombre"].ToString();
                cajero.Primer_Apellido = registro["PrimerApellido"].ToString();
                cajero.Segundo_Apellido = registro["SegundoApellido"].ToString();
                cajero.Caja_Asignada = Convert.ToInt32(registro["CajaAsignada"]);

                lista.Add(cajero); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCajeros.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCajeros.Columns[0].HeaderText = "Identificación";
            this.dgvCajeros.Columns[2].HeaderText = "Primer Apellido";
            this.dgvCajeros.Columns[3].HeaderText = "Segundo Apellido";
            this.dgvCajeros.Columns[4].HeaderText = "Caja Asignada";
        }
    }
}
