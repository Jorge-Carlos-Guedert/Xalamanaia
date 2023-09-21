

using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Models
{
    public class ClienteModelo
    {
        // atributos aplicados no Banco de Dados Table Pessoa
        private int Id_Cliente;
        private string Telefone;
        private string Nome;
        private string Email;
        private string Cep;
        private string Logradouro;
        private string Numero;
        private string Complemento;
        private string Bairro;
        private string Localidade;
        private string Uf;

       

        // construtor da classe UsuariosModelo

        public ClienteModelo()
        {
            
            Telefone = telefone;
            Nome = nome;
            Email = email;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Localidade = localidade;
            Uf = uf;
                       
        }

        public int codigo { get; set; }
        public string telefone { get; set; }

        public string nome { get; set; }
        public string email { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }




    }


}