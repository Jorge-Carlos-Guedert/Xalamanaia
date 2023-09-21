using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;

namespace Xalamanaia_Pizzaria
{
    public partial class FrmCadastraBebidaProvisorio : Form
    {
        Conexao con = new Conexao();
        ProdutoController prodController = new ProdutoController();
        ProdutoModelo prodModelo = new ProdutoModelo();
        public FrmCadastraBebidaProvisorio()
        {
            InitializeComponent();
            dtBebida.DataSource = con.ObterDados("select bebida.idBebida, bebida.descricaoBebida, bebida.volumeBebida, bebida.valorBebida from bebida");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                prodModelo.descBebida = textBoxDesc.Text;
                prodModelo.volumeBebida = textBoxVolume.Text;
                prodModelo.valorBebida = Convert.ToDecimal(textBoxPreco.Text);
                if(prodController.cadastraBebida(prodModelo, 1) == true)
                {
                    MessageBox.Show("Item cadastrado com sucesso");
                    dtBebida.DataSource = con.ObterDados("select bebida.idBebida, bebida.descricaoBebida, bebida.volumeBebida, bebida.valorBebida from bebida");

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar item");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencher todos os campos");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            prodModelo.descBebida = textBoxDesc.Text;
            prodModelo.volumeBebida = textBoxVolume.Text;
            prodModelo.valorBebida = Convert.ToDecimal(textBoxPreco.Text);
            if(prodController.cadastraBebida(prodModelo, 2) == true)
            {
                MessageBox.Show("Item atualizado com sucesso");
                dtBebida.DataSource = con.ObterDados("select bebida.idBebida, bebida.descricaoBebida, bebida.volumeBebida, bebida.valorBebida from bebida");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar item");
            }
        }

        private void dtBebida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodModelo.idBebida = Convert.ToInt32(dtBebida.Rows[e.RowIndex].Cells[0].Value);
            textBoxCodigo.Text = prodModelo.idBebida.ToString();
            textBoxDesc.Text = dtBebida.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxVolume.Text = dtBebida.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxPreco.Text = dtBebida.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(prodModelo.idBebida.ToString()))
                {
                    MessageBox.Show("Código está vazio");
                    textBoxCodigo.Focus();
                }
                if(prodModelo.idBebida > 0)
                {
                    if(prodController.cadastraBebida(prodModelo, 3) == true)
                    {
                        MessageBox.Show("Item excluído com sucesso");
                        dtBebida.DataSource = con.ObterDados("select bebida.idBebida, bebida.descricaoBebida, bebida.volumeBebida, bebida.valorBebida from bebida");

                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um item");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor selecionar um item");
            }
        }
    }
}
