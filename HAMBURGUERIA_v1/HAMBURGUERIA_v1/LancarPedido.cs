﻿using System;
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
                dgvPedido.DataSource = pedidos.PesquisaComanda();
                dgvPedido.AutoResizeColumns();
            }

        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }






    }
                
               

    

