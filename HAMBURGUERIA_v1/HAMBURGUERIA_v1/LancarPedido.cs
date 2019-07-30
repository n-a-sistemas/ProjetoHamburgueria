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

 
        private void txtQuantidade_Produto_TextChanged_1(object sender, EventArgs e)
        {
            Pedido PesquisaProduto = new Pedido();
            dgvProduto.DataSource = PesquisaProduto.PesquisaProduto(txtQuantidade_Produto.Text);
            dgvProduto.AutoResizeColumns();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            dgvPedido.Rows.Add(linha[0].Cells[1].Value.ToString(), linha[0].Cells[2].Value.ToString(),1);
        
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Pedido EnviarPedido = new Pedido();
            EnviarPedido.AdicionarPedido();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtObservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
