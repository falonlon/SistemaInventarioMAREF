using System.Windows.Forms;

namespace SistemaInventarioMAREF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_CverClientes = new System.Windows.Forms.Button();
            this.button_Pconsultar = new System.Windows.Forms.Button();
            this.button_Pver = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox_salir = new System.Windows.Forms.PictureBox();
            this.button_salir = new System.Windows.Forms.Button();
            this.pictureBox_conta = new System.Windows.Forms.PictureBox();
            this.pictureBox_historial = new System.Windows.Forms.PictureBox();
            this.pictureBox_registrar = new System.Windows.Forms.PictureBox();
            this.pictureBox_cliente = new System.Windows.Forms.PictureBox();
            this.pictureBox_producto = new System.Windows.Forms.PictureBox();
            this.button_conta = new System.Windows.Forms.Button();
            this.button_registrar = new System.Windows.Forms.Button();
            this.button_historial = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_clientes = new System.Windows.Forms.Button();
            this.button_productos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_contenido_user = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_title = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage_inventario = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label_buscarI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_elementosInventario = new System.Windows.Forms.Label();
            this.comboBox_mostrarI = new System.Windows.Forms.ComboBox();
            this.panel_inventario_tabla = new System.Windows.Forms.Panel();
            this.label_listaInventario = new System.Windows.Forms.Label();
            this.dataGridView_inventario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_productos = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_buscar = new System.Windows.Forms.Label();
            this.textBox_productos_buscar = new System.Windows.Forms.TextBox();
            this.label_elementosProductos = new System.Windows.Forms.Label();
            this.comboBox_mostrar = new System.Windows.Forms.ComboBox();
            this.panel_productoTable = new System.Windows.Forms.Panel();
            this.label_listaProductos = new System.Windows.Forms.Label();
            this.dataGridView_productos = new System.Windows.Forms.DataGridView();
            this.Column_precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_pUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_stockA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_registrarProducto = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_modificarCatP_codigo = new System.Windows.Forms.Label();
            this.textBox_modificarCatP_codigo = new System.Windows.Forms.TextBox();
            this.textBox_modificarCatP_desc = new System.Windows.Forms.TextBox();
            this.textBox_modificarCatP_peso = new System.Windows.Forms.TextBox();
            this.textBox_modificarCatP_precioU = new System.Windows.Forms.TextBox();
            this.label_modificarCatP_desc = new System.Windows.Forms.Label();
            this.label_modificarCatP_peso = new System.Windows.Forms.Label();
            this.label_modificarCatP_precioU = new System.Windows.Forms.Label();
            this.button_modificarCatP_crear = new System.Windows.Forms.Button();
            this.button_modificarCatP_actualizar = new System.Windows.Forms.Button();
            this.button_modificarCatP_eliminar = new System.Windows.Forms.Button();
            this.panel_modificarCat = new System.Windows.Forms.Panel();
            this.label_modificarCat = new System.Windows.Forms.Label();
            this.tabPage_login = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1_Clientes = new System.Windows.Forms.TabPage();
            this.dataGridView_clientes = new System.Windows.Forms.DataGridView();
            this.panel_clientes_tabla = new System.Windows.Forms.Panel();
            this.label_listaclientes = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_elementosCliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_buscarCliente = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_registrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_contenido_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage_inventario.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel_inventario_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inventario)).BeginInit();
            this.tabPage_productos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_productoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel_modificarCat.SuspendLayout();
            this.tabPage_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabcontrol1.SuspendLayout();
            this.tabPage1_Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).BeginInit();
            this.panel_clientes_tabla.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.button_CverClientes);
            this.panel2.Controls.Add(this.button_Pconsultar);
            this.panel2.Controls.Add(this.button_Pver);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pictureBox_conta);
            this.panel2.Controls.Add(this.pictureBox_historial);
            this.panel2.Controls.Add(this.pictureBox_registrar);
            this.panel2.Controls.Add(this.pictureBox_cliente);
            this.panel2.Controls.Add(this.pictureBox_producto);
            this.panel2.Controls.Add(this.button_conta);
            this.panel2.Controls.Add(this.button_registrar);
            this.panel2.Controls.Add(this.button_historial);
            this.panel2.Controls.Add(this.pictureBox_logo);
            this.panel2.Controls.Add(this.button_clientes);
            this.panel2.Controls.Add(this.button_productos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 1055);
            this.panel2.TabIndex = 0;
            // 
            // button_CverClientes
            // 
            this.button_CverClientes.BackColor = System.Drawing.Color.Teal;
            this.button_CverClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_CverClientes.FlatAppearance.BorderSize = 0;
            this.button_CverClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_CverClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_CverClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CverClientes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CverClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_CverClientes.Location = new System.Drawing.Point(198, 820);
            this.button_CverClientes.Margin = new System.Windows.Forms.Padding(4);
            this.button_CverClientes.Name = "button_CverClientes";
            this.button_CverClientes.Size = new System.Drawing.Size(302, 35);
            this.button_CverClientes.TabIndex = 19;
            this.button_CverClientes.Text = "VER CATALOGO DE CLIENTES";
            this.button_CverClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CverClientes.UseVisualStyleBackColor = false;
            this.button_CverClientes.Visible = false;
            // 
            // button_Pconsultar
            // 
            this.button_Pconsultar.BackColor = System.Drawing.Color.Teal;
            this.button_Pconsultar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Pconsultar.FlatAppearance.BorderSize = 0;
            this.button_Pconsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_Pconsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Pconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pconsultar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pconsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Pconsultar.Location = new System.Drawing.Point(198, 778);
            this.button_Pconsultar.Margin = new System.Windows.Forms.Padding(4);
            this.button_Pconsultar.Name = "button_Pconsultar";
            this.button_Pconsultar.Size = new System.Drawing.Size(288, 35);
            this.button_Pconsultar.TabIndex = 18;
            this.button_Pconsultar.Text = "CONSULTAR";
            this.button_Pconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pconsultar.UseVisualStyleBackColor = false;
            this.button_Pconsultar.Visible = false;
            // 
            // button_Pver
            // 
            this.button_Pver.BackColor = System.Drawing.Color.Teal;
            this.button_Pver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Pver.FlatAppearance.BorderSize = 0;
            this.button_Pver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_Pver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Pver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pver.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Pver.Location = new System.Drawing.Point(198, 735);
            this.button_Pver.Margin = new System.Windows.Forms.Padding(4);
            this.button_Pver.Name = "button_Pver";
            this.button_Pver.Size = new System.Drawing.Size(288, 35);
            this.button_Pver.TabIndex = 17;
            this.button_Pver.Text = "VER INVENTARIO";
            this.button_Pver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pver.UseVisualStyleBackColor = false;
            this.button_Pver.Visible = false;
            this.button_Pver.Click += new System.EventHandler(this.button_Pver_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.pictureBox_salir);
            this.panel5.Controls.Add(this.button_salir);
            this.panel5.Location = new System.Drawing.Point(0, 755);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 300);
            this.panel5.TabIndex = 16;
            // 
            // pictureBox_salir
            // 
            this.pictureBox_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_salir.Enabled = false;
            this.pictureBox_salir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_salir.Image")));
            this.pictureBox_salir.Location = new System.Drawing.Point(90, 154);
            this.pictureBox_salir.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_salir.Name = "pictureBox_salir";
            this.pictureBox_salir.Size = new System.Drawing.Size(60, 51);
            this.pictureBox_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_salir.TabIndex = 12;
            this.pictureBox_salir.TabStop = false;
            // 
            // button_salir
            // 
            this.button_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_salir.BackColor = System.Drawing.Color.Teal;
            this.button_salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_salir.FlatAppearance.BorderSize = 0;
            this.button_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salir.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_salir.Location = new System.Drawing.Point(0, 135);
            this.button_salir.Margin = new System.Windows.Forms.Padding(4);
            this.button_salir.Name = "button_salir";
            this.button_salir.Padding = new System.Windows.Forms.Padding(188, 0, 0, 0);
            this.button_salir.Size = new System.Drawing.Size(469, 86);
            this.button_salir.TabIndex = 6;
            this.button_salir.Text = "SALIR";
            this.button_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click_1);
            // 
            // pictureBox_conta
            // 
            this.pictureBox_conta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_conta.Enabled = false;
            this.pictureBox_conta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_conta.Image")));
            this.pictureBox_conta.Location = new System.Drawing.Point(90, 659);
            this.pictureBox_conta.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_conta.Name = "pictureBox_conta";
            this.pictureBox_conta.Size = new System.Drawing.Size(60, 58);
            this.pictureBox_conta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_conta.TabIndex = 11;
            this.pictureBox_conta.TabStop = false;
            // 
            // pictureBox_historial
            // 
            this.pictureBox_historial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_historial.Enabled = false;
            this.pictureBox_historial.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_historial.Image")));
            this.pictureBox_historial.Location = new System.Drawing.Point(90, 562);
            this.pictureBox_historial.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_historial.Name = "pictureBox_historial";
            this.pictureBox_historial.Size = new System.Drawing.Size(60, 58);
            this.pictureBox_historial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_historial.TabIndex = 10;
            this.pictureBox_historial.TabStop = false;
            // 
            // pictureBox_registrar
            // 
            this.pictureBox_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_registrar.Enabled = false;
            this.pictureBox_registrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_registrar.Image")));
            this.pictureBox_registrar.Location = new System.Drawing.Point(90, 471);
            this.pictureBox_registrar.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_registrar.Name = "pictureBox_registrar";
            this.pictureBox_registrar.Size = new System.Drawing.Size(60, 58);
            this.pictureBox_registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_registrar.TabIndex = 9;
            this.pictureBox_registrar.TabStop = false;
            // 
            // pictureBox_cliente
            // 
            this.pictureBox_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_cliente.Enabled = false;
            this.pictureBox_cliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cliente.Image")));
            this.pictureBox_cliente.Location = new System.Drawing.Point(90, 375);
            this.pictureBox_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_cliente.Name = "pictureBox_cliente";
            this.pictureBox_cliente.Size = new System.Drawing.Size(60, 58);
            this.pictureBox_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cliente.TabIndex = 8;
            this.pictureBox_cliente.TabStop = false;
            // 
            // pictureBox_producto
            // 
            this.pictureBox_producto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_producto.Enabled = false;
            this.pictureBox_producto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_producto.Image")));
            this.pictureBox_producto.Location = new System.Drawing.Point(90, 278);
            this.pictureBox_producto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_producto.Name = "pictureBox_producto";
            this.pictureBox_producto.Size = new System.Drawing.Size(60, 58);
            this.pictureBox_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_producto.TabIndex = 7;
            this.pictureBox_producto.TabStop = false;
            // 
            // button_conta
            // 
            this.button_conta.BackColor = System.Drawing.Color.Teal;
            this.button_conta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_conta.FlatAppearance.BorderSize = 0;
            this.button_conta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_conta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_conta.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_conta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_conta.Location = new System.Drawing.Point(0, 641);
            this.button_conta.Margin = new System.Windows.Forms.Padding(4);
            this.button_conta.Name = "button_conta";
            this.button_conta.Padding = new System.Windows.Forms.Padding(188, 0, 0, 0);
            this.button_conta.Size = new System.Drawing.Size(469, 86);
            this.button_conta.TabIndex = 5;
            this.button_conta.Text = "CONTABILIDAD";
            this.button_conta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_conta.UseVisualStyleBackColor = false;
            this.button_conta.Click += new System.EventHandler(this.button_conta_Click);
            // 
            // button_registrar
            // 
            this.button_registrar.BackColor = System.Drawing.Color.Teal;
            this.button_registrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_registrar.FlatAppearance.BorderSize = 0;
            this.button_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registrar.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_registrar.Location = new System.Drawing.Point(0, 454);
            this.button_registrar.Margin = new System.Windows.Forms.Padding(4);
            this.button_registrar.Name = "button_registrar";
            this.button_registrar.Padding = new System.Windows.Forms.Padding(188, 0, 0, 0);
            this.button_registrar.Size = new System.Drawing.Size(469, 86);
            this.button_registrar.TabIndex = 3;
            this.button_registrar.Text = "COMPRAS";
            this.button_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registrar.UseVisualStyleBackColor = false;
            this.button_registrar.Click += new System.EventHandler(this.button_regis_Click);
            // 
            // button_historial
            // 
            this.button_historial.BackColor = System.Drawing.Color.Teal;
            this.button_historial.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_historial.FlatAppearance.BorderSize = 0;
            this.button_historial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_historial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_historial.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_historial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_historial.Location = new System.Drawing.Point(0, 548);
            this.button_historial.Margin = new System.Windows.Forms.Padding(4);
            this.button_historial.Name = "button_historial";
            this.button_historial.Padding = new System.Windows.Forms.Padding(188, 0, 0, 0);
            this.button_historial.Size = new System.Drawing.Size(469, 86);
            this.button_historial.TabIndex = 2;
            this.button_historial.Text = "VENTAS";
            this.button_historial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_historial.UseVisualStyleBackColor = false;
            this.button_historial.Click += new System.EventHandler(this.button_historial_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(165, 15);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(124, 155);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // button_clientes
            // 
            this.button_clientes.BackColor = System.Drawing.Color.Teal;
            this.button_clientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clientes.FlatAppearance.BorderSize = 0;
            this.button_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clientes.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_clientes.Location = new System.Drawing.Point(0, 360);
            this.button_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.button_clientes.Name = "button_clientes";
            this.button_clientes.Padding = new System.Windows.Forms.Padding(188, 0, 0, 0);
            this.button_clientes.Size = new System.Drawing.Size(469, 86);
            this.button_clientes.TabIndex = 1;
            this.button_clientes.Text = "CLIENTES";
            this.button_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clientes.UseVisualStyleBackColor = false;
            this.button_clientes.Click += new System.EventHandler(this.button_clientes_Click);
            // 
            // button_productos
            // 
            this.button_productos.BackColor = System.Drawing.Color.Teal;
            this.button_productos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_productos.FlatAppearance.BorderSize = 0;
            this.button_productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_productos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_productos.Location = new System.Drawing.Point(0, 264);
            this.button_productos.Margin = new System.Windows.Forms.Padding(4);
            this.button_productos.Name = "button_productos";
            this.button_productos.Padding = new System.Windows.Forms.Padding(188, 0, 0, 0);
            this.button_productos.Size = new System.Drawing.Size(469, 86);
            this.button_productos.TabIndex = 0;
            this.button_productos.Text = "INVENTARIO";
            this.button_productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_productos.UseVisualStyleBackColor = false;
            this.button_productos.Click += new System.EventHandler(this.button_productos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.panel_contenido_user);
            this.panel3.Controls.Add(this.label_title);
            this.panel3.Controls.Add(this.pictureBox_title);
            this.panel3.Location = new System.Drawing.Point(466, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1929, 1316);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel_contenido_user
            // 
            this.panel_contenido_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_contenido_user.Controls.Add(this.tabcontrol1);
            this.panel_contenido_user.Location = new System.Drawing.Point(10, 118);
            this.panel_contenido_user.Margin = new System.Windows.Forms.Padding(4);
            this.panel_contenido_user.Name = "panel_contenido_user";
            this.panel_contenido_user.Size = new System.Drawing.Size(1889, 1180);
            this.panel_contenido_user.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_title.Location = new System.Drawing.Point(534, 15);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(810, 81);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "INVENTARIO";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_title
            // 
            this.pictureBox_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_title.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox_title.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_title.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_title.Name = "pictureBox_title";
            this.pictureBox_title.Size = new System.Drawing.Size(1992, 109);
            this.pictureBox_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_title.TabIndex = 0;
            this.pictureBox_title.TabStop = false;
            this.pictureBox_title.Click += new System.EventHandler(this.pictureBox_title_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1055);
            this.panel1.TabIndex = 0;
            // 
            // tabPage_inventario
            // 
            this.tabPage_inventario.Controls.Add(this.dataGridView_inventario);
            this.tabPage_inventario.Controls.Add(this.panel_inventario_tabla);
            this.tabPage_inventario.Controls.Add(this.panel8);
            this.tabPage_inventario.Location = new System.Drawing.Point(4, 28);
            this.tabPage_inventario.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_inventario.Name = "tabPage_inventario";
            this.tabPage_inventario.Size = new System.Drawing.Size(1881, 1148);
            this.tabPage_inventario.TabIndex = 2;
            this.tabPage_inventario.Text = "inventario";
            this.tabPage_inventario.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.comboBox_mostrarI);
            this.panel8.Controls.Add(this.label_elementosInventario);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.label_buscarI);
            this.panel8.Location = new System.Drawing.Point(32, 115);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1421, 939);
            this.panel8.TabIndex = 5;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label_buscarI
            // 
            this.label_buscarI.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarI.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_buscarI.Location = new System.Drawing.Point(1035, 89);
            this.label_buscarI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_buscarI.Name = "label_buscarI";
            this.label_buscarI.Size = new System.Drawing.Size(138, 50);
            this.label_buscarI.TabIndex = 4;
            this.label_buscarI.Text = "Buscar:";
            this.label_buscarI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1161, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 34);
            this.textBox1.TabIndex = 5;
            // 
            // label_elementosInventario
            // 
            this.label_elementosInventario.BackColor = System.Drawing.Color.Transparent;
            this.label_elementosInventario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_elementosInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_elementosInventario.Location = new System.Drawing.Point(18, 84);
            this.label_elementosInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_elementosInventario.Name = "label_elementosInventario";
            this.label_elementosInventario.Size = new System.Drawing.Size(389, 55);
            this.label_elementosInventario.TabIndex = 6;
            this.label_elementosInventario.Text = "Mostrar            elementos";
            this.label_elementosInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_mostrarI
            // 
            this.comboBox_mostrarI.FormattingEnabled = true;
            this.comboBox_mostrarI.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.comboBox_mostrarI.Location = new System.Drawing.Point(151, 104);
            this.comboBox_mostrarI.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_mostrarI.Name = "comboBox_mostrarI";
            this.comboBox_mostrarI.Size = new System.Drawing.Size(64, 24);
            this.comboBox_mostrarI.TabIndex = 7;
            this.comboBox_mostrarI.Text = "10";
            // 
            // panel_inventario_tabla
            // 
            this.panel_inventario_tabla.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_inventario_tabla.Controls.Add(this.label_listaInventario);
            this.panel_inventario_tabla.Location = new System.Drawing.Point(32, 115);
            this.panel_inventario_tabla.Margin = new System.Windows.Forms.Padding(4);
            this.panel_inventario_tabla.Name = "panel_inventario_tabla";
            this.panel_inventario_tabla.Size = new System.Drawing.Size(1421, 65);
            this.panel_inventario_tabla.TabIndex = 4;
            this.panel_inventario_tabla.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_inventario_tabla_Paint);
            // 
            // label_listaInventario
            // 
            this.label_listaInventario.BackColor = System.Drawing.Color.Transparent;
            this.label_listaInventario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_listaInventario.Location = new System.Drawing.Point(4, 0);
            this.label_listaInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_listaInventario.Name = "label_listaInventario";
            this.label_listaInventario.Size = new System.Drawing.Size(321, 61);
            this.label_listaInventario.TabIndex = 3;
            this.label_listaInventario.Text = "Inventario";
            this.label_listaInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_listaInventario.Click += new System.EventHandler(this.label_listaInventario_Click);
            // 
            // dataGridView_inventario
            // 
            this.dataGridView_inventario.AllowUserToAddRows = false;
            this.dataGridView_inventario.AllowUserToDeleteRows = false;
            this.dataGridView_inventario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_inventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_inventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_inventario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_inventario.ColumnHeadersHeight = 45;
            this.dataGridView_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_inventario.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_inventario.Location = new System.Drawing.Point(58, 279);
            this.dataGridView_inventario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_inventario.MultiSelect = false;
            this.dataGridView_inventario.Name = "dataGridView_inventario";
            this.dataGridView_inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_inventario.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_inventario.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_inventario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_inventario.RowTemplate.Height = 50;
            this.dataGridView_inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_inventario.Size = new System.Drawing.Size(1372, 742);
            this.dataGridView_inventario.TabIndex = 3;
            this.dataGridView_inventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_inventario_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio Total";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio Unit.";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Peso (KG)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // tabPage_productos
            // 
            this.tabPage_productos.Controls.Add(this.panel_modificarCat);
            this.tabPage_productos.Controls.Add(this.panel6);
            this.tabPage_productos.Controls.Add(this.button_registrarProducto);
            this.tabPage_productos.Controls.Add(this.dataGridView_productos);
            this.tabPage_productos.Controls.Add(this.panel_productoTable);
            this.tabPage_productos.Controls.Add(this.panel4);
            this.tabPage_productos.Location = new System.Drawing.Point(4, 28);
            this.tabPage_productos.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_productos.Name = "tabPage_productos";
            this.tabPage_productos.Size = new System.Drawing.Size(1881, 1148);
            this.tabPage_productos.TabIndex = 1;
            this.tabPage_productos.Text = "productos";
            this.tabPage_productos.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.comboBox_mostrar);
            this.panel4.Controls.Add(this.label_elementosProductos);
            this.panel4.Controls.Add(this.textBox_productos_buscar);
            this.panel4.Controls.Add(this.label_buscar);
            this.panel4.Location = new System.Drawing.Point(32, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1421, 939);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label_buscar
            // 
            this.label_buscar.BackColor = System.Drawing.Color.Transparent;
            this.label_buscar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_buscar.Location = new System.Drawing.Point(1035, 89);
            this.label_buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(138, 50);
            this.label_buscar.TabIndex = 4;
            this.label_buscar.Text = "Buscar:";
            this.label_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_productos_buscar
            // 
            this.textBox_productos_buscar.Location = new System.Drawing.Point(1161, 99);
            this.textBox_productos_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_productos_buscar.Multiline = true;
            this.textBox_productos_buscar.Name = "textBox_productos_buscar";
            this.textBox_productos_buscar.Size = new System.Drawing.Size(234, 34);
            this.textBox_productos_buscar.TabIndex = 5;
            // 
            // label_elementosProductos
            // 
            this.label_elementosProductos.BackColor = System.Drawing.Color.Transparent;
            this.label_elementosProductos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_elementosProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_elementosProductos.Location = new System.Drawing.Point(18, 84);
            this.label_elementosProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_elementosProductos.Name = "label_elementosProductos";
            this.label_elementosProductos.Size = new System.Drawing.Size(389, 55);
            this.label_elementosProductos.TabIndex = 6;
            this.label_elementosProductos.Text = "Mostrar            elementos";
            this.label_elementosProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_mostrar
            // 
            this.comboBox_mostrar.FormattingEnabled = true;
            this.comboBox_mostrar.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.comboBox_mostrar.Location = new System.Drawing.Point(151, 104);
            this.comboBox_mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_mostrar.Name = "comboBox_mostrar";
            this.comboBox_mostrar.Size = new System.Drawing.Size(64, 24);
            this.comboBox_mostrar.TabIndex = 7;
            this.comboBox_mostrar.Text = "10";
            // 
            // panel_productoTable
            // 
            this.panel_productoTable.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_productoTable.Controls.Add(this.label_listaProductos);
            this.panel_productoTable.Location = new System.Drawing.Point(32, 111);
            this.panel_productoTable.Margin = new System.Windows.Forms.Padding(4);
            this.panel_productoTable.Name = "panel_productoTable";
            this.panel_productoTable.Size = new System.Drawing.Size(1421, 65);
            this.panel_productoTable.TabIndex = 1;
            this.panel_productoTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_productoTable_Paint);
            // 
            // label_listaProductos
            // 
            this.label_listaProductos.BackColor = System.Drawing.Color.Transparent;
            this.label_listaProductos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_listaProductos.Location = new System.Drawing.Point(4, 0);
            this.label_listaProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_listaProductos.Name = "label_listaProductos";
            this.label_listaProductos.Size = new System.Drawing.Size(321, 61);
            this.label_listaProductos.TabIndex = 3;
            this.label_listaProductos.Text = "Lista de productos";
            this.label_listaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_productos
            // 
            this.dataGridView_productos.AllowUserToAddRows = false;
            this.dataGridView_productos.AllowUserToDeleteRows = false;
            this.dataGridView_productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_productos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_productos.ColumnHeadersHeight = 45;
            this.dataGridView_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_cod,
            this.Column_desc,
            this.Column_Peso,
            this.Column_stockA,
            this.Column_pUnitario,
            this.Column_precioTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_productos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_productos.Location = new System.Drawing.Point(58, 275);
            this.dataGridView_productos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_productos.MultiSelect = false;
            this.dataGridView_productos.Name = "dataGridView_productos";
            this.dataGridView_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_productos.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_productos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_productos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_productos.RowTemplate.Height = 50;
            this.dataGridView_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_productos.Size = new System.Drawing.Size(1372, 742);
            this.dataGridView_productos.TabIndex = 0;
            this.dataGridView_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productos_CellClick);
            // 
            // Column_precioTotal
            // 
            this.Column_precioTotal.HeaderText = "Precio Total";
            this.Column_precioTotal.MinimumWidth = 6;
            this.Column_precioTotal.Name = "Column_precioTotal";
            this.Column_precioTotal.ReadOnly = true;
            this.Column_precioTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_precioTotal.Width = 150;
            // 
            // Column_pUnitario
            // 
            this.Column_pUnitario.HeaderText = "Precio Unit.";
            this.Column_pUnitario.MinimumWidth = 6;
            this.Column_pUnitario.Name = "Column_pUnitario";
            this.Column_pUnitario.ReadOnly = true;
            this.Column_pUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_pUnitario.Width = 150;
            // 
            // Column_stockA
            // 
            this.Column_stockA.HeaderText = "Cantidad";
            this.Column_stockA.MinimumWidth = 6;
            this.Column_stockA.Name = "Column_stockA";
            this.Column_stockA.ReadOnly = true;
            this.Column_stockA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_stockA.Width = 150;
            // 
            // Column_Peso
            // 
            this.Column_Peso.HeaderText = "Peso (KG)";
            this.Column_Peso.MinimumWidth = 6;
            this.Column_Peso.Name = "Column_Peso";
            this.Column_Peso.ReadOnly = true;
            this.Column_Peso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Peso.Width = 125;
            // 
            // Column_desc
            // 
            this.Column_desc.HeaderText = "Descripcion";
            this.Column_desc.MinimumWidth = 6;
            this.Column_desc.Name = "Column_desc";
            this.Column_desc.ReadOnly = true;
            this.Column_desc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_desc.Width = 400;
            // 
            // Column_cod
            // 
            this.Column_cod.HeaderText = "Codigo";
            this.Column_cod.MinimumWidth = 6;
            this.Column_cod.Name = "Column_cod";
            this.Column_cod.ReadOnly = true;
            this.Column_cod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_cod.Width = 125;
            // 
            // button_registrarProducto
            // 
            this.button_registrarProducto.BackColor = System.Drawing.Color.Teal;
            this.button_registrarProducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_registrarProducto.FlatAppearance.BorderSize = 0;
            this.button_registrarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_registrarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_registrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registrarProducto.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registrarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_registrarProducto.Location = new System.Drawing.Point(32, 39);
            this.button_registrarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.button_registrarProducto.Name = "button_registrarProducto";
            this.button_registrarProducto.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button_registrarProducto.Size = new System.Drawing.Size(265, 52);
            this.button_registrarProducto.TabIndex = 16;
            this.button_registrarProducto.Text = "Agregar Inventario";
            this.button_registrarProducto.UseVisualStyleBackColor = false;
            this.button_registrarProducto.Click += new System.EventHandler(this.button_registrarProducto_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.button_modificarCatP_eliminar);
            this.panel6.Controls.Add(this.button_modificarCatP_actualizar);
            this.panel6.Controls.Add(this.button_modificarCatP_crear);
            this.panel6.Controls.Add(this.label_modificarCatP_precioU);
            this.panel6.Controls.Add(this.label_modificarCatP_peso);
            this.panel6.Controls.Add(this.label_modificarCatP_desc);
            this.panel6.Controls.Add(this.textBox_modificarCatP_precioU);
            this.panel6.Controls.Add(this.textBox_modificarCatP_peso);
            this.panel6.Controls.Add(this.textBox_modificarCatP_desc);
            this.panel6.Controls.Add(this.textBox_modificarCatP_codigo);
            this.panel6.Controls.Add(this.label_modificarCatP_codigo);
            this.panel6.Location = new System.Drawing.Point(1481, 111);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 939);
            this.panel6.TabIndex = 17;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label_modificarCatP_codigo
            // 
            this.label_modificarCatP_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modificarCatP_codigo.Location = new System.Drawing.Point(89, 104);
            this.label_modificarCatP_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modificarCatP_codigo.Name = "label_modificarCatP_codigo";
            this.label_modificarCatP_codigo.Size = new System.Drawing.Size(218, 42);
            this.label_modificarCatP_codigo.TabIndex = 0;
            this.label_modificarCatP_codigo.Text = "Codigo";
            this.label_modificarCatP_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_modificarCatP_codigo
            // 
            this.textBox_modificarCatP_codigo.Location = new System.Drawing.Point(40, 150);
            this.textBox_modificarCatP_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_modificarCatP_codigo.Multiline = true;
            this.textBox_modificarCatP_codigo.Name = "textBox_modificarCatP_codigo";
            this.textBox_modificarCatP_codigo.Size = new System.Drawing.Size(313, 58);
            this.textBox_modificarCatP_codigo.TabIndex = 1;
            // 
            // textBox_modificarCatP_desc
            // 
            this.textBox_modificarCatP_desc.Location = new System.Drawing.Point(40, 262);
            this.textBox_modificarCatP_desc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_modificarCatP_desc.Multiline = true;
            this.textBox_modificarCatP_desc.Name = "textBox_modificarCatP_desc";
            this.textBox_modificarCatP_desc.Size = new System.Drawing.Size(313, 58);
            this.textBox_modificarCatP_desc.TabIndex = 2;
            // 
            // textBox_modificarCatP_peso
            // 
            this.textBox_modificarCatP_peso.Location = new System.Drawing.Point(40, 375);
            this.textBox_modificarCatP_peso.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_modificarCatP_peso.Multiline = true;
            this.textBox_modificarCatP_peso.Name = "textBox_modificarCatP_peso";
            this.textBox_modificarCatP_peso.Size = new System.Drawing.Size(313, 58);
            this.textBox_modificarCatP_peso.TabIndex = 3;
            // 
            // textBox_modificarCatP_precioU
            // 
            this.textBox_modificarCatP_precioU.Location = new System.Drawing.Point(40, 488);
            this.textBox_modificarCatP_precioU.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_modificarCatP_precioU.Multiline = true;
            this.textBox_modificarCatP_precioU.Name = "textBox_modificarCatP_precioU";
            this.textBox_modificarCatP_precioU.Size = new System.Drawing.Size(313, 58);
            this.textBox_modificarCatP_precioU.TabIndex = 4;
            // 
            // label_modificarCatP_desc
            // 
            this.label_modificarCatP_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modificarCatP_desc.Location = new System.Drawing.Point(95, 214);
            this.label_modificarCatP_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modificarCatP_desc.Name = "label_modificarCatP_desc";
            this.label_modificarCatP_desc.Size = new System.Drawing.Size(211, 45);
            this.label_modificarCatP_desc.TabIndex = 6;
            this.label_modificarCatP_desc.Text = "Descripcion";
            this.label_modificarCatP_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_modificarCatP_peso
            // 
            this.label_modificarCatP_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modificarCatP_peso.Location = new System.Drawing.Point(89, 325);
            this.label_modificarCatP_peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modificarCatP_peso.Name = "label_modificarCatP_peso";
            this.label_modificarCatP_peso.Size = new System.Drawing.Size(218, 45);
            this.label_modificarCatP_peso.TabIndex = 7;
            this.label_modificarCatP_peso.Text = "Peso (KG)";
            this.label_modificarCatP_peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_modificarCatP_precioU
            // 
            this.label_modificarCatP_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modificarCatP_precioU.Location = new System.Drawing.Point(89, 439);
            this.label_modificarCatP_precioU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modificarCatP_precioU.Name = "label_modificarCatP_precioU";
            this.label_modificarCatP_precioU.Size = new System.Drawing.Size(218, 45);
            this.label_modificarCatP_precioU.TabIndex = 8;
            this.label_modificarCatP_precioU.Text = "Precio Unit.";
            this.label_modificarCatP_precioU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_modificarCatP_crear
            // 
            this.button_modificarCatP_crear.BackColor = System.Drawing.Color.Teal;
            this.button_modificarCatP_crear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_modificarCatP_crear.FlatAppearance.BorderSize = 0;
            this.button_modificarCatP_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_modificarCatP_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_modificarCatP_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificarCatP_crear.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificarCatP_crear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_modificarCatP_crear.Location = new System.Drawing.Point(66, 590);
            this.button_modificarCatP_crear.Margin = new System.Windows.Forms.Padding(4);
            this.button_modificarCatP_crear.Name = "button_modificarCatP_crear";
            this.button_modificarCatP_crear.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button_modificarCatP_crear.Size = new System.Drawing.Size(265, 52);
            this.button_modificarCatP_crear.TabIndex = 18;
            this.button_modificarCatP_crear.Text = "Crear Producto";
            this.button_modificarCatP_crear.UseVisualStyleBackColor = false;
            // 
            // button_modificarCatP_actualizar
            // 
            this.button_modificarCatP_actualizar.BackColor = System.Drawing.Color.Teal;
            this.button_modificarCatP_actualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_modificarCatP_actualizar.FlatAppearance.BorderSize = 0;
            this.button_modificarCatP_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_modificarCatP_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_modificarCatP_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificarCatP_actualizar.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificarCatP_actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_modificarCatP_actualizar.Location = new System.Drawing.Point(66, 690);
            this.button_modificarCatP_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.button_modificarCatP_actualizar.Name = "button_modificarCatP_actualizar";
            this.button_modificarCatP_actualizar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button_modificarCatP_actualizar.Size = new System.Drawing.Size(265, 52);
            this.button_modificarCatP_actualizar.TabIndex = 19;
            this.button_modificarCatP_actualizar.Text = "Actualizar Producto";
            this.button_modificarCatP_actualizar.UseVisualStyleBackColor = false;
            this.button_modificarCatP_actualizar.Click += new System.EventHandler(this.button_modificarCatP_actualizar_Click);
            // 
            // button_modificarCatP_eliminar
            // 
            this.button_modificarCatP_eliminar.BackColor = System.Drawing.Color.Teal;
            this.button_modificarCatP_eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_modificarCatP_eliminar.FlatAppearance.BorderSize = 0;
            this.button_modificarCatP_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_modificarCatP_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_modificarCatP_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificarCatP_eliminar.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificarCatP_eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_modificarCatP_eliminar.Location = new System.Drawing.Point(66, 790);
            this.button_modificarCatP_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.button_modificarCatP_eliminar.Name = "button_modificarCatP_eliminar";
            this.button_modificarCatP_eliminar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button_modificarCatP_eliminar.Size = new System.Drawing.Size(265, 52);
            this.button_modificarCatP_eliminar.TabIndex = 20;
            this.button_modificarCatP_eliminar.Text = "Eliminar Producto";
            this.button_modificarCatP_eliminar.UseVisualStyleBackColor = false;
            // 
            // panel_modificarCat
            // 
            this.panel_modificarCat.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_modificarCat.Controls.Add(this.label_modificarCat);
            this.panel_modificarCat.Location = new System.Drawing.Point(1481, 111);
            this.panel_modificarCat.Margin = new System.Windows.Forms.Padding(4);
            this.panel_modificarCat.Name = "panel_modificarCat";
            this.panel_modificarCat.Size = new System.Drawing.Size(390, 65);
            this.panel_modificarCat.TabIndex = 4;
            // 
            // label_modificarCat
            // 
            this.label_modificarCat.BackColor = System.Drawing.Color.Transparent;
            this.label_modificarCat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modificarCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_modificarCat.Location = new System.Drawing.Point(32, 0);
            this.label_modificarCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modificarCat.Name = "label_modificarCat";
            this.label_modificarCat.Size = new System.Drawing.Size(321, 61);
            this.label_modificarCat.TabIndex = 3;
            this.label_modificarCat.Text = "Modificar catalogo";
            this.label_modificarCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_login
            // 
            this.tabPage_login.Controls.Add(this.dataGridView);
            this.tabPage_login.Location = new System.Drawing.Point(4, 28);
            this.tabPage_login.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_login.Name = "tabPage_login";
            this.tabPage_login.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_login.Size = new System.Drawing.Size(1881, 1148);
            this.tabPage_login.TabIndex = 0;
            this.tabPage_login.Text = "login";
            this.tabPage_login.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 55;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_user,
            this.Column_hora});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(271, 71);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.Height = 55;
            this.dataGridView.Size = new System.Drawing.Size(1301, 856);
            this.dataGridView.TabIndex = 0;
            // 
            // Column_hora
            // 
            this.Column_hora.HeaderText = "HORA DE INGRESO";
            this.Column_hora.MinimumWidth = 6;
            this.Column_hora.Name = "Column_hora";
            this.Column_hora.ReadOnly = true;
            this.Column_hora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_hora.Width = 500;
            // 
            // Column_user
            // 
            this.Column_user.HeaderText = "USUARIO";
            this.Column_user.MinimumWidth = 6;
            this.Column_user.Name = "Column_user";
            this.Column_user.ReadOnly = true;
            this.Column_user.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_user.Width = 500;
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.AccessibleDescription = "";
            this.tabcontrol1.AccessibleName = "";
            this.tabcontrol1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabcontrol1.Controls.Add(this.tabPage_login);
            this.tabcontrol1.Controls.Add(this.tabPage_productos);
            this.tabcontrol1.Controls.Add(this.tabPage_inventario);
            this.tabcontrol1.Controls.Add(this.tabPage1_Clientes);
            this.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol1.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol1.Margin = new System.Windows.Forms.Padding(4);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1889, 1180);
            this.tabcontrol1.TabIndex = 22;
            // 
            // tabPage1_Clientes
            // 
            this.tabPage1_Clientes.Controls.Add(this.button1);
            this.tabPage1_Clientes.Controls.Add(this.dataGridView_clientes);
            this.tabPage1_Clientes.Controls.Add(this.panel_clientes_tabla);
            this.tabPage1_Clientes.Controls.Add(this.panel9);
            this.tabPage1_Clientes.Location = new System.Drawing.Point(4, 28);
            this.tabPage1_Clientes.Name = "tabPage1_Clientes";
            this.tabPage1_Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_Clientes.Size = new System.Drawing.Size(1881, 1148);
            this.tabPage1_Clientes.TabIndex = 3;
            this.tabPage1_Clientes.Text = "Clientes";
            this.tabPage1_Clientes.UseVisualStyleBackColor = true;
            // 
            // dataGridView_clientes
            // 
            this.dataGridView_clientes.AllowUserToAddRows = false;
            this.dataGridView_clientes.AllowUserToDeleteRows = false;
            this.dataGridView_clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_clientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_clientes.ColumnHeadersHeight = 45;
            this.dataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.Column1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_clientes.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_clientes.Location = new System.Drawing.Point(59, 282);
            this.dataGridView_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_clientes.MultiSelect = false;
            this.dataGridView_clientes.Name = "dataGridView_clientes";
            this.dataGridView_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_clientes.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_clientes.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_clientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_clientes.RowTemplate.Height = 50;
            this.dataGridView_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_clientes.Size = new System.Drawing.Size(1372, 742);
            this.dataGridView_clientes.TabIndex = 6;
            this.dataGridView_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel_clientes_tabla
            // 
            this.panel_clientes_tabla.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_clientes_tabla.Controls.Add(this.label_listaclientes);
            this.panel_clientes_tabla.Location = new System.Drawing.Point(33, 118);
            this.panel_clientes_tabla.Margin = new System.Windows.Forms.Padding(4);
            this.panel_clientes_tabla.Name = "panel_clientes_tabla";
            this.panel_clientes_tabla.Size = new System.Drawing.Size(1421, 65);
            this.panel_clientes_tabla.TabIndex = 7;
            this.panel_clientes_tabla.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label_listaclientes
            // 
            this.label_listaclientes.BackColor = System.Drawing.Color.Transparent;
            this.label_listaclientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaclientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_listaclientes.Location = new System.Drawing.Point(4, -2);
            this.label_listaclientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_listaclientes.Name = "label_listaclientes";
            this.label_listaclientes.Size = new System.Drawing.Size(321, 61);
            this.label_listaclientes.TabIndex = 3;
            this.label_listaclientes.Text = "Clientes";
            this.label_listaclientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_listaclientes.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.comboBox1);
            this.panel9.Controls.Add(this.label_elementosCliente);
            this.panel9.Controls.Add(this.textBox2);
            this.panel9.Controls.Add(this.label_buscarCliente);
            this.panel9.Location = new System.Drawing.Point(33, 118);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1421, 939);
            this.panel9.TabIndex = 8;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(151, 104);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "10";
            // 
            // label_elementosCliente
            // 
            this.label_elementosCliente.BackColor = System.Drawing.Color.Transparent;
            this.label_elementosCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_elementosCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_elementosCliente.Location = new System.Drawing.Point(18, 84);
            this.label_elementosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_elementosCliente.Name = "label_elementosCliente";
            this.label_elementosCliente.Size = new System.Drawing.Size(389, 55);
            this.label_elementosCliente.TabIndex = 6;
            this.label_elementosCliente.Text = "Mostrar            elementos";
            this.label_elementosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1161, 99);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 34);
            this.textBox2.TabIndex = 5;
            // 
            // label_buscarCliente
            // 
            this.label_buscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_buscarCliente.Location = new System.Drawing.Point(1035, 89);
            this.label_buscarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_buscarCliente.Name = "label_buscarCliente";
            this.label_buscarCliente.Size = new System.Drawing.Size(138, 50);
            this.label_buscarCliente.TabIndex = 4;
            this.label_buscarCliente.Text = "Buscar:";
            this.label_buscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Rut";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 140;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 140;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Calle";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Region";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Comuna";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(33, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(265, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_registrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel_contenido_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage_inventario.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel_inventario_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inventario)).EndInit();
            this.tabPage_productos.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_productoTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel_modificarCat.ResumeLayout(false);
            this.tabPage_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabcontrol1.ResumeLayout(false);
            this.tabPage1_Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).EndInit();
            this.panel_clientes_tabla.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox_salir;
        private PictureBox pictureBox_conta;
        private PictureBox pictureBox_historial;
        private PictureBox pictureBox_registrar;
        private PictureBox pictureBox_cliente;
        private PictureBox pictureBox_producto;
        private Button button_salir;
        private Button button_conta;
        private Button button_registrar;
        private Button button_historial;
        private PictureBox pictureBox_logo;
        private Button button_clientes;
        private Button button_productos;
        private Panel panel3;
        private Label label_title;
        private Panel panel1;
        private PictureBox pictureBox_title;
        private Panel panel_contenido_user;
        private Panel panel5;
        private Button button_Pver;
        private Button button_Pconsultar;
        private Button button_CverClientes;
        private TabControl tabcontrol1;
        private TabPage tabPage_login;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column_user;
        private DataGridViewTextBoxColumn Column_hora;
        private TabPage tabPage_productos;
        private Panel panel_modificarCat;
        private Label label_modificarCat;
        private Panel panel6;
        private Button button_modificarCatP_eliminar;
        private Button button_modificarCatP_actualizar;
        private Button button_modificarCatP_crear;
        private Label label_modificarCatP_precioU;
        private Label label_modificarCatP_peso;
        private Label label_modificarCatP_desc;
        private TextBox textBox_modificarCatP_precioU;
        private TextBox textBox_modificarCatP_peso;
        private TextBox textBox_modificarCatP_desc;
        private TextBox textBox_modificarCatP_codigo;
        private Label label_modificarCatP_codigo;
        private Button button_registrarProducto;
        private DataGridView dataGridView_productos;
        private DataGridViewTextBoxColumn Column_cod;
        private DataGridViewTextBoxColumn Column_desc;
        private DataGridViewTextBoxColumn Column_Peso;
        private DataGridViewTextBoxColumn Column_stockA;
        private DataGridViewTextBoxColumn Column_pUnitario;
        private DataGridViewTextBoxColumn Column_precioTotal;
        private Panel panel_productoTable;
        private Label label_listaProductos;
        private Panel panel4;
        private ComboBox comboBox_mostrar;
        private Label label_elementosProductos;
        private TextBox textBox_productos_buscar;
        private Label label_buscar;
        private TabPage tabPage_inventario;
        private DataGridView dataGridView_inventario;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Panel panel_inventario_tabla;
        private Label label_listaInventario;
        private Panel panel8;
        private ComboBox comboBox_mostrarI;
        private Label label_elementosInventario;
        private TextBox textBox1;
        private Label label_buscarI;
        private TabPage tabPage1_Clientes;
        private DataGridView dataGridView_clientes;
        private Panel panel_clientes_tabla;
        private Label label_listaclientes;
        private Panel panel9;
        private ComboBox comboBox1;
        private Label label_elementosCliente;
        private TextBox textBox2;
        private Label label_buscarCliente;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn Column1;
    }
}

