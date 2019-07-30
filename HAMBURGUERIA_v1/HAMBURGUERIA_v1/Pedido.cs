using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;


namespace HAMBURGUERIA_v1
{
    public class Pedido : Produto
    {
        private int num_pedido;
        private int num_comanda;
        private decimal valor_pedido;
        private string observacoes;
        private string quant_produto;
        private string num_mesa;
        private string cod_cliente;
        private string valor_por_item;
        private int quantidade_itens;
        private int num_item;


        conectaBD BD = new conectaBD();




        public int Num_item
        {
            get { return num_item; }
            set { num_item = value; }
        }


        public int Quantidade_itens
        {
            get { return quantidade_itens; }
            set { quantidade_itens = value; }
        }




        public int Num_pedido
        {
            get { return num_pedido; }
            set { num_pedido = value; }
        }

        public string Valor_por_item
        {
            get { return valor_por_item; }
        
            set { valor_por_item = value; }
        }


        public int Num_comanda
        {
            get { return num_comanda; }
            set { num_comanda = value; }
        }

        public decimal Valor_pedido
        {
            get { return valor_pedido; }
            set { valor_pedido = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public string Quant_produto
        {
            get { return quant_produto; }
            set { quant_produto = value; }
        }

        public string Num_mesa
        {
            get { return num_mesa; }
            set { num_mesa = value; }
        }

        public string Cod_cliente
        {
            get { return cod_cliente; }
            set { cod_cliente = value; }
        }


        public int AdicionarPedido()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PEDIDO (valor_pedido, observacoes,quant_produto) " +
                                        " values ('{0}','{1}','{2}')",
                                                  valor_pedido, observacoes,quant_produto) +
                                                  "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Pedido feito com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;




        }


        public int AdicionarItemPedido()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO ITEM_PEDIDO (cod_produto,valor_por_item,quantidade_itens) " +
                                        " values  ('{0}','{1}''{3}')",
                                                   Cod_produto, valor_por_item,quantidade_itens) +
                                                  ";SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Pedido foi cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;




        }









        public DataTable PesquisaProduto(String nome_pedido)
        {
            try
            {
                BD._sql = "SELECT p.cod_produto as 'Cod. Produto', p.nome_produto as 'Nome do Produto', p.valor_produto as 'Valor do Produto'" +
                           " FROM PRODUTO P" +
                            " LEFT JOIN BEBIDA B ON P.COD_PRODUTO = B.COD_PRODUTO " +
                            " LEFT JOIN COMIDA C ON P.COD_PRODUTO = C.COD_PRODUTO " +
                        " WHERE p.nome_produto LIKE '%" + nome_pedido + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }

    }
}
