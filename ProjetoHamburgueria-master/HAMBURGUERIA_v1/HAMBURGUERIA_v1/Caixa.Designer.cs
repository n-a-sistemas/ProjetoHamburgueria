namespace HAMBURGUERIA_v1
{
    partial class Caixa
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
            this.txtNomeCaixa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCaixa = new System.Windows.Forms.TextBox();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCaixaLista = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSetaDireita = new System.Windows.Forms.Button();
            this.btnSetaEsquerda = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixaLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto:";
            // 
            // txtNomeCaixa
            // 
            this.txtNomeCaixa.Location = new System.Drawing.Point(111, 31);
            this.txtNomeCaixa.Name = "txtNomeCaixa";
            this.txtNomeCaixa.Size = new System.Drawing.Size(259, 20);
            this.txtNomeCaixa.TabIndex = 2;
            this.txtNomeCaixa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // txtTotalCaixa
            // 
            this.txtTotalCaixa.Location = new System.Drawing.Point(568, 365);
            this.txtTotalCaixa.Name = "txtTotalCaixa";
            this.txtTotalCaixa.ReadOnly = true;
            this.txtTotalCaixa.Size = new System.Drawing.Size(204, 20);
            this.txtTotalCaixa.TabIndex = 4;
            this.txtTotalCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Location = new System.Drawing.Point(84, 336);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(176, 21);
            this.cmbPagamento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pagamento:";
            // 
            // dgvCaixaLista
            // 
            this.dgvCaixaLista.AllowUserToAddRows = false;
            this.dgvCaixaLista.AllowUserToDeleteRows = false;
            this.dgvCaixaLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixaLista.Location = new System.Drawing.Point(15, 72);
            this.dgvCaixaLista.Name = "dgvCaixaLista";
            this.dgvCaixaLista.Size = new System.Drawing.Size(355, 243);
            this.dgvCaixaLista.TabIndex = 7;
            this.dgvCaixaLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(568, 415);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(97, 23);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "OK";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(677, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSetaDireita
            // 
            this.btnSetaDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSetaDireita.Location = new System.Drawing.Point(376, 139);
            this.btnSetaDireita.Name = "btnSetaDireita";
            this.btnSetaDireita.Size = new System.Drawing.Size(47, 47);
            this.btnSetaDireita.TabIndex = 11;
            this.btnSetaDireita.Text = "->";
            this.btnSetaDireita.UseVisualStyleBackColor = true;
            this.btnSetaDireita.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetaEsquerda
            // 
            this.btnSetaEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSetaEsquerda.Location = new System.Drawing.Point(376, 192);
            this.btnSetaEsquerda.Name = "btnSetaEsquerda";
            this.btnSetaEsquerda.Size = new System.Drawing.Size(47, 47);
            this.btnSetaEsquerda.TabIndex = 12;
            this.btnSetaEsquerda.Text = "<-";
            this.btnSetaEsquerda.UseVisualStyleBackColor = true;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(429, 72);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(359, 243);
            this.dgvCompra.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Operador:";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(84, 377);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(176, 20);
            this.txtFuncionario.TabIndex = 16;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnSetaEsquerda);
            this.Controls.Add(this.btnSetaDireita);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvCaixaLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPagamento);
            this.Controls.Add(this.txtTotalCaixa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCaixa);
            this.Controls.Add(this.label1);
            this.Name = "Caixa";
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixaLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCaixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalCaixa;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCaixaLista;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSetaDireita;
        private System.Windows.Forms.Button btnSetaEsquerda;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFuncionario;
    }
}