namespace HAMBURGUERIA_v1
{
    partial class Pedido
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
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.Comanda = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade_Produto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComanda
            // 
            this.txtComanda.Location = new System.Drawing.Point(70, 23);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(100, 20);
            this.txtComanda.TabIndex = 0;
            // 
            // Comanda
            // 
            this.Comanda.AutoSize = true;
            this.Comanda.Location = new System.Drawing.Point(12, 26);
            this.Comanda.Name = "Comanda";
            this.Comanda.Size = new System.Drawing.Size(55, 13);
            this.Comanda.TabIndex = 1;
            this.Comanda.Text = "Comanda:";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 91);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(240, 150);
            this.dgvProduto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade Produto:";
            // 
            // txtQuantidade_Produto
            // 
            this.txtQuantidade_Produto.Location = new System.Drawing.Point(123, 65);
            this.txtQuantidade_Produto.Name = "txtQuantidade_Produto";
            this.txtQuantidade_Produto.Size = new System.Drawing.Size(129, 20);
            this.txtQuantidade_Produto.TabIndex = 4;
            this.txtQuantidade_Produto.TextChanged += new System.EventHandler(this.txtQuantidade_Produto_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(12, 247);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 6;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(177, 247);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(75, 23);
            this.Remover.TabIndex = 7;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pedido:";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQuantidade_Produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.Comanda);
            this.Controls.Add(this.txtComanda);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.Label Comanda;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade_Produto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Label label2;
    }
}