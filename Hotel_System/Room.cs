using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    class Room
    {
        DBConnection conn = new DBConnection();
        //получить все типы rooms
        public DataTable RoomTypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM rooms_type", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //получение все номера взависимости от типа
        public DataTable RoomByType(int type)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM rooms WHERE type=@type and free = 'YES'", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //получение id типа rooms
        public int GetRoomType(int number)
        {
            MySqlCommand command = new MySqlCommand("SELECT type FROM rooms WHERE number=@number", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        //Установка на свободный или нет (NO/YES)
        public bool SetRoomFree(int number, String isFree)
        {
            MySqlCommand command = new MySqlCommand("UPDATE rooms SET free=@isFree WHERE number=@number", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@isFree", MySqlDbType.VarChar).Value = isFree;

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

        //добавить новый room
        public bool InsertRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String queryInsert = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@number, @type, @phone, @free)";
            command.CommandText = queryInsert;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@free", MySqlDbType.VarChar).Value = free;

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

        //получение все доступные rooms в базе
        public DataTable GetAllRooms()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM rooms", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }


        //изменение ROOM data
        public bool EditRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String queryUpdate = "UPDATE rooms SET type=@type, phone=@phone, free=@free WHERE number=@number";
            command.CommandText = queryUpdate;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@free", MySqlDbType.VarChar).Value = free;

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

        //удаление room
        public bool RemoveRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String queryDelete = "DELETE FROM rooms WHERE number=@number";
            command.CommandText = queryDelete;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;

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
