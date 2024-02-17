using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    class Reservation
    {
        DBConnection conn = new DBConnection();
        //Получение существующие Брони
        public DataTable GetAllReservations()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM reservations", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //Создание Брони
        public bool MakeReservation(int roomNumber, int clientID, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String queryInsert = "INSERT INTO reservations(room_number, client_id, date_in, date_out) VALUES (@number, @client, @dateIn, @dateOut)";
            command.CommandText = queryInsert;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@client", MySqlDbType.Int32).Value = clientID;
            command.Parameters.Add("@dateIn", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dateOut", MySqlDbType.Date).Value = dateOut;

            conn.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }
        }

        //Изменение Брони
        public bool EditReservation(int id, int roomNumber, int clientID, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String queryUpdate = "UPDATE reservations SET room_number=@number, client_id=@client, date_in=@dateIn, date_out=@dateOut WHERE id=@rid";
            command.CommandText = queryUpdate;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@number", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@client", MySqlDbType.Int32).Value = clientID;
            command.Parameters.Add("@dateIn", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dateOut", MySqlDbType.Date).Value = dateOut;

            conn.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }
        }

        //Удаление Брони
        public bool RemoveReservation(int reservationID)
        {
            MySqlCommand command = new MySqlCommand();
            String queryDelete = "DELETE FROM reservations WHERE id=@id";
            command.CommandText = queryDelete;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = reservationID;

            conn.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }
        }

    }
}
