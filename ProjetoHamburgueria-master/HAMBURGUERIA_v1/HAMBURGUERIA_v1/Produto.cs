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
    public class Produto
    {
        private int cod_produto;
        private string nome_produto;
        private decimal valor_produto;
        private string descricao_produto;
        private string descricao_comida;
        private string categoria_comida;
        private string tipo_bebida;
        private string quantidade_minima;
        private string quantidade_atual;


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

        public string Categoria_Comida
        {
            get { return categoria_comida; }
            set { categoria_comida = value; }
        }

        public string Descricao_Comida
        {
            get { return descricao_comida; }
            set { descricao_comida = value; }
        }

        public string Tipo_bebida
        {
            get { return tipo_bebida; }
            set { tipo_bebida = value; }
        }

        public string Quantidade_minima
        {
            get { return quantidade_minima; }
            set { quantidade_minima = value; }
        }
        public string Quantidade_atual
        {
            get { return quantidade_atual; }
            set { quantidade_atual = value; }
        }




        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PRODUTO (nome_produto, valor_produto) " +
                                        " values ('{0}','{1}')",
                                                  nome_produto, valor_produto) +
                                                  "; SELECT SCOPE_IDENTITY();";

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

        public void AdicionarComida()
        {

            try
            {
                int exOK = 0;
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO COMIDA (cod_produto,categoria_comida, descricao_comida) " +
                                        " values ({0},'{1}','{2}')",
                                                  cod_produto, categoria_comida, descricao_comida);


                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao cadastrar comida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Comida cadastrado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AdicionarBebida()
        {

            try
            {
                int exOK = 0;
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO BEBIDA (cod_produto,tipo_bebida, quantidade_minima,quantidade_atual) " +
                                        " values ({0},'{1}','{2}','{3}')",
                                                  cod_produto, tipo_bebida, quantidade_minima, quantidade_atual);


                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao cadastrar bebida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bebida cadastrada com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public DataTable PesquisaProduto(String nome_pesquisa)
        {
            try
            {
                BD._sql = "SELECT p.cod_produto as 'Cod. Produto', p.nome_produto as 'Nome do Produto', p.valor_produto as 'Valor do Produto', b.tipo_bebida as 'Categoria', " +
                            " b.quantidade_atual  as 'Quantidade no estoque', b.quantidade_minima as 'Quantidade minima'" +
                        " FROM BEBIDA B " +
                            " LEFT JOIN PRODUTO P ON B.COD_PRODUTO = P.COD_PRODUTO " +
                        " WHERE p.nome_produto LIKE '%" + nome_pesquisa + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }

        public DataTable PesquisaProdutoCaixa(String nome_caixa)
        {
            try
            {
                BD._sql = "SELECT p.cod_produto as 'Cod. Produto', p.nome_produto as 'Nome do Produto', p.valor_produto as 'Valor do Produto'" +
                           " FROM PRODUTO P" +
                            " LEFT JOIN BEBIDA B ON P.COD_PRODUTO = B.COD_PRODUTO " +
                            " LEFT JOIN COMIDA C ON P.COD_PRODUTO = C.COD_PRODUTO " +
                        " WHERE p.nome_produto LIKE '%" + nome_caixa + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }


        public void AtualizaProduto()
        {
            try
            {
                int exOK = 0;

                BD._sql = String.Format(new CultureInfo("en-US"), "UPDATE PRODUTO SET nome_produto = '{0}', valor_produto = '{1}'" +
                    " WHERE cod_produto = {2}", nome_produto, valor_produto, cod_produto);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Produto atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        public void AtualizaBebida()
        {
            try
            {
                int exOK = 0;

                BD._sql = String.Format(new CultureInfo("en-US"), "UPDATE BEBIDA SET tipo_bebida = '{0}', quantidade_atual = '{1}',quantidade_minima = '{2}'" +
                    " WHERE cod_produto = {3}", tipo_bebida, quantidade_atual, quantidade_minima, cod_produto);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bebida atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        public void DeletarBebida()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM BEBIDA WHERE cod_produto = {0}", cod_produto);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Bebida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bebida deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;


        }

        public void DeletarProduto()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM Produto WHERE cod_produto = {0}", cod_produto);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Produto deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
