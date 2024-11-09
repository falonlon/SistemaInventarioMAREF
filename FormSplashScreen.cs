using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioMAREF
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);

            if (progressBar1.Value != 1 && progressBar1.Value % 2 != 0)
            {
                label1_maref.Text += ".";
            }

            if (label1_maref.Text.Length >= 4)
            {
                label1_maref.Text = string.Empty;
            }

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void label1_maref_Click(object sender, EventArgs e)
        {

        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            // Ruta al archivo de la fuente .otf
            string fontPath = Application.StartupPath + @"\resources\fonts\coolvetica.otf";

            // Crear un objeto PrivateFontCollection
            PrivateFontCollection pfc = new PrivateFontCollection();

            // Agregar la fuente a la colección
            pfc.AddFontFile(@"C:\Users\Victus\source\repos\sistema\SistemaInventarioMAREF\resources\fonts\coolvetica.otf");

            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }

            label1_maref.Font = new Font(pfc.Families[0], label1_maref.Font.Size, FontStyle.Regular);
        }
    }
}
