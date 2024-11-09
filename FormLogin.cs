using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioMAREF
{
    public partial class FormLogin : Form
    { 
        //AQUÍ YA SE ESTÁ HACIENDO LA CONEXIÓN
        FontTheme fontTheme = new FontTheme(@"C:\Users\Victus\source\repos\sistema\SistemaInventarioMAREF\resources\fonts\coolvetica.otf");
        Form1 form1;

        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "maref";
        private string user = "root";
        private string password = "Mikayuufanfic12";
        private string connectionString;


        // contructor q recibe parametro
        public FormLogin(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        public FormLogin()
        {
            InitializeComponent();


        }


        // FUNCIONES PROPIAS DEL LA CLASE FORM.

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm(false); 
        }

        private void buttonL_eliminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // FUNCIONES AL CERRARSE LOGIN

        private void CloseForm(bool isAccepted)
        {
            // CUANDO CIERRA EL FORMULARIO DE LOGIN Y VUELVE AL FORMULARIO PRINCIPAL
            if (isAccepted)
            {
                MessageBox.Show("Ingresado Correctamente. Bienvenido/a");
            }
           
            //cierra formlogin
            this.Close(); 
            
           // form1.Enabled = true;
         
        }

        private void InitializeAction()
        {
            // AGREGAR LA FUENTE A LA COLECCION DE FUENTES
            fontTheme.pfc.AddFontFile(fontTheme.fontPath);

            foreach (Control c in this.Controls)
            {
                c.Font = new Font(fontTheme.pfc.Families[0], c.Font.Size, c.Font.Style);
            }
            //.

            // APLICAR FUENTE A LOS TEXTOS
            labelL_username.Font = new Font(fontTheme.pfc.Families[0], labelL_username.Font.Size, FontStyle.Regular);
            labelL_contra.Font = new Font(fontTheme.pfc.Families[0], labelL_contra.Font.Size, FontStyle.Regular);
            buttonL_continuar.Font = new Font(fontTheme.pfc.Families[0], buttonL_continuar.Font.Size, FontStyle.Regular);
            buttonL_eliminar.Font = new Font(fontTheme.pfc.Families[0], buttonL_eliminar.Font.Size, FontStyle.Regular);
            txtNombre.Font = new Font(fontTheme.pfc.Families[0], txtNombre.Font.Size, FontStyle.Regular);
            txtPassword.Font = new Font(fontTheme.pfc.Families[0], txtPassword.Font.Size, FontStyle.Regular);
            //.

            // APLICAR COLORES
            buttonL_continuar.BackColor = ColorTheme.color2;
            buttonL_eliminar.BackColor = ColorTheme.color2;
            //.
        }

        private void textBoxL_userName_TextChanged(object sender, EventArgs e)
        {
             //INGRESAR USUARIO 
        }

        //  EJECUTA EL BOTON CONTINUAR SI LAS CREDENCIALES SON CORRECTAS (LA CONEXION ESTÁ HECHA EN EL MISMO CODIGO)
        private void buttonL_continuar_Click(object sender, EventArgs e) //CODIGO BOTON CONTINUAR
        {
            Connection conn = new Connection(); // CREA LA CONEXION
            MySqlConnection connection = conn.GetConexion(); // Obtiene la conexión
            //MessageBox.Show("Botón presionado");
            try
            {
               connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = connection;
            //agarra los labels de usuario y contraseña del FORMLOGIN
           
 
           //CONSULTA LA BASE DE DATOS
            codigo.CommandText = "SELECT * FROM Usuario WHERE nombre_usuario = @username AND contrasenna = @password";

            codigo.Parameters.AddWithValue("@username", txtNombre.Text);
            codigo.Parameters.AddWithValue("@password", txtPassword.Text);
            MySqlDataReader leer = codigo.ExecuteReader();

            //si el usuario y contraseña es correcto ingresa al form1 (CORREGIR PORQUE EL FORMLOGIN ESTÁ DENTRO DEL FORM1)
            if (leer.Read())
            {

                this.DialogResult = DialogResult.OK;  // Indica que el login fue exitoso
                 this.Close();

            }
            else //si es incorrecto
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                txtNombre.Clear();
                txtPassword.Clear();
            }
            connection.Close(); //se cierra conexion
        }
        
        private void textBoxL_contra_TextChanged(object sender, EventArgs e)
        {
            //ingresar contraseña 
        }

        // MOSTRAR U OCULTAR CONTRASEÑA 

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            //trae la imagen mostrar al frente
            pbOcultar.BringToFront();
            //muestra
            txtPassword.PasswordChar = '*';
           

        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            //oculta
            txtPassword.PasswordChar = '\0';
            //txtPassword.Refresh();



        }




    }
}
