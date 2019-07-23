namespace HAMBURGUERIA_v1
{
    partial class Estoque
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
            this.txtBuscaProduto = new System.Windows.Forms.TextBox();
            this.dgvTodosProdutos = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca por produto:";
            // 
            // txtBuscaProduto
            // 
            this.txtBuscaProduto.Location = new System.Drawing.Point(116, 15);
            this.txtBuscaProduto.Name = "txtBuscaProduto";
            this.txtBuscaProduto.Size = new System.Drawing.Size(672, 20);
            this.txtBuscaProduto.TabIndex = 1;
            this.txtBuscaProduto.TextChanged += new System.EventHandler(this.txtBuscaProduto_TextChanged);
            // 
            // dgvTodosProdutos
            // 
            this.dgvTodosProdutos.AllowUserToAddRows = false;
            this.dgvTodosProdutos.AllowUserToDeleteRows = false;
            this.dgvTodosProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosProdutos.Location = new System.Drawing.Point(12, 54);
            this.dgvTodosProdutos.Name = "dgvTodosProdutos";
            this.dgvTodosProdutos.ReadOnly = true;
            this.dgvTodosProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodosProdutos.Size = new System.Drawing.Size(776, 341);
            this.dgvTodosProdutos.TabIndex = 2;
            this.dgvTodosProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodosProdutos_CellContentClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(544, 406);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 37);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(717, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(634, 406);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 37);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(452, 406);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 37);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvTodosProdutos);
            this.Controls.Add(this.txtBuscaProduto);
            this.Controls.Add(this.label1);
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaProduto;
        private System.Windows.Forms.DataGridView dgvTodosProdutos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAdicionar;
    }
}