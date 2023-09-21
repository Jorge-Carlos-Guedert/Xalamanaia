namespace Xalamanaia_Pizzaria
{
    partial class FrmCadastraCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastraCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAtencaoCliente = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btncep = new System.Windows.Forms.Button();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DGVCliente = new System.Windows.Forms.DataGridView();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtCompCliente = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRuaCLiente = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtCepCliente = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtTeleCliente = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnConfirmarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.lblAtencaoCliente);
            this.groupBox1.Controls.Add(this.btnExcluirCliente);
            this.groupBox1.Controls.Add(this.btnPesquisarCliente);
            this.groupBox1.Controls.Add(this.btncep);
            this.groupBox1.Controls.Add(this.btnConfirmarCliente);
            this.groupBox1.Controls.Add(this.txtPesquisarCliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DGVCliente);
            this.groupBox1.Controls.Add(this.txtEstadoCliente);
            this.groupBox1.Controls.Add(this.lblestado);
            this.groupBox1.Controls.Add(this.txtCompCliente);
            this.groupBox1.Controls.Add(this.lblComp);
            this.groupBox1.Controls.Add(this.txtBairroCliente);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtCidadeCliente);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.txtNumeroCliente);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.txtRuaCLiente);
            this.groupBox1.Controls.Add(this.lblRua);
            this.groupBox1.Controls.Add(this.txtCepCliente);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.txtTeleCliente);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmailCliente);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Cliente";
            // 
            // lblAtencaoCliente
            // 
            this.lblAtencaoCliente.AutoSize = true;
            this.lblAtencaoCliente.Location = new System.Drawing.Point(11, 268);
            this.lblAtencaoCliente.Name = "lblAtencaoCliente";
            this.lblAtencaoCliente.Size = new System.Drawing.Size(0, 13);
            this.lblAtencaoCliente.TabIndex = 30;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(670, 21);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCliente.TabIndex = 28;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btncep
            // 
            this.btncep.Location = new System.Drawing.Point(200, 132);
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(195, 23);
            this.btncep.TabIndex = 27;
            this.btncep.Text = "Buscar Cep";
            this.btncep.UseVisualStyleBackColor = true;
            this.btncep.Click += new System.EventHandler(this.btncep_Click);
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.Location = new System.Drawing.Point(488, 22);
            this.txtPesquisarCliente.MaxLength = 11;
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(176, 20);
            this.txtPesquisarCliente.TabIndex = 25;
            this.txtPesquisarCliente.TextChanged += new System.EventHandler(this.txtPesquisarCliente_TextChanged);
            this.txtPesquisarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisarCliente_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Pesquisar";
            // 
            // DGVCliente
            // 
            this.DGVCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCliente.GridColor = System.Drawing.SystemColors.Control;
            this.DGVCliente.Location = new System.Drawing.Point(429, 48);
            this.DGVCliente.Name = "DGVCliente";
            this.DGVCliente.Size = new System.Drawing.Size(330, 303);
            this.DGVCliente.TabIndex = 23;
            this.DGVCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCliente_CellClick);
            this.DGVCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCliente_CellContentClick);
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(243, 228);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.Size = new System.Drawing.Size(152, 20);
            this.txtEstadoCliente.TabIndex = 22;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(197, 232);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 21;
            this.lblestado.Text = "Estado";
            // 
            // txtCompCliente
            // 
            this.txtCompCliente.Location = new System.Drawing.Point(272, 198);
            this.txtCompCliente.Name = "txtCompCliente";
            this.txtCompCliente.Size = new System.Drawing.Size(123, 20);
            this.txtCompCliente.TabIndex = 20;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(197, 202);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(71, 13);
            this.lblComp.TabIndex = 19;
            this.lblComp.Text = "Complemento";
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(52, 199);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(139, 20);
            this.txtBairroCliente.TabIndex = 18;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 200);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Location = new System.Drawing.Point(52, 228);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(139, 20);
            this.txtCidadeCliente.TabIndex = 16;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 231);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(319, 166);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroCliente.TabIndex = 14;
            this.txtNumeroCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCliente_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(269, 170);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Numero";
            // 
            // txtRuaCLiente
            // 
            this.txtRuaCLiente.Location = new System.Drawing.Point(52, 166);
            this.txtRuaCLiente.Name = "txtRuaCLiente";
            this.txtRuaCLiente.Size = new System.Drawing.Size(210, 20);
            this.txtRuaCLiente.TabIndex = 12;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(19, 169);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 11;
            this.lblRua.Text = "Rua";
            // 
            // txtCepCliente
            // 
            this.txtCepCliente.Location = new System.Drawing.Point(52, 133);
            this.txtCepCliente.Name = "txtCepCliente";
            this.txtCepCliente.Size = new System.Drawing.Size(139, 20);
            this.txtCepCliente.TabIndex = 10;
            this.txtCepCliente.TextChanged += new System.EventHandler(this.txtCepCliente_TextChanged);
            this.txtCepCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCepCliente_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(18, 136);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 9;
            this.lblCep.Text = "CEP";
            // 
            // txtTeleCliente
            // 
            this.txtTeleCliente.Location = new System.Drawing.Point(252, 64);
            this.txtTeleCliente.Name = "txtTeleCliente";
            this.txtTeleCliente.Size = new System.Drawing.Size(143, 20);
            this.txtTeleCliente.TabIndex = 8;
            this.txtTeleCliente.TextChanged += new System.EventHandler(this.txtTeleCliente_TextChanged);
            this.txtTeleCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeleCliente_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(197, 67);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(52, 98);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(343, 20);
            this.txtEmailCliente.TabIndex = 5;
            this.txtEmailCliente.TextChanged += new System.EventHandler(this.txtEmailCliente_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome ";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(52, 64);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(139, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(52, 29);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(139, 20);
            this.txtIdCliente.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(31, 292);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 39);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirCliente.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluirCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExcluirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.Brown;
            this.btnExcluirCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCliente.Image")));
            this.btnExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCliente.Location = new System.Drawing.Point(293, 292);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(102, 39);
            this.btnExcluirCliente.TabIndex = 29;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnConfirmarCliente
            // 
            this.btnConfirmarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirmarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCliente.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarCliente.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarCliente.Image")));
            this.btnConfirmarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarCliente.Location = new System.Drawing.Point(151, 292);
            this.btnConfirmarCliente.Name = "btnConfirmarCliente";
            this.btnConfirmarCliente.Size = new System.Drawing.Size(127, 39);
            this.btnConfirmarCliente.TabIndex = 26;
            this.btnConfirmarCliente.Text = "Confirmar";
            this.btnConfirmarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCliente.UseVisualStyleBackColor = true;
            this.btnConfirmarCliente.Click += new System.EventHandler(this.btnConfirmarCliente_Click);
            // 
            // FrmCadastraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 394);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadastraCliente";
            this.Text = "FrmCadastraCliente";
            this.Load += new System.EventHandler(this.FrmCadastraCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtTeleCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCepCliente;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtRuaCLiente;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtCompCliente;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Button btnConfirmarCliente;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DGVCliente;
        private System.Windows.Forms.Button btncep;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Label lblAtencaoCliente;
        private System.Windows.Forms.Button btnLimpar;
    }
}