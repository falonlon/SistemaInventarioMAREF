using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;   // Para PrivateFontCollection
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioMAREF
{
    public partial class FormAgregar : Form
    {
        FormAgregar formAgregar;
        public FormAgregar()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // DIBUJAR UN BORDE AL PANEL
            using (Pen borderPen = new Pen(ColorTheme.color2, 2)) // COLOR Y GROSOR DEL BORDE
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, ((Panel)sender).Width - 1, ((Panel)sender).Height - 1);
            }
            //.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
