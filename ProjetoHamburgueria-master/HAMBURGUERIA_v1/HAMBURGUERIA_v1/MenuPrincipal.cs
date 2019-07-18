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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 addProd = new Form1();

            addProd.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque addProd = new Estoque();

            addProd.ShowDialog();
        }

        private void lançarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido addProd = new Pedido();

            addProd.ShowDialog();
        }
    }
}
