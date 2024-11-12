using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioMAREF.Clases
{
    internal class Clientes
    {
        //recibe parametro a datagridview ya q ahi se mostraran los datos
        public void mostrarClientes(DataGridView tablaClientes)
        {
            try
            {
                Connection conn = new Connection(); // CREA LA CONEXION
                //MySqlConnection connection = conn.GetConexion();
                //JOIN PARA UNIR TABLAS Y MOSTRAR COLUMNAS
                string query = @"
                SELECT 
                    c.run_cliente AS 'RUT', 
                    c.nombre AS 'Nombre', 
                    c.apellido AS 'Apellido', 
                    c.calle AS 'Dirección', 
                    c.telefono AS 'Teléfono', 
                    com.nombre_comuna AS 'Comuna', 
                    reg.nombre_region AS 'Región'
                FROM 
                    cliente c
                LEFT JOIN 
                    comuna com ON c.id_comuna = com.id_comuna
                LEFT JOIN 
                    region reg ON c.id_region = reg.id_region";
                tablaClientes.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn.GetConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //valores llenados
                tablaClientes.DataSource= dt;

                
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
                }
            }
        }
    }
}
