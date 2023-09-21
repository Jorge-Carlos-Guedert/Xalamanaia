using Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace Controllers
{
    public class ClienteController
    {
        string sql;//estrutura sql
        bool resultado = false;//verifico o resultado
        Conexao con = new Conexao();//chamo o método conexão;
        ClienteModelo clienteM = new ClienteModelo();

        public bool cadastrarCliente(ClienteModelo clienteModelo, int operacao)
        {

            try
            {
                switch (operacao)
                {
                    //inserir dados
                    case 1:
                        sql = "insert into cliente (telCliente, nomeCliente, emailCliente, cepCliente, logCliente, numCliente, compCliente, bairroCliente, localidadeCliente, ufCliente)" + "values(@telCliente , @nomeCliente, @emailCliente, @cepCliente, @logCliente, @numCliente, @compCliente, @bairroCliente, @localidadeCliente, @ufCliente)";
                        break;
                    //atualizar dados
                    case 2:
                        sql = "update cliente set  telCliente=@telCliente , nomeCliente=@nomeCliente, emailCliente=@emailCliente, cepCliente=@cepCliente, logCliente=@logCliente, numCliente=@numCliente, compCliente=@compCliente, bairroCliente=@bairroCliente, localidadeCliente=@localidadeCliente, ufCliente=@ufCliente where idCliente=@id";
                        break;
                    case 3:
                        sql = "delete from cliente where idCliente=@id";
                        break;
                    default:
                        break;

                }
                string[] campos = {"@telCliente","@nomeCliente","@emailCliente",
                    "@cepCliente",
                        "@logCliente" ,
                        "@numCliente",
                        "@compCliente",
                        "@bairroCliente",
                        "@localidadeCliente",
                        "@ufCliente" };


                object[] valores = {

                    clienteModelo.telefone,
                    clienteModelo.nome,
                    clienteModelo.email,
                    clienteModelo.cep,
                    clienteModelo.logradouro,
                    clienteModelo.numero,
                    clienteModelo.complemento,
                    clienteModelo.bairro,
                    clienteModelo.localidade,
                    clienteModelo.uf
               };

                if (con.cadastrar(clienteModelo.codigo, campos, valores, sql) >= 1)
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
        public int VericarTelefone(string fone)
        {


            int registro;
            string sql = "SELECT count(*) FROM cliente where telCliente=@fone";
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlCon);
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@fone", fone);

            registro = Convert.ToInt32(command.ExecuteScalar());

            return registro;
        }       

    }
}
