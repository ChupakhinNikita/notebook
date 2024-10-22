using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace The_Notebook
{
    internal class Work
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public Work() { }

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
            adapter = new SqlDataAdapter("USE Note; SELECT ID_Work, Work AS [Вид деятельности] FROM Work;", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addWork(string work)
        {
            if (work != "")
            {
                cmd = new SqlCommand("USE Note; INSERT INTO Work (Work) VALUES (@Work)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Work", work);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Тип работы добавлен", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public void changeWork(string id, string work)
        {
            if (id != "" && work != "")
            {
                cmd = new SqlCommand("USE Note; UPDATE Work SET Work = @Work WHERE ID_Work = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@Work", work);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные типа работы изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные типа работы");
            }
        }

        public void delWork(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Note; " +
                    "DELETE FROM Work WHERE ID_Work = @id", connection);
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
