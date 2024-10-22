using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System;

namespace The_Notebook
{
    internal class User
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;

        public User() { }

        public Authorization Authorization
        {
            get => default;
            set
            {
            }
        }

        public Registration Registration
        {
            get => default;
            set
            {
            }
        }

        public EditYourData EditYourData
        {
            get => default;
            set
            {
            }
        }

        public Menu Menu
        {
            get => default;
            set
            {
            }
        }

        public void DisplayData(DataGridView data)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; SELECT * FROM [User]", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addUser(string name, string login, string password)
        {
            if (login != "" && name != "" && password != "")
            {
                cmd = new SqlCommand("USE Note; " +
                    "INSERT INTO [User] (Name, Login, Password) " +
                    "VALUES (@Name, @Login, @Password)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Вы успешно зарегистрировались в системе.\n Теперь вы можете войти.", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public int authUser(string login, string password)
        {
            cmd = new SqlCommand("USE Note; " +
                "SELECT ID_User FROM [User] WHERE Login = @Login AND Password = @Password;"
                ,connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            int id = -1;

            if (reader.HasRows) // если есть данные
            {
                // выводим названия столбцов
                while (reader.Read()) // построчно считываем данные
                {
                    id = reader.GetInt32(0);
                }
            }
            reader.Close();
            connection.Close();
            return id;
        }

        public void changeUser(int id, string name, string login, string password)
        {
            if (name != "" && login != "" && password != "")
            {
                cmd = new SqlCommand("USE Note; " +
                   "UPDATE [User] SET Name = @Name, Login = @Login, Password = @Password WHERE ID_User = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ваши данные успешно изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные контакта");
            }
        }

        public void delUser(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Notepad; " +
                    "DELETE FROM People WHERE ID_People = @id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Контакт удалён", "Внимание!");
            }
            else
            {
                MessageBox.Show("Не выбран контакт!", "Внимание!");
            }
        }

        public string getNameUserById(int id) {
            cmd = new SqlCommand("USE Note; " +
                "SELECT Name FROM [User] WHERE ID_User = @id;"
                , connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            string name = "";

            if (reader.HasRows) // если есть данные
            {
                // выводим названия столбцов
                while (reader.Read()) // построчно считываем данные
                {
                    name = reader.GetString(0);
                }

            }
            reader.Close();
            connection.Close();

            return name;
        }

        public string[] getUserById(int id)
        {
            cmd = new SqlCommand("USE Note; " +
                "SELECT Name, Login, Password From [User] WHERE ID_User = @id;"
                , connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            string[] user = new string[3];

            if (reader.HasRows) // если есть данные
            {
                // выводим названия столбцов
                while (reader.Read()) // построчно считываем данные
                {
                    user[0] = reader.GetString(0);
                    user[1] = reader.GetString(1);
                    user[2] = reader.GetString(2);
                }
            }
            reader.Close();
            connection.Close();

            return user;
        }
    }
}
