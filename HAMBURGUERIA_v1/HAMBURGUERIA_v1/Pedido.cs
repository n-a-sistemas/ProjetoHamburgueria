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
        private string num_comanda;
        private decimal valor_pedido;
        private string observacoes;
        private string quant_produto;
        private string num_mesa;
        private string cod_cliente;
        private bool status_comanda;
        private byte status2;



        conectaBD BD = new conectaBD();


        public byte Status2
        {
            get { return status2; }
            set { status2 = value; }

        }



        public bool Status_comanda
        {
            get { return status_comanda; }
            set { status_comanda = value; }
        }

        public int Num_pedido
        {
            get { return num_pedido; }
            set { num_pedido = value; }
        }

        public string Num_comanda
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


        public void AdicionarPedido()
        {
            int exOK = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PEDIDO (num_comanda,valor_pedido, observacoes,quant_produto,status_comanda) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}')",
                                                num_comanda,valor_pedido, observacoes,quant_produto,status_comanda);

                exOK = BD.ExecutaComando(false);

                if (exOK > 0)
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
        }

        public DataTable PesquisaComandasAbertas()
        {
            try
            {
                BD._sql = "SELECT num_comanda FROM pedido WHERE status_comanda = 1";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
