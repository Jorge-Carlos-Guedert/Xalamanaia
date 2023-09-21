using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;//importei o objeto Modelo
using Org.BouncyCastle.Math.EC;

namespace Controllers
{
   public class ProdutoController
    {
        string sql;//estrutura sql
        bool resultado = false;//verifico o resultado
        Conexao con = new Conexao();//chamo o método conexão;
        public bool cadastrarPizza(ProdutoModelo prod, int operacao)
        {
            try
            {
                switch (operacao)
                {
                    //inserir dados
                    case 1:
                        sql = "insert into sabores(descricaosabor, valorBroto, valorMedia, valorGrande, valorGigante)" 
                            + "values(@descricaosabor, @valorBroto, @valorMedia, @valorGrande, @valorGigante)";
                        break;
                        //atualizar dados
                    case 2:
                        sql = "update sabores set descricaosabor=@descricaosabor, valorBroto=@valorBroto, valorMedia=@valorMedia, valorGrande=@valorGrande, valorGigante=@valorGigante where idsabores=@id";
                        break;
                    case 3:
                        sql = "delete from sabores where idsabores=@id";
                        break;
                    default:
                        break;

                }
                string[] campos = {"@descricaosabor", "@valorBroto", "@valorMedia", "@valorGrande", "@valorGigante" };
                object[] valores = { prod.descricaosabor, prod.valorBroto, prod.valorMedia, prod.valorGrande, prod.valorGigante };

                if(con.cadastrar(prod.codigo, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);           
            }
        }

        public bool cadastraBebida(ProdutoModelo prod, int operacao)
        {
           try
            {
                switch (operacao)
                {
                    //inserir dados
                    case 1:
                        sql = "insert into bebida(descricaoBebida, volumeBebida, valorBebida)" 
                            + "values(@descricaoBebida, @volumeBebida, @valorBebida)";
                        break;
                    //atualizar dados
                    case 2:
                        sql = "update bebida set descricaoBebida=@descricaoBebida, volumeBebida=@volumeBebida, valorBebida=@valorBebida where idBebida=@id";
                        break;
                    case 3:
                        sql = "delete from bebida where idBebida=@id";
                        break;
                    default:
                        break;

                }
                string[] campos = { "@descricaoBebida", "@volumeBebida", "@valorBebida"};
                object[] valores = { prod.descBebida, prod.volumeBebida, prod.valorBebida};

                if (con.cadastrar(prod.idBebida, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
