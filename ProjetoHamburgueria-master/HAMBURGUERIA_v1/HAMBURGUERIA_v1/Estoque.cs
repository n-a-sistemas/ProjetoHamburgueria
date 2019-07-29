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
            produto.Tipo_bebida = linha[0].Cells[3].Value.ToString();
            produto.Quantidade_atual = linha[0].Cells[4].Value.ToString();
            produto.Quantidade_minima = linha[0].Cells[5].Value.ToString();
           

            if (linha[0].Cells[4].Value.ToString() != "")
            {
                //produto.Cod_produto = Convert.ToInt32(linha[0].Cells[4].Value);
            }

            EditarProduto formulario = new EditarProduto();
            formulario.produto_carrega = produto;
            formulario.ShowDialog();
            txtBuscaProduto_TextChanged(sender, e);

        }

        private void dgvTodosProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha_selecionada = dgvTodosProdutos.SelectedRows;

            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
            }
            else
            {
                Produto delete_cliente = new Produto();
                delete_cliente.Cod_produto = Convert.ToInt32(linha_selecionada[0].Cells[0].Value.ToString());
                delete_cliente.DeletarBebida();
                delete_cliente.DeletarProduto();

                txtBuscaProduto_TextChanged(sender, e);
            }
                                                         
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form1 addProd = new Form1();

            addProd.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
