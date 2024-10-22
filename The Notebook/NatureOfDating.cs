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
    internal class NatureOfDating
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public NatureOfDating() { }

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
            adapter = new SqlDataAdapter("USE Note; SELECT ID_Dating, TheNatureOfDating AS [Характер знакомства] FROM NatureOfDating", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addNature(string TheNatureOfDating)
        {
            if (TheNatureOfDating != "")
            {
                cmd = new SqlCommand("USE Note; INSERT INTO NatureOfDating (TheNatureOfDating) VALUES (@TheNatureOfDating)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@TheNatureOfDating", TheNatureOfDating);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Характер знакомства добавлен", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public void changeNature(string id, string TheNatureOfDating)
        {
            if (id != "" && TheNatureOfDating != "")
            {
                cmd = new SqlCommand("USE Note; UPDATE NatureOfDating SET TheNatureOfDating = @TheNatureOfDating WHERE ID_Dating = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@TheNatureOfDating", TheNatureOfDating);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные характера знакомства изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные характера знакомства");
            }
        }

        public void delNature(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Note; " +
                    "DELETE FROM NatureOfDating WHERE ID_Dating = @id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Характер знакомства удалён", "Внимание!");
            }
            else
            {
                MessageBox.Show("Не выбран Характер знакомства!", "Внимание!");
            }
        }
    }
}
