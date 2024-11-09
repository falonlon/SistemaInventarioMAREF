using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioMAREF
{
    public class Fardo
    {
        public string codigo {  get; set; }
        public string desc {  get; set; }
        public float peso { get; set; }
        public int stock { get; set; }
        public float precioUnitario { get; set; }

        public Fardo()
        {
            codigo = "";
            desc = "";
            peso = 0.0f;
            stock = 0;
            precioUnitario = 0.0f;
        }

        public Fardo(string codigo, string desc, float peso, int stock, float precioUnitario)
        {
            this.codigo = codigo;
            this.desc = desc;
            this.peso = peso;
            this.stock = stock;
            this.precioUnitario = precioUnitario;
        }
    }
}
