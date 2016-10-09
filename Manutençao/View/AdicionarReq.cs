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
    public partial class AdicionarReq : Form
    {
        long CodigoExterno;
        public AdicionarReq()
        {
            InitializeComponent();
        }
        public AdicionarReq(long codigo)
        {
            CodigoExterno = codigo;
            InitializeComponent();
        }

        private void button_Adc_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja adicionar a requisição?",
           "Requisição",
           MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((maskedTextBox_Datareq.Text != "") && (maskedTextBox_ReqP.Text != "") && (maskedTextBox_ReqMO.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.DataRequisicao = maskedTextBox_Datareq.Text;
                    ex.ReqPecas = maskedTextBox_ReqP.Text;
                    ex.ReqMObra= maskedTextBox_ReqMO.Text;
                    ex.Status = 4;
                    externo.AtualizarReq(ex);

                    MessageBox.Show("Requisição Inserida com Sucesso");
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

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

