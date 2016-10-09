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
    public partial class Equipamentos : Form
    {
        bool ativacao;
        public Equipamentos()
        {
            InitializeComponent();
        }
        public Equipamentos(bool ativar)
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
            NovoEquipamento novo = new NovoEquipamento();
            novo.ShowDialog();
        }

        private void Equipamentos_Activated(object sender, EventArgs e)
        {
            dataGridView_Equipamentos.Rows.Clear();

            foreach (Equipamento equipamento in new EquipamentoDAO().Listar())
            {
                int index = dataGridView_Equipamentos.Rows.Add();
                DataGridViewRow dado = dataGridView_Equipamentos.Rows[index];
                dado.Cells["Código"].Value = equipamento.CodigoEquipamento;
                dado.Cells["Descrição"].Value = equipamento.Descricao;             
            }
        }

        private void dataGridView_Equipamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirEquipamento novo = new ExibirEquipamento(Int16.Parse(dataGridView_Equipamentos.Rows[e.RowIndex].Cells["Código"].Value.ToString()),ativacao);
            novo.ShowDialog();
        }
    }
}
