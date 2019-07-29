namespace HAMBURGUERIA_v1
{
    partial class EditarProduto
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome_produtoed = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.nudPreco_produto = new System.Windows.Forms.NumericUpDown();
            this.nudQuantidademinima = new System.Windows.Forms.NumericUpDown();
            this.nudQuantidade_entrando = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidademinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade_entrando)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade Entrando:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantidade Minima:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(294, 265);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNome_produtoed
            // 
            this.txtNome_produtoed.Location = new System.Drawing.Point(133, 91);
            this.txtNome_produtoed.Multiline = true;
            this.txtNome_produtoed.Name = "txtNome_produtoed";
            this.txtNome_produtoed.Size = new System.Drawing.Size(246, 20);
            this.txtNome_produtoed.TabIndex = 12;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(133, 169);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(120, 20);
            this.txtTipo.TabIndex = 25;
            // 
            // nudPreco_produto
            // 
            this.nudPreco_produto.DecimalPlaces = 2;
            this.nudPreco_produto.Location = new System.Drawing.Point(133, 123);
            this.nudPreco_produto.Name = "nudPreco_produto";
            this.nudPreco_produto.Size = new System.Drawing.Size(120, 20);
            this.nudPreco_produto.TabIndex = 16;
            // 
            // nudQuantidademinima
            // 
            this.nudQuantidademinima.Location = new System.Drawing.Point(132, 268);
            this.nudQuantidademinima.Name = "nudQuantidademinima";
            this.nudQuantidademinima.Size = new System.Drawing.Size(80, 20);
            this.nudQuantidademinima.TabIndex = 24;
            // 
            // nudQuantidade_entrando
            // 
            this.nudQuantidade_entrando.Location = new System.Drawing.Point(133, 217);
            this.nudQuantidade_entrando.Name = "nudQuantidade_entrando";
            this.nudQuantidade_entrando.Size = new System.Drawing.Size(80, 20);
            this.nudQuantidade_entrando.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cod Produto";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(133, 48);
            this.txtCodProduto.Multiline = true;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(246, 20);
            this.txtCodProduto.TabIndex = 27;
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 300);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.nudQuantidademinima);
            this.Controls.Add(this.nudQuantidade_entrando);
            this.Controls.Add(this.nudPreco_produto);
            this.Controls.Add(this.txtNome_produtoed);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarProduto";
            this.Text = "Editar Produto";
            this.Load += new System.EventHandler(this.EditarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidademinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade_entrando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome_produtoed;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.NumericUpDown nudPreco_produto;
        private System.Windows.Forms.NumericUpDown nudQuantidademinima;
        private System.Windows.Forms.NumericUpDown nudQuantidade_entrando;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodProduto;
    }
}