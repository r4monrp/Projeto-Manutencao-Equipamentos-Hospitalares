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
    public partial class AdicionarAprovacao : Form
    {
        long CodigoExterno;
        public AdicionarAprovacao()
        {
            InitializeComponent();
        }
            public AdicionarAprovacao(long codigo)
        {
            CodigoExterno = codigo;
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AdcAprv_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja adicionar a aprovação?",
            "Aprovação Gestor",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((maskedTextBox_DataAp.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.DataAprovacao = maskedTextBox_DataAp.Text;
                    ex.Status = 5;
                    externo.AtualizarAprov(ex);

                    MessageBox.Show("Aprovação Inserida com Sucesso");
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
