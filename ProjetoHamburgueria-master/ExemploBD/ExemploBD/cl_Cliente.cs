using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;


namespace ExemploBD
{
    public class cl_Cliente
    {
        private int idCliente;
        private string nome;
        private DateTime dt_Nascimento;
        private string endereco;
        private int id_estado;
        private int id_cidade;
        private string bairro;
        private string cep;
        private string complemento;
        private string cpf;
        private string rg;
        private string email;


        conectaBD BD = new conectaBD();


        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value;}
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Dt_Nascimento
        {
            get { return dt_Nascimento; }
            set { dt_Nascimento = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public int Id_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        public int Id_cidade
        {
            get { return id_cidade; }
            set { id_cidade = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO CLIENTE (nome,dtnascimento,logradouro," +
                                                                  "id_estado,id_cidade,bairro,cep,complemento,cpf,rg,email) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", 
                                                  nome, dt_Nascimento.ToShortDateString(),endereco,
                                                  id_estado,id_cidade,bairro,cep,complemento,cpf,rg,email) +
                                                  "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

        }

        public void Listar()
        {
            //throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM CLIENTE WHERE IDCLIENTE = {0}", idCliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public void Atualizar()
        {
            try
            {
                int exOK = 0;

                BD._sql = String.Format("UPDATE CLIENTE SET NOME = '{0}', dtnascimento = '{1}', complemento = '{2}', logradouro = '{3}', id_estado = '{4}', id_cidade = '{5}', cep = '{6}', cpf = '{7}', rg = '{8}', email = '{9}', bairro = '{10} ' " +
                    " WHERE idcliente = {11}", nome, dt_Nascimento.ToShortDateString(), complemento, endereco, id_estado, id_cidade, cep, cpf, rg, email, bairro, idCliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable ListaSexos()
        {
            try
            {
                BD._sql = "SELECT id_sexo, nome FROM SEXO";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataTable PesquisaPorNome(String nome_pesquisa)
        {
            try
            {
                BD._sql = "SELECT C.idcliente as 'ID', C.nome as 'Nome', C.cpf as 'CPF', C.rg as 'RG', " +
                            " C.dtnascimento as 'Nascimento', C.logradouro as 'Endereço', c.cep, " +
                            " CID.CIDADE AS 'Cidade', E.SIGLA as 'UF', c.Bairro as 'Bairro', c.Complemento as 'Complemento', email as 'Email', c.ID_CIDADE, C.ID_ESTADO " +
                        " FROM CLIENTE C " +
                            " LEFT JOIN ESTADOS E ON C.ID_ESTADO = E.ID_ESTADO " +
                            " LEFT JOIN CIDADES CID ON C.ID_CIDADE = CID.ID_CIDADE " +
                        " WHERE C.nome LIKE '%" + nome_pesquisa + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }

        public DataTable ListaUf()
        {
            try
            {
                BD._sql = "SELECT ID_ESTADO, SIGLA FROM ESTADOS ORDER BY SIGLA";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ListaCidade()
        {
            try
            {
                BD._sql = "SELECT ID_CIDADE, CIDADE FROM CIDADES WHERE ID_ESTADO = " + id_estado.ToString() + " ORDER BY CIDADE";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
