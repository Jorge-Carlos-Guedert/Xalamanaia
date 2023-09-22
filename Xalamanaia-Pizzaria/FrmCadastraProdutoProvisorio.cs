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
using System.Diagnostics;
using System.Linq.Expressions;

namespace Xalamanaia_Pizzaria
{

    public partial class FrmCadastraProdutoProvisorio : Form
    {
        Conexao con = new Conexao();
        ProdutoController prodController = new ProdutoController();
        ProdutoModelo prodModelo = new ProdutoModelo();
        public FrmCadastraProdutoProvisorio()
        {
            InitializeComponent();
        }

        private void FrmCadastraProdutoProvisorio_Load(object sender, EventArgs e)
        {
            ProdutoController prodController = new ProdutoController();
            dtPizza.DataSource = con.ObterDados("SELECT sabores.idsabores, sabores.descricaosabor, sabores.valorBroto, sabores.valorMedia, sabores.valorGrande, sabores.valorGigante from sabores");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                prodModelo.descricaosabor = textBoxDesc.Text;
                prodModelo.valorBroto = Convert.ToDecimal(textBoxBroto.Text);
                prodModelo.valorMedia = Convert.ToDecimal(textBoxMedia.Text);
                prodModelo.valorGrande = Convert.ToDecimal(textBoxGrande.Text);
                prodModelo.valorGigante = Convert.ToDecimal(textBoxGigante.Text);

                if (prodController.cadastrarPizza(prodModelo, 1) == true)
                {
                    MessageBox.Show("Item cadastrado com sucesso!");
                    dtPizza.DataSource = con.ObterDados("select sabores.idsabores, sabores.descricaosabor, sabores.valorBroto, sabores.valorMedia, sabores.valorGrande, sabores.valorGigante from sabores");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar item");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
        }

        private void textBoxBroto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != (char)44;
        }

        private void textBoxMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != (char)44;
        }

        private void textBoxGrande_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != (char)44;
        }

        private void textBoxGigante_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != (char)44;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            prodModelo.descricaosabor = textBoxDesc.Text;
            prodModelo.valorBroto = Convert.ToDecimal(textBoxBroto.Text);
            prodModelo.valorMedia = Convert.ToDecimal(textBoxMedia.Text);
            prodModelo.valorGrande = Convert.ToDecimal(textBoxGrande.Text);
            prodModelo.valorGigante = Convert.ToDecimal(textBoxGigante.Text);
            if (prodController.cadastrarPizza(prodModelo, 2) == true)
            {
                MessageBox.Show("Item atualizado com sucesso");
                dtPizza.DataSource = con.ObterDados("select sabores.idsabores, sabores.descricaosabor, sabores.valorBroto, sabores.valorMedia, sabores.valorGrande, sabores.valorGigante from sabores");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar item");
            }
        }

        private void dtPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            prodModelo.idsabores = Convert.ToInt32(dtPizza.Rows[e.RowIndex].Cells[0].Value);
            textBoxCodigo.Text = prodModelo.idsabores.ToString();
            textBoxDesc.Text = dtPizza.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxBroto.Text = dtPizza.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxMedia.Text = dtPizza.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxGrande.Text = dtPizza.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxGigante.Text = dtPizza.Rows[e.RowIndex].Cells[5].Value.ToString();

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(prodModelo.idsabores.ToString()))
                {
                    MessageBox.Show("Código está vazio");
                    textBoxCodigo.Focus();
                }
                if (prodModelo.idsabores > 0)
                {
                    if (prodController.cadastrarPizza(prodModelo, 3) == true)
                    {
                        MessageBox.Show("Item excluido com sucesso");
                        dtPizza.DataSource = con.ObterDados("select sabores.idsabores, sabores.descricaosabor, sabores.valorBroto, sabores.valorMedia, sabores.valorGrande, sabores.valorGigante from sabores");

                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir item");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            prodModelo.descricaosabor = textBoxDesc.Text;
            prodModelo.valorBroto = Convert.ToDecimal(textBoxBroto.Text);
            prodModelo.valorMedia = Convert.ToDecimal(textBoxMedia.Text);
            prodModelo.valorGrande = Convert.ToDecimal(textBoxGrande.Text);
            prodModelo.valorGigante = Convert.ToDecimal(textBoxGigante.Text);
            int verifica = prodController.VericarProduto(textBoxDesc.Text);

            if (!string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                if (prodController.cadastrarPizza(prodModelo, 2) == true)
                {
                    MessageBox.Show("Item atualizado com sucesso");
                    dtPizza.DataSource = con.ObterDados("select sabores.idsabores, sabores.descricaosabor, sabores.valorBroto, sabores.valorMedia, sabores.valorGrande, sabores.valorGigante from sabores");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar item");
                }
            }
            else
            {
                if (prodController.cadastrarPizza(prodModelo, 1) == true && verifica < 0)
                {
                    MessageBox.Show("Item cadastrado com sucesso!");
                    dtPizza.DataSource = con.ObterDados("select sabores.idsabores, sabores.descricaosabor, sabores.valorBroto, sabores.valorMedia, sabores.valorGrande, sabores.valorGigante from sabores");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar item");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxBroto.Text = "";
            textBoxCodigo
        }
    }
}
