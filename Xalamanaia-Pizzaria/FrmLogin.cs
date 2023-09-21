using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xalamanaia_Pizzaria
{
    public partial class FrmLogin : Form
    {
        UsuarioModelo usuarioModelo = new UsuarioModelo();
        ClienteModelo clienteModelo = new ClienteModelo();
        UsuarioController usuarioController = new UsuarioController();
        public FrmLogin()
        {
            InitializeComponent();
        }
       
        int MaxSenha = 8;//Quantidade maxima de caractere para senha
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            lblEmail.ForeColor = Color.Black;
            lblSenha.ForeColor = Color.Black;
            lblAtencao.ForeColor = Color.Black;
            lblAtencao.Text = "";
            int codigopessoa;
            
            usuarioModelo.email= txtEmail.Text;
            usuarioModelo.senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuarioModelo.senha) || string.IsNullOrEmpty(usuarioModelo.email))
            {
                if (string.IsNullOrEmpty(usuarioModelo.email))
                {
                    txtEmail.Focus();
                    lblEmail.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(usuarioModelo.senha))
                {
                    
                    txtSenha.Focus();
                    lblSenha.ForeColor = Color.Red;
                }
                lblAtencao.ForeColor = Color.Red;
                lblAtencao.Text = "*Preencher todos os campos*";
            }
            else
            {

                codigopessoa = usuarioController.logar(usuarioModelo);
                
                if (codigopessoa >= 1)
                {
                    this.Hide();
                    FrmPrincipal principal = new FrmPrincipal();
                    principal.ShowDialog();
                }
                else
                {
                    lblAtencao.ForeColor=Color.Red;
                    lblAtencao.Text = "*Usuario invalido*";
                    txtEmail.Clear();
                    txtSenha.Clear();
                    
                }
            }

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //limita a quantidade de caracteres
            txtSenha.MaxLength = MaxSenha;
            //Somante numeros podem ser inseridos
            char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.CharacterCasing = CharacterCasing.Lower; // qualquer digitado no email é minúsculo.
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

