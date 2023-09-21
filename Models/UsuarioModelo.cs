using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UsuarioModelo
    {
        private int Id_Usuario;
        private string Email;
        private string Senha;
        private string Perfil;


        public UsuarioModelo()
        {
            
        }

        public int id_Usuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public string perfil { get; set; }

    }

   
}
