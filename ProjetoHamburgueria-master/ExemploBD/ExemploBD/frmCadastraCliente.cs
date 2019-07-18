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
    public partial class frmCadastraCliente : Form
    {
        public frmCadastraCliente()
        {
            InitializeComponent();
        }

        public cl_Cliente cliente_carrega;

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cl_Cliente cliente = new cl_Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Dt_Nascimento = Convert.ToDateTime(txtNascimento.Text);
            cliente.Endereco = txtEndereco.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Id_estado = Convert.ToInt16( cmbUF.SelectedValue );
            cliente.Id_cidade = Convert.ToInt16(cmbCidade.SelectedValue);
            cliente.Cep = txtCEP.Text;
            cliente.Cpf = txtCPF.Text;
            cliente.Rg = txtRG.Text;
            cliente.Email = txtEmail.Text;

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(cliente.Adicionar());
            }
            else
            {
                cliente.IdCliente = Convert.ToInt32(txtID.Text);
                cliente.Atualizar();
            }
        }

        private void frmCadastraCliente_Load(object sender, EventArgs e)
        {
            cl_Cliente cliente = new cl_Cliente();
            cmbUF.DisplayMember = "SIGLA";
            cmbUF.ValueMember = "ID_ESTADO";
            cmbUF.DataSource = cliente.ListaUf();
            cmbUF.SelectedValue = 0;
        }

        private void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUF.SelectedIndex >= 0)
            {
                cl_Cliente cliente = new cl_Cliente();
                cliente.Id_estado = Convert.ToInt16( cmbUF.SelectedValue );
                cmbCidade.DisplayMember = "CIDADE";
                cmbCidade.ValueMember = "ID_CIDADE";
                cmbCidade.DataSource = cliente.ListaCidade();
                cmbCidade.SelectedValue = 0;
            }
        }

        private void frmCadastraCliente_Shown(object sender, EventArgs e)
        {
            if (cliente_carrega != null)
            {
                txtID.Text = cliente_carrega.IdCliente.ToString();
                txtNome.Text = cliente_carrega.Nome;
                txtCPF.Text = cliente_carrega.Cpf;
                txtRG.Text = cliente_carrega.Rg;
                txtBairro.Text = cliente_carrega.Bairro;
                txtCEP.Text = cliente_carrega.Cep;
                txtEndereco.Text = cliente_carrega.Endereco;
                txtEmail.Text = cliente_carrega.Email;
                txtNascimento.Text = cliente_carrega.Dt_Nascimento.ToShortDateString();
                if (cliente_carrega.Id_estado != null)
                {
                    cmbUF.SelectedValue = cliente_carrega.Id_estado;
                }

                if (cliente_carrega.Id_cidade != null)
                {
                    cmbCidade.SelectedValue = cliente_carrega.Id_cidade;
                }

                if (txtID.Text != "")
                {
                    btnSalvar.Text = "Atualizar";
                }
            }
        }
    }
}
