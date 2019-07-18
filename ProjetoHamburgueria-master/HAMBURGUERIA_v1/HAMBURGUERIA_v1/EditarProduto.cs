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
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();

        }


        public Produto produto_carrega;

    

        
      


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            
            Produto produto = new Produto();
            produto.Nome_produto = txtNome_produtoed.Text;
            produto.Valor_produto = Convert.ToDecimal(nudPreco_produto.Text);
            produto.Cod_produto =  Convert.ToInt32(txtCodProduto.Text);




            produto.AtualizaProduto();


            produto.Quantidade_minima = nudQuantidademinima.Text;
            produto.Quantidade_atual = nudQuantidade_entrando.Text;
            produto.Tipo_bebida = txtTipo.Text;


            produto.AtualizaBebida();

            this.Close();





        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {

            if (produto_carrega != null)
            {
                Produto pro = new Produto();
                txtCodProduto.Text = produto_carrega.Cod_produto.ToString();
                txtNome_produtoed.Text = produto_carrega.Nome_produto;
                nudPreco_produto.Value =  Convert.ToDecimal(produto_carrega.Valor_produto);
                txtTipo.Text = produto_carrega.Tipo_bebida;
                nudQuantidade_entrando.Value = Convert.ToInt32(produto_carrega.Quantidade_atual);
                nudQuantidademinima.Value = Convert.ToInt32(produto_carrega.Quantidade_minima);



             
            }

   

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }

        
    }
