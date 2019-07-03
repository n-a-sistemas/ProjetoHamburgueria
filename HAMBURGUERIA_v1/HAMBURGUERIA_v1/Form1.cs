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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalvar_produto_Click(object sender, EventArgs e)
        {

 

            Produto produto = new Produto();

            produto.Nome_produto = txtNome_produto.Text;
            produto.Valor_produto = Convert.ToDecimal(nudPreco_produto.Text) ;
            produto.Descricao_produto = txtDescricao_produto.Text;


            produto.Adicionar();



        }

    
        private void rdbComida_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdbComida.Checked) { 

            cmbCategoria.Visible = true;
                txtDescricao_produto.Visible = true;
                Label_Descrição.Visible = true;
                rdbEntrada_produtos.Visible = false;
                rdbEntrada_produtos.Checked = false;

            }

            else
            {
                cmbCategoria.Visible = false;
                txtDescricao_produto.Visible = false;
                Label_Descrição.Visible = false;
            }


        }

        private void rdbBebida_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbBebida.Checked)
            {
                cmbBebida.Visible = true;
                numericUpDown1.Visible = true;
                labelQuantidade_minima.Visible = true;
                rdbEntrada_produtos.Visible = true;
                nudEntrada_produto.Visible = false;
                labelQuantidade_maxima.Visible = false;
                txtQuantidade.Visible = false;





            }

            else
            {

                cmbBebida.Visible = false;
                numericUpDown1.Visible = false;
                labelQuantidade_minima.Visible = false;
                rdbEntrada_produtos.Visible = false;



            }


        }

        private void rdbEntrada_produtos_CheckedChanged(object sender, EventArgs e)
        {
           if (rdbEntrada_produtos.Checked)
            {

                nudEntrada_produto.Visible = true;
                labelQuantidade_maxima.Visible = true;
                txtQuantidade.Visible = true;


            }

           else
            {

                nudEntrada_produto.Visible = false;
                labelQuantidade_maxima.Visible = false;
                txtQuantidade.Visible = false;




            }
        }
    }
}

