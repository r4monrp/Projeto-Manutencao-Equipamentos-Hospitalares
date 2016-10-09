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
    public partial class EquipamentoManutenção : Form
    {
        long Código;
        string CaminhoOrc;
        bool ativacao;
        string obs;
        public EquipamentoManutenção()
        {
            InitializeComponent();
        }
        public EquipamentoManutenção(long codigo,bool ativar)
        {
            Código = codigo;
            ativacao = ativar;
            InitializeComponent();
            if (ativacao == false)
            {
                button_AdcAprv.Visible = false;
                button_AdcOrcamento.Visible = false;
                button_AdcPed.Visible = false;
                button_AdcRetirada.Visible = false;
                button_Entrega.Visible = false;
                button_Req.Visible = false;
                toolStrip_Cobranca.Visible = false;
                toolStrip_Obs.Visible = false;
            }
            if (ativacao == true)
            {
                button_AdcAprv.Visible = true;
                button_AdcOrcamento.Visible = true;
                button_AdcPed.Visible = true;
                button_AdcRetirada.Visible = true;
                button_Entrega.Visible = true;
                button_Req.Visible = true;
                toolStrip_Cobranca.Visible = true;
            }

            Externo externo = new ExternoDAO().Buscar(Código);

            Equipamento eq = new EquipamentoDAO().Buscar(externo.CodigoEquipamento);
            maskedTextBox_Equip.Text = eq.Descricao;

            Setor s = new SetorDAO().Buscar(externo.CodigoSetor);
            maskedTextBox_Setor.Text = s.Nome;
            maskedTextBox_Aprovador.Text = s.CoordResponsavel;

           Fornecedor f = new FornecedorDAO().Buscar(externo.CodigoFornecedor);
            maskedTextBox_Fornecedor.Text = f.Nome;

            if (externo.Status == 1)
            {
                maskedTextBox_Status.Text = "Aguardando Retirada";
                maskedTextBox_Status.BackColor = Color.Orange;
            }
            if (externo.Status == 2)
            {
                maskedTextBox_Status.Text = "Aguardando Orçamento";
                maskedTextBox_Status.BackColor = Color.Yellow;
            }
            if (externo.Status == 3)
            {
                maskedTextBox_Status.Text = "Aguardando Requisição";
                maskedTextBox_Status.BackColor = Color.Orchid;
            }
            if (externo.Status == 4)
            {
                maskedTextBox_Status.Text = "Aguardando Aprovação";
                maskedTextBox_Status.BackColor = Color.Red;
            }
            if (externo.Status == 5)
            {
                maskedTextBox_Status.Text = "Aguardando Pedido de Compra";
                maskedTextBox_Status.BackColor = Color.Violet;
            }
            if (externo.Status == 6)
            {
                maskedTextBox_Status.Text = "Aprovado - Aguardando Entrega";
                maskedTextBox_Status.BackColor = Color.GreenYellow;
            }
            if (externo.Status == 9)
            {
                maskedTextBox_Status.Text = "Entregue";
                maskedTextBox_Status.BackColor = Color.Green;
                    button_AdcAprv.Visible = false;
                    button_AdcOrcamento.Visible = false;
                    button_AdcPed.Visible = false;
                    button_AdcRetirada.Visible = false;
                    button_Entrega.Visible = false;
                    button_Req.Visible = false;
                    toolStrip_Cobranca.Visible = false;
            }
            maskedTextBox_OS.Text = externo.OS;
            maskedTextBox_Codigo.Text = externo.Codigo;
            maskedTextBox_DataEnt.Text= externo.DataEntrada;
            maskedTextBox_DataRet.Text= externo.DataSaida;
            maskedTextBox_DataO.Text = externo.DataOrcamento;
            maskedTextBox_O.Text= externo.NOrcamento;
            maskedTextBox_ValorO.Text= externo.ValorOrcamento;
            maskedTextBox_Datareq.Text= externo.DataRequisicao;
            maskedTextBox_ReqP.Text= externo.ReqPecas;
            maskedTextBox_ReqMO.Text= externo.ReqMObra;
            maskedTextBox_DataAp.Text= externo.DataAprovacao;
            maskedTextBox_DataP.Text= externo.DataPedido;
            maskedTextBox_PedP.Text= externo.PedPecas;
            maskedTextBox_PedMO.Text= externo.PedMObra;
            maskedTextBox_EntregaP.Text= externo.DataPrevista;
            maskedTextBox_DataC.Text= externo.DataCobranca;
            maskedTextBox_ViaC.Text= externo.ViaCobranca;
            maskedTextBox_EntrData.Text= externo.DataEntrega;
            textBox_OBS.Text= externo.Observacoes;
            obs = externo.Observacoes;
            CaminhoOrc = externo.Orcamento;
            if (externo.Orcamento == null)
            {
                maskedTextBox_O.Text = "Não Recebido";
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button_AdcOrcamento_Click(object sender, EventArgs e)
        {
                AdicionarOrcamento novo = new AdicionarOrcamento(Código);
                novo.ShowDialog();
        }

        private void button_AdcRetirada_Click(object sender, EventArgs e)
        {
                AdicionarRetirada novo = new AdicionarRetirada(Código);
                novo.ShowDialog();
        }

        private void toolStripButton_ArqOrc_Click(object sender, EventArgs e)
        {
            openFileDialog_Orc.FileName = CaminhoOrc;
            if (CaminhoOrc != null)
            {
                System.Diagnostics.Process.Start(openFileDialog_Orc.FileName);
            }
            else MessageBox.Show("Nenhum arquivo localizado!");
            
        }

        private void button_AdcAprv_Click(object sender, EventArgs e)
        {

            AdicionarAprovacao novo = new AdicionarAprovacao(Código);
            novo.ShowDialog();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarReq novo = new AdicionarReq(Código);
            novo.ShowDialog();
        }

        private void button_AdcPed_Click(object sender, EventArgs e)
        {
            AdicionarPed novo = new AdicionarPed(Código);
            novo.ShowDialog();
        }

        private void button_Entrega_Click(object sender, EventArgs e)
        {
            AdicionarEntrega novo = new AdicionarEntrega(Código);
            novo.ShowDialog();
        }

        private void toolStripButton_AdcCob_Click(object sender, EventArgs e)
        {
            AdicionarCobranca novo = new AdicionarCobranca(Código);
            novo.ShowDialog();
        }

        private void toolStripButton_Obs_Click(object sender, EventArgs e)
        {
            AdicionarOBS novo = new AdicionarOBS(Código,obs);
            novo.ShowDialog();
        }

        private void EquipamentoManutenção_Activated(object sender, EventArgs e)
        {
            Externo externo = new ExternoDAO().Buscar(Código);

            Equipamento eq = new EquipamentoDAO().Buscar(externo.CodigoEquipamento);
            maskedTextBox_Equip.Text = eq.Descricao;

            Setor s = new SetorDAO().Buscar(externo.CodigoSetor);
            maskedTextBox_Setor.Text = s.Nome;
            maskedTextBox_Aprovador.Text = s.CoordResponsavel;

            Fornecedor f = new FornecedorDAO().Buscar(externo.CodigoFornecedor);
            maskedTextBox_Fornecedor.Text = f.Nome;

            if (externo.Status == 1)
            {
                maskedTextBox_Status.Text = "Aguardando Retirada";
                maskedTextBox_Status.BackColor = Color.Orange;
            }
            if (externo.Status == 2)
            {
                maskedTextBox_Status.Text = "Aguardando Orçamento";
                maskedTextBox_Status.BackColor = Color.Yellow;
            }
            if (externo.Status == 3)
            {
                maskedTextBox_Status.Text = "Aguardando Requisição";
                maskedTextBox_Status.BackColor = Color.Orchid;
            }
            if (externo.Status == 4)
            {
                maskedTextBox_Status.Text = "Aguardando Aprovação";
                maskedTextBox_Status.BackColor = Color.Red;
            }
            if (externo.Status == 5)
            {
                maskedTextBox_Status.Text = "Aguardando Pedido de Compra";
                maskedTextBox_Status.BackColor = Color.Violet;
            }
            if (externo.Status == 6)
            {
                maskedTextBox_Status.Text = "Aprovado - Aguardando Entrega";
                maskedTextBox_Status.BackColor = Color.Green;
            }
            if (externo.Status == 9)
            {
                maskedTextBox_Status.Text = "Entregue";
                maskedTextBox_Status.BackColor = Color.DarkGreen;
            }
            maskedTextBox_OS.Text = externo.OS;
            maskedTextBox_Codigo.Text = externo.Codigo;
            maskedTextBox_DataEnt.Text = externo.DataEntrada;
            maskedTextBox_DataRet.Text = externo.DataSaida;
            maskedTextBox_DataO.Text = externo.DataOrcamento;
            maskedTextBox_O.Text = externo.NOrcamento;
            maskedTextBox_ValorO.Text = externo.ValorOrcamento;
            maskedTextBox_Datareq.Text = externo.DataRequisicao;
            maskedTextBox_ReqP.Text = externo.ReqPecas;
            maskedTextBox_ReqMO.Text = externo.ReqMObra;
            maskedTextBox_DataAp.Text = externo.DataAprovacao;
            maskedTextBox_DataP.Text = externo.DataPedido;
            maskedTextBox_PedP.Text = externo.PedPecas;
            maskedTextBox_PedMO.Text = externo.PedMObra;
            maskedTextBox_EntregaP.Text = externo.DataPrevista;
            maskedTextBox_DataC.Text = externo.DataCobranca;
            maskedTextBox_ViaC.Text = externo.ViaCobranca;
            maskedTextBox_EntrData.Text = externo.DataEntrega;
            textBox_OBS.Text = externo.Observacoes;
            obs = externo.Observacoes;
            CaminhoOrc = externo.Orcamento;
            if (externo.Orcamento == null)
            {
                maskedTextBox_O.Text = "Não Recebido";
            }
        }
    }
}
