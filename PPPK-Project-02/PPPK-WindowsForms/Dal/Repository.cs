using PPPK_WindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_WindowsForms.Dal
{
    class Repository : IRepository
    {
        private string cs;
        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";

        private const string SelectDatabases = "SELECT name as Name FROM sys.databases";
        private const string SelectTables = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.TABLES";
        private const string SelectViews = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.VIEWS";
        private const string SelectProcedures = "SELECT SPECIFIC_NAME as Name, ROUTINE_DEFINITION as Definition FROM {0}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'";
        private const string SelectColumns = "SELECT COLUMN_NAME as Name, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'";
        private const string SelectProcedureParameters = "SELECT PARAMETER_NAME as Name, PARAMETER_MODE as Mode, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='{1}'";
        private const string SelectQuery = "use {0} {1}";


        public void LogIn(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(
                string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }

        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    //cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        con.FireInfoMessageEventOnUserErrors = true;
                        con.InfoMessage += new SqlInfoMessageEventHandler(myConnection_InfoMessage);

                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }



        public DataSet GetDataSet(string SQL, System.Windows.Forms.TextBox tbMessages)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();


            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            con.FireInfoMessageEventOnUserErrors = true;

            con.Open();

            con.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            {
                tbMessages.Text += e.Message + Environment.NewLine + Environment.NewLine;
            };

            da.RowUpdated += delegate (object sender, SqlRowUpdatedEventArgs e)
            {
                tbMessages.Text += "Rows affected: " + e.RecordsAffected + Environment.NewLine + Environment.NewLine;
            };

            try
            {
                da.Fill(ds);
            }
            catch
            {

            }
            con.Close();

            return ds;
        }

        void myConnection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(e.Message);
        }

 
    }

}
