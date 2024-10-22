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
    internal class NatureOfDating_People
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public NatureOfDating_People() { }

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
                "SELECT ID_People, NatureOfDating_People.ID_Dating, TheNatureOfDating AS [Характер знакомства] " +
                "FROM NatureOfDating_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating " +
                "WHERE ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addNatureOfDating_People(int ID_Dating, int ID_People, int ID_User)
        {
            cmd = new SqlCommand("USE Note; INSERT INTO NatureOfDating_People (ID_Dating, ID_People, ID_User) " +
                "VALUES (@ID_Dating, @ID_People, @ID_User)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@ID_Dating", ID_Dating);
            cmd.Parameters.AddWithValue("@ID_People", ID_People);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void delNatureOfDating_People(int ID_Dating, int ID_People, int ID_User)
        {
            connection.Open();
            cmd = new SqlCommand("USE Note; " +
                "DELETE FROM NatureOfDating_People WHERE ID_Dating = @ID_Dating AND ID_People = @ID_People " +
                "AND ID_User = @ID_User", connection);
            cmd.Parameters.AddWithValue("@ID_Dating", ID_Dating);
            cmd.Parameters.AddWithValue("@ID_People", ID_People);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
