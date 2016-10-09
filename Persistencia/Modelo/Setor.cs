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
    public class Setor
    {
        public long CodigoSetor { get; set; }
        public string Nome{ get; set; }
        public string EnfResponsavel { get; set; }
        public string CoordResponsavel { get; set; }
        public int Status { get; set; }
    }
}
