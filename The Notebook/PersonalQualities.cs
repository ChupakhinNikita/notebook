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
    internal class PersonalQualities
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public PersonalQualities() { }

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
            adapter = new SqlDataAdapter("USE Note; SELECT ID_Quality, Personal_Qualities AS [Личное качество], Description_Qualities [Описание качества] FROM PersonalQualities", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addQuality(string Personal_Qualities, string Description_Qualities)
        {
            if (Personal_Qualities != "" && Description_Qualities != "")
            {
                cmd = new SqlCommand("USE Note; INSERT INTO PersonalQualities (Personal_Qualities, Description_Qualities) VALUES (@Personal_Qualities, @Description_Qualities)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Personal_Qualities", Personal_Qualities);
                cmd.Parameters.AddWithValue("@Description_Qualities", Description_Qualities);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Тип работы добавлен", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public void changeQuality(string id, string Personal_Qualities, string Description_Qualities)
        {
            if (id != "" && Personal_Qualities != "" && Description_Qualities != "")
            {
                cmd = new SqlCommand("USE Note; UPDATE PersonalQualities SET Personal_Qualities = @Personal_Qualities, Description_Qualities = @Description_Qualities WHERE ID_Quality = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@Personal_Qualities", Personal_Qualities);
                cmd.Parameters.AddWithValue("@Description_Qualities", Description_Qualities);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные типа работы изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные типа работы");
            }
        }

        public void delQuality(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Note; " +
                    "DELETE FROM PersonalQualities WHERE ID_Quality = @id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Тип работы удалён", "Внимание!");
            }
            else
            {
                MessageBox.Show("Не выбран тип работы!", "Внимание!");
            }
        }
    }
}
