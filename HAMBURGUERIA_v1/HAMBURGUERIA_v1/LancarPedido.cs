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

        int comanda_pedido;
        int num_item;




        private void txtQuantidade_Produto_TextChanged_1(object sender, EventArgs e)
        {
            Pedido PesquisaProduto = new Pedido();
            dgvProduto.DataSource = PesquisaProduto.PesquisaProduto(txtQuantidade_Produto.Text);
            dgvProduto.AutoResizeColumns();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            dgvPedido.Rows.Add(linha[0].Cells[1].Value.ToString(), linha[0].Cells[2].Value.ToString(),nudQuantidade.Value);


            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(linha[0].Cells[2].Value) * nudQuantidade.Value);
            txtQuantidade.Text = Convert.ToString(nudQuantidade.Value + Convert.ToDecimal(txtQuantidade.Text));
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);

            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(linha[0].Cells[2].Value) * nudQuantidade.Value);

        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Pedido EnviarPedido = new Pedido();
            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;


            ///Adicionar Pedido
            EnviarPedido.Observacoes = txtObservacoes.Text;
            EnviarPedido.Valor_pedido = Convert.ToDecimal(txtTotal.Text);
            EnviarPedido.Quant_produto = Convert.ToString(txtQuantidade.Text);

            ///Adicionar Item pedido
            EnviarPedido.Num_item = num_item;
            EnviarPedido.Cod_produto = Convert.ToInt32(linha[0].Cells[0].Value.ToString());
            EnviarPedido.Valor_por_item = linha[0].Cells[2].Value.ToString();
            EnviarPedido.Quantidade_itens = Convert.ToInt32(nudQuantidade.Value);


            EnviarPedido.Num_comanda = comanda_pedido;


           comanda_pedido = EnviarPedido.AdicionarPedido();///
           num_item = EnviarPedido.AdicionarItemPedido();

            

            this.Close();
            

        }
     




    }
                
               

    
}
