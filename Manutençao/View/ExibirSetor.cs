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
    public partial class ExibirSetor : Form
    {
        long Código;
        bool ativacao;
        public ExibirSetor()
        {
            InitializeComponent();
        }
        public ExibirSetor(long codigo,bool ativar)
        {
            Código = codigo;
            ativacao = ativar;
            InitializeComponent();
            Setor s = new SetorDAO().Buscar(Código);
            textBox_Nome.Text = s.Nome;
            textBox_CoordResp.Text = s.CoordResponsavel;
            textBox_EnfResp.Text = s.EnfResponsavel;
            if (ativacao == false)
            {
                button_Salvar.Visible = false;
            }
            if (ativacao == true)
            {
                button_Salvar.Visible = true;
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja salvar as alterações?",
           "Salvar alterações",
           MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((textBox_Nome.Text != "") && (textBox_EnfResp.Text != null) && (textBox_EnfResp.Text != null) && (textBox_CoordResp.Text != null))
                {
                    SetorDAO setor = new SetorDAO();
                    Setor s = new Setor();

                    s.Nome = textBox_Nome.Text;
                    s.EnfResponsavel = textBox_EnfResp.Text;
                    s.CoordResponsavel = textBox_CoordResp.Text;
                    s.CodigoSetor = Código;
                    setor.Atualizar(s);

                    MessageBox.Show("Atualização efetuada com sucesso!");
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
