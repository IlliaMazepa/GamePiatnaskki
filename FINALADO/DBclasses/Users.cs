using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALADO.DBclasses
{
    public class Users
    {
        public DataSet ds = null;
        string connectionString = @"Data Source=CIA;Initial Catalog=FinalADO;Integrated Security=True";


        public void Load()
        {
            ds = new DataSet();
            string SelBooks = "SELECT * FROM Users";
            string SelQA = "SELECT * FROM QA";
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapterA = new SqlDataAdapter(SelBooks, connection);
                SqlDataAdapter adapterB = new SqlDataAdapter(SelQA, connection);
                



                adapterA.Fill(ds, "Users");
                adapterB.Fill(ds, "QA");
               
            }
        }

        public void INS(string com)
        {

            string sqlExpression = com;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("NEw data was added");
            }
            Console.Read();

        }
    }
}
