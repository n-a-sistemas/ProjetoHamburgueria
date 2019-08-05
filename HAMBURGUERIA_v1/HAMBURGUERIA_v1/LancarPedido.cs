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
            Pedido PesquisaPedido = new Pedido();
            dgvProduto.DataSource = PesquisaPedido.PesquisaPedido(txtQuantidade_Produto.Text);
            dgvProduto.AutoResizeColumns();
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;
            MenuPrincipal menu = new MenuPrincipal();

            dgvPedido.Rows.Add(linha[0].Cells[0].Value.ToString(), linha[0].Cells[1].Value.ToString(), linha[0].Cells[2].Value.ToString(),nudQuantidade.Value);
            dgvPedido.AutoResizeColumns();


            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(linha[0].Cells[2].Value) * nudQuantidade.Value);
            txtQuantidade.Text = Convert.ToString(nudQuantidade.Value + Convert.ToDecimal(txtQuantidade.Text));
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);

            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(linha[0].Cells[2].Value) * nudQuantidade.Value);

        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
            Pedido EnviarPedido = new Pedido();
            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;


            ///Adicionar Pedido
            EnviarPedido.Observacoes = txtObservacoes.Text;
            EnviarPedido.Valor_pedido = Convert.ToDecimal(txtTotal.Text);
            EnviarPedido.Quant_produto = Convert.ToString(txtQuantidade.Text);
            EnviarPedido.Num_comanda =   txtComanda.Text;
            EnviarPedido.Status_comanda = true;

          EnviarPedido.AdicionarPedido();///
           //num_item = EnviarPedido.AdicionarItemPedido();

            SalvaItemPedido();

            this.Close();
         
        }
        private void SalvaItemPedido()
        {
            foreach (DataGridViewRow dataGridViewRow in dgvPedido.Rows)
            {
                Item_pedido item = new Item_pedido();




                if (dataGridViewRow.Cells[0].Value != null)
                {
                    item.Cod_produto = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
                    item.Valor_por_item = Convert.ToDecimal(dataGridViewRow.Cells[2].Value);
                    item.Quantidade_itens = Convert.ToInt32(dataGridViewRow.Cells[3].Value);
                    item.Num_comanda = txtComanda.Text;
                    

                    item.AdicionarItem();
                }
            }

        }

        private void txtComanda_TextChanged(object sender, EventArgs e)
        {

        }

        private void LancarPedido_Load(object sender, EventArgs e)
        {
            Pedido pedidos = new Pedido();



            if (txtComanda.Text != "")
            {
                pedidos.Id_comanda = Convert.ToInt32(txtComanda.Text);
                dgvComanda.DataSource = pedidos.PesquisaComanda();
                dgvPedido.Visible = false;
                dgvComanda.Visible = true;
                btnAdicionar.Visible = false;
                btnAdicionar2.Visible = true;
                dgvComanda.AutoResizeColumns();
                btnEnviar.Visible = false;
                btnCancelar.Text = "Voltar";
                btnRemover.Visible = false;
                btnRemover2.Visible = true;
               //txtObservacoes.Visible = false;
              //label4.Visible = false;
            }
            else
            {
                btnAdicionar.Visible = true;
                btnAdicionar2.Visible = false;
                btnRemover.Visible = true;
                btnRemover2.Visible = false;
               // txtObservacoes.Visible = true;
               // label4.Visible = true;
            }

            if (dgvComanda.Rows.Count > 0)
            {
                decimal valor_total = 0;
                int qtd_total = 0;

                foreach (DataGridViewRow dataGridViewRow in dgvComanda.Rows)
                {
                    valor_total = valor_total + Convert.ToDecimal(dataGridViewRow.Cells[1].Value) * Convert.ToDecimal(dataGridViewRow.Cells[2].Value);
                    qtd_total = qtd_total + Convert.ToInt32(dataGridViewRow.Cells[1].Value);
                }

                txtTotal.Text = valor_total.ToString();
                txtQuantidade.Text = qtd_total.ToString();
            }


        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar2_Click(object sender, EventArgs e)
        {
            Item_pedido ped = new Item_pedido();

            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;
                      
            ped.Cod_produto = Convert.ToInt32(linha[0].Cells[0].Value);
            ped.Valor_por_item = Convert.ToDecimal(linha[0].Cells[2].Value);
            ped.Quantidade_itens = Convert.ToInt32(nudQuantidade.Value);
            ped.Num_comanda = txtComanda.Text;
            dgvPedido.AutoResizeColumns();

            ped.AdicionarItem();

            Pedido pedido2 = new Pedido();
            pedido2.Id_comanda = Convert.ToInt32( txtComanda.Text);
            dgvComanda.DataSource = pedido2.PesquisaComanda();
            btnEnviar.Visible = false;

            decimal valor_total = 0;
            int qtd_total = 0;

            foreach (DataGridViewRow dataGridViewRow in dgvComanda.Rows)
            {
                valor_total = valor_total + Convert.ToDecimal(dataGridViewRow.Cells[1].Value) * Convert.ToDecimal(dataGridViewRow.Cells[2].Value);
                qtd_total = qtd_total + Convert.ToInt32(dataGridViewRow.Cells[1].Value);
            }

            txtTotal.Text = valor_total.ToString();
            txtQuantidade.Text = qtd_total.ToString();
        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvComanda.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Comanda não tem produtos cadastrados!");
            }
            else
            {

                Item_pedido ped = new Item_pedido();

                ped.Num_item = Convert.ToInt32(linha[0].Cells[3].Value);
                ped.RemoverItemPedido();
                Pedido pedido2 = new Pedido();
                pedido2.Id_comanda = Convert.ToInt32(txtComanda.Text);
                dgvComanda.DataSource = pedido2.PesquisaComanda();

                decimal valor_total = 0;
                int qtd_total = 0;

                foreach (DataGridViewRow dataGridViewRow in dgvComanda.Rows)
                {
                    valor_total = valor_total + Convert.ToDecimal(dataGridViewRow.Cells[1].Value) * Convert.ToDecimal(dataGridViewRow.Cells[2].Value);
                    qtd_total = qtd_total + Convert.ToInt32(dataGridViewRow.Cells[1].Value);
                }

                txtTotal.Text = valor_total.ToString();
                txtQuantidade.Text = qtd_total.ToString();
            }





        }

    }






    }
                
               

    

