using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Persistencia.DAO;
using Persistencia.Modelo;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manutençao
{
    public partial class AdicionarPed : Form
    {
        long CodigoExterno;
        public AdicionarPed()
        {
            InitializeComponent();
        }
        public AdicionarPed(long codigo)
        {
            CodigoExterno = codigo;
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AdcRet_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja adicionar o pedido?",
          "Pedido de Compra",
          MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((maskedTextBox_DataP.Text != "") && (maskedTextBox_PedP.Text != "") && (maskedTextBox_PedMO.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.DataPedido = maskedTextBox_DataP.Text;
                    ex.PedPecas = maskedTextBox_PedP.Text;
                    ex.PedMObra = maskedTextBox_PedMO.Text;
                    ex.DataPrevista = maskedTextBox_EntregaP.Text;
                    ex.Status = 6;
                    externo.AtualizarPed(ex);

                    MessageBox.Show("Pedido Inserido com Sucesso");
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
