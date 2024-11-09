using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;   // Para PrivateFontCollection
using System.Runtime.InteropServices;  // Para Marshal
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Globalization;

namespace SistemaInventarioMAREF
{
    public partial class Form1 : Form
    {
        // SE LE LLAMA PARA CARGAR LAS FUENTES QUE SE QUIERAN AGREGAR
        FontTheme fontTheme = new FontTheme(@"C:\Users\Victus\source\repos\sistema\SistemaInventarioMAREF\resources\fonts\coolvetica.otf");
        //.

        // LOS OBJETOS DE LA BASE DE DATOS (FARDOS, CLIENTES, FACTURAS, PEDIDOS)
        private List<Fardo> fardos = null;

        private List<Login> logins = new List<Login>();

        //.
        private List<Button> buttonsS = new List<Button>();
        private Connection connection;
        private bool isSelect = false;

        public Form1()
        {

            ConnectToDB();
            InitializeComponent();
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
            //ShowLoginForm1();
            //this.ClientSize = new Size(1280, 720);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            // Escalas
            float scaleX = 1280f / 1920f;
            float scaleY = 720f / 1080f;

            // Ajustar la posición de los controles
            foreach (Control control in this.Controls)
            {
                control.Location = new Point(
                    (int)(control.Location.X * scaleX),
                    (int)(control.Location.Y * scaleY)
                );
                control.Size = new Size(
                    (int)(control.Size.Width * scaleX),
                    (int)(control.Size.Height * scaleY)
                );
            }

            ApplicateActions();
            ColumnsDatabase();
        }


   

                private void ConnectToDB()
        {
            // GENERAR CONEXION CON BASE DE DATOS
            connection = new Connection();
            //.
        }

        private void ColumnsDatabase()
        {
            // COLUMNAS DE PRODUCTOS
            dataGridView_productos.AutoGenerateColumns = true;
            dataGridView_inventario.AutoGenerateColumns = true;

            fardos = connection.GetListFardo();
            if (fardos != null)
            {
                foreach (Fardo fardo in fardos)
                {
                    dataGridView_productos.Rows.Clear();
                    dataGridView_productos.Rows.Add(fardo.codigo, fardo.desc, Convert.FToString(fardo.peso, 1, false), fardo.stock,
                        Convert.FToString(fardo.precioUnitario, 2, true), (Convert.FToString(fardo.precioUnitario * fardo.stock, 2, true)));

                    dataGridView_inventario.Rows.Clear();
                    dataGridView_inventario.Rows.Add(fardo.codigo, fardo.desc, Convert.FToString(fardo.peso, 1, false), fardo.stock,
                        Convert.FToString(fardo.precioUnitario, 2, true), (Convert.FToString(fardo.precioUnitario * fardo.stock, 2, true)));
                }

                //dataGridView_productos.DataSource = null; // Limpiar la fuente de datos anterior
                //dataGridView_productos.DataSource = fardos;
                dataGridView_productos.ClearSelection();
                dataGridView_inventario.ClearSelection();
            }
            //.
        }

        private void ApplicateActions()
        {


            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            imageList.Images.Add(Convert.ResizeImage(Image.FromFile(@"C:\Users\Victus\source\repos\sistema\SistemaInventarioMAREF\resources\images\iconProducto1.png"), 32, 32));


            //button2.ImageList = imageList;
            //button2.ImageIndex = 0;

            // AGREGAR LA FUENTE A LA COLECCION DE FUENTES
            fontTheme.pfc.AddFontFile(fontTheme.fontPath);

            foreach (Control c in this.Controls)
            {
                c.Font = new Font(fontTheme.pfc.Families[0], c.Font.Size, c.Font.Style);
            }
            //.


            //--------------------------EDITAR COSAS ESPECIFICAS DE ALGUN COMPONENTE DENTRO DEL FORM.-------------------//

            // HABILITAR AJUSTE DE TEXTO EN LAS CELDAS
            dataGridView_productos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView_inventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //.

            // CONFIGURAR FILAS PARA QUE CAMBIEN SU ALTURA AUTOMATICAMENTE
            dataGridView_productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_inventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //.


            //-----------------------------ÇAMBIAR TAMAÑO, FUENTE, COLOR DE PANALES Y TEXTOS.---------------------------//

            // FONT BOTONES PRINCIPALES DEL MENU
            button_Pver.Font = new Font(fontTheme.pfc.Families[0], 11, FontStyle.Regular);
            button_Pconsultar.Font = new Font(fontTheme.pfc.Families[0], 11, FontStyle.Regular);
            button_CverClientes.Font = new Font(fontTheme.pfc.Families[0], 11, FontStyle.Regular);
            button_clientes.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            button_historial.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            button_productos.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            button_registrar.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            button_conta.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            button_salir.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            //button_iniciarSesion.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            //.

            //FONT DENTRO DE TABPAGE 'CLIENTES'
            label_listaclientes.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
            dataGridView_clientes.RowTemplate.DefaultCellStyle.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            dataGridView_clientes.ColumnHeadersDefaultCellStyle.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular); //columnas atributos
            label_buscarCliente.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            


            // FONT DENTRO DEL PANEL DE 'PRODUCTOS'
            label_title.Font = new Font(fontTheme.pfc.Families[0], 30, FontStyle.Regular);


            dataGridView_productos.RowTemplate.DefaultCellStyle.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            dataGridView_inventario.RowTemplate.DefaultCellStyle.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            dataGridView_productos.ColumnHeadersDefaultCellStyle.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            dataGridView_inventario.ColumnHeadersDefaultCellStyle.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(fontTheme.pfc.Families[0], 14, FontStyle.Regular);

            label_listaProductos.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
            label_listaInventario.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
 
            label_modificarCat.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
            label_modificarCatP_codigo.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
            label_modificarCatP_desc.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
            label_modificarCatP_peso.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
            label_modificarCatP_precioU.Font = new Font(fontTheme.pfc.Families[0], 16, FontStyle.Regular);
            label_buscar.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            label_buscarI.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);

            textBox_productos_buscar.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            textBox_modificarCatP_codigo.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            textBox_modificarCatP_desc.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            textBox_modificarCatP_peso.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            textBox_modificarCatP_precioU.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);

            comboBox_mostrar.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            comboBox_mostrarI.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);

            button_registrarProducto.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            button_modificarCatP_crear.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            button_modificarCatP_actualizar.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            button_modificarCatP_eliminar.Font = new Font(fontTheme.pfc.Families[0], 13, FontStyle.Regular);
            //.

            // COLOR PANELES Y BOTONES PRINCIPALES DE TABPAGE
            ColorTheme.ElegirTema(0);
            panel2.BackColor = ColorTheme.color2;
            panel_productoTable.BackColor = ColorTheme.color2;
            panel_inventario_tabla.BackColor = ColorTheme.color2;
            panel_clientes_tabla.BackColor = ColorTheme.color2;

            panel_modificarCat.BackColor = ColorTheme.color2;
            button_clientes.BackColor = ColorTheme.color2;
            button_historial.BackColor = ColorTheme.color2;
            button_productos.BackColor = ColorTheme.color2;
            button_registrar.BackColor = ColorTheme.color2;
            button_conta.BackColor = ColorTheme.color2;
            button_salir.BackColor = ColorTheme.color2;
            //button_iniciarSesion.BackColor = ColorTheme.color2;
            button_registrarProducto.BackColor = ColorTheme.color2;
            button_modificarCatP_crear.BackColor = ColorTheme.color2;
            button_modificarCatP_actualizar.BackColor = ColorTheme.color2;
            button_modificarCatP_eliminar.BackColor = ColorTheme.color2;
            button_Pver.BackColor = ColorTheme.color2;
            button_Pconsultar.BackColor = ColorTheme.color2;
            button_CverClientes.BackColor = ColorTheme.color2;
            //.

            // COLOR PANEL FONDO BASE DE DATOS.
            panel3.BackColor = ColorTheme.color3;
            dataGridView_productos.RowTemplate.DefaultCellStyle.BackColor = ColorTheme.color3;
            dataGridView_inventario.RowTemplate.DefaultCellStyle.BackColor = ColorTheme.color3;
            dataGridView_productos.ColumnHeadersDefaultCellStyle.BackColor = ColorTheme.color3;
            dataGridView_inventario.ColumnHeadersDefaultCellStyle.BackColor = ColorTheme.color3;
            //.

            // COLOR DE PANEL INDICADOR.
            pictureBox_title.BackColor = ColorTheme.color2;
            label_title.BackColor = ColorTheme.color2;
            //.
        }
        //PANTALLA CARGA, SI CONECTA CORRECTAMENTE MUESTRA MENSAJE
        private void Form1_Load(object sender, EventArgs e)
        {

            if (connection.GetConexion() != null)
            {
                MessageBox.Show("CONECTADO.");
            }
            else
            {
                MessageBox.Show("ERROR.");
            }

            buttonsS.Add(button_Pver);
            buttonsS.Add(button_Pconsultar);
            buttonsS.Add(button_CverClientes);
        }

        private void pictureBox_title_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // DIBUJAR UN BORDE AL PANEL
            using (Pen borderPen = new Pen(ColorTheme.color2, 2)) // COLOR Y GROSOR DEL BORDE
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, ((Panel)sender).Width - 1, ((Panel)sender).Height - 1);
            }
            //.
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATENCION. Si decide salir se podrían perder los datos.");
        }

        private void button_productos_Click(object sender, EventArgs e)
        {
            isSelect = !isSelect;

            if (isSelect)
            {
                // SUB BOTON 1
                button_Pver.Visible = true;
                button_Pver.Enabled = true;
                button_Pver.Location = new Point(button_productos.Location.X + 150, button_productos.Location.Y + button_productos.Size.Height);
                //.

                // SUB BOTON 2
                button_Pconsultar.Visible = true;
                button_Pconsultar.Enabled = true;
                button_Pconsultar.Location = new Point(button_productos.Location.X + 150, button_productos.Location.Y + button_productos.Size.Height
                    + button_Pver.Size.Height);
                //.

                button_clientes.Location = new Point(button_clientes.Location.X, button_clientes.Location.Y + 50);
                button_registrar.Location = new Point(button_registrar.Location.X, button_registrar.Location.Y + 50);
                button_historial.Location = new Point(button_historial.Location.X, button_historial.Location.Y + 50);
                button_conta.Location = new Point(button_conta.Location.X, button_conta.Location.Y + 50);

                pictureBox_cliente.Location = new Point(pictureBox_cliente.Location.X, pictureBox_cliente.Location.Y + 50);
                pictureBox_registrar.Location = new Point(pictureBox_registrar.Location.X, pictureBox_registrar.Location.Y + 50);
                pictureBox_historial.Location = new Point(pictureBox_historial.Location.X, pictureBox_historial.Location.Y + 50);
                pictureBox_conta.Location = new Point(pictureBox_conta.Location.X, pictureBox_conta.Location.Y + 50);
            }

            else
            {
                // SUB BOTON 1
                button_Pver.Visible = false;
                button_Pver.Enabled = false;
                //.

                // SUB BOTON 2
                button_Pconsultar.Visible = false;
                button_Pconsultar.Enabled = false;
                //.

                button_clientes.Location = new Point(button_clientes.Location.X, button_clientes.Location.Y - 50);
                button_registrar.Location = new Point(button_registrar.Location.X, button_registrar.Location.Y - 50);
                button_historial.Location = new Point(button_historial.Location.X, button_historial.Location.Y - 50);
                button_conta.Location = new Point(button_conta.Location.X, button_conta.Location.Y - 50);

                pictureBox_cliente.Location = new Point(pictureBox_cliente.Location.X, pictureBox_cliente.Location.Y - 50);
                pictureBox_registrar.Location = new Point(pictureBox_registrar.Location.X, pictureBox_registrar.Location.Y - 50);
                pictureBox_historial.Location = new Point(pictureBox_historial.Location.X, pictureBox_historial.Location.Y - 50);
                pictureBox_conta.Location = new Point(pictureBox_conta.Location.X, pictureBox_conta.Location.Y - 50);
            }
        
        }

        private void button_clientes_Click(object sender, EventArgs e)
        {
            label_title.Text = "CATALOGO DE CLIENTES";
            tabcontrol1.SelectedTab = tabPage1_Clientes;
        }
          

        //FORMULARIO DE SESION USUARIO
        /*
        private void button_sesion_Click(object sender, EventArgs e)
        {
            label_title.Text = "ADMINISTRADOR";

            // SE LLAMA Y ABRE EL FORMULARIO PARA INICIAR SESION DENTRO DEL PROGRAMA.
            this.Enabled = false;
            FormLogin form1 = new FormLogin(this);
            //form1.ShowDialog(); // showdialog bloquea la interaccion del usuario al logearse correctamente
            form1.Show(); //una vez ingresado correctamente, deja al usuario interactuar
            //.
        }
        */
        private void button_historial_Click(object sender, EventArgs e)
        {
            label_title.Text = "HISTORIAL";
        }
        
        private void button_regis_Click(object sender, EventArgs e)
        {
            label_title.Text = "REGISTRAR COMPRA";
        }

        private void button_conta_Click(object sender, EventArgs e)
        {
            label_title.Text = "CONTABILIDAD";
        }

        // CUANDO SE DA CLICK A UNA FILA DENTRO DEL DATA GRID VIEW
        private void dataGridView_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView_productos.Rows[e.RowIndex];

                textBox_modificarCatP_codigo.Text = filaSeleccionada.Cells[0].Value.ToString(); // Columna 1
                textBox_modificarCatP_desc.Text = filaSeleccionada.Cells[1].Value.ToString(); // Columna 2
                textBox_modificarCatP_peso.Text = filaSeleccionada.Cells[2].Value.ToString(); // Columna 3
                textBox_modificarCatP_precioU.Text = filaSeleccionada.Cells[4].Value.ToString(); // Columna 4
            }
        }
        //.

        // CUANDO SE ACTUALIZA UN FARDO.
        private void button_modificarCatP_actualizar_Click(object sender, EventArgs e)
        {
            string codigo = textBox_modificarCatP_codigo.Text;
            string desc = textBox_modificarCatP_desc.Text;
            string peso = textBox_modificarCatP_peso.Text;
            string precioU = textBox_modificarCatP_precioU.Text;

            if (textBox_modificarCatP_codigo.Text != null)
            {
                foreach (Fardo fardo in fardos)
                {
                    // REEMPLAZAR CARACTERES ESPECIFICOS QUE POR LO GENERAL USAN AL PONER CANTIDAD DE DINERO ($, '.', ',', etc)
                    peso = peso.Replace(".", ",");
                    precioU = precioU.Replace(",", "");
                    precioU = precioU.Replace(".", ",");
                    precioU = precioU.Replace("$", "");
                    precioU = precioU.Replace(" ", "");
                    //.

                    float numeroPeso, numeroPrecioU;
                    float.TryParse(peso, NumberStyles.Any, new CultureInfo("es-ES"), out numeroPeso);
                    float.TryParse(precioU, NumberStyles.Any, new CultureInfo("es-ES"), out numeroPrecioU);
                    connection.UpdateFardo(fardo.codigo, codigo, desc, numeroPeso, numeroPrecioU);
                }
                ColumnsDatabase();  // ACTUALIZAR LA LISTA DE FARDOS.
            }
        }
        //.


        // CUANDO SE AGREGA INVENTARIO
        private void button_registrarProducto_Click(object sender, EventArgs e)
        {

        }
        //.

        // VER INVENTARIO BOTON.
        private void button_Pver_Click(object sender, EventArgs e)
        {
            label_title.Text = "Catalogo de Productos";
            tabcontrol1.SelectedTab = tabPage_inventario;
        }

        private void button_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_listaInventario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_inventario_tabla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            // DIBUJAR UN BORDE AL PANEL
            using (Pen borderPen = new Pen(ColorTheme.color2, 2)) // COLOR Y GROSOR DEL BORDE
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, ((Panel)sender).Width - 1, ((Panel)sender).Height - 1);
            }
            //.
        }

        private void panel_productoTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //.

    }
}
