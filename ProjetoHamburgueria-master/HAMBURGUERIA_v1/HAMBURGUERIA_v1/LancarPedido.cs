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
    public partial class LancarPedido : Form
    {
        public LancarPedido()
        {
            InitializeComponent();
        }

        private void txtQuantidade_Produto_TextChanged(object sender, EventArgs e)
        {
            Produto pesquisa_produto = new Produto();
            dgvProduto.DataSource = pesquisa_produto.PesquisaProduto(txtQuantidade_Produto.Text);
            dgvProduto.AutoResizeColumns();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            dgvPedido.ColumnCount = 3;

            for (int i = 0; i < dgvProduto.Rows.Count; i++)
            {
                dgvPedido.Rows.Add(dgvProduto.Rows[i].Cells[0].Value,
                dgvProduto.Rows[i].Cells[1].Value,
                dgvProduto.Rows[i].Cells[2].Value);
            }
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvPedido.SelectedRows;
            dgvPedido.Rows.Remove(dgvPedido.Rows[0]);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Num_comanda = txtComanda.Text;
            pedido.Quant_produto = dgvPedido.Text;
            pedido.Observacoes = txtObservacoes.Text;
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
