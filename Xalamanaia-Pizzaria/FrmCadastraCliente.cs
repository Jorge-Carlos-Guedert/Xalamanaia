using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
//using System.Globalization;

namespace Xalamanaia_Pizzaria
{
    public partial class FrmCadastraCliente : Form
    {
        string sql = "";
        int codigo = 0;
        ClienteModelo clienteM = new ClienteModelo();
        ClienteController clienteC = new ClienteController();
        string sqlApelido = "SELECT idCliente as ID," +
                            " nomeCliente as Nome," +
                            " emailCliente as Email," +
                            " telCliente as Telefone," +
                            " cepCliente as CEP," +
                            " logCliente as Logradouro," +
                            " numCliente as Numero," +
                            " compCliente as Complemento," +
                            " bairroCliente as Bairro," +
                            " localidadeCliente as Cidade," +
                            " ufCliente as Estado " +
                            "from cliente";
        Conexao Conexao = new Conexao();
        public FrmCadastraCliente()
        {
            InitializeComponent();
        }

        private void txtCepCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCadastraCliente_Load(object sender, EventArgs e)
        {
            DGVCliente.DataSource = Conexao.ObterDados(sqlApelido);
        }

        private void DGVCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            codigo = Convert.ToInt32(DGVCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            MessageBox.Show("usuario selecionado :" + codigo.ToString());
            txtIdCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtEmailCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            txtTeleCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            txtNomeCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtCepCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
            txtRuaCLiente.Text = DGVCliente.Rows[e.RowIndex].Cells["Logradouro"].Value.ToString();
            txtNumeroCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
            txtCompCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Complemento"].Value.ToString();
            txtBairroCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
            txtCidadeCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
            txtEstadoCliente.Text = DGVCliente.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
        }

        private void btncep_Click(object sender, EventArgs e)
        {
            txtCompCliente.Text = "";
            txtNumeroCliente.Text = "";
            if (!string.IsNullOrWhiteSpace(txtCepCliente.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCepCliente.Text.Trim());


                        txtEstadoCliente.Text = endereco.uf.ToString();
                        txtCidadeCliente.Text = endereco.cidade.ToString();
                        txtBairroCliente.Text = endereco.bairro.ToString();
                        txtRuaCLiente.Text = endereco.end.ToString();
                    }
                    catch (Exception ex)
                    {
                        limpaCep();
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                limpaCep();
                MessageBox.Show("informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCepCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxCep = 8;
            txtCepCliente.MaxLength = maxCep;
            char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
            txtEmailCliente.CharacterCasing = CharacterCasing.Lower;
        }

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Black;
            lblTelefone.ForeColor = Color.Black;
            lblRua.ForeColor = Color.Black;
            lblNumero.ForeColor = Color.Black;
            lblBairro.ForeColor = Color.Black;
            lblestado.ForeColor = Color.Black;
            lblCidade.ForeColor = Color.Black;
            lblAtencaoCliente.ForeColor = Color.Black;
            lblAtencaoCliente.Text = "";


            int verifica;
            clienteM.codigo = codigo;
            clienteM.telefone = txtTeleCliente.Text;
            clienteM.nome = txtNomeCliente.Text;
            clienteM.email = txtEmailCliente.Text;
            clienteM.cep = txtCepCliente.Text;
            clienteM.logradouro = txtRuaCLiente.Text;
            clienteM.numero = txtNumeroCliente.Text;
            clienteM.complemento = txtCompCliente.Text;
            clienteM.bairro = txtBairroCliente.Text;
            clienteM.localidade = txtCidadeCliente.Text;
            clienteM.uf = txtEstadoCliente.Text;
            if (!string.IsNullOrEmpty(clienteM.nome) &&
                !string.IsNullOrEmpty(clienteM.telefone) &&
                !string.IsNullOrEmpty(clienteM.logradouro) &&
                !string.IsNullOrEmpty(clienteM.numero) &&
                !string.IsNullOrEmpty(clienteM.bairro) &&
                !string.IsNullOrEmpty(clienteM.uf) &&
                !string.IsNullOrEmpty(clienteM.localidade)
                )
            {
                verifica = clienteC.VericarTelefone(txtTeleCliente.Text);


                if (clienteM.codigo>0)
                {

                    if (clienteC.cadastrarCliente(clienteM, 2) == true)
                    {
                        MessageBox.Show("Usuário atualizado " + txtNomeCliente.Text);
                        DGVCliente.DataSource = Conexao.ObterDados(sqlApelido);
                        LimpaTela();
                    }
                }
                else
                {
                    if (verifica >= 1)
                    {
                        MessageBox.Show("Esse número já existe");
                        LimpaTela();
                    }
                    else
                    {
                        if (clienteC.cadastrarCliente(clienteM, 1) == true)
                        {
                            MessageBox.Show("Usuário cadastrado " + txtNomeCliente.Text);
                            DGVCliente.DataSource = Conexao.ObterDados(sqlApelido);
                            LimpaTela();
                        }
                    }
                }

            }
            else
            {
                if (string.IsNullOrEmpty(clienteM.nome))
                {
                    lblNome.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(clienteM.telefone))
                {
                    lblTelefone.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(clienteM.logradouro))
                {
                    lblRua.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(clienteM.numero))
                {
                    lblNumero.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(clienteM.bairro))
                {
                    lblBairro.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(clienteM.uf))
                {
                    lblestado.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(clienteM.localidade))
                {
                    lblCidade.ForeColor = Color.Red;
                }
                lblAtencaoCliente.ForeColor = Color.Red;
                lblAtencaoCliente.Text = "Preencher todos os campos*";
            }
        }

        private void txtTeleCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeleCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxtele = 11;
            txtTeleCliente.MaxLength = maxtele;
            char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void txtNumeroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxNum = 4;
            txtTeleCliente.MaxLength = maxNum;
            char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {            
            sql = "SELECT idCliente as ID," +
                  " emailCliente as Email," +
                  " telCliente as Telefone," +
                  " nomeCliente as Nome," +
                  " cepCliente as CEP," +
                  " logCliente as Logradouro," +
                  " numCliente as Numero," +
                  " compCliente as Complemento," +
                  " bairroCliente as Bairro," +
                  " localidadeCliente as Cidade," +
                  " ufCliente as Estado " +
                  "from cliente where telCliente like '%" + txtPesquisarCliente.Text + "%'";
            DGVCliente.DataSource = Conexao.ObterDados(sql);
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {

            try
            {
                clienteM.codigo = Convert.ToInt32(txtIdCliente.Text);
                if (string.IsNullOrEmpty(clienteM.codigo.ToString()))
                {
                    MessageBox.Show("Campo está vazio");
                    txtIdCliente.Focus();
                }
                else
                {
                    if (clienteM.codigo > 0)
                    {

                        if (clienteC.cadastrarCliente(clienteM, 3) == true)
                        {
                            LimpaTela();
                            MessageBox.Show(clienteM.nome + "Excluido com sucesso");
                        }
                        else
                        {
                            LimpaTela();
                            MessageBox.Show("Erro ao excluir");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            DGVCliente.DataSource = Conexao.ObterDados(sqlApelido);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();

        }

        public void LimpaTela()
        {
            txtIdCliente.Text = "";
            txtNomeCliente.Text = "";
            txtEmailCliente.Text = "";
            txtTeleCliente.Text = "";
            txtCepCliente.Text = "";
            txtRuaCLiente.Text = "";
            txtBairroCliente.Text = "";
            txtCidadeCliente.Text = "";
            txtEstadoCliente.Text = "";
            txtCompCliente.Text = "";
            txtNumeroCliente.Text = "";
        }
        public void limpaCep()
        {
            txtCepCliente.Text = "";
            txtEstadoCliente.Text = "";
            txtCidadeCliente.Text = "";
            txtBairroCliente.Text = "";
            txtRuaCLiente.Text = "";
        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxtele = 11;
            txtTeleCliente.MaxLength = maxtele;
            char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }
    }
}

// Tentativa de Merge em 19/09/2023
