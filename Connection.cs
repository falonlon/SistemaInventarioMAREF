using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioMAREF
{
    public class Connection
    {
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "maref";
        private string user = "root";
        private string password = "Mikayuufanfic12";
        private string connectionChain;
        //private MySqlConnection connection = new MySqlConnection(connectionChain);

        public Connection()
        {
            connectionChain = "Database=" + database +
                 "; DataSource=" + server +
                 "; User=" + user +
                 "; Password=" + password;

        }

        public MySqlConnection GetConexion()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionChain);
            }
            return connection;
        }


        // LOGIN
        //AQUI CONSULTA A LA BASE DE DATOS PARA VERIFFICAR SI EL USUARIO COINCIDE O NO, PUEDE SER LLAMADO DESDE CUALQUIER CLASE
        //PARA VERIFICAR LAS CREDENCIALES **//INNECESARIO YA QUE EN FORMLOGIN YA HACE ESTE PROCESO 
        /*
        public bool LoginCtrl(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionChain)) // HAGO LA CONEXION 
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Usuario WHERE nombre_usuario = @username AND contrasenna = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); 

                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int count = Convert.ToInt32(result);
                        return count > 0; // Devuelve verdadero si las credenciales son válidas
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                    return false; // Devuelve falso si error
                }
            }
        }
        
        */ 


        // MODIFICAR UN FARDO (UPDATE)
        public void UpdateFardo(string beforeCod, string cod, string desc, float peso, float precioU)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionChain))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Fardo SET codigo_fardo = @nuevo_codigo_fardo, precio_unitario = @precio_unitario, peso = @peso," +
                                "stock_actual = stock_actual, descripcion = @descripcion WHERE codigo_fardo = @viejo_codigo_fardo";

                    MySqlCommand msq = new MySqlCommand(query, connection);

                    msq.Parameters.AddWithValue("@nuevo_codigo_fardo", cod);
                    msq.Parameters.AddWithValue("@viejo_codigo_fardo", beforeCod);
                    msq.Parameters.AddWithValue("@precio_unitario", precioU);
                    msq.Parameters.AddWithValue("@peso", peso);
                    msq.Parameters.AddWithValue("@descripcion", desc);

                    int filasAfectadas = msq.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto actualizado correctamente, incluido el ID.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con ese ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            
        }
        //.

        // OBTENER UN FARDO EN ESPECIFICO (SELECT)
        public Fardo GetFardo(string sqlCommand)
        {
            MySqlCommand msq = new MySqlCommand(sqlCommand, connection);
            MySqlDataReader reader = msq.ExecuteReader();
            Fardo fardo = new Fardo();

            while (reader.Read())
            {
                //fardo.codigo = reader.GetString(1);
                fardo.codigo = reader["codigo_fardo"].ToString();
                fardo.desc = reader["descripcion"].ToString();
                fardo.peso = Convert.StringToFloat(reader["peso"].ToString());
                fardo.stock = Convert.StringToInt(reader["stock_actual"].ToString());
                fardo.precioUnitario = Convert.StringToFloat(reader["stock_actual"].ToString());
            }

            return fardo;
        }
        //.

        // OBTENER TODOS LOS FARDOS
        public List<Fardo> GetListFardo()
        {
            List<Fardo> listFardo = new List<Fardo>();

            using (MySqlConnection connection = new MySqlConnection(connectionChain))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Fardo";
                    MySqlCommand msq = new MySqlCommand(query, connection);
                    MySqlDataReader reader = msq.ExecuteReader();

                    // Leer cada fila y agregar a la lista de productos
                    while (reader.Read())
                    {
                        Fardo fardo = new Fardo();
                        fardo.codigo = reader["codigo_fardo"].ToString();
                        fardo.desc = reader["descripcion"].ToString();
                        fardo.peso = float.Parse(reader["peso"].ToString());
                        fardo.stock = int.Parse(reader["stock_actual"].ToString());
                        fardo.precioUnitario = float.Parse(reader["precio_unitario"].ToString());

                        listFardo.Add(fardo);
                    }

                    reader.Close();
                    //.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return listFardo;
        }
        //.
    }
}
