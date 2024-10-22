using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace The_Notebook
{
    internal class Organization
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public Organization() { }

        public ChanhePeople ChanhePeople
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
            adapter = new SqlDataAdapter("USE Note; SELECT ID_Organization, Name AS Компания, Address AS [Адрес компании], Email AS [Почта компании], " +
                "Website AS [Сайт], Department AS [Отдел], ID_Work FROM Organization", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addOrg(string name, string address, string email, string web, string department, string idWork)
        {
            if (name != "" && address != "" && email != "" && web != "" && department != "" && idWork != "")
            {
                cmd = new SqlCommand("USE Note; " +
                    "INSERT INTO Organization (Name, Address, Email, Website, Department, ID_Work) " +
                    "VALUES (@Name, @Address, @Email, @Website, @Department, @ID_Work)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Website", web);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@ID_Work", int.Parse(idWork));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Человек добавлен  в записную книжку", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public void changeOrg(string id, string name, string address, string email, string web, string department, string idWork)
        {
            if (id != "" && name != "" && address != "" && email != "" && web != "" && department != "" && idWork != "")
            {
                cmd = new SqlCommand("USE Note; " +
                   "UPDATE Organization SET Name = @Name, Address = @Address, Email = @Email, Website = @Website, Department = @Department, ID_Work = @ID_Work " +
                   "WHERE ID_Organization = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Website", web);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@ID_Work", int.Parse(idWork));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные контакта изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные контакта");
            }
        }

        public void delOrg(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Note; " +
                    "DELETE FROM Organization WHERE ID_Organization = @id", connection);
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
    }
}
