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
    class Item_pedido
    {
        private int quantidade_itens;
        private int num_item;
        private decimal valor_por_item;
        private string num_comanda;
        private int cod_produto;


        conectaBD BD = new conectaBD();


        public int Quantidade_itens
        {
            get { return quantidade_itens; }
            set { quantidade_itens = value; }
        }

        public int Num_item
        {
            get { return num_item; }
            set { num_item = value; }
        }

        public decimal Valor_por_item
        {
            get { return valor_por_item; }
            set { valor_por_item = value; }
        }

        public string Num_comanda
        {
            get { return num_comanda; }
            set { num_comanda = value; }
        }

        public int Cod_produto
        {
            get { return cod_produto; }
            set { cod_produto = value; }
        }

        public int AdicionarItem()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"),
                    "INSERT INTO item_pedido (cod_produto, quantidade_itens, valor_por_item, num_comanda) " +
                    " values ({0},'{1}','{2}','{3}')",
                    Cod_produto, quantidade_itens, valor_por_item, num_comanda) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Item pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        public void RemoverItemPedido()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM ITEM_PEDIDO WHERE num_item = {0}", num_item);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
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
