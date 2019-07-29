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
    public class Pedido
    {
        private int num_pedido;
        private string num_comanda;
        private decimal valor_pedido;
        private string observacoes;
        private string quant_produto;
        private string num_mesa;
        private string cod_cliente;


        conectaBD BD = new conectaBD();

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


        public int AdicionarPedido()
        {
            int exOK = 0;
            try
            {

                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PRODUTO (num_comanda, quant_produto, observacoes) " +
                                        " values ('{0}','{1}','{2}')",
                                                  num_comanda, quant_produto, observacoes) +
                                                  "; SELECT SCOPE_IDENTITY();";

                exOK = BD.ExecutaComando(false);

                if (exOK > 0)
                {
                    MessageBox.Show("Pedido cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return exOK;
        }


        public void DeletarPedido()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM Pedido WHERE num_pedido = {0}", num_pedido);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pedido deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
    }
}
