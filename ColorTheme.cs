using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SistemaInventarioMAREF
{
    public static class ColorTheme
    {
        public static Color color1;
        public static Color color2;
        public static Color color3;
        public static Color color4;
        public static Color color5;

        //POR DEFECTO LOS COLORES.
        /*
        private static readonly Color color1D = Color.FromArgb(180, 53, 66);
        private static readonly Color color2D = Color.FromArgb(218, 53, 88);
        private static readonly Color color3D = Color.FromArgb(199, 53, 88);
        private static readonly Color color4D = Color.FromArgb(234, 60, 88);
        private static readonly Color color5D = Color.FromArgb(199, 20, 88);
        */

        private static readonly Color color1D = Color.FromArgb(13, 139, 217);
        private static readonly Color color2D = Color.FromArgb(14, 154, 241);
        private static readonly Color color3D = Color.FromArgb(250, 245, 240);
        private static readonly Color color4D = Color.FromArgb(62, 174, 244);
        private static readonly Color color5D = Color.FromArgb(171, 196, 255);

        #region -> Metodos
        public static void ElegirTema(int tema)
        { 
            //PORDEFECTO.
            if (tema == 0)
            {
                color1 = color1D;
                color2 = color2D;
                color3 = color3D;
                color4 = color4D;
                color5 = color5D;
            }
        }
        #endregion
    }
}