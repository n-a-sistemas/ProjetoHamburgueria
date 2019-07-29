using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAMBURGUERIA_v1
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Produto pesquisa_produto = new Produto();
            dgvCaixaLista.DataSource = pesquisa_produto.PesquisaProdutoCaixa(txtNomeCaixa.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvCaixaLista.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Produto adicionado.", "Erro! Produto não foi adicionado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto produtoCaixa = new Produto();
            produtoCaixa.Cod_produto = Convert.ToInt32(linha[0].Cells[0].Value);
            produtoCaixa.Nome_produto = linha[0].Cells[1].Value.ToString();
            produtoCaixa.Valor_produto = Convert.ToInt32(linha[0].Cells[2].Value);

            
            //DataGridViewRow row = (DataGridViewRow)dgvCaixaLista.Rows[0].Clone();
           // row.Cells[0].Value = produtoCaixa.Cod_produto.Value;
           // row.Cells[1].Value = produtoCaixa.Nome_produto.Text;
           // row.Cells[2].Value = produtoCaixa.Valor_produto.Value;

            //dgvCompra.Rows.Add(row);
            //produtoCaixa.Cod_produto.SelectedValue = 0;
            //produtoCaixa.Nome_produto.Text = "";
            //produtoCaixa.Valor_produto.SelectedValue = 0;
        }
    }
}
