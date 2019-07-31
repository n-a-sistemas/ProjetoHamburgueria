namespace HAMBURGUERIA_v1
{
    partial class LancarPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade_Produto = new System.Windows.Forms.TextBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btbCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.bntRemover = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.cod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUTO:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PEDIDO:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observações:";
            // 
            // txtQuantidade_Produto
            // 
            this.txtQuantidade_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade_Produto.Location = new System.Drawing.Point(73, 52);
            this.txtQuantidade_Produto.Name = "txtQuantidade_Produto";
            this.txtQuantidade_Produto.Size = new System.Drawing.Size(243, 20);
            this.txtQuantidade_Produto.TabIndex = 5;
            this.txtQuantidade_Produto.TextChanged += new System.EventHandler(this.txtQuantidade_Produto_TextChanged_1);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_produto,
            this.NomeProduto,
            this.Valor,
            this.Quantidade});
            this.dgvPedido.Location = new System.Drawing.Point(602, 103);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(347, 150);
            this.dgvPedido.TabIndex = 6;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(73, 103);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(337, 150);
            this.dgvProduto.TabIndex = 7;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacoes.Location = new System.Drawing.Point(12, 320);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(952, 35);
            this.txtObservacoes.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.Location = new System.Drawing.Point(72, 259);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 28);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btbCancelar
            // 
            this.btbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btbCancelar.Location = new System.Drawing.Point(864, 364);
            this.btbCancelar.Name = "btbCancelar";
            this.btbCancelar.Size = new System.Drawing.Size(75, 40);
            this.btbCancelar.TabIndex = 10;
            this.btbCancelar.Text = "Cancelar";
            this.btbCancelar.UseVisualStyleBackColor = true;
            this.btbCancelar.Click += new System.EventHandler(this.btbCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(763, 364);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 40);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // bntRemover
            // 
            this.bntRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntRemover.Location = new System.Drawing.Point(745, 259);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(75, 28);
            this.bntRemover.TabIndex = 12;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudQuantidade.Location = new System.Drawing.Point(335, 265);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(75, 20);
            this.nudQuantidade.TabIndex = 13;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "QUANTIDADE:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(602, 267);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(602, 297);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(116, 20);
            this.txtQuantidade.TabIndex = 16;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "COMANDA:";
            // 
            // txtComanda
            // 
            this.txtComanda.Location = new System.Drawing.Point(73, 13);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(243, 20);
            this.txtComanda.TabIndex = 18;
            // 
            // cod_produto
            // 
            this.cod_produto.HeaderText = "Código do produto";
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.ReadOnly = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome do Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // LancarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 406);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btbCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.txtQuantidade_Produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "LancarPedido";
            this.Text = "LancarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade_Produto;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btbCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}