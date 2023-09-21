namespace Xalamanaia_Pizzaria
{
    partial class FrmPizza
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
            this.lblCodigoPizza = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblDescriçãoPizza = new System.Windows.Forms.Label();
            this.txtDescricaoPizza = new System.Windows.Forms.TextBox();
            this.lblBrotoPizza = new System.Windows.Forms.Label();
            this.txtBrotoPizza = new System.Windows.Forms.TextBox();
            this.txtGrandePizza = new System.Windows.Forms.TextBox();
            this.lblGrandePizza = new System.Windows.Forms.Label();
            this.txtGigantePizza = new System.Windows.Forms.TextBox();
            this.lblGigantePizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigoPizza
            // 
            this.lblCodigoPizza.AutoSize = true;
            this.lblCodigoPizza.Location = new System.Drawing.Point(26, 32);
            this.lblCodigoPizza.Name = "lblCodigoPizza";
            this.lblCodigoPizza.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoPizza.TabIndex = 0;
            this.lblCodigoPizza.Text = "Código";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(72, 29);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 1;
            // 
            // lblDescriçãoPizza
            // 
            this.lblDescriçãoPizza.AutoSize = true;
            this.lblDescriçãoPizza.Location = new System.Drawing.Point(12, 61);
            this.lblDescriçãoPizza.Name = "lblDescriçãoPizza";
            this.lblDescriçãoPizza.Size = new System.Drawing.Size(55, 13);
            this.lblDescriçãoPizza.TabIndex = 2;
            this.lblDescriçãoPizza.Text = "Descrição";
            // 
            // txtDescricaoPizza
            // 
            this.txtDescricaoPizza.Location = new System.Drawing.Point(72, 58);
            this.txtDescricaoPizza.Name = "txtDescricaoPizza";
            this.txtDescricaoPizza.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoPizza.TabIndex = 3;
            // 
            // lblBrotoPizza
            // 
            this.lblBrotoPizza.AutoSize = true;
            this.lblBrotoPizza.Location = new System.Drawing.Point(34, 88);
            this.lblBrotoPizza.Name = "lblBrotoPizza";
            this.lblBrotoPizza.Size = new System.Drawing.Size(32, 13);
            this.lblBrotoPizza.TabIndex = 4;
            this.lblBrotoPizza.Text = "Broto";
            // 
            // txtBrotoPizza
            // 
            this.txtBrotoPizza.Location = new System.Drawing.Point(72, 84);
            this.txtBrotoPizza.Name = "txtBrotoPizza";
            this.txtBrotoPizza.Size = new System.Drawing.Size(100, 20);
            this.txtBrotoPizza.TabIndex = 5;
            // 
            // txtGrandePizza
            // 
            this.txtGrandePizza.Location = new System.Drawing.Point(72, 114);
            this.txtGrandePizza.Name = "txtGrandePizza";
            this.txtGrandePizza.Size = new System.Drawing.Size(100, 20);
            this.txtGrandePizza.TabIndex = 6;
            // 
            // lblGrandePizza
            // 
            this.lblGrandePizza.AutoSize = true;
            this.lblGrandePizza.Location = new System.Drawing.Point(24, 121);
            this.lblGrandePizza.Name = "lblGrandePizza";
            this.lblGrandePizza.Size = new System.Drawing.Size(42, 13);
            this.lblGrandePizza.TabIndex = 7;
            this.lblGrandePizza.Text = "Grande";
            // 
            // txtGigantePizza
            // 
            this.txtGigantePizza.Location = new System.Drawing.Point(72, 151);
            this.txtGigantePizza.Name = "txtGigantePizza";
            this.txtGigantePizza.Size = new System.Drawing.Size(100, 20);
            this.txtGigantePizza.TabIndex = 8;
            // 
            // lblGigantePizza
            // 
            this.lblGigantePizza.AutoSize = true;
            this.lblGigantePizza.Location = new System.Drawing.Point(22, 154);
            this.lblGigantePizza.Name = "lblGigantePizza";
            this.lblGigantePizza.Size = new System.Drawing.Size(44, 13);
            this.lblGigantePizza.TabIndex = 9;
            this.lblGigantePizza.Text = "Gigante";
            // 
            // FrmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGigantePizza);
            this.Controls.Add(this.txtGigantePizza);
            this.Controls.Add(this.lblGrandePizza);
            this.Controls.Add(this.txtGrandePizza);
            this.Controls.Add(this.txtBrotoPizza);
            this.Controls.Add(this.lblBrotoPizza);
            this.Controls.Add(this.txtDescricaoPizza);
            this.Controls.Add(this.lblDescriçãoPizza);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.lblCodigoPizza);
            this.Name = "FrmPizza";
            this.Text = "FrmPizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoPizza;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblDescriçãoPizza;
        private System.Windows.Forms.TextBox txtDescricaoPizza;
        private System.Windows.Forms.Label lblBrotoPizza;
        private System.Windows.Forms.TextBox txtBrotoPizza;
        private System.Windows.Forms.TextBox txtGrandePizza;
        private System.Windows.Forms.Label lblGrandePizza;
        private System.Windows.Forms.TextBox txtGigantePizza;
        private System.Windows.Forms.Label lblGigantePizza;
    }
}