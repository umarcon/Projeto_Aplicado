using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestao_condominio.Dados;
using MySql.Data.MySqlClient;

namespace gestao_condominio
{
    public class SqlUtils
    {

        private static MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        //Servidor de dados
        private const string SqlHost = @"localhost";
        //Usuário do banco de dados
        private const string SqlUser = "root";
        //Senha do usuário
        private const string SqlPass = "123456";
        //Database que irá se conectar
        private const string SqlDb = "gestao_condominio";

        public static void Connect()
        {
            //Verifica se o status da conexão é null
            //Este caso precisa ficar porque eu ainda não tenho o objeto connection instanciado pela sqlconnection
            try
            {
                mConn = new MySqlConnection(string.Format(
                "user id={0};password={1};server={2};database={3};connection timeout=60",
                SqlUser,
                SqlPass,
                SqlHost,
                SqlDb));

                //Caso tenha sucesso em se conectar, abre a sessão.
                mConn.Open();
            }
            catch (Exception ex)
            {
               
            }
        }

        public static void InsertMorador(List<Morador> result)
        {
            try
            {
                Connect();

                foreach (var item in result)
                {
                    var sql = string.Format(@"insert into morador (nome, apartamento, proprietario, cpf, telefone, email, rg, moradores)
                               values ('{0}', {1}, {2}, '{3}', '{4}', '{5}', '{6}', '{7}');", 
                               item.nome, item.apartamento, item.proprietario, item.cpf, item.telefone, item.email, item.rg, item.moradores);

                    MySqlCommand command = new MySqlCommand(sql, mConn);

                    command.ExecuteNonQuery();

                    mConn.Close();

                    MessageBox.Show("Morador cadastrado com sucesso!");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }
        }

        public static void InsertVisitantes(List<CadVisitantes> result)
        {
            try
            {
                Connect();

                foreach (var item in result)
                {
                    var data = item.data_visita.Value.Year + "-" + item.data_visita.Value.Month + "-" + item.data_visita.Value.Day;
                    var sql = string.Format(@"insert into visitantes (nome, morador_idmorador, data_visita, rg)
                               values ('{0}', {1}, '{2}', '{3}');",
                               item.nome, item.morador, data, item.rg);

                    MySqlCommand command = new MySqlCommand(sql, mConn);

                    command.ExecuteNonQuery();

                    mConn.Close();

                    MessageBox.Show("Visitante cadastrado com sucesso!");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }
        }

        public static void UpdateMorador(List<Morador> result)
        {
            try
            {
                Connect();

                foreach (var item in result)
                {
                    var sql = string.Format(@"update morador set nome = '{0}', apartamento = '{1}', cpf = '{2}', telefone = '{3}', email = '{4}', rg = '{5}', moradores = '{6}'
                                            where apartamento = '{1}';",
                               item.nome, item.apartamento, item.cpf, item.telefone, item.email, item.rg, item.moradores);

                    MySqlCommand command = new MySqlCommand(sql, mConn);

                    command.ExecuteNonQuery();

                    mConn.Close();

                    MessageBox.Show("Morador atualizado com sucesso!");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }
        }

        public static void InsertAtivo(List<Ativo> result)
        {
            try
            {
                Connect();

                foreach (var item in result)
                {
                    var dateTime = Convert.ToDateTime(item.Data_Cadastro);
                    var data = dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day; 

                    var sql = string.Format(@"insert into ativo (item, marca, area, data_cadastro)
                               values ('{0}', '{1}', '{2}', '{3}');",
                               item.Item, item.Marca, item.Area, data);

                    MySqlCommand command = new MySqlCommand(sql, mConn);

                    command.ExecuteNonQuery();

                    mConn.Close();

                    MessageBox.Show("Ativo cadastrado com sucesso!");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }
        }

        public static void InsertMudanca(List<Mudanca> result)
        {
            try
            {
                Connect();

                foreach (var item in result)
                {
                    var dateTime = Convert.ToDateTime(item.Data);
                    var data = dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day;

                    var sql = string.Format(@"insert into mudancas (`morador_idmorador`,`⁮tipo`,`data_mudanca`,`obs`)
                               values ({0}, {1}, '{2}', '{3}');",
                               1, item.Tipo, data, item.Obs);

                    MySqlCommand command = new MySqlCommand(sql, mConn);

                    command.ExecuteNonQuery();

                    mConn.Close();

                    MessageBox.Show("Ativo cadastrado com sucesso!");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }
        }

        public static void InsertUsuario(List<Usuario> result)
        {
            try
            {
                Connect();

                foreach (var item in result)
                {
                    var sql = string.Format(@"insert into usuario (`nome`,`cargo`,`login`,`senha`)
                               values ('{0}', '{1}', '{2}', '{3}');",
                               item.Nome, item.Cargo, item.Login, item.Senha);

                    MySqlCommand command = new MySqlCommand(sql, mConn);

                    command.ExecuteNonQuery();

                    mConn.Close();

                    MessageBox.Show("Ativo cadastrado com sucesso!");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }
        }

        public static List<CadVisitantes> GetVisitantes(string dataDe, string dataAte)
        {
            var listResult = new List<CadVisitantes>();

            try
            {
                Connect();

                var sqlQuery = "select * from visitantes where data_visita between '" + dataDe + "' and '" + dataAte + "';";

                MySqlCommand command = new MySqlCommand(sqlQuery, mConn);

                
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var result = new CadVisitantes();

                        result.morador = (int)dr["morador_idmorador"];
                        result.nome = (String)dr["nome"];
                        result.data_visita = Convert.ToDateTime(dr["data_visita"]);
                        result.rg = (String)dr["rg"];
                        listResult.Add(result);
                    }
                }

                mConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }

            return listResult;
        }

        public static List<Eventos> GetEventos(string dataDe, string dataAte)
        {
            var listResult = new List<Eventos>();

            try
            {
                Connect();

                var sqlQuery = "select * from eventos where data between '" + dataDe + "' and '" + dataAte + "';";

                MySqlCommand command = new MySqlCommand(sqlQuery, mConn);


                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var result = new Eventos();

                        result.morador = (int)dr["morador_idmorador"];
                        result.area = (int)dr["area"];
                        result.data = Convert.ToDateTime(dr["data"]);
                        listResult.Add(result);
                    }
                }

                mConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }

            return listResult;
        }

        public static void DeletaRegistro(string tabela, int idRegistro)
        {
            try
            {
                Connect();

                var sql = string.Format(@"delete from {0} where id = {1}", tabela, idRegistro);

                MySqlCommand command = new MySqlCommand(sql, mConn);

                command.ExecuteNonQuery();

                mConn.Close();

                MessageBox.Show("Ativo apagado com sucesso!");

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }
        }

        public static List<Morador> GetMorador(int apto)
        {
            var listResult = new List<Morador>();

            try
            {
                Connect();

                var sqlQuery = string.Format("select * from morador where apartamento = {0};", apto);

                MySqlCommand command = new MySqlCommand(sqlQuery, mConn);

                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var result = new Morador();

                        result.apartamento = (int)dr["apartamento"];
                        result.nome = (String)dr["nome"];
                        result.proprietario = Convert.ToInt32(dr["proprietario"]);
                        result.rg = (String)dr["rg"];
                        result.cpf = (String)dr["cpf"];
                        result.telefone = (String)dr["telefone"];
                        result.email = (String)dr["email"];
                        result.id = (int)dr["idmorador"];
                        listResult.Add(result);
                    }
                }

                mConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }

            return listResult;
        }

        public static List<Usuario> GetUsuario(string login, string senha)
        {
            var listResult = new List<Usuario>();

            try
            {
                Connect();

                var sqlQuery = string.Format("select * from usuario where login = '{0}' and senha = '{1}';", login, senha);

                MySqlCommand command = new MySqlCommand(sqlQuery, mConn);

                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var result = new Usuario();

                        result.Login = (String)dr["login"];
                        result.Senha = (String)dr["senha"];
                        result.Nome = (String)(dr["nome"]);
                        result.Cargo = (String)dr["cargo"];

                        listResult.Add(result);
                    }
                }

                mConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mConn.Close();
            }

            return listResult;
        }
    }
}
