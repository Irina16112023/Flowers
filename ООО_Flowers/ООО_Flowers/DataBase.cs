using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ООО_Flowers
{
     class DataBase
    {
       // Подключение к базе данных
        SqlConnection connection=new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = flawers; Integrated Security = True");
        
        
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }
            
        }
        public void closeConnection()

        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        
        }

        public SqlConnection GetConnection()
        {

            return connection;


        }

    }
}
