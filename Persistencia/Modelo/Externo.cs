using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Persistencia.Interface;
using Persistencia.Modelo;
using Persistencia.Util;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class Externo
    {
        public long CodigoExterno { get; set; }
        public string Codigo { get; set; }
        public string OS { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
        public string DataOrcamento { get; set; }
        public string NOrcamento { get; set; }
        public string Orcamento{ get; set; }
        public string ValorOrcamento { get; set; }
        public string DataRequisicao { get; set; }
        public string ReqPecas { get; set; }
        public string ReqMObra { get; set; }
        public string DataAprovacao { get; set; }
        public string DataPedido { get; set; }
        public string PedPecas{ get; set; }
        public string PedMObra { get; set; }
        public string DataPrevista { get; set; }
        public string DataCobranca { get; set; }
        public string ViaCobranca{ get; set; }
        public string DataEntrega { get; set; }
        public string Observacoes{ get; set; }
        public long CodigoEquipamento { get; set; }
        public long CodigoSetor { get; set; }
        public long CodigoFornecedor { get; set; }
        public int Status { get; set; }
    }
}
