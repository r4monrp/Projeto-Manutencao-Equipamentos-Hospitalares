using MySql.Data.MySqlClient;
using Persistencia.Interface;
using Persistencia.Modelo;
using Persistencia.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAO
{
    public class ExternoDAO : IDAO<Externo>, IDisposable
    {
        private Connection _connection;

        public ExternoDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO EXTERNO(COD_EQUIPAMENTO,CODIGO,COD_SETOR,OS,COD_FORNECEDOR,DATA_ENTRADA) VALUES (@COD_EQUIPAMENTO,@CODIGO,@COD_SETOR,@OS,@COD_FORNECEDOR,@DATA_ENTRADA);";

                    comando.Parameters.Add("@COD_EQUIPAMENTO", MySqlDbType.Int16).Value = externo.CodigoEquipamento;
                    comando.Parameters.Add("@CODIGO", MySqlDbType.Text).Value = externo.Codigo;
                    comando.Parameters.Add("@COD_SETOR", MySqlDbType.Int16).Value = externo.CodigoSetor;
                    comando.Parameters.Add("@OS", MySqlDbType.Text).Value = externo.OS;
                    comando.Parameters.Add("@COD_FORNECEDOR", MySqlDbType.Int16).Value = externo.CodigoFornecedor;
                    comando.Parameters.Add("@DATA_ENTRADA", MySqlDbType.Text).Value = externo.DataEntrada;

                    if (comando.ExecuteNonQuery() > 0)
                        return comando.LastInsertedId;
                    return -1;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public bool Remover(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET STATUS = @STATUS WHERE COD_EXTERNO = @COD_EXTERNO";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = externo.Status;

                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }


        public bool Atualizar(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,COD_EQUIPAMENTO=@COD_EQUIPAMENTO,CODIGO = @CODIGO  ,COD_SETOR = @COD_SETOR,OS=@OS,COD_FORNECEDOR =@COD_FORNECEDOR,DATA_ENTRADA=@DATA_ENTRADA,DATA_SAIDA=@DATA_SAIDA,DATA_ORCAMENTO =@DATA_ORCAMENTO,ORCAMENTO =@ORCAMENTO,N_ORCAMENTO=@N_ORCAMENTO,VALOR_ORCAMENTO =@VALOR_ORCAMENTO,DATA_REQUISICAO =@DATA_REQUISICAO,REQ_PECAS =@REQ_PECAS,REQ_MOBRA=@REQ_MOBRA,DATA_APROVACAO=@DATA_APROVACAO,DATA_PEDIDO=@DATA_PEDIDO,PED_PECAS=@PED_PECAS,PED_MOBRA=@PED_MOBRA,DATA_PREVISTA=@DATA_PREVISTA,DATA_COBRANCA=@DATA_COBRANCA,VIA_COBRANCA=@VIA_COBRANCA,DATA_ENTREGA=@DATA_ENTREGA,OBSERVACOES=@OBSERVACOES,STATUS=@STATUS WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@COD_EQUIPAMENTO", MySqlDbType.Int16).Value = externo.CodigoEquipamento;
                    comando.Parameters.Add("@COD_FORNECEDOR", MySqlDbType.Int16).Value = externo.CodigoFornecedor;
                    comando.Parameters.Add("@COD_SETOR", MySqlDbType.Int16).Value = externo.CodigoSetor;
                    comando.Parameters.Add("@CODIGO", MySqlDbType.Text).Value = externo.Codigo;
                    comando.Parameters.Add("@OS", MySqlDbType.Text).Value = externo.OS;
                    comando.Parameters.Add("@DATA_ENTRADA", MySqlDbType.Text).Value = externo.DataEntrada;
                    comando.Parameters.Add("@DATA_SAIDA", MySqlDbType.Text).Value = externo.DataSaida;
                    comando.Parameters.Add("@DATA_ORCAMENTO", MySqlDbType.Text).Value = externo.DataOrcamento;
                    comando.Parameters.Add("@ORCAMENTO", MySqlDbType.Text).Value = externo.Orcamento;
                    comando.Parameters.Add("@N_ORCAMENTO", MySqlDbType.Text).Value = externo.NOrcamento;
                    comando.Parameters.Add("@VALOR_ORCAMENTO", MySqlDbType.Text).Value = externo.ValorOrcamento;
                    comando.Parameters.Add("@DATA_REQUISICAO", MySqlDbType.Text).Value = externo.DataRequisicao;
                    comando.Parameters.Add("@REQ_PECAS", MySqlDbType.Text).Value = externo.ReqPecas;
                    comando.Parameters.Add("@REQ_MOBRA", MySqlDbType.Text).Value = externo.ReqMObra;
                    comando.Parameters.Add("@DATA_APROVACAO", MySqlDbType.Text).Value = externo.DataAprovacao;
                    comando.Parameters.Add("@DATA_PEDIDO", MySqlDbType.Text).Value = externo.DataPedido;
                    comando.Parameters.Add("@PED_PECAS", MySqlDbType.Text).Value = externo.PedPecas;
                    comando.Parameters.Add("@PED_MOBRA", MySqlDbType.Text).Value = externo.PedMObra;
                    comando.Parameters.Add("@DATA_PREVISTA", MySqlDbType.Text).Value = externo.DataPrevista;
                    comando.Parameters.Add("@DATA_COBRANCA", MySqlDbType.Text).Value = externo.DataCobranca;
                    comando.Parameters.Add("@VIA_COBRANCA", MySqlDbType.Text).Value = externo.ViaCobranca;
                    comando.Parameters.Add("@DATA_ENTREGA", MySqlDbType.Text).Value = externo.DataEntrega;
                    comando.Parameters.Add("@OBSERVACOES", MySqlDbType.Text).Value = externo.Observacoes;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = externo.Status;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarRetirada(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,DATA_SAIDA=@DATA_SAIDA,STATUS=@STATUS WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@DATA_SAIDA", MySqlDbType.Text).Value = externo.DataSaida;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = externo.Status;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarOrc(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,ORCAMENTO = @ORCAMENTO,VALOR_ORCAMENTO =@VALOR_ORCAMENTO,N_ORCAMENTO =@N_ORCAMENTO,DATA_ORCAMENTO=@DATA_ORCAMENTO,STATUS=@STATUS WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@DATA_ORCAMENTO", MySqlDbType.Text).Value = externo.DataOrcamento;
                    comando.Parameters.Add("@ORCAMENTO", MySqlDbType.Text).Value = externo.Orcamento;
                    comando.Parameters.Add("@N_ORCAMENTO", MySqlDbType.Text).Value = externo.NOrcamento;
                    comando.Parameters.Add("@VALOR_ORCAMENTO", MySqlDbType.Text).Value = externo.ValorOrcamento;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = externo.Status;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarReq(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,DATA_REQUISICAO = @DATA_REQUISICAO,REQ_PECAS =@REQ_PECAS,REQ_MOBRA =@REQ_MOBRA,STATUS=@STATUS WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@DATA_REQUISICAO", MySqlDbType.Text).Value = externo.DataRequisicao;
                    comando.Parameters.Add("@REQ_PECAS", MySqlDbType.Text).Value = externo.ReqPecas;
                    comando.Parameters.Add("@REQ_MOBRA", MySqlDbType.Text).Value = externo.ReqMObra;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = externo.Status;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarAprov(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,DATA_APROVACAO = @DATA_APROVACAO,STATUS=@STATUS WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@DATA_APROVACAO", MySqlDbType.Text).Value = externo.DataAprovacao;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = externo.Status;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarPed(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,DATA_PREVISTA=@DATA_PREVISTA,PED_MOBRA=@PED_MOBRA,PED_PECAS=@PED_PECAS,DATA_PEDIDO = @DATA_PEDIDO,STATUS=@STATUS WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@DATA_PEDIDO", MySqlDbType.Text).Value = externo.DataPedido;
                    comando.Parameters.Add("@PED_PECAS", MySqlDbType.Text).Value = externo.PedPecas;
                    comando.Parameters.Add("@PED_MOBRA", MySqlDbType.Text).Value = externo.PedMObra;
                    comando.Parameters.Add("@DATA_PREVISTA", MySqlDbType.Text).Value = externo.DataPrevista;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = externo.Status;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarEnt(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,DATA_ENTREGA=@DATA_ENTREGA,STATUS=@STATUS WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@DATA_ENTREGA", MySqlDbType.Text).Value = externo.DataEntrega;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Text).Value = externo.Status;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarCob(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,VIA_COBRANCA=@VIA_COBRANCA,DATA_COBRANCA=@DATA_COBRANCA WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@DATA_COBRANCA", MySqlDbType.Text).Value = externo.DataCobranca;
                    comando.Parameters.Add("@VIA_COBRANCA", MySqlDbType.Text).Value = externo.ViaCobranca;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public bool AtualizarObs(Externo externo)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EXTERNO SET COD_EXTERNO=@COD_EXTERNO,OBSERVACOES=@OBSERVACOES WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = externo.CodigoExterno;
                    comando.Parameters.Add("@OBSERVACOES", MySqlDbType.Text).Value = externo.Observacoes;
                    if (comando.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public List<Externo> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Externo> externos = new List<Externo>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_EXTERNO,COD_EQUIPAMENTO,CODIGO,COD_SETOR,OS,COD_FORNECEDOR,DATA_ENTRADA,STATUS FROM EXTERNO WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Externo externo = new Externo();
                       externo.CodigoEquipamento = Int16.Parse(leitor["COD_EQUIPAMENTO"].ToString());
                       externo.Codigo = leitor["CODIGO"].ToString();
                       externo.CodigoSetor =Int16.Parse(leitor["COD_SETOR"].ToString());
                       externo.OS = leitor["OS"].ToString();
                       externo.CodigoFornecedor = Int16.Parse(leitor["COD_FORNECEDOR"].ToString());
                       externo.DataEntrada = leitor["DATA_ENTRADA"].ToString();
                       externo.Status = Int16.Parse(leitor["STATUS"].ToString());
                        externo.CodigoExterno = Int16.Parse(leitor["COD_EXTERNO"].ToString());

                        externos.Add(externo);
                    }

                    return externos;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }
        public List<Externo> ListarF()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Externo> externos = new List<Externo>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_EXTERNO,COD_EQUIPAMENTO,CODIGO,COD_SETOR,OS,COD_FORNECEDOR,DATA_ENTREGA,STATUS FROM EXTERNO WHERE STATUS = 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Externo externo = new Externo();
                        externo.CodigoEquipamento = Int16.Parse(leitor["COD_EQUIPAMENTO"].ToString());
                        externo.Codigo = leitor["CODIGO"].ToString();
                        externo.CodigoSetor = Int16.Parse(leitor["COD_SETOR"].ToString());
                        externo.OS = leitor["OS"].ToString();
                        externo.CodigoFornecedor = Int16.Parse(leitor["COD_FORNECEDOR"].ToString());
                        externo.DataEntrega = leitor["DATA_ENTREGA"].ToString();
                        externo.Status = Int16.Parse(leitor["STATUS"].ToString());
                        externo.CodigoExterno = Int16.Parse(leitor["COD_EXTERNO"].ToString());

                        externos.Add(externo);
                    }

                    return externos;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public Externo Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Externo externo = new Externo();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_EXTERNO,COD_EQUIPAMENTO,CODIGO,COD_SETOR,OS,COD_FORNECEDOR,DATA_ENTRADA,DATA_SAIDA,DATA_ORCAMENTO,ORCAMENTO,N_ORCAMENTO,VALOR_ORCAMENTO,DATA_REQUISICAO,REQ_PECAS,REQ_MOBRA,DATA_APROVACAO,DATA_PEDIDO,PED_PECAS,PED_MOBRA,DATA_PREVISTA,DATA_COBRANCA,VIA_COBRANCA,DATA_ENTREGA,OBSERVACOES,STATUS FROM EXTERNO WHERE COD_EXTERNO = @COD_EXTERNO;";

                    comando.Parameters.Add("@COD_EXTERNO", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        externo.CodigoEquipamento = Int16.Parse(leitor["COD_EQUIPAMENTO"].ToString());
                        externo.CodigoFornecedor = Int16.Parse(leitor["COD_FORNECEDOR"].ToString());
                        externo.CodigoExterno = Int16.Parse(leitor["COD_EXTERNO"].ToString());
                        externo.CodigoSetor = Int16.Parse(leitor["COD_SETOR"].ToString());
                        externo.Codigo = leitor["CODIGO"].ToString();
                        externo.OS = leitor["OS"].ToString();
                        externo.DataEntrada = leitor["DATA_ENTRADA"].ToString();
                        externo.DataSaida = leitor["DATA_SAIDA"].ToString();
                        externo.DataOrcamento= leitor["DATA_ORCAMENTO"].ToString();
                        externo.Orcamento= leitor["ORCAMENTO"].ToString();
                        externo.NOrcamento = leitor["N_ORCAMENTO"].ToString();
                        externo.ValorOrcamento = leitor["VALOR_ORCAMENTO"].ToString();
                        externo.DataRequisicao = leitor["DATA_REQUISICAO"].ToString();
                        externo.ReqPecas = leitor["REQ_PECAS"].ToString();
                        externo.ReqMObra = leitor["REQ_MOBRA"].ToString();
                        externo.DataAprovacao = leitor["DATA_APROVACAO"].ToString();
                        externo.DataPedido = leitor["DATA_PEDIDO"].ToString();
                        externo.PedPecas = leitor["PED_PECAS"].ToString(); 
                        externo.PedMObra = leitor["PED_MOBRA"].ToString();
                        externo.DataPrevista = leitor["DATA_PREVISTA"].ToString();
                        externo.DataCobranca = leitor["DATA_COBRANCA"].ToString();
                        externo.ViaCobranca = leitor["VIA_COBRANCA"].ToString();
                        externo.DataEntrega= leitor["DATA_ENTREGA"].ToString();
                        externo.Observacoes = leitor["OBSERVACOES"].ToString();
                        externo.Status = Int16.Parse(leitor["STATUS"].ToString());
                        

                    }

                    return externo;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public long Contagem()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COUNT(COD_EXTERNO) FROM EXTERNO WHERE STATUS <> 9;";

                    return (long)comando.ExecuteScalar();
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                _connection.Fechar();
            }
        }

        public void Dispose()
        {
            _connection.Fechar();
            GC.SuppressFinalize(this);
        }

    }
}