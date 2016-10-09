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
    public partial class Novo_Setor : Form
    {
        public Novo_Setor()
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
                if ((textBox_Nome.Text != "") && (textBox_EnfResp.Text != "") && (textBox_EnfResp.Text != "") && (textBox_CoordResp.Text != ""))
                {
                    SetorDAO setor = new SetorDAO();
                    Setor s = new Setor();

                    Setor snome = new SetorDAO().BuscarNome(textBox_Nome.Text);
                    s.Nome = snome.Nome;
                    if (s.Nome != textBox_Nome.Text)
                    {
                         s.Nome = textBox_Nome.Text;
                        s.EnfResponsavel = textBox_EnfResp.Text;
                        s.CoordResponsavel = textBox_CoordResp.Text;
                        s.Status = 1;
                        setor.Inserir(s);

                        MessageBox.Show("Setor Inserido com Sucesso");
                        this.Close();
                       
                    }
                    else MessageBox.Show("Setor ja existente!");

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

