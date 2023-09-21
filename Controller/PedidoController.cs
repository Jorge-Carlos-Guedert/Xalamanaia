using Controllers;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Models.ProdutoModelo;

namespace Controllers
{

    public class PedidoController
    {
        string sql;
        Conexao conexao = new Conexao();


        public List<PizzaModelo> ObterPizzas()
        {
            List<PizzaModelo> pizzas = new List<PizzaModelo>();

            try
            {
                MySqlConnection connection = conexao.getConexao();
                sql = "SELECT * FROM pizza order by idtamanho";

                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PizzaModelo pizza = new PizzaModelo
                    {
                        IdTamanho = Convert.ToInt32(reader["idtamanho"]),
                        Tamanho = reader["tamanho"].ToString(),
                        QtdSabores = Convert.ToInt32(reader["qtdsabores"])
                    };

                    pizzas.Add(pizza);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception exTop)
            {


                MessageBox.Show("Não foi possível obter Tamanhos do Banco de Dados", exTop.ToString());


            }
            return pizzas;
        }
        public List<SaboresModelo> ObterSabores()
        {
            List<SaboresModelo> sabores = new List<SaboresModelo>();

            try
            {
                MySqlConnection connection = conexao.getConexao();
                sql = "SELECT * FROM sabores order by descricaosabor";

                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SaboresModelo sabor = new SaboresModelo
                    {
                        IdSabores = Convert.ToInt32(reader["idsabores"]),
                        DescricaoSabor = reader["descricaosabor"].ToString(),
                        ValorBroto = Convert.ToDecimal(reader["valorBroto"]),
                        ValorMedia = Convert.ToDecimal(reader["valorMedia"]),
                        ValorGrande = Convert.ToDecimal(reader["valorGrande"]),
                        ValorGigante = Convert.ToDecimal(reader["valorGigante"])
                    };

                    sabores.Add(sabor);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception exTop)
            {
                MessageBox.Show("Não foi possível obter os Sabores do Banco de Dados", exTop.ToString());
            }
            return sabores;
        }

        public List<AdicionaisModelo> ObterAdicionais()
        {
            List<AdicionaisModelo> adicionais = new List<AdicionaisModelo>();

            try
            {
                MySqlConnection connection = conexao.getConexao();
                sql = "SELECT * FROM adicionais order by descricaoadicionais";

                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    AdicionaisModelo adicional = new AdicionaisModelo
                    {
                        idAdicional = Convert.ToInt32(reader["idadicionais"]),
                        descricao = (reader["descricaoadicionais"].ToString()),
                        valoradicional_broto = Convert.ToDecimal(reader["valoradicionalbroto"].ToString()),
                        valoradicional_media = Convert.ToDecimal(reader["valoradicionalmedia"].ToString()),
                        valoradicional_grande = Convert.ToDecimal(reader["valoradicionalgrande"].ToString()),
                        valoradicional_gigante = Convert.ToDecimal(reader["valoradicionalgigante"].ToString())


                    };

                    adicionais.Add(adicional);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception exTop)
            {
                MessageBox.Show("Não foi possível obter os Adicionais do Banco de Dados", exTop.ToString());
            }
            return adicionais;
        }

        public decimal MaiorDValor(decimal valor1,decimal valor2)
        {
            decimal maiorValor = 0;

            
            if (valor1 >= valor2)
            {
                maiorValor = valor1;
                               
            }
            else
            {
                maiorValor = valor2;
                               
            }

            return maiorValor;
        }



        public decimal MaiorTValor(decimal valor1, decimal valor2, decimal valor3)
        {
            decimal maiorValor = 0;


            if (valor1 >= valor2 && valor1 >= valor3)
            {
                maiorValor = valor1; 
                
            }
            else if (valor2 >= valor1 && valor2 >= valor3)
            {
                maiorValor = valor1;
            }
            else
            {
                maiorValor = valor1;

            }

            return maiorValor;
        }
    }
}

// primeira tentativa de Commit












