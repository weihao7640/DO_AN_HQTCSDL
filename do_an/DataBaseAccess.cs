using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public class DatabaseAccess
    {
        private SqlDataAdapter sqlDataAdapter;
        private SqlConnection sqlConnection;


        public DatabaseAccess()
        {
            sqlDataAdapter = new SqlDataAdapter();
            sqlConnection = new SqlConnection(@"Data Source=NGOCHAI\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        }
        public SqlConnection openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }
        public DataSet executeQuery(String query)
        {
            using (sqlDataAdapter = new SqlDataAdapter(query, openConnection()))
            {
                try
                {
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    return dataSet;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return null;
        }
        public int executeNonQuery(String query)
        {
            using (SqlCommand cmd = new SqlCommand(query, openConnection()))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred! Please try again.");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return 0;
        }
    }
}
