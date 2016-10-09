using System;
using System.Collections.Generic;
using System.ComponentModel;
using Persistencia.DAO;
using Persistencia.Modelo;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manutençao
{
    public partial class ExibirFornecedor : Form
    {
        long Código;
        bool ativacao;
        public ExibirFornecedor()
        {
            InitializeComponent();
        }
        public ExibirFornecedor(long codigo,bool ativar)
        {
            Código = codigo;
            ativacao = ativar;
            InitializeComponent();
            Fornecedor f = new FornecedorDAO().Buscar(Código);
            textBox_Nome.Text = f.Nome;
            maskedtextBox_Tel.Text = f.Telefone;
            textBox_Email.Text = f.Email;
            textBox_Contato.Text = f.Contato;
            if (ativacao == false)
            {
                button_Salvar.Visible = false;
            }
            if (ativacao == true)
            {
                button_Salvar.Visible = true;
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja salvar as alterações?",
            "Salvar alterações",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((textBox_Nome.Text != "") && (textBox_Contato.Text != null) && (maskedtextBox_Tel.Text != null) && (textBox_Email.Text != null))
                {
                    FornecedorDAO fornecedor = new FornecedorDAO();
                    Fornecedor f = new Fornecedor();

                    f.Nome = textBox_Nome.Text;
                    f.Contato = textBox_Contato.Text;
                    f.Telefone = maskedtextBox_Tel.Text;
                    f.Email = textBox_Email.Text;
                    f.CodigoFornecedor = Código;
                    fornecedor.Atualizar(f);

                    MessageBox.Show("Alterações Efetuadas com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }
    }
}
