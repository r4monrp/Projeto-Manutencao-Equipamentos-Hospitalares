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
    public partial class NovoFornecedor : Form
    {
        public NovoFornecedor()
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
                if ((textBox_Nome.Text != "") && (textBox_Contato.Text != "") &&  (textBox_Email.Text!= ""))
                {
                    FornecedorDAO fornecedor = new FornecedorDAO();
                    Fornecedor f = new Fornecedor();

                    Fornecedor fnome = new FornecedorDAO().BuscarNome(textBox_Nome.Text);
                    f.Nome = fnome.Nome;

                    if (f.Nome != textBox_Nome.Text)
                    {
                        f.Nome = textBox_Nome.Text;
                        f.Contato = textBox_Contato.Text;
                        f.Telefone = maskedtextBox_Tel.Text;
                        f.Email = textBox_Email.Text;
                        f.Status = 1;
                        fornecedor.Inserir(f);

                        MessageBox.Show("Fornecedor Inserido com Sucesso");
                        this.Close();

                    }
                    else MessageBox.Show("Fornecedor já existe!");

                    
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

