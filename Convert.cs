using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioMAREF
{
    public static class Convert
    {
        public static string FToString(float value, int decimals, bool isMoney)
        {
            string decim = "#,";
            string decim2= "0.";

            for (int i = 0; i < decimals; i++)
            {
                decim += "#";
                decim2 += "0";
            }

            decim = decim + decim2;

            if (isMoney)
            {
                return "$   " + value.ToString(decim, CultureInfo.InvariantCulture);
            }

            return value.ToString(decim, CultureInfo.InvariantCulture);
        }

        public static string IToString(int value, bool isMoney)
        {
            if (isMoney)
            {
                return "$   " + value.ToString("#,##", CultureInfo.InvariantCulture);
            }

            return value.ToString("#,##", CultureInfo.InvariantCulture);
        }

        public static int StringToInt(string value)
        {
            int num = 0;

            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    num = num * 10 + (c - '0');
                }
            }

            return num;
        }

        public static float StringToFloat(string valor)
        {
            //valor = valor.Replace(',', '.');

            float resultado;
            if (float.TryParse(valor, NumberStyles.Any, new CultureInfo("es-ES"), out resultado))
            {
                return resultado;
            }
            else
            {
                throw new FormatException("El formato de la cadena no es correcto.");
            }
        }

        public static int Square(int num, int e)
        {
            if (e == 0)
            {
                return 1;
            }

            int value = 1;

            for (int i = 0; i < e; i++)
            {
                value *= num;
            }

            return value;
        }

        public static Image ResizeImage(Image image, int width, int height)
        {
            Bitmap newImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return newImage;
        }

        internal static int ToInt32(object result)
        {
            throw new NotImplementedException();
        }
    }
}
