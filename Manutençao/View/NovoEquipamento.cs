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
    public partial class NovoEquipamento : Form
    {
        public NovoEquipamento()
        {
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Adc_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja salvar o novo cadastro?",
           "Salvar novo cadastro",
           MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((textBox_Desc.Text!= ""))
                {
                    EquipamentoDAO equipamento = new EquipamentoDAO();
                    Equipamento eq = new Equipamento();

                    Equipamento eqnome = new EquipamentoDAO().BuscarNome(textBox_Desc.Text);
                    eq.Descricao = eqnome.Descricao;
                    if (eq.Descricao != textBox_Desc.Text)
                    {
                        eq.Descricao = textBox_Desc.Text;
                        eq.Status = 1;
                        equipamento.Inserir(eq);

                        MessageBox.Show("Equipamento Inserido com Sucesso");
                        this.Close();
                        
                    }
                    else MessageBox.Show("Equipamento já existente!");
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
    

