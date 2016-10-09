using System;
using System.Collections.Generic;
using Persistencia.DAO;
using Persistencia.Modelo;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manutençao
{
    public partial class Principal : Form
    {
        bool ativacao;
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(bool ativar)
        {
            ativacao = ativar;
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            this.Close();
        }

        private void button_Fornec_Click(object sender, EventArgs e)
        {
            Fornecedores novo = new Fornecedores(ativacao);
            novo.ShowDialog();
        }

        private void button_Equip_Click(object sender, EventArgs e)
        {
            Equipamentos novo = new Equipamentos(ativacao);
            novo.ShowDialog();
        }

        private void button_Setor_Click(object sender, EventArgs e)
        {
            Setores novo = new Setores(ativacao);
            novo.ShowDialog();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AdicionarMan novo = new AdicionarMan(ativacao);
            novo.ShowDialog();
        }
        private void Principal_Activated(object sender, EventArgs e)
        {
            dataGridView_EmAberto.Rows.Clear();

            foreach (Externo externo in new ExternoDAO().Listar())
            {
                int index = dataGridView_EmAberto.Rows.Add();
                DataGridViewRow dado = dataGridView_EmAberto.Rows[index];
                if (externo.Status == 1)
                {
                    dado.Cells["Status"].Value = "Aguardando Retirada";
                    dado.Cells["Status"].Style.BackColor = Color.Orange;
                }
                if (externo.Status == 2)
                {
                    dado.Cells["Status"].Value = "Aguardando Orçamento";
                    dado.Cells["Status"].Style.BackColor = Color.Yellow;
                }
                if (externo.Status == 3)
                {
                    dado.Cells["Status"].Value  ="Aguardando Requisição";
                    dado.Cells["Status"].Style.BackColor = Color.Orchid;

                }
                if (externo.Status == 4)
                {
                    dado.Cells["Status"].Value = "Aguardando Aprovação";
                    dado.Cells["Status"].Style.BackColor = Color.DarkRed;
                }
                if (externo.Status == 5)
                {
                    dado.Cells["Status"].Value = "Aguardando Pedido de Compra";
                    dado.Cells["Status"].Style.BackColor = Color.Violet;
                }
                if (externo.Status == 6)
                {
                    dado.Cells["Status"].Value = "Aprovado - Aguardando Entrega";
                    dado.Cells["Status"].Style.BackColor = Color.GreenYellow;

                }
                Equipamento eq = new EquipamentoDAO().Buscar(externo.CodigoEquipamento);
                dado.Cells["Equipamento"].Value = eq.Descricao;
                dado.Cells["Código"].Value = externo.Codigo;
                Setor s = new SetorDAO().Buscar(externo.CodigoSetor);
                dado.Cells["Setor"].Value = s.Nome;
                dado.Cells["OS"].Value = externo.OS;
                Fornecedor f = new FornecedorDAO().Buscar(externo.CodigoFornecedor);
                dado.Cells["Fornecedor"].Value = f.Nome;
                if(externo.Orcamento == null)
                dado.Cells["CodExterno"].Value = externo.CodigoExterno;
            }

            dataGridView_Finalizados.Rows.Clear();

            foreach (Externo externof in new ExternoDAO().ListarF())
            {
                int index = dataGridView_Finalizados.Rows.Add();
                DataGridViewRow dado = dataGridView_Finalizados.Rows[index];
                dado.Cells["Entrega"].Value = externof.DataEntrega;
                dado.Cells["Entrega"].Style.BackColor = Color.Green;
                Equipamento eqp = new EquipamentoDAO().Buscar(externof.CodigoEquipamento);
                dado.Cells["EquipamentoF"].Value = eqp.Descricao;
                dado.Cells["CódigoF"].Value = externof.Codigo;
                Setor s = new SetorDAO().Buscar(externof.CodigoSetor);
                dado.Cells["SetorF"].Value = s.Nome;
                dado.Cells["OSF"].Value = externof.OS;
                Fornecedor forn = new FornecedorDAO().Buscar(externof.CodigoFornecedor);
                dado.Cells["FornecedorF"].Value = forn.Nome;
                dado.Cells["CodExternoF"].Value = externof.CodigoExterno;
            }
        }

        private void dataGridView_EmAberto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                EquipamentoManutenção novo = new EquipamentoManutenção(Int16.Parse(dataGridView_EmAberto.Rows[e.RowIndex].Cells["CodExterno"].Value.ToString()), ativacao);
                novo.ShowDialog();
            }
            
        }

        private void dataGridView_Finalizados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EquipamentoManutenção novo = new EquipamentoManutenção(Int16.Parse(dataGridView_Finalizados.Rows[e.RowIndex].Cells["CodExternoF"].Value.ToString()), ativacao);
                novo.ShowDialog();
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
        }
    }
    }

