using System;
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
    public partial class Logar : Form
    {
        bool ativacao;
        public Logar()
        {
            InitializeComponent();
        }
        public Logar(bool ativar)
        {
            ativacao = ativar;
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            this.Close();
        }

        private void button_Entrar_Click(object sender, EventArgs e)
        {
            textBox_Usuario.ToString();
            textBox_Senha.ToString();
            if (((textBox_Usuario.Text == "manutencao") && (textBox_Senha.Text == "externa")) | ((textBox_Usuario.Text == "MANUTENCAO") && (textBox_Senha.Text == "EXTERNA")))
            {
                Principal novo = new Principal(ativacao);
                this.Hide();
                if (novo.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else MessageBox.Show("Você não possui acesso!");
        }

        private void Logar_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                {
                    Application.OpenForms[intIndex].Close();
                }
                    
            }
           
        }
        

        private void Logar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox_Usuario.ToString();
                textBox_Senha.ToString();
                if (((textBox_Usuario.Text == "manutencao") && (textBox_Senha.Text == "externa")) | ((textBox_Usuario.Text == "MANUTENCAO") && (textBox_Senha.Text == "EXTERNA")))
                {
                    Principal novo = new Principal(ativacao);
                    this.Hide();
                    if (novo.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
                else MessageBox.Show("Você não possui acesso!");
            }
        }
    }
}

