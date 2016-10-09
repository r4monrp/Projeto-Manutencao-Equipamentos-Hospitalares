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
    public partial class Entrar : Form
    {
        public bool ativacao;
        public Entrar()
        {
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

        private void button_Equipe_Click(object sender, EventArgs e)
        {

            ativacao = true;
            Logar novo = new Logar(ativacao);
            this.Hide();
            if (novo.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void button_Visualizar_Click(object sender, EventArgs e)
        {

            ativacao = false;
            Principal novo= new Principal(ativacao);
            this.Hide();
            if (novo.ShowDialog() == DialogResult.OK)
            {  
            }
        }
    }
}
