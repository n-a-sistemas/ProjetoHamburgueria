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
    class Produto
    {
        private int cod_produto;
        private string nome_produto;
        private decimal valor_produto;
        private string descricao_produto;

        conectaBD BD = new conectaBD();

        public int Cod_produto
        {
            get { return cod_produto; }
            set { cod_produto = value; }
        }


        public string Nome_produto
        {
            get { return nome_produto; }
            set { nome_produto = value; }
        }

        public decimal Valor_produto
        {
            get { return valor_produto; }
            set { valor_produto = value; }
        }

        public string Descricao_produto
        {
            get { return descricao_produto; }
            set { descricao_produto = value; }
        }

        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PRODUTO (nome_produto, valor_produto) " +
                                        " values ('{0}','{1}')",
                                                  nome_produto, valor_produto +
                                                  "; SELECT SCOPE_IDENTITY();");

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
