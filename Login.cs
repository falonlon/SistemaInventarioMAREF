using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioMAREF
{
    public class Login
    {
        public string nameUser {  get; set; }
        public string fechaHora {  get; set; }
        public bool exitoso {  get; set; }

        public Login(string nameUser, string fechaHora, bool exitoso)
        {
            this.nameUser = nameUser;
            this.fechaHora = fechaHora;
            this.exitoso = exitoso;
        }
    }
}
