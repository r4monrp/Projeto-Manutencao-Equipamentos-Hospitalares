using System;
using Persistencia.DAO;
using Persistencia.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manutençao
{
    public partial class Fornecedores : Form
    {
        bool ativacao;
        public Fornecedores()
        {
            InitializeComponent();
        }
        public Fornecedores(bool ativar)
        {
            ativacao = ativar;
            InitializeComponent();
            if (ativacao == false)
            {
                button_Novo.Visible = false;
            }
            if (ativacao == true)
            {
                button_Novo.Visible = true;
            }
        }
        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Novo_Click(object sender, EventArgs e)
        {
            NovoFornecedor novo = new NovoFornecedor();
            novo.ShowDialog();
        }

        private void Fornecedores_Activated(object sender, EventArgs e)
        {
            dataGridView_Fornecedores.Rows.Clear();

            foreach ( Fornecedor fornecedor in new FornecedorDAO().Listar())
            {
                int index = dataGridView_Fornecedores.Rows.Add();
                DataGridViewRow dado = dataGridView_Fornecedores.Rows[index];
                dado.Cells["Código"].Value = fornecedor.CodigoFornecedor;
                dado.Cells["Nome"].Value = fornecedor.Nome;
                dado.Cells["Contato"].Value = fornecedor.Contato;
                dado.Cells["Telefone"].Value = fornecedor.Telefone;
                dado.Cells["Email"].Value = fornecedor.Email;
            }
        }

        private void dataGridView_Fornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirFornecedor novo = new ExibirFornecedor(Int16.Parse(dataGridView_Fornecedores.Rows[e.RowIndex].Cells["Código"].Value.ToString()),ativacao);
            novo.ShowDialog();
        }
    }
}
