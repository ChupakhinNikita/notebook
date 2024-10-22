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
    internal class PersonalQualities_People
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public PersonalQualities_People() { }

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
                "SELECT ID_People, PersonalQualities_People.ID_Quality, Personal_Qualities AS [Личное качество], Description_Qualities [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality =  PersonalQualities.ID_Quality " +
                "WHERE ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addPersonalQualities_People(int ID_Quality, int ID_People, int ID_User)
        {
            cmd = new SqlCommand("USE Note; INSERT INTO PersonalQualities_People (ID_Quality, ID_People, ID_User) " +
                "VALUES (@ID_Quality, @ID_People, @ID_User)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@ID_Quality", ID_Quality);
            cmd.Parameters.AddWithValue("@ID_People", ID_People);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void delPersonalQualities_People(int ID_Quality, int ID_People, int ID_User)
        {
            connection.Open();
            cmd = new SqlCommand("USE Note; " +
                "DELETE FROM PersonalQualities_People WHERE ID_Quality = @ID_Quality AND ID_People = @ID_People " +
                "AND ID_User = @ID_User", connection);
            cmd.Parameters.AddWithValue("@ID_Quality", ID_Quality);
            cmd.Parameters.AddWithValue("@ID_People", ID_People);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
