﻿using System;
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
    public partial class AdicionarRetirada : Form
    {
        long CodigoExterno;
        public AdicionarRetirada()
        {
            InitializeComponent();
        }
        public AdicionarRetirada(long codigo)
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
            DialogResult result1 = MessageBox.Show("Deseja adicionar retirada do equipamento?",
            "Retirada Fornecedor",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((maskedTextBox_DataRet.Text != ""))
                {
                    ExternoDAO externo = new ExternoDAO();
                    Externo ex = new Externo();

                    ex.CodigoExterno = CodigoExterno;
                    ex.DataSaida = maskedTextBox_DataRet.Text;
                    ex.Status = 2;
                    externo.AtualizarRetirada(ex);

                    MessageBox.Show("Retirada Inserida com Sucesso");
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

