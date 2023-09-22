namespace Xalamanaia_Pizzaria
{
    partial class FrmCadastraProdutoProvisorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastraProdutoProvisorio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxBroto = new System.Windows.Forms.TextBox();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.textBoxGrande = new System.Windows.Forms.TextBox();
            this.textBoxGigante = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtPizza = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExlcuir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Média:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grande:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gigante:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDesc.Location = new System.Drawing.Point(102, 35);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesc.TabIndex = 5;
            // 
            // textBoxBroto
            // 
            this.textBoxBroto.Location = new System.Drawing.Point(102, 62);
            this.textBoxBroto.MaxLength = 5;
            this.textBoxBroto.Name = "textBoxBroto";
            this.textBoxBroto.Size = new System.Drawing.Size(100, 20);
            this.textBoxBroto.TabIndex = 6;
            this.textBoxBroto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBroto_KeyPress);
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Location = new System.Drawing.Point(102, 86);
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedia.TabIndex = 7;
            this.textBoxMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMedia_KeyPress);
            // 
            // textBoxGrande
            // 
            this.textBoxGrande.Location = new System.Drawing.Point(102, 113);
            this.textBoxGrande.Name = "textBoxGrande";
            this.textBoxGrande.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrande.TabIndex = 8;
            this.textBoxGrande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGrande_KeyPress);
            // 
            // textBoxGigante
            // 
            this.textBoxGigante.Location = new System.Drawing.Point(102, 139);
            this.textBoxGigante.Name = "textBoxGigante";
            this.textBoxGigante.Size = new System.Drawing.Size(100, 20);
            this.textBoxGigante.TabIndex = 9;
            this.textBoxGigante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGigante_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(-1, 204);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtPizza
            // 
            this.dtPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPizza.Location = new System.Drawing.Point(450, 13);
            this.dtPizza.Name = "dtPizza";
            this.dtPizza.RowHeadersVisible = false;
            this.dtPizza.Size = new System.Drawing.Size(316, 382);
            this.dtPizza.TabIndex = 11;
            this.dtPizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPizza_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(101, 10);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(102, 204);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExlcuir
            // 
            this.btnExlcuir.Location = new System.Drawing.Point(203, 204);
            this.btnExlcuir.Name = "btnExlcuir";
            this.btnExlcuir.Size = new System.Drawing.Size(75, 23);
            this.btnExlcuir.TabIndex = 15;
            this.btnExlcuir.Text = "Excluir";
            this.btnExlcuir.UseVisualStyleBackColor = true;
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
            this.btnLimpar.Location = new System.Drawing.Point(11, 302);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 39);
            this.btnLimpar.TabIndex = 34;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Brown;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(273, 302);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 39);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(131, 302);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(127, 39);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmarCliente_Click);
            // 
            // FrmCadastraProdutoProvisorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnExlcuir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtPizza);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textBoxGigante);
            this.Controls.Add(this.textBoxGrande);
            this.Controls.Add(this.textBoxMedia);
            this.Controls.Add(this.textBoxBroto);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastraProdutoProvisorio";
            this.Text = "FrmCadastraProdutoProvisorio";
            this.Load += new System.EventHandler(this.FrmCadastraProdutoProvisorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxBroto;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.TextBox textBoxGrande;
        private System.Windows.Forms.TextBox textBoxGigante;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtPizza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExlcuir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
    }
}