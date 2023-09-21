namespace Xalamanaia_Pizzaria
{
    partial class FrmSolPedido
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exibeteladicional = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxAdicionais = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxExcecoes = new System.Windows.Forms.CheckBox();
            this.checkedListBoxExcecao = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnadicionaritem = new System.Windows.Forms.Button();
            this.valorpizza = new System.Windows.Forms.TextBox();
            this.cbxsabor3 = new System.Windows.Forms.ComboBox();
            this.cbxsabor2 = new System.Windows.Forms.ComboBox();
            this.cbxsabor1 = new System.Windows.Forms.ComboBox();
            this.cbxtamanho = new System.Windows.Forms.ComboBox();
            this.cbxUnidades = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(720, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Pedido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxUnidades);
            this.panel1.Controls.Add(this.exibeteladicional);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxAdicionais);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.checkBoxExcecoes);
            this.panel1.Controls.Add(this.checkedListBoxExcecao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExcluirItem);
            this.panel1.Controls.Add(this.btnadicionaritem);
            this.panel1.Controls.Add(this.valorpizza);
            this.panel1.Controls.Add(this.cbxsabor3);
            this.panel1.Controls.Add(this.cbxsabor2);
            this.panel1.Controls.Add(this.cbxsabor1);
            this.panel1.Controls.Add(this.cbxtamanho);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 804);
            this.panel1.TabIndex = 1;
            
            // 
            // exibeteladicional
            // 
            this.exibeteladicional.Location = new System.Drawing.Point(759, 38);
            this.exibeteladicional.Name = "exibeteladicional";
            this.exibeteladicional.Size = new System.Drawing.Size(100, 20);
            this.exibeteladicional.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(765, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total  Adicionais";
            // 
            // cbxAdicionais
            // 
            this.cbxAdicionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAdicionais.FormattingEnabled = true;
            this.cbxAdicionais.Location = new System.Drawing.Point(594, 37);
            this.cbxAdicionais.Name = "cbxAdicionais";
            this.cbxAdicionais.Size = new System.Drawing.Size(121, 21);
            this.cbxAdicionais.TabIndex = 19;
            this.cbxAdicionais.SelectedIndexChanged += new System.EventHandler(this.cbxAdicionais_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adicionais";
            // 
            // checkBoxExcecoes
            // 
            this.checkBoxExcecoes.AutoSize = true;
            this.checkBoxExcecoes.Location = new System.Drawing.Point(951, 38);
            this.checkBoxExcecoes.Name = "checkBoxExcecoes";
            this.checkBoxExcecoes.Size = new System.Drawing.Size(73, 17);
            this.checkBoxExcecoes.TabIndex = 17;
            this.checkBoxExcecoes.Text = "Excecões";
            this.checkBoxExcecoes.UseVisualStyleBackColor = true;
            this.checkBoxExcecoes.CheckedChanged += new System.EventHandler(this.checkBoxExcecoes_CheckedChanged);
            // 
            // checkedListBoxExcecao
            // 
            this.checkedListBoxExcecao.FormattingEnabled = true;
            this.checkedListBoxExcecao.Location = new System.Drawing.Point(923, 78);
            this.checkedListBoxExcecao.Name = "checkedListBoxExcecao";
            this.checkedListBoxExcecao.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxExcecao.TabIndex = 16;
            this.checkedListBoxExcecao.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxExcecao_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1184, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1062, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "1º Sabor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2º Sabor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1º Sabor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecione Tamanho";
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(1342, 34);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItem.TabIndex = 6;
            this.btnExcluirItem.Text = "Exclui";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // btnadicionaritem
            // 
            this.btnadicionaritem.Location = new System.Drawing.Point(1261, 34);
            this.btnadicionaritem.Name = "btnadicionaritem";
            this.btnadicionaritem.Size = new System.Drawing.Size(75, 23);
            this.btnadicionaritem.TabIndex = 5;
            this.btnadicionaritem.Text = "Adicionar";
            this.btnadicionaritem.UseVisualStyleBackColor = true;
            // 
            // valorpizza
            // 
            this.valorpizza.Location = new System.Drawing.Point(1155, 36);
            this.valorpizza.Name = "valorpizza";
            this.valorpizza.Size = new System.Drawing.Size(100, 20);
            this.valorpizza.TabIndex = 4;
            // 
            // cbxsabor3
            // 
            this.cbxsabor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsabor3.FormattingEnabled = true;
            this.cbxsabor3.Location = new System.Drawing.Point(445, 37);
            this.cbxsabor3.Name = "cbxsabor3";
            this.cbxsabor3.Size = new System.Drawing.Size(121, 21);
            this.cbxsabor3.TabIndex = 3;
            this.cbxsabor3.SelectedIndexChanged += new System.EventHandler(this.cbxsabor3_SelectedIndexChanged);
            // 
            // cbxsabor2
            // 
            this.cbxsabor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsabor2.FormattingEnabled = true;
            this.cbxsabor2.Location = new System.Drawing.Point(295, 37);
            this.cbxsabor2.Name = "cbxsabor2";
            this.cbxsabor2.Size = new System.Drawing.Size(121, 21);
            this.cbxsabor2.TabIndex = 2;
            this.cbxsabor2.SelectedIndexChanged += new System.EventHandler(this.cbxsabor2_SelectedIndexChanged);
            // 
            // cbxsabor1
            // 
            this.cbxsabor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsabor1.FormattingEnabled = true;
            this.cbxsabor1.Location = new System.Drawing.Point(152, 37);
            this.cbxsabor1.Name = "cbxsabor1";
            this.cbxsabor1.Size = new System.Drawing.Size(121, 21);
            this.cbxsabor1.TabIndex = 1;
            this.cbxsabor1.SelectedIndexChanged += new System.EventHandler(this.cbxsabor1_SelectedIndexChanged);
            // 
            // cbxtamanho
            // 
            this.cbxtamanho.FormattingEnabled = true;
            this.cbxtamanho.Location = new System.Drawing.Point(14, 37);
            this.cbxtamanho.Name = "cbxtamanho";
            this.cbxtamanho.Size = new System.Drawing.Size(121, 21);
            this.cbxtamanho.TabIndex = 0;
            this.cbxtamanho.SelectedIndexChanged += new System.EventHandler(this.cbxtamanho_SelectedIndexChanged);
            // 
            // cbxUnidades
            // 
            this.cbxUnidades.FormattingEnabled = true;
            this.cbxUnidades.Location = new System.Drawing.Point(1065, 35);
            this.cbxUnidades.Name = "cbxUnidades";
            this.cbxUnidades.Size = new System.Drawing.Size(49, 21);
            this.cbxUnidades.TabIndex = 23;
            this.cbxUnidades.SelectedIndexChanged += new System.EventHandler(this.cbxUnidades_SelectedIndexChanged);
            // 
            // FrmSolPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 842);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSolPedido";
            this.Text = "FrmSolPedido";
            this.Load += new System.EventHandler(this.FrmSolPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxsabor3;
        private System.Windows.Forms.ComboBox cbxsabor2;
        private System.Windows.Forms.ComboBox cbxsabor1;
        private System.Windows.Forms.ComboBox cbxtamanho;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnadicionaritem;
        private System.Windows.Forms.TextBox valorpizza;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.CheckedListBox checkedListBoxExcecao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxExcecoes;
        private System.Windows.Forms.ComboBox cbxAdicionais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox exibeteladicional;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxUnidades;
    }
}