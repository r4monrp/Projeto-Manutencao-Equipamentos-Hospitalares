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
    public class Fornecedor
    {
        public long CodigoFornecedor { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
    }
}
