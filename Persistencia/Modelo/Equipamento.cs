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
    public class Equipamento
    {
        public long CodigoEquipamento { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
    }
}
