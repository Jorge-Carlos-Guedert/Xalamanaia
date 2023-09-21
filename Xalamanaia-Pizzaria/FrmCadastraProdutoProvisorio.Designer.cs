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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.textBoxDesc.Location = new System.Drawing.Point(102, 35);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesc.TabIndex = 5;
            // 
            // textBoxBroto
            // 
            this.textBoxBroto.Location = new System.Drawing.Point(102, 62);
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
            this.dtPizza.Location = new System.Drawing.Point(297, 13);
            this.dtPizza.Name = "dtPizza";
            this.dtPizza.Size = new System.Drawing.Size(469, 382);
            this.dtPizza.TabIndex = 11;
            this.dtPizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPizza_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(102, 166);
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
            this.btnExlcuir.Click += new System.EventHandler(this.btnExlcuir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmCadastraProdutoProvisorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}