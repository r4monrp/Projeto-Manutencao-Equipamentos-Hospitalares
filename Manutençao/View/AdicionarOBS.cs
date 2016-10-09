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
    public partial class AdicionarOBS : Form
    {
        long CodigoExterno;
        string Observacoes;
        public AdicionarOBS()
        {
            InitializeComponent();
        }
        public AdicionarOBS(long codigo,string obs)
        {
            CodigoExterno = codigo;
            Observacoes = obs;
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Adc_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja adicionar a observação?",
         "Observações",
         MessageBoxButtons.OKCancel,
         MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((textBox_OBS.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.Observacoes = textBox_OBS.Text;
                    externo.AtualizarObs(ex);

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

        private void AdicionarOBS_Load(object sender, EventArgs e)
        {
            textBox_OBS.Text = Observacoes;
        }
    }
}
