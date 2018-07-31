using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
namespace BrgyMis2
{
    class database
    {

        private static database instance;

        public static database Instance
        {
            get
            {
                if (instance == null)
                    instance = new database();
                return instance;
            }
        }

        MySqlConnection mysqlconn = new MySqlConnection();
        MySqlCommand command;
        public DataTable table;
        public static string serverIp = "localhost";
        public static string dbUser = "root";
        public static string dbPass = "";
        public static string dbName = "db_brgymis";

        private void connection()
        {
            try
            {
                mysqlconn = new MySqlConnection();
                mysqlconn.ConnectionString = "server=" + serverIp + ";userid=" + dbUser + ";password=" + dbPass + ";database=" + dbName;
                mysqlconn.Open();
                if (mysqlconn.State == System.Data.ConnectionState.Open)
                {
                    //    MessageBox.Show("connected");
                }
                else
                {
                    MessageBox.Show("not connected");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        public bool insertRecord(string table, Dictionary<string, dynamic> keys)
        {
            try
            {
                connection();
                string q = string.Empty;
                q += "INSERT INTO " + table;
                q += " (" + string.Join(",", keys.Keys) + ") VALUES ";
                q += "('" + string.Join("','", keys.Values) + "')";

                MySqlDataReader reader;
                command = new MySqlCommand(q, mysqlconn);
                reader = command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                mysqlconn.Close();
            }

        }

        private bool insertRecordx(string q)
        {
            try
            {
                connection();
                MySqlDataReader reader;
                command = new MySqlCommand(q, mysqlconn);
                reader = command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                mysqlconn.Close();
            }
        }

        public bool insertProgram(string name, string category, string description, byte[] img)
        {
            try
            {
                connection();
                MySqlDataReader reader;
                string q;
                q = "insert into tbl_programs (name, category, description, bannerImage) values (@name, @category, @description, @img)";
                command = new MySqlCommand(q, mysqlconn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@img", img);
                reader = command.ExecuteReader();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                mysqlconn.Close();
            }
        }



        public BindingSource tableLoad(string mytable, string[] need)
        {
            BindingSource bsource = new BindingSource();
            try
            {
                 connection();
                table = new DataTable();
                MySqlDataAdapter reader = new MySqlDataAdapter();
                

                string q = string.Empty;
                q += "SELECT " + string.Join(",", need) + " FROM " + mytable;
                command = new MySqlCommand(q, mysqlconn);
                reader.SelectCommand = command;
                reader.Fill(table);
                bsource.DataSource = table;
                reader.Update(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mysqlconn.Close();
            }
            return bsource;
        }

        public Dictionary<string, dynamic> fetchRecordWithCondition(string table, string[] need, string condition, string id)
        {
            Dictionary<string, dynamic> result = new Dictionary<string, dynamic>();
            try
            {
                connection();
                MySqlDataReader reader;

                string q = "select * from " + table + " where " + condition + "='" + id + "'";
                command = new MySqlCommand(q, mysqlconn);
                //command.Parameters.AddWithValue("id", id);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    foreach (var f in need)
                    {
                        result.Add(f, reader[f].ToString());
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mysqlconn.Close();
            }
            return result;
        }


        public bool updateProgram(string name, string category, string description, byte[] img, string id)
        {
            try
            {
                connection();
                MySqlDataReader reader;
                string q;
                q = "update tbl_programs set name=@name, category=@category, description=@description, bannerImage=@img where id=@id";
                command = new MySqlCommand(q, mysqlconn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@img", img);
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                mysqlconn.Close();
            }
        }


        public bool updateRecord(string table, Dictionary<string, dynamic> where, Dictionary<string, dynamic> fields)
        {
            try
            {
            string q = "";
            string condition = "";
            foreach (var item in where)
                condition += item.Key + "='" + item.Value + "' AND ";

           

            condition = condition.Substring(0, condition.Length - 5);


            foreach (var item in fields)
                q += item.Key + "='" + item.Value + "', ";

            q = q.Substring(0, q.Length -2);
            q = "update " + table + " SET " + q + " WHERE " + condition;
            
                connection();
                MySqlDataReader reader;
                command = new MySqlCommand(q, mysqlconn);
                reader = command.ExecuteReader();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                mysqlconn.Close();
            }
        }


        public bool deleteRecord(string table, string condition, string id)
        {
            try
            {
                connection();
                MySqlDataReader reader;
                string q = "delete from "+ table + " where " + condition + "='"+ id +"'";
                command = new MySqlCommand(q, mysqlconn);
                reader = command.ExecuteReader();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                mysqlconn.Close();
            }
        }

        public string countrecord(string table, string condition, string value)
        {
            string count = "";
            try
            {
                connection();
                MySqlDataReader reader;
                string q = "select count(condition) as 'count' from " + table + " where " + condition + "='" + value + "'";
                command = new MySqlCommand(q, mysqlconn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = reader["count"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mysqlconn.Close();
            }
            return count;
        }
    }
}
