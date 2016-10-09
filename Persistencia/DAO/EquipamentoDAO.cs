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

namespace   Persistencia.DAO
{
    public class EquipamentoDAO : IDAO<Equipamento>, IDisposable
    {
        private Connection _connection;

        public EquipamentoDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Equipamento equipamento)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO EQUIPAMENTO(DESCRICAO) VALUES (@DESCRICAO);";

                    comando.Parameters.Add("@DESCRICAO", MySqlDbType.Text).Value = equipamento.Descricao;

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

        public bool Remover(Equipamento equipamento)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EQUIPAMENTO SET STATUS = @STATUS WHERE COD_EQUIPAMENTO = @COD_EQUIPAMENTO";

                    comando.Parameters.Add("@COD_EQUIPAMENTO", MySqlDbType.Int16).Value = equipamento.CodigoEquipamento;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = equipamento.Status;

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


        public bool Atualizar(Equipamento equipamento)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE EQUIPAMENTO SET DESCRICAO = @DESCRICAO WHERE COD_EQUIPAMENTO = @COD_EQUIPAMENTO;";

                    comando.Parameters.Add("@COD_EQUIPAMENTO", MySqlDbType.Int16).Value = equipamento.CodigoEquipamento;
                    comando.Parameters.Add("@DESCRICAO", MySqlDbType.Text).Value = equipamento.Descricao;
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

        public List<Equipamento> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Equipamento> equipamentos = new List<Equipamento>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_EQUIPAMENTO,DESCRICAO,STATUS FROM EQUIPAMENTO WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Equipamento equipamento = new Equipamento();
                        equipamento.CodigoEquipamento = Int16.Parse(leitor["COD_EQUIPAMENTO"].ToString());
                        equipamento.Descricao = leitor["DESCRICAO"].ToString();
                        equipamento.Status = Int16.Parse(leitor["STATUS"].ToString());

                        equipamentos.Add(equipamento);
                    }

                    return equipamentos;
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

        public Equipamento Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Equipamento equipamento = new Equipamento();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_EQUIPAMENTO,DESCRICAO,STATUS FROM EQUIPAMENTO WHERE STATUS <> 9 AND COD_EQUIPAMENTO = @COD_EQUIPAMENTO;";

                    comando.Parameters.Add("@COD_EQUIPAMENTO", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        equipamento.CodigoEquipamento = Int16.Parse(leitor["COD_EQUIPAMENTO"].ToString());
                        equipamento.Descricao = leitor["DESCRICAO"].ToString();
                        equipamento.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return equipamento;
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
        public Equipamento BuscarNome(string nome)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Equipamento equipamento = new Equipamento();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_EQUIPAMENTO,DESCRICAO,STATUS FROM EQUIPAMENTO WHERE STATUS <> 9 AND DESCRICAO = @DESCRICAO;";

                    comando.Parameters.Add("@DESCRICAO", MySqlDbType.Text).Value = nome;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        equipamento.CodigoEquipamento = Int16.Parse(leitor["COD_EQUIPAMENTO"].ToString());
                        equipamento.Descricao = leitor["DESCRICAO"].ToString();
                        equipamento.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return equipamento;
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
                    comando.CommandText = "SELECT COUNT(COD_EQUIPAMENTO) FROM EQUIPAMENTO WHERE STATUS <> 9;";

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