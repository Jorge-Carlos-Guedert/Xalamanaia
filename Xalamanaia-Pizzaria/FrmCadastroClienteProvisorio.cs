using Controllers;
using Models;
using System;
using System.Data;
using System.Windows.Forms;



namespace Xalamanaia_Pizzaria
{
    
    public partial class FrmCadastroClienteProvisorio : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        UsuarioModelo usuarioModelo = new UsuarioModelo();
        public FrmCadastroClienteProvisorio()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            ClienteModelo clienteModelo = new ClienteModelo()
            {
               
                
                telefone = textTelefone.Text,
                nome = textNome.Text,
                email = textEmail.Text,
                cep = textCep.Text,
                logradouro = textLogradouro.Text,
                numero = textNumero.Text,
                complemento = textComplemento.Text,
                bairro = textBairro.Text,
                localidade = textLocalidade.Text,
                uf = textUf.Text,

            };

            

            if (usuarioModelo.email != "" && usuarioModelo.senha != "")
            {
               
                if(usuarioController.cadastrarUsuario(usuarioModelo, 1) == true)
                {
                    MessageBox.Show("Novo Cadastro " + textEmail.Text + " Realizado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao efetuar cadastro");
                }


            }
           
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                usuarioModelo.id_Usuario = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            //textId.Text = dgvPessoas.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            textId.Text = usuarioModelo.id_Usuario.ToString();
           
            textEmail.Text = dgvClientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            textSenha.Text = dgvClientes.Rows[e.RowIndex].Cells["Senha"].Value.ToString(); // não mostrar a senha
            //textPerfil.Text = dgvPessoas.Rows[e.RowIndex].Cells["perfilPessoa"].Value.ToString();
            
            
            //textEmail.Text = pessoaModelo.email;
            //textSenha.Text = pessoaModelo.senha;
            //textPerfil.Text = pessoaModelo.perfil;
            //textTelefone.Text = pessoaModelo.telefone;
            //textNome.Text = pessoaModelo.nome;
            //textCep.Text = pessoaModelo.cep;
            //textLogradouro.Text = pessoaModelo.logradouro;
            //textNumero.Text = pessoaModelo.numero;
            //textComplemento.Text = pessoaModelo.complemento;
            //textBairro.Text = pessoaModelo.bairro;
            //textLocalidade.Text = pessoaModelo.localidade;
            //textUf.Text = pessoaModelo.uf;

             

            
        }

        private void FrmCadastroPessoaProvisorio_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            DataTable dt = new DataTable();
            dt = conexao.ObterDados("SELECT idUsuario as ID, emailUsuario as Email, senhaUsuario as Senha from usuario");
            dgvClientes.DataSource = dt;
            
            
            



            



            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaCEP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(textCep.Text.Trim());


                        textUf.Text = endereco.uf.ToString();
                        textLocalidade.Text = endereco.cidade.ToString();
                        textBairro.Text = endereco.bairro.ToString();
                        textLogradouro.Text = endereco.end.ToString();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
            }
            else
            {
                MessageBox.Show("informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
