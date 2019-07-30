namespace HAMBURGUERIA_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome_produto = new System.Windows.Forms.TextBox();
            this.btnSalvar_produto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Label_Descrição = new System.Windows.Forms.Label();
            this.txtDescricao_produto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBebida = new System.Windows.Forms.RadioButton();
            this.rdbComida = new System.Windows.Forms.RadioButton();
            this.nudPreco_produto = new System.Windows.Forms.NumericUpDown();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.nudQuantidademinima = new System.Windows.Forms.NumericUpDown();
            this.labelQuantidade_minima = new System.Windows.Forms.Label();
            this.Quantidade_entrando = new System.Windows.Forms.Label();
            this.nudQuantidade_entrando = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidademinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade_entrando)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preço";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome_produto
            // 
            this.txtNome_produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome_produto.Location = new System.Drawing.Point(159, 64);
            this.txtNome_produto.Name = "txtNome_produto";
            this.txtNome_produto.Size = new System.Drawing.Size(718, 20);
            this.txtNome_produto.TabIndex = 8;
            this.txtNome_produto.TextChanged += new System.EventHandler(this.txtNome_produto_TextChanged);
            // 
            // btnSalvar_produto
            // 
            this.btnSalvar_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar_produto.Location = new System.Drawing.Point(824, 498);
            this.btnSalvar_produto.Name = "btnSalvar_produto";
            this.btnSalvar_produto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar_produto.TabIndex = 10;
            this.btnSalvar_produto.Text = "SALVAR";
            this.btnSalvar_produto.UseVisualStyleBackColor = true;
            this.btnSalvar_produto.Click += new System.EventHandler(this.BtnSalvar_produto_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(743, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Label_Descrição
            // 
            this.Label_Descrição.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Descrição.AutoSize = true;
            this.Label_Descrição.Location = new System.Drawing.Point(12, 456);
            this.Label_Descrição.Name = "Label_Descrição";
            this.Label_Descrição.Size = new System.Drawing.Size(55, 13);
            this.Label_Descrição.TabIndex = 12;
            this.Label_Descrição.Text = "Descrição";
            this.Label_Descrição.Click += new System.EventHandler(this.Label_Descrição_Click);
            // 
            // txtDescricao_produto
            // 
            this.txtDescricao_produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao_produto.Location = new System.Drawing.Point(105, 453);
            this.txtDescricao_produto.Multiline = true;
            this.txtDescricao_produto.Name = "txtDescricao_produto";
            this.txtDescricao_produto.Size = new System.Drawing.Size(866, 24);
            this.txtDescricao_produto.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbBebida);
            this.groupBox1.Controls.Add(this.rdbComida);
            this.groupBox1.Location = new System.Drawing.Point(15, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbBebida
            // 
            this.rdbBebida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbBebida.AutoSize = true;
            this.rdbBebida.Location = new System.Drawing.Point(181, 44);
            this.rdbBebida.Name = "rdbBebida";
            this.rdbBebida.Size = new System.Drawing.Size(58, 17);
            this.rdbBebida.TabIndex = 1;
            this.rdbBebida.Text = "Bebida";
            this.rdbBebida.UseVisualStyleBackColor = true;
            this.rdbBebida.CheckedChanged += new System.EventHandler(this.rdbBebida_CheckedChanged);
            // 
            // rdbComida
            // 
            this.rdbComida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbComida.AutoSize = true;
            this.rdbComida.Checked = true;
            this.rdbComida.Location = new System.Drawing.Point(42, 44);
            this.rdbComida.Name = "rdbComida";
            this.rdbComida.Size = new System.Drawing.Size(60, 17);
            this.rdbComida.TabIndex = 0;
            this.rdbComida.TabStop = true;
            this.rdbComida.Text = "Comida";
            this.rdbComida.UseVisualStyleBackColor = true;
            this.rdbComida.CheckedChanged += new System.EventHandler(this.rdbComida_CheckedChanged_1);
            // 
            // nudPreco_produto
            // 
            this.nudPreco_produto.DecimalPlaces = 2;
            this.nudPreco_produto.Location = new System.Drawing.Point(156, 152);
            this.nudPreco_produto.Name = "nudPreco_produto";
            this.nudPreco_produto.Size = new System.Drawing.Size(120, 20);
            this.nudPreco_produto.TabIndex = 15;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "LANCHE",
            "SOBREMESA",
            "PORÇÃO"});
            this.cmbCategoria.Location = new System.Drawing.Point(17, 374);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 16;
            // 
            // cmbBebida
            // 
            this.cmbBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Items.AddRange(new object[] {
            "290 ml",
            "350 ml",
            "500 ml",
            "600 ml",
            "1 L",
            "1,5 L",
            "2 L "});
            this.cmbBebida.Location = new System.Drawing.Point(18, 375);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(121, 21);
            this.cmbBebida.TabIndex = 17;
            this.cmbBebida.Visible = false;
            // 
            // nudQuantidademinima
            // 
            this.nudQuantidademinima.Location = new System.Drawing.Point(521, 374);
            this.nudQuantidademinima.Name = "nudQuantidademinima";
            this.nudQuantidademinima.Size = new System.Drawing.Size(80, 20);
            this.nudQuantidademinima.TabIndex = 18;
            this.nudQuantidademinima.Visible = false;
            // 
            // labelQuantidade_minima
            // 
            this.labelQuantidade_minima.AutoSize = true;
            this.labelQuantidade_minima.Location = new System.Drawing.Point(399, 379);
            this.labelQuantidade_minima.Name = "labelQuantidade_minima";
            this.labelQuantidade_minima.Size = new System.Drawing.Size(100, 13);
            this.labelQuantidade_minima.TabIndex = 20;
            this.labelQuantidade_minima.Text = "Quantidade minima:";
            this.labelQuantidade_minima.Visible = false;
            // 
            // Quantidade_entrando
            // 
            this.Quantidade_entrando.AutoSize = true;
            this.Quantidade_entrando.Location = new System.Drawing.Point(168, 378);
            this.Quantidade_entrando.Name = "Quantidade_entrando";
            this.Quantidade_entrando.Size = new System.Drawing.Size(111, 13);
            this.Quantidade_entrando.TabIndex = 21;
            this.Quantidade_entrando.Text = "Quantidade Entrando:";
            this.Quantidade_entrando.Visible = false;
            // 
            // nudQuantidade_entrando
            // 
            this.nudQuantidade_entrando.Location = new System.Drawing.Point(295, 374);
            this.nudQuantidade_entrando.Name = "nudQuantidade_entrando";
            this.nudQuantidade_entrando.Size = new System.Drawing.Size(80, 20);
            this.nudQuantidade_entrando.TabIndex = 22;
            this.nudQuantidade_entrando.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(905, 498);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 533);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nudQuantidade_entrando);
            this.Controls.Add(this.Quantidade_entrando);
            this.Controls.Add(this.labelQuantidade_minima);
            this.Controls.Add(this.nudQuantidademinima);
            this.Controls.Add(this.cmbBebida);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.nudPreco_produto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescricao_produto);
            this.Controls.Add(this.Label_Descrição);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvar_produto);
            this.Controls.Add(this.txtNome_produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "CADASTRO DE PRODUTOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidademinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade_entrando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome_produto;
        private System.Windows.Forms.Button btnSalvar_produto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label_Descrição;
        private System.Windows.Forms.TextBox txtDescricao_produto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBebida;
        private System.Windows.Forms.RadioButton rdbComida;
        private System.Windows.Forms.NumericUpDown nudPreco_produto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.NumericUpDown nudQuantidademinima;
        private System.Windows.Forms.Label labelQuantidade_minima;
        private System.Windows.Forms.Label Quantidade_entrando;
        private System.Windows.Forms.NumericUpDown nudQuantidade_entrando;
        private System.Windows.Forms.Button btnCancelar;
    }
}

