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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelQuantidade_minima = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.rdbEntrada_produtos = new System.Windows.Forms.RadioButton();
            this.nudEntrada_produto = new System.Windows.Forms.NumericUpDown();
            this.labelQuantidade_maxima = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntrada_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preço";
            // 
            // txtNome_produto
            // 
            this.txtNome_produto.Location = new System.Drawing.Point(159, 35);
            this.txtNome_produto.Name = "txtNome_produto";
            this.txtNome_produto.Size = new System.Drawing.Size(351, 20);
            this.txtNome_produto.TabIndex = 8;
            // 
            // btnSalvar_produto
            // 
            this.btnSalvar_produto.Location = new System.Drawing.Point(303, 466);
            this.btnSalvar_produto.Name = "btnSalvar_produto";
            this.btnSalvar_produto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar_produto.TabIndex = 10;
            this.btnSalvar_produto.Text = "SALVAR";
            this.btnSalvar_produto.UseVisualStyleBackColor = true;
            this.btnSalvar_produto.Click += new System.EventHandler(this.BtnSalvar_produto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Label_Descrição
            // 
            this.Label_Descrição.AutoSize = true;
            this.Label_Descrição.Location = new System.Drawing.Point(270, 177);
            this.Label_Descrição.Name = "Label_Descrição";
            this.Label_Descrição.Size = new System.Drawing.Size(55, 13);
            this.Label_Descrição.TabIndex = 12;
            this.Label_Descrição.Text = "Descrição";
            this.Label_Descrição.Visible = false;
            // 
            // txtDescricao_produto
            // 
            this.txtDescricao_produto.Location = new System.Drawing.Point(12, 193);
            this.txtDescricao_produto.Multiline = true;
            this.txtDescricao_produto.Name = "txtDescricao_produto";
            this.txtDescricao_produto.Size = new System.Drawing.Size(592, 24);
            this.txtDescricao_produto.TabIndex = 13;
            this.txtDescricao_produto.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBebida);
            this.groupBox1.Controls.Add(this.rdbComida);
            this.groupBox1.Location = new System.Drawing.Point(15, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rdbBebida
            // 
            this.rdbBebida.AutoSize = true;
            this.rdbBebida.Location = new System.Drawing.Point(109, 44);
            this.rdbBebida.Name = "rdbBebida";
            this.rdbBebida.Size = new System.Drawing.Size(58, 17);
            this.rdbBebida.TabIndex = 1;
            this.rdbBebida.TabStop = true;
            this.rdbBebida.Text = "Bebida";
            this.rdbBebida.UseVisualStyleBackColor = true;
            this.rdbBebida.CheckedChanged += new System.EventHandler(this.rdbBebida_CheckedChanged);
            // 
            // rdbComida
            // 
            this.rdbComida.AutoSize = true;
            this.rdbComida.Location = new System.Drawing.Point(5, 44);
            this.rdbComida.Name = "rdbComida";
            this.rdbComida.Size = new System.Drawing.Size(60, 17);
            this.rdbComida.TabIndex = 0;
            this.rdbComida.Text = "Comida";
            this.rdbComida.UseVisualStyleBackColor = true;
            this.rdbComida.CheckedChanged += new System.EventHandler(this.rdbComida_CheckedChanged_1);
            // 
            // nudPreco_produto
            // 
            this.nudPreco_produto.DecimalPlaces = 2;
            this.nudPreco_produto.Location = new System.Drawing.Point(159, 61);
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
            this.cmbCategoria.Location = new System.Drawing.Point(236, 98);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 16;
            this.cmbCategoria.Visible = false;
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
            this.cmbBebida.Location = new System.Drawing.Point(236, 154);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(121, 21);
            this.cmbBebida.TabIndex = 17;
            this.cmbBebida.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(511, 98);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Visible = false;
            // 
            // labelQuantidade_minima
            // 
            this.labelQuantidade_minima.AutoSize = true;
            this.labelQuantidade_minima.Location = new System.Drawing.Point(394, 101);
            this.labelQuantidade_minima.Name = "labelQuantidade_minima";
            this.labelQuantidade_minima.Size = new System.Drawing.Size(100, 13);
            this.labelQuantidade_minima.TabIndex = 20;
            this.labelQuantidade_minima.Text = "Quantidade minima:";
            this.labelQuantidade_minima.Visible = false;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Enabled = false;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 266);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(592, 148);
            this.dgvEstoque.TabIndex = 21;
            // 
            // rdbEntrada_produtos
            // 
            this.rdbEntrada_produtos.AutoSize = true;
            this.rdbEntrada_produtos.Location = new System.Drawing.Point(20, 245);
            this.rdbEntrada_produtos.Name = "rdbEntrada_produtos";
            this.rdbEntrada_produtos.Size = new System.Drawing.Size(62, 17);
            this.rdbEntrada_produtos.TabIndex = 22;
            this.rdbEntrada_produtos.TabStop = true;
            this.rdbEntrada_produtos.Text = "Entrada";
            this.rdbEntrada_produtos.UseVisualStyleBackColor = true;
            this.rdbEntrada_produtos.Visible = false;
            this.rdbEntrada_produtos.CheckedChanged += new System.EventHandler(this.rdbEntrada_produtos_CheckedChanged);
            // 
            // nudEntrada_produto
            // 
            this.nudEntrada_produto.Location = new System.Drawing.Point(88, 242);
            this.nudEntrada_produto.Name = "nudEntrada_produto";
            this.nudEntrada_produto.Size = new System.Drawing.Size(80, 20);
            this.nudEntrada_produto.TabIndex = 23;
            this.nudEntrada_produto.Visible = false;
            // 
            // labelQuantidade_maxima
            // 
            this.labelQuantidade_maxima.AutoSize = true;
            this.labelQuantidade_maxima.Location = new System.Drawing.Point(469, 247);
            this.labelQuantidade_maxima.Name = "labelQuantidade_maxima";
            this.labelQuantidade_maxima.Size = new System.Drawing.Size(62, 13);
            this.labelQuantidade_maxima.TabIndex = 24;
            this.labelQuantidade_maxima.Text = "Quantidade";
            this.labelQuantidade_maxima.Visible = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(537, 242);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(54, 20);
            this.txtQuantidade.TabIndex = 25;
            this.txtQuantidade.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 501);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.labelQuantidade_maxima);
            this.Controls.Add(this.nudEntrada_produto);
            this.Controls.Add(this.rdbEntrada_produtos);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.labelQuantidade_minima);
            this.Controls.Add(this.numericUpDown1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntrada_produto)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelQuantidade_minima;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.RadioButton rdbEntrada_produtos;
        private System.Windows.Forms.NumericUpDown nudEntrada_produto;
        private System.Windows.Forms.Label labelQuantidade_maxima;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}

