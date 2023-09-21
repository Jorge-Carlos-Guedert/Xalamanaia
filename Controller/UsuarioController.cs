using System;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace Controllers
{
    public class UsuarioController
    {
        // variaveis
        string sql;
        bool resultado = false;


        // instanciando
        // usuarioController = new UsuarioController();
        Conexao conexao = new Conexao();
        public int logar(UsuarioModelo usuarioModelo)
        {

            int registro; // retorna o numero de registros

            string sql = "SELECT idUsuario from usuario  where emailusuario=@email and senhaUsuario=@senha";
            MySqlConnection sqlCon = conexao.getConexao();
            sqlCon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlCon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@email", usuarioModelo.email);
            command.Parameters.AddWithValue("@senha", usuarioModelo.senha); //getMD5Hash(usModelo.senha));
            registro = Convert.ToInt32(command.ExecuteScalar()); // retorna quantidade de registros encontrados

            return registro; // devolvo o idusuario encontrado no banco
        }


        public string getMD5Hash(string senha) // Criptografia de senha no Banco de Daados
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(senha);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }


        public bool cadastrarUsuario(UsuarioModelo usuarioModelo, int operacao)
        {


            try
            {
                switch (operacao)
                {
                    case 1:
                        sql = "INSERT INTO usuarios (email, senha, perfil) values (@email,@senha,@perfil)";
                        break;


                    case 2:
                        sql = "UPDATE usuarios SET email=@email, senha=@senha, perfil=@perfil WHERE idUsuarios=@idUsuarios";
                        break;


                    case 3:
                        sql = "DELETE from usuarios WHERE idUsuario=@idUsuario ";
                        break;



                }

                string[] campos =
                {
                    "@email",
                    "@senha",
                    "@perfil"
                };

                object[] valores =
                {
                    usuarioModelo.email,
                    usuarioModelo.senha,
                    usuarioModelo.perfil
                };

                if (conexao.cadastrar(usuarioModelo.id_Usuario, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
