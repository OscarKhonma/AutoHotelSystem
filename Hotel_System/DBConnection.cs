using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_System
{
    /*
     * подключение между приложением и MySQL database
     */
    class DBConnection
    {
        private MySqlConnection _connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=auto_hotel_system");

        //вернуть connection
        public MySqlConnection GetConnection()
        {
            return _connection;
        }

        //открыть connection
        public void OpenConnection()
        {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        } 
        
        //закрыть connection
        public void CloseConnection()
        {
            if(_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
