using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace The_Notebook
{
    internal class Profession
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public Profession() { }

        public ChanhePeople ChanhePeople
        {
            get => default;
            set
            {
            }
        }

        public void DisplayData(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "SELECT ID_Profession, Profession AS Профессия, Description_profession AS Описание, " +
                "ID_Organization, ID_Work, ID_People FROM Profession WHERE ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addProf(string prof, string desc, string idOrg, string idWork, string idPeople, int id_user)
        {
            if (prof != "" && desc != "" && idOrg != "" && idWork != "" && idPeople != "")
            {
                cmd = new SqlCommand("USE Note; " +
                    "INSERT INTO Profession (Profession, Description_Profession, ID_Organization, ID_Work, ID_People, ID_User) " +
                    "VALUES (@Profession, @Description, @ID_Organization, @ID_Work, @ID_People, @ID_User)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Profession", prof);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@ID_Organization", int.Parse(idOrg));
                cmd.Parameters.AddWithValue("@ID_Work", int.Parse(idWork));
                cmd.Parameters.AddWithValue("@ID_People", int.Parse(idPeople));
                cmd.Parameters.AddWithValue("@ID_User", id_user);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Профессия добавлена контакту в записной книжке", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public void changeProf(string id, string prof, string desc, string idOrg, string idWork, string idPeople, int id_user)
        {
            if (id != "" && prof != "" && desc != "" && idOrg != "" && idWork != "" && idPeople != "")
            {
                cmd = new SqlCommand("USE Note; " +
                   "UPDATE Profession SET Profession = @Profession, Description_profession = @Description, ID_Organization = @ID_Organization, ID_Work = @ID_Work, ID_People = @ID_People, ID_User = @ID_User" +
                   "WHERE ID_Profession = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@Profession", prof);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@ID_Organization", int.Parse(idOrg));
                cmd.Parameters.AddWithValue("@ID_Work", int.Parse(idWork));
                cmd.Parameters.AddWithValue("@ID_People", int.Parse(idPeople));
                cmd.Parameters.AddWithValue("@ID_User", id_user);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные контакта изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные профессии");
            }
        }

        public void delProf(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Note; " +
                    "DELETE FROM Profession WHERE ID_Profession = @id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Профессия удалена у контакта", "Внимание!");
            }
            else
            {
                MessageBox.Show("Не выбрана профессия контакта!", "Внимание!");
            }
        }
    }
}
