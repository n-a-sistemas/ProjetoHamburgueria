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

namespace HAMBURGUERIA_v1
{
    public partial class MenuPrincipal : Form
    {
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
        }

        private void atualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque addProd = new Estoque();

            addProd.ShowDialog();
        }

        private void lançarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LancarPedido addProd = new LancarPedido();
            //addProd.WindowState = FormWindowState.Maximized;

            addProd.ShowDialog();
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caixa addProd = new Caixa();
            addProd.ShowDialog();
        }

        private void cadastrarComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atualizaTabela()
        {

        }

    }

    


}
