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
    internal class PhoneType_People
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public PhoneType_People() { }

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
                "SELECT ID_People, PhoneType_People.ID_PhoneType, Type  AS [Тип телефона] " +
                "FROM PhoneType_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType " +
                "WHERE ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addPhoneType_People(int ID_PhoneType, int ID_People, int ID_User)
        {
            cmd = new SqlCommand("USE Note; INSERT INTO PhoneType_People (ID_PhoneType, ID_People, ID_User) " +
                "VALUES (@ID_PhoneType, @ID_People, @ID_User)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@ID_PhoneType", ID_PhoneType);
            cmd.Parameters.AddWithValue("@ID_People", ID_People);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void delPhoneType_People(int ID_PhoneType, int ID_People, int ID_User)
        {
            connection.Open();
            cmd = new SqlCommand("USE Note; " +
                "DELETE FROM PhoneType_People WHERE ID_PhoneType = @ID_PhoneType AND ID_People = @ID_People " +
                "AND ID_User = @ID_User", connection);
            cmd.Parameters.AddWithValue("@ID_PhoneType", ID_PhoneType);
            cmd.Parameters.AddWithValue("@ID_People", ID_People);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
/*        public void changePhoneType_People(int id, int ID_PhoneType, int ID_People, int ID_User)
        {
            cmd = new SqlCommand("USE Note; UPDATE PhoneType_People SET ID_PhoneType = @ID_PhoneType, ID_People = @ID_People, ID_User = @ID_User WHERE ID_PhoneType = @id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@ID_PhoneType", ID_PhoneType);
            cmd.Parameters.AddWithValue("@ID_People", ID_People);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }*/
