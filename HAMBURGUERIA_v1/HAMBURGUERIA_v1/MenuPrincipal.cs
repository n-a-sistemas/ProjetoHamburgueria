﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace HAMBURGUERIA_v1
{
    public partial class MenuPrincipal : Form
    {
        int botao = 0;
        int id_comanda;
        conectaBD BD = new conectaBD();

        public MenuPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 addProd = new Form1();

            addProd.ShowDialog();
            Recarrega();
        }

        private void atualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque addProd = new Estoque();

            addProd.ShowDialog();
            Recarrega();
        }

        private void lançarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LancarPedido addProd = new LancarPedido();
            

            addProd.ShowDialog();
            Recarrega();
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caixa addProd = new Caixa();
            addProd.ShowDialog();
            Recarrega();
        }

        private void cadastrarComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recarrega();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            RecarregaComandas();
        }

        private void RecarregaComandas()
        {
            Pedido comanda = new Pedido();

            DataTable dt = comanda.PesquisaComandasAbertas();

            foreach (DataRow linha in dt.Rows)
            {
                botao = botao + 1;
                id_comanda = Convert.ToInt32(linha[0].ToString());

                if (botao == 1)
                {
                    button1.Text = id_comanda.ToString();
                    button1.Visible = true;
                }

                if (botao == 2)
                {
                    button2.Text = id_comanda.ToString();
                    button2.Visible = true;
                }

                if (botao == 3)
                {
                    button3.Text = id_comanda.ToString();
                    button3.Visible = true;
                }

                if (botao == 4)
                {
                    button4.Text = id_comanda.ToString();
                    button4.Visible = true;
                }

                if (botao == 5)
                {
                    button5.Text = id_comanda.ToString();
                    button5.Visible = true;
                }

                if (botao == 6)
                {
                    button6.Text = id_comanda.ToString();
                    button6.Visible = true;
                }

                if (botao == 7)
                {
                    button7.Text = id_comanda.ToString();
                    button7.Visible = true;
                }

                if (botao == 8)
                {
                    button8.Text = id_comanda.ToString();
                    button8.Visible = true;
                }

                if (botao == 9)
                {
                    button9.Text = id_comanda.ToString();
                    button9.Visible = true;
                }

                if (botao == 10)
                {
                    button10.Text = id_comanda.ToString();
                    button10.Visible = true;
                }

                if (botao == 11)
                {
                    button11.Text = id_comanda.ToString();
                    button11.Visible = true;
                }

                if (botao == 12)
                {
                    button12.Text = id_comanda.ToString();
                    button12.Visible = true;
                }

                if (botao == 13)
                {
                    button13.Text = id_comanda.ToString();
                    button13.Visible = true;
                }

                if (botao == 14)
                {
                    button14.Text = id_comanda.ToString();
                    button14.Visible = true;
                }

                if (botao == 15)
                {
                    button15.Text = id_comanda.ToString();
                    button15.Visible = true;
                }
            }

        }

        private void Recarrega_botao()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

            botao = 0;
        }

        public void Recarrega()
        {
            Recarrega_botao();
            RecarregaComandas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button1.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button2.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button3.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button4.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button5.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button6.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button7.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button8.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button9.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button10.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button11.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button12.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button13.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button14.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button15.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button16.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button25.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button24.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button23.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button22.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                LancarPedido addProd = new LancarPedido();
                addProd.txtComanda.Text = button21.Text;
                addProd.ShowDialog();
                Pedido pedidos = new Pedido();
                pedidos.Id_comanda = Convert.ToInt32(addProd.txtComanda.Text);
            }
        }
        
            
       
    }
    }

    



