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
    public partial class AdicionarMan : Form
    {
        bool ativacao;
        public AdicionarMan()
        {
            InitializeComponent();
        }
        public AdicionarMan(bool ativar)
        {
            ativacao = ativar;
            InitializeComponent();
            foreach (Fornecedor fornecedor in new FornecedorDAO().Listar())
            {

                int index = comboBox_Fornecedor.Items.Add(fornecedor.Nome);
            }


            foreach (Equipamento equipamento in new EquipamentoDAO().Listar())
            {
                int index = comboBox_Equip.Items.Add(equipamento.Descricao);
            }

            foreach (Setor setor in new SetorDAO().Listar())
            {
                int index = comboBox_Setor.Items.Add(setor.Nome);
            }
            if (ativacao == false)
            {
                button_Adc.Visible = false;
            }
            if (ativacao == true)
            {
                button_Adc.Visible = true;
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Adc_Click(object sender, EventArgs e)
        {
                DialogResult result1 = MessageBox.Show("Deseja enviar o equipamento para manutenção?",
           "Manutenção Externa",
           MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((comboBox_Equip.Text != "") && (maskedTextBox_Codigo.Text != "") && (comboBox_Setor.Text != "") && (maskedTextBox_OS.Text != "") && (comboBox_Fornecedor.Text != "") && (maskedTextBox_Data.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    Equipamento eq = new EquipamentoDAO().BuscarNome(comboBox_Equip.Text);
                    ex.CodigoEquipamento = eq.CodigoEquipamento;

                    Setor s = new SetorDAO().BuscarNome(comboBox_Setor.Text);
                    ex.CodigoSetor = s.CodigoSetor;

                    Fornecedor f = new FornecedorDAO().BuscarNome(comboBox_Fornecedor.Text);
                    ex.CodigoFornecedor = f.CodigoFornecedor;
                    
                    ex.Codigo = maskedTextBox_Codigo.Text;
                    ex.OS = maskedTextBox_OS.Text;
                    ex.DataEntrada = maskedTextBox_Data.Text;
                    ex.Status = 1;
                    externo.Inserir(ex);

                    MessageBox.Show("Equipamento enviado com Sucesso");
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

