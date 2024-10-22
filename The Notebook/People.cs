using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace The_Notebook
{
    internal class People
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public People() { }

        public Menu Menu
        {
            get => default;
            set
            {
            }
        }

        public ReadPeople ReadPeople
        {
            get => default;
            set
            {
            }
        }

        public ChanhePeople ChanhePeople
        {
            get => default;
            set
            {
            }
        }

        public FormingBirthdayGreetings FormingBirthdayGreetings
        {
            get => default;
            set
            {
            }
        }

        public int getCountAccount(int id)
        {
            cmd = new SqlCommand("USE Note; " +
            "SELECT Count(*) From People WHERE ID_User = @id;"
            , connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            int count = -1;

            if (reader.HasRows) // если есть данные
            {
                // выводим названия столбцов
                while (reader.Read()) // построчно считываем данные
                {
                    count = reader.GetInt32(0);
                }

            }
            reader.Close();
            connection.Close();

            return count;
        }

        public void DisplayFullDataById(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "USE Note;" +
                "SELECT Фамилия, Имя, Отчество, Адрес, " +
                "[Номер телефона], [Эл. Почта], [Семейное положение], [Образование], " +
                "[Ссылка на соцсеть], [День рождения], [Дата знакомства], [Характер знакомства], " +
                "[Тип телефона], [Личное качество], [Описание качества], Профессия, [Описание профессии], [Компания], " +
                "[Адрес компании], [Почта компании], [Сайт компании], [Отдел], [Тип деятельности] " +
                "FROM ( SELECT  People.ID_People,  People.ID_User, People.Surname as Фамилия, " +
                "People.Name as Имя, People.Middle_name as Отчество, People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT People.ID_People, People.ID_User, Type as [Тип телефона] " +
                "FROM PhoneType_People JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, People.ID_User, Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "JOIN (SELECT Profession.ID_People, " +
                "Profession AS Профессия, " +
                "Description_profession AS [Описание профессии], " +
                "Name AS [Компания], Address AS [Адрес компании], " +
                "Email AS [Почта компании], Website AS [Сайт компании], " +
                "Department AS [Отдел], Work AS [Тип деятельности] " +
                "FROM Profession JOIN Organization ON Organization.ID_Organization = Profession.ID_Organization " +
                "JOIN Work ON Organization.ID_Work = Work.ID_Work ) AS Table4 ON Table1.ID_People = Table4.ID_People " +
                "WHERE Table1.ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayDataById(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "SELECT " +
                "Фамилия, " +
                "Имя, " +
                "Отчество, " +
                "Адрес, " +
                "[Номер телефона], " +
                "[Эл. Почта], " +
                "[Семейное положение], " +
                "[Образование], " +
                "[Ссылка на соцсеть], " +
                "[День рождения], " +
                "[Дата знакомства], " +
                "[Характер знакомства], " +
                "[Тип телефона], " +
                "[Личное качество], " +
                "[Описание качества] " +
                "FROM (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "People.Surname as Фамилия, " +
                "People.Name as Имя, " +
                "People.Middle_name as Отчество, " +
                "People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], " +
                "People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], " +
                "People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], " +
                "People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], " +
                "NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People " +
                "JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Type as [Тип телефона] " +
                "FROM PhoneType_People " +
                "JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "WHERE Table1.ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayMinDataById(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "SELECT " +
                "Surname as Фамилия, " +
                "Name as Имя, " +
                "Middle_name as Отчество, " +
                "Address as Адрес, " +
                "Phone_number as [Номер телефона], " +
                "Email as [Эл. Почта], " +
                "Family_status as [Семейное положение], " +
                "Education as [Образование], " +
                "SocialMediaLink as [Ссылка на соцсеть], " +
                "Birthday as [День рождения], " +
                "Date_of_dating as [Дата знакомства] " +
                "FROM People " +
                "WHERE ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayMinDataByIdWithID(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "SELECT " +
                "ID_People, " +
                "Surname as Фамилия, " +
                "Name as Имя, " +
                "Middle_name as Отчество, " +
                "Address as Адрес, " +
                "Phone_number as [Номер телефона], " +
                "Email as [Эл. Почта], " +
                "Family_status as [Семейное положение], " +
                "Education as [Образование], " +
                "SocialMediaLink as [Ссылка на соцсеть], " +
                "Birthday as [День рождения], " +
                "Date_of_dating as [Дата знакомства] " +
                "FROM People " +
                "WHERE ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayDataByIdWithID(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "SELECT " +
                "Table1.ID_People, " +
                "Фамилия, " +
                "Имя, " +
                "Отчество, " +
                "Адрес, " +
                "[Номер телефона], " +
                "[Эл. Почта], " +
                "[Семейное положение], " +
                "[Образование], " +
                "[Ссылка на соцсеть], " +
                "[День рождения], " +
                "[Дата знакомства], " +
                "[Характер знакомства], " +
                "[Тип телефона], " +
                "[Личное качество], " +
                "[Описание качества] " +
                "FROM (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "People.Surname as Фамилия, " +
                "People.Name as Имя, " +
                "People.Middle_name as Отчество, " +
                "People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], " +
                "People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], " +
                "People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], " +
                "People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], " +
                "NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People " +
                "JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Type as [Тип телефона] " +
                "FROM PhoneType_People " +
                "JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "WHERE Table1.ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayDataByAlphabet(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "SELECT " +
                "Фамилия, " +
                "Имя, " +
                "Отчество, " +
                "Адрес, " +
                "[Номер телефона], " +
                "[Эл. Почта], " +
                "[Семейное положение], " +
                "[Образование], " +
                "[Ссылка на соцсеть], " +
                "[День рождения], " +
                "[Дата знакомства], " +
                "[Характер знакомства], " +
                "[Тип телефона], " +
                "[Личное качество], " +
                "[Описание качества] " +
                "FROM (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "People.Surname as Фамилия, " +
                "People.Name as Имя, " +
                "People.Middle_name as Отчество, " +
                "People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], " +
                "People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], " +
                "People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], " +
                "People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], " +
                "NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People " +
                "JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Type as [Тип телефона] " +
                "FROM PhoneType_People " +
                "JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "WHERE Table1.ID_User = " + id + " ORDER BY Фамилия ASC", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayFullDataByIdByAlphabet(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "USE Note;" +
                "SELECT Фамилия, Имя, Отчество, Адрес, " +
                "[Номер телефона], [Эл. Почта], [Семейное положение], [Образование], " +
                "[Ссылка на соцсеть], [День рождения], [Дата знакомства], [Характер знакомства], " +
                "[Тип телефона], [Личное качество], [Описание качества], Профессия, [Описание профессии], [Компания], " +
                "[Адрес компании], [Почта компании], [Сайт компании], [Отдел], [Тип деятельности] " +
                "FROM ( SELECT  People.ID_People,  People.ID_User, People.Surname as Фамилия, " +
                "People.Name as Имя, People.Middle_name as Отчество, People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT People.ID_People, People.ID_User, Type as [Тип телефона] " +
                "FROM PhoneType_People JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, People.ID_User, Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "JOIN (SELECT Profession.ID_People, " +
                "Profession AS Профессия, " +
                "Description_profession AS [Описание профессии], " +
                "Name AS [Компания], Address AS [Адрес компании], " +
                "Email AS [Почта компании], Website AS [Сайт компании], " +
                "Department AS [Отдел], Work AS [Тип деятельности] " +
                "FROM Profession JOIN Organization ON Organization.ID_Organization = Profession.ID_Organization " +
                "JOIN Work ON Organization.ID_Work = Work.ID_Work ) AS Table4 ON Table1.ID_People = Table4.ID_People " +
                "WHERE Table1.ID_User = " + id + " ORDER BY Фамилия ASC", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayFullDataByIdByAdditions(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "USE Note;" +
                "SELECT Фамилия, Имя, Отчество, Адрес, " +
                "[Номер телефона], [Эл. Почта], [Семейное положение], [Образование], " +
                "[Ссылка на соцсеть], [День рождения], [Дата знакомства], [Характер знакомства], " +
                "[Тип телефона], [Личное качество], [Описание качества], Профессия, [Описание профессии], [Компания], " +
                "[Адрес компании], [Почта компании], [Сайт компании], [Отдел], [Тип деятельности] " +
                "FROM ( SELECT  People.ID_People,  People.ID_User, People.Surname as Фамилия, " +
                "People.Name as Имя, People.Middle_name as Отчество, People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT People.ID_People, People.ID_User, Type as [Тип телефона] " +
                "FROM PhoneType_People JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, People.ID_User, Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "JOIN (SELECT Profession.ID_People, " +
                "Profession AS Профессия, " +
                "Description_profession AS [Описание профессии], " +
                "Name AS [Компания], Address AS [Адрес компании], " +
                "Email AS [Почта компании], Website AS [Сайт компании], " +
                "Department AS [Отдел], Work AS [Тип деятельности] " +
                "FROM Profession JOIN Organization ON Organization.ID_Organization = Profession.ID_Organization " +
                "JOIN Work ON Organization.ID_Work = Work.ID_Work ) AS Table4 ON Table1.ID_People = Table4.ID_People " +
                "WHERE Table1.ID_User = " + id + " ORDER BY Table1.ID_People DESC", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayFullDataByIdByBirthday(DataGridView data, int id, string with, string to)
        {
            string inputDate = with;
            DateTime date = DateTime.ParseExact(inputDate, "MM.dd", CultureInfo.InvariantCulture);
            string formattedDate = "-" + date.ToString("dd-MM");
            Console.WriteLine(formattedDate);

            string inputDate2 = to;
            DateTime date2 = DateTime.ParseExact(inputDate2, "MM.dd", CultureInfo.InvariantCulture);
            string formattedDate2 = "-" + date2.ToString("dd-MM");
            Console.WriteLine(formattedDate);
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "USE Note;" +
                "SELECT Фамилия, Имя, Отчество, Адрес, " +
                "[Номер телефона], [Эл. Почта], [Семейное положение], [Образование], " +
                "[Ссылка на соцсеть], [День рождения], [Дата знакомства], [Характер знакомства], " +
                "[Тип телефона], [Личное качество], [Описание качества], Профессия, [Описание профессии], [Компания], " +
                "[Адрес компании], [Почта компании], [Сайт компании], [Отдел], [Тип деятельности] " +
                "FROM ( SELECT  People.ID_People,  People.ID_User, People.Surname as Фамилия, " +
                "People.Name as Имя, People.Middle_name as Отчество, People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT People.ID_People, People.ID_User, Type as [Тип телефона] " +
                "FROM PhoneType_People JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, People.ID_User, Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "JOIN (SELECT Profession.ID_People, " +
                "Profession AS Профессия, " +
                "Description_profession AS [Описание профессии], " +
                "Name AS [Компания], Address AS [Адрес компании], " +
                "Email AS [Почта компании], Website AS [Сайт компании], " +
                "Department AS [Отдел], Work AS [Тип деятельности] " +
                "FROM Profession JOIN Organization ON Organization.ID_Organization = Profession.ID_Organization " +
                "JOIN Work ON Organization.ID_Work = Work.ID_Work ) AS Table4 ON Table1.ID_People = Table4.ID_People " +
                "WHERE Table1.ID_User = " + id + "AND [День рождения] BETWEEN CONCAT(YEAR([День рождения]), '" + formattedDate + "') AND CONCAT(YEAR([День рождения]), '" + formattedDate2 + "')", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayDataByDating(DataGridView data, int id)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                "SELECT " +
                "Фамилия, " +
                "Имя, " +
                "Отчество, " +
                "Адрес, " +
                "[Номер телефона], " +
                "[Эл. Почта], " +
                "[Семейное положение], " +
                "[Образование], " +
                "[Ссылка на соцсеть], " +
                "[День рождения], " +
                "[Дата знакомства], " +
                "[Характер знакомства], " +
                "[Тип телефона], " +
                "[Личное качество], " +
                "[Описание качества] " +
                "FROM (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "People.Surname as Фамилия, " +
                "People.Name as Имя, " +
                "People.Middle_name as Отчество, " +
                "People.Address as Адрес, " +
                "People.Phone_number as [Номер телефона], " +
                "People.Email as [Эл. Почта], " +
                "People.Family_status as [Семейное положение], " +
                "People.Education as [Образование], " +
                "People.SocialMediaLink as [Ссылка на соцсеть], " +
                "People.Birthday as [День рождения], " +
                "People.Date_of_dating as [Дата знакомства], " +
                "NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                "FROM NatureOfDating_People " +
                "JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                "JOIN ( SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Type as [Тип телефона] " +
                "FROM PhoneType_People " +
                "JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                "JOIN (SELECT " +
                "People.ID_People, " +
                "People.ID_User, " +
                "Personal_Qualities as [Личное качество], " +
                "Description_Qualities as [Описание качества] " +
                "FROM PersonalQualities_People " +
                "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                "WHERE Table1.ID_User = " + id + " ORDER BY [Дата знакомства] DESC", connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void DisplayDataByNatureDating(DataGridView data, int id, string natureDating)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("USE Note; " +
                    "USE Note;" +
                    "SELECT Фамилия, Имя, Отчество, Адрес, " +
                    "[Номер телефона], [Эл. Почта], [Семейное положение], [Образование], " +
                    "[Ссылка на соцсеть], [День рождения], [Дата знакомства], [Характер знакомства], " +
                    "[Тип телефона], [Личное качество], [Описание качества], Профессия, [Описание профессии], [Компания], " +
                    "[Адрес компании], [Почта компании], [Сайт компании], [Отдел], [Тип деятельности] " +
                    "FROM ( SELECT  People.ID_People,  People.ID_User, People.Surname as Фамилия, " +
                    "People.Name as Имя, People.Middle_name as Отчество, People.Address as Адрес, " +
                    "People.Phone_number as [Номер телефона], People.Email as [Эл. Почта], " +
                    "People.Family_status as [Семейное положение], People.Education as [Образование], " +
                    "People.SocialMediaLink as [Ссылка на соцсеть], People.Birthday as [День рождения], " +
                    "People.Date_of_dating as [Дата знакомства], NatureOfDating.TheNatureOfDating as [Характер знакомства] " +
                    "FROM NatureOfDating_People JOIN People ON NatureOfDating_People.ID_People = People.ID_People " +
                    "JOIN NatureOfDating ON NatureOfDating_People.ID_Dating = NatureOfDating.ID_Dating) AS Table1 " +
                    "JOIN ( SELECT People.ID_People, People.ID_User, Type as [Тип телефона] " +
                    "FROM PhoneType_People JOIN People ON PhoneType_People.ID_People = People.ID_People " +
                    "JOIN PhoneType ON PhoneType_People.ID_PhoneType = PhoneType.ID_PhoneType) " +
                    "AS Table2 ON Table1.ID_People = Table2.ID_People " +
                    "JOIN (SELECT " +
                    "People.ID_People, People.ID_User, Personal_Qualities as [Личное качество], " +
                    "Description_Qualities as [Описание качества] " +
                    "FROM PersonalQualities_People " +
                    "JOIN People ON PersonalQualities_People.ID_People = People.ID_People " +
                    "JOIN PersonalQualities ON PersonalQualities_People.ID_Quality = PersonalQualities.ID_Quality) " +
                    "AS Table3 ON Table1.ID_People = Table3.ID_People " +
                    "JOIN (SELECT Profession.ID_People, " +
                    "Profession AS Профессия, " +
                    "Description_profession AS [Описание профессии], " +
                    "Name AS [Компания], Address AS [Адрес компании], " +
                    "Email AS [Почта компании], Website AS [Сайт компании], " +
                    "Department AS [Отдел], Work AS [Тип деятельности] " +
                    "FROM Profession JOIN Organization ON Organization.ID_Organization = Profession.ID_Organization " +
                    "JOIN Work ON Organization.ID_Work = Work.ID_Work ) AS Table4 ON Table1.ID_People = Table4.ID_People " +
                    "WHERE [Характер знакомства] = '" + natureDating + "' AND Table1.ID_User = " + id, connection);
            adapter.Fill(dt);
            data.DataSource = dt;
            connection.Close();
        }

        public void addPeople(string surname, string name, string midname, string address, string phoneNumber, string email, string familyStatus, string edu, string link, string birthday, string dateDating, int id_user)
        {
            if (surname != "" && name != "" && midname != "" && address != "" && phoneNumber != "" && email != "" && familyStatus != "" && edu != "" && link != "" && birthday != "" && dateDating != "")
            {
                cmd = new SqlCommand("USE Note; " +
                    "INSERT INTO People (Surname, Name, Middle_name, Address, Phone_number, Email, Family_status, Education, SocialMediaLink, Birthday, Date_of_dating, ID_User) " +
                    "VALUES (@Surname, @Name, @Middle_name, @Address, @Phone_number, @Email, @Family_status, @Education, @SocialMediaLink, @Birthday, @Date_of_dating, @ID_User)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Middle_name", midname);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone_number", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Family_status", familyStatus);
                cmd.Parameters.AddWithValue("@Education", edu);
                cmd.Parameters.AddWithValue("@SocialMediaLink", link);
                cmd.Parameters.AddWithValue("@Birthday", birthday);
                cmd.Parameters.AddWithValue("@Date_of_dating", dateDating);
                cmd.Parameters.AddWithValue("@ID_User", id_user);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Человек добавлен в записную книжку", "Внимание!");
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Внимание!");
            }
        }

        public void changePeople(string id, string surname, string name, string midname, string address, string phoneNumber, string email, string familyStatus, string edu, string link, string birthday, string dateDating, int id_user)
        {
            if (id != "" && surname != "" && name != "" && midname != "" && address != "" && phoneNumber != "" && email != "" && familyStatus != "" && edu != "" && link != "" && birthday != "" && dateDating != "")
            {
                cmd = new SqlCommand("USE Note; " +
                   "UPDATE People SET Surname = @Surname, Name = @Name, Middle_name = @Middle_name, Address = @Address, Phone_number = @Phone_number, Email = @Email, Family_status = @Family_status, Education = @Education, SocialMediaLink = @SocialMediaLink, Birthday = @Birthday, Date_of_dating = @Date_of_dating, ID_User = @ID_User " +
                   "WHERE ID_People = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Middle_name", midname);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone_number", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Family_status", familyStatus);
                cmd.Parameters.AddWithValue("@Education", edu);
                cmd.Parameters.AddWithValue("@SocialMediaLink", link);
                cmd.Parameters.AddWithValue("@Birthday", birthday);
                cmd.Parameters.AddWithValue("@Date_of_dating", dateDating);
                cmd.Parameters.AddWithValue("@ID_User", id_user);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Данные контакта изменены", "Внимание!");
            }
            else
            {
                MessageBox.Show("Введите данные контакта");
            }
        }

        public void delPeople(string id)
        {
            if (id != "")
            {
                connection.Open();
                cmd = new SqlCommand("USE Note; " +
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
    }
}
