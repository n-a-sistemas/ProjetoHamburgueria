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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.txtQuantidade_Produto = new System.Windows.Forms.TextBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btbCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.bntRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comanda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observações:";
            // 
            // txtComanda
            // 
            this.txtComanda.Location = new System.Drawing.Point(73, 6);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(100, 20);
            this.txtComanda.TabIndex = 4;
            // 
            // txtQuantidade_Produto
            // 
            this.txtQuantidade_Produto.Location = new System.Drawing.Point(73, 39);
            this.txtQuantidade_Produto.Name = "txtQuantidade_Produto";
            this.txtQuantidade_Produto.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade_Produto.TabIndex = 5;
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(354, 65);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(240, 150);
            this.dgvPedido.TabIndex = 6;
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(15, 65);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(240, 150);
            this.dgvProduto.TabIndex = 7;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(12, 286);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(582, 79);
            this.txtObservacoes.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(15, 221);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btbCancelar
            // 
            this.btbCancelar.Location = new System.Drawing.Point(430, 371);
            this.btbCancelar.Name = "btbCancelar";
            this.btbCancelar.Size = new System.Drawing.Size(75, 23);
            this.btbCancelar.TabIndex = 10;
            this.btbCancelar.Text = "Cancelar";
            this.btbCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(519, 371);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(354, 221);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(75, 23);
            this.bntRemover.TabIndex = 12;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            // 
            // LancarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 406);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btbCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.txtQuantidade_Produto);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LancarPedido";
            this.Text = "LancarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.TextBox txtQuantidade_Produto;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btbCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button bntRemover;
    }
}