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
    public partial class AdicionarEntrega : Form
    {
        long CodigoExterno;
        public AdicionarEntrega()
        {
            InitializeComponent();
        }
        public AdicionarEntrega(long codigo)
        {
            CodigoExterno = codigo;
            InitializeComponent();
        }
        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AdcEntrega_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja adicionar entrega do equipamento?",
            "Entrega de Equipamento",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((maskedTextBox_EntrData.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.DataEntrega = maskedTextBox_EntrData.Text;
                    ex.Status = 9;
                    externo.AtualizarEnt(ex);

                    MessageBox.Show("Entrega Inserida com Sucesso");
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
