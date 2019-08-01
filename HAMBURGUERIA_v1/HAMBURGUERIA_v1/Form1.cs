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




        int id_produto;
        

        private void BtnSalvar_produto_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
            Produto produto = new Produto();

            produto.Nome_produto = txtNome_produto.Text;
            produto.Valor_produto = Convert.ToDecimal(nudPreco_produto.Text) ;
            produto.Descricao_produto = txtDescricao_produto.Text;
          
            id_produto = produto.Adicionar();

            if (rdbComida.Checked)
            {
                Adiciona_Comida();

            }
            else
            {
                Adiciona_Bebida();
            }

            LimpaCampos();
            

        }


        private void Adiciona_Comida()
        {
            Produto produto = new Produto();
            produto.Cod_produto = id_produto;
            produto.Categoria_Comida = cmbCategoria.Text;
            produto.Descricao_Comida = txtDescricao_produto.Text;
            produto.AdicionarComida();
        }

        private void Adiciona_Bebida()
        {
            Produto produto = new Produto();
            produto.Cod_produto = id_produto;
            produto.Quantidade_minima = nudQuantidademinima.Text;
            produto.Quantidade_atual = nudQuantidade_entrando.Text;
            produto.Tipo_bebida = cmbBebida.Text;
            produto.AdicionarBebida();

        }


    
        private void rdbComida_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdbComida.Checked) { 

            cmbCategoria.Visible = true;
                txtDescricao_produto.Visible = true;
                Label_Descrição.Visible = true;           
                nudQuantidademinima.Value = nudQuantidademinima.Minimum;
                nudQuantidade_entrando.Value = nudQuantidade_entrando.Minimum;


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
                nudQuantidademinima.Visible = true;
                nudQuantidade_entrando.Visible = true;
                Quantidade_entrando.Visible = true;
                nudPreco_produto.Visible = true;
                labelQuantidade_minima.Visible = true;
                txtDescricao_produto.Clear();
              






            }

            else
            {

                cmbBebida.Visible = false;
                nudQuantidademinima.Visible = false;
                nudQuantidade_entrando.Visible = false;
                Quantidade_entrando.Visible = false;

                labelQuantidade_minima.Visible = false;
         



            }


        }

        private void rdbEntrada_produtos_CheckedChanged(object sender, EventArgs e)
        {
        


        



        }
        private void LimpaCampos()
        {
            txtNome_produto.Clear();
            nudPreco_produto.Value = nudPreco_produto.Minimum;
            cmbBebida.SelectedValue = 0;
            cmbCategoria.SelectedValue = 0;
            nudQuantidademinima.Value = nudQuantidademinima.Minimum;
            txtDescricao_produto.Clear();
            rdbComida.Checked = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
            this.Close();
        }

        private void txtNome_produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label_Descrição_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Recarrega();
        }
    }
}

