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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void txtBuscaProduto_TextChanged(object sender, EventArgs e)
        {
            Produto pesquisa_produto = new Produto();
            dgvTodosProdutos.DataSource = pesquisa_produto.PesquisaProduto(txtBuscaProduto.Text);
            dgvTodosProdutos.AutoResizeColumns();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha = dgvTodosProdutos.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 produto para editar", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto  produto = new Produto();
            produto.Cod_produto = Convert.ToInt32(linha[0].Cells[0].Value);
            produto.Nome_produto= linha[0].Cells[1].Value.ToString();
            produto.Valor_produto = Convert.ToInt32(linha[0].Cells[2].Value);
            produto.Quantidade_atual = linha[0].Cells[3].Value.ToString();
            produto.Quantidade_minima = linha[0].Cells[4].Value.ToString();
           

            if (linha[0].Cells[12].Value.ToString() != "")
            {
                produto.Cod_produto = Convert.ToInt32(linha[0].Cells[12].Value);
            }

            EditarProduto formulario = new EditarProduto();
            formulario.ShowDialog();
            txtBuscaProduto_TextChanged(sender, e);







        }

        private void dgvTodosProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
