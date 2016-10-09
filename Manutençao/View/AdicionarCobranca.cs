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
    public partial class AdicionarCobranca : Form
    {
        long CodigoExterno;
        public AdicionarCobranca()
        {
            InitializeComponent();
        }
        public AdicionarCobranca(long codigo)
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
            DialogResult result1 = MessageBox.Show("Deseja adicionar a cobrança?",
          "Cobrança",
          MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((maskedTextBox_DataC.Text != "") && (comboBox_ViaC.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.DataCobranca = maskedTextBox_DataC.Text;
                    ex.ViaCobranca = comboBox_ViaC.Text;
                    externo.AtualizarCob(ex);

                    MessageBox.Show("Cobrança Inserida com Sucesso");
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
