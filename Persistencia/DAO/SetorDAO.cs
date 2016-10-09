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
    public class SetorDAO : IDAO<Setor>, IDisposable
    {
        private Connection _connection;

        public SetorDAO()
        {
            _connection = new Connection();
        }

        public long Inserir(Setor setor)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO SETOR(NOME,ENFRESPONSAVEL,COORDRESPONSAVEL) VALUES (@NOME,@ENFRESPONSAVEL,@COORDRESPONSAVEL);";

                    comando.Parameters.Add("@NOME", MySqlDbType.Text).Value = setor.Nome;
                    comando.Parameters.Add("@ENFRESPONSAVEL", MySqlDbType.Text).Value = setor.EnfResponsavel;
                    comando.Parameters.Add("@COORDRESPONSAVEL", MySqlDbType.Text).Value = setor.CoordResponsavel;

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

        public bool Remover(Setor setor)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE SETOR SET STATUS = @STATUS WHERE COD_SETOR = @COD_SETOR";

                    comando.Parameters.Add("@COD_SETOR", MySqlDbType.Int16).Value = setor.CodigoSetor;
                    comando.Parameters.Add("@STATUS", MySqlDbType.Int16).Value = setor.Status;

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


        public bool Atualizar(Setor setor)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE SETOR SET NOME = @NOME, ENFRESPONSAVEL = @ENFRESPONSAVEL, COORDRESPONSAVEL = @COORDRESPONSAVEL WHERE COD_SETOR = @COD_SETOR;";

                    comando.Parameters.Add("@COD_SETOR", MySqlDbType.Int16).Value = setor.CodigoSetor;
                    comando.Parameters.Add("@NOME", MySqlDbType.Text).Value = setor.Nome;
                    comando.Parameters.Add("@ENFRESPONSAVEL", MySqlDbType.Text).Value = setor.EnfResponsavel;
                    comando.Parameters.Add("@COORDRESPONSAVEL", MySqlDbType.Text).Value = setor.CoordResponsavel;
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

        public List<Setor> Listar()
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    List<Setor> setores = new List<Setor>();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_SETOR,NOME,ENFRESPONSAVEL,COORDRESPONSAVEL, STATUS FROM SETOR WHERE STATUS <> 9;";
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        Setor setor = new Setor();
                        setor.CodigoSetor = Int16.Parse(leitor["COD_SETOR"].ToString());
                        setor.Nome = leitor["NOME"].ToString();
                        setor.EnfResponsavel = leitor["ENFRESPONSAVEL"].ToString();
                        setor.CoordResponsavel = leitor["COORDRESPONSAVEL"].ToString();
                        setor.Status = Int16.Parse(leitor["STATUS"].ToString());

                        setores.Add(setor);
                    }

                    return setores;
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

        public Setor Buscar(long cod)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Setor setor = new Setor();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_SETOR,NOME,ENFRESPONSAVEL,COORDRESPONSAVEL,STATUS FROM SETOR WHERE STATUS <> 9 AND COD_SETOR = @COD_SETOR;";

                    comando.Parameters.Add("@COD_SETOR", MySqlDbType.Int16).Value = cod;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        setor.CodigoSetor = Int16.Parse(leitor["COD_SETOR"].ToString());
                        setor.Nome = leitor["NOME"].ToString();
                        setor.EnfResponsavel = leitor["ENFRESPONSAVEL"].ToString();
                        setor.CoordResponsavel = leitor["COORDRESPONSAVEL"].ToString();
                        setor.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return setor;
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
        public Setor BuscarNome(string nome)
        {
            try
            {
                using (MySqlCommand comando = _connection.Buscar().CreateCommand())
                {
                    Setor setor = new Setor();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT COD_SETOR,NOME,ENFRESPONSAVEL,COORDRESPONSAVEL,STATUS FROM SETOR WHERE STATUS <> 9 AND NOME = @NOME;";

                    comando.Parameters.Add("@NOME", MySqlDbType.Text).Value = nome;
                    MySqlDataReader leitor = comando.ExecuteReader();

                    if (leitor.Read())
                    {
                        setor.CodigoSetor = Int16.Parse(leitor["COD_SETOR"].ToString());
                        setor.Nome = leitor["NOME"].ToString();
                        setor.EnfResponsavel = leitor["ENFRESPONSAVEL"].ToString();
                        setor.CoordResponsavel = leitor["COORDRESPONSAVEL"].ToString();
                        setor.Status = Int16.Parse(leitor["STATUS"].ToString());
                    }

                    return setor;
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
                    comando.CommandText = "SELECT COUNT(COD_SETOR) FROM EQUIPAMENTO WHERE STATUS <> 9;";

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