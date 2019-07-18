using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBD
{
    public partial class frmBuscaCliente : Form
    {
        public frmBuscaCliente()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastraCliente formulario = new frmCadastraCliente();
            formulario.ShowDialog();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            cl_Cliente pesquisa_cliente = new cl_Cliente();
            //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
            dgvCliente.DataSource = pesquisa_cliente.PesquisaPorNome(txtPesquisa.Text);
            dgvCliente.Columns[12].Visible = false;
            dgvCliente.Columns[13].Visible = false;
            dgvCliente.AutoResizeColumns();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgvCliente.SelectedRows;

            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
            }
            else
            {
                cl_Cliente delete_cliente = new cl_Cliente();
                delete_cliente.IdCliente = Convert.ToInt32(linha_selecionada[0].Cells[0].Value.ToString());
                delete_cliente.Deletar();
                txtPesquisa_TextChanged(sender, e);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvCliente.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 cliente para editar", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cl_Cliente cliente = new cl_Cliente();
            cliente.IdCliente = Convert.ToInt32(linha[0].Cells[0].Value);
            cliente.Nome = linha[0].Cells[1].Value.ToString();
            cliente.Cpf = linha[0].Cells[2].Value.ToString();
            cliente.Rg = linha[0].Cells[3].Value.ToString();
            cliente.Dt_Nascimento = Convert.ToDateTime(linha[0].Cells[4].Value.ToString());
            cliente.Endereco = linha[0].Cells[5].Value.ToString();
            cliente.Bairro = linha[0].Cells[9].Value.ToString();
            cliente.Cep = linha[0].Cells[6].Value.ToString();
            cliente.Complemento = linha[0].Cells[10].Value.ToString();
            cliente.Email = linha[0].Cells[11].Value.ToString();

            if (linha[0].Cells[12].Value.ToString() != "")
            {
                cliente.Id_cidade = Convert.ToInt32(linha[0].Cells[12].Value);
            }

            if (linha[0].Cells[13].Value.ToString() != "")
            {
                cliente.Id_estado = Convert.ToInt32(linha[0].Cells[13].Value);
            }

            frmCadastraCliente formulario = new frmCadastraCliente();
            formulario.cliente_carrega = cliente;
            formulario.ShowDialog();
            txtPesquisa_TextChanged(sender, e);
        }

        private void frmBuscaCliente_Shown(object sender, EventArgs e)
        {

        }
    }
}
