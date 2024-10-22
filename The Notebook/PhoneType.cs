using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Notebook
{
    internal class PhoneType
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public PhoneType() { }

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
            adapter = new SqlDataAdapter("USE Note; SELECT ID_PhoneType, Type  AS [Тип телефона] FROM PhoneType", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addPhoneType(string Type)
        {
            if (Type != "")
            {
                cmd = new SqlCommand("USE Note; INSERT INTO PhoneType (Type) VALUES (@Type)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Тип телефона добавлен", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public void changePhoneType(string id, string Type)
        {
            if (id != "" && Type != "")
            {
                cmd = new SqlCommand("USE Note; UPDATE PhoneType SET Type = @Type WHERE ID_PhoneType = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные типа телефона изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные типа телефона");
            }
        }

        public void delPhoneType(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Note; " +
                    "DELETE FROM PhoneType WHERE ID_PhoneType = @id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Тип телефона удалён", "Внимание!");
            }
            else
            {
                MessageBox.Show("Не выбран тип телефона!", "Внимание!");
            }
        }
    }
}
