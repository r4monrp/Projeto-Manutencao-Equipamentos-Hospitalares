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
    public partial class ExibirEquipamento : Form
    {
        long Código;
        bool ativacao;
        public ExibirEquipamento()
        {
            InitializeComponent();
        }
        public ExibirEquipamento(long codigo,bool ativar)
        {
            Código = codigo;
            ativacao = ativar;
            InitializeComponent();
            Equipamento equipamento = new EquipamentoDAO().Buscar(Código);
            textBox_Desc.Text = equipamento.Descricao;
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
                if ((textBox_Desc.Text != ""))
                {
                    EquipamentoDAO equipamento = new EquipamentoDAO();
                    Equipamento eq = new Equipamento();

                    eq.Descricao = textBox_Desc.Text;
                    eq.CodigoEquipamento = Código;
                    equipamento.Atualizar(eq);

                    MessageBox.Show("Alterações efetuadas com sucesso!");
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
