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
    public partial class Setores : Form
    {
        bool ativacao;
        public Setores()
        {
            InitializeComponent();
        }
        public Setores(bool ativar)
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
            Novo_Setor novo = new Novo_Setor();
            novo.ShowDialog();
        }

        private void Setores_Activated(object sender, EventArgs e)
        {
            dataGridView_Setor.Rows.Clear();

            foreach (Setor setor in new SetorDAO().Listar())
            {
                int index = dataGridView_Setor.Rows.Add();
                DataGridViewRow dado = dataGridView_Setor.Rows[index];
                dado.Cells["Código"].Value = setor.CodigoSetor;
                dado.Cells["Setor"].Value = setor.Nome;
                dado.Cells["EnfResponsavel"].Value = setor.EnfResponsavel;
                dado.Cells["CoordResponsavel"].Value = setor.CoordResponsavel;
            }
        }

        private void dataGridView_Setor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirSetor novo = new ExibirSetor(Int16.Parse(dataGridView_Setor.Rows[e.RowIndex].Cells["Código"].Value.ToString()),ativacao);
            novo.ShowDialog();
        }
    }
    }

