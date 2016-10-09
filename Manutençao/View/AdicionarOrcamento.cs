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

    public partial class AdicionarOrcamento : Form
    {
        long CodigoExterno;
        public AdicionarOrcamento()
        {
            InitializeComponent();
        }
        public AdicionarOrcamento(long codigo)
        {
            CodigoExterno = codigo;
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Adc_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja adicionar o orçamento?",
            "Orçamento Externo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((maskedTextBox_DataO.Text != "") && (maskedTextBox_NOrc.Text != "") && (maskedTextBox_Orcamento.Text != "") && (maskedTextBox_ValorO.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.DataOrcamento = maskedTextBox_DataO.Text;
                    ex.ValorOrcamento = maskedTextBox_ValorO.Text;
                    ex.Orcamento = maskedTextBox_Orcamento.Text;
                    ex.NOrcamento = maskedTextBox_NOrc.Text;
                    ex.Status = 3;
                    externo.AtualizarOrc(ex);

                    MessageBox.Show("Orçamento Inserido com Sucesso");
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

        private void toolStripButton_AdcArq_Click(object sender, EventArgs e)
        {
            openFileDialog_orc.ShowDialog();
           maskedTextBox_Orcamento.Text = (openFileDialog_orc.FileName);
        }
    }
    }

