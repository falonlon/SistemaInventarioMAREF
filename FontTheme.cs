using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioMAREF
{
    public class FontTheme
    {
        public string fontPath = string.Empty;
        public PrivateFontCollection pfc;

        public FontTheme()
        {
            pfc = new PrivateFontCollection();
        }

        public FontTheme(string fontPath)
        {
            // Ruta al archivo de la fuente .otf
            this.fontPath = fontPath;
            //string fontPath = Application.StartupPath + @"\resources\fonts\coolvetica.otf";

            // Crear un objeto PrivateFontCollection
            pfc = new PrivateFontCollection();
        }
    }
}
