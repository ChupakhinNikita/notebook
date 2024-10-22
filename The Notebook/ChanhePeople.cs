using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace The_Notebook
{
    public partial class ChanhePeople : Form
    {
        int id;
        private People human = new People();
        private Profession prof = new Profession();
        private Organization org = new Organization();
        private Work work = new Work();

        private NatureOfDating nature = new NatureOfDating();
        private PhoneType phone = new PhoneType();
        private PersonalQualities qualities = new PersonalQualities();

        private NatureOfDating_People naturePeople = new NatureOfDating_People();
        private PersonalQualities_People qualitiesPeople = new PersonalQualities_People();
        private PhoneType_People phonePeople = new PhoneType_People();

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;


        public ChanhePeople(int id)
        {
            InitializeComponent();
            this.id = id;
            human.DisplayMinDataByIdWithID(dataGridView1, id);
            human.DisplayMinDataByIdWithID(dataGridView3, id);
            prof.DisplayData(dataGridView2, id);
            org.DisplayData(dataGridView4);
            org.DisplayData(dataGridView7);
            work.DisplayData(dataGridView5);
            work.DisplayData(dataGridView6);


            nature.DisplayData(dataGridViewNatureDating);
            phone.DisplayData(dataGridViewTelephone);
            qualities.DisplayData(dataGridViewQuality);

            nature.DisplayData(dataGridView9);
            phone.DisplayData(dataGridView8);
            qualities.DisplayData(dataGridView10);

            naturePeople.DisplayData(dataGridView13, id);
            qualitiesPeople.DisplayData(dataGridView12, id);
            phonePeople.DisplayData(dataGridView11, id);

        }

        private void ChanhePeople_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxMidName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxSemPoloj.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxEdu.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxLink.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBoxBirthday.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBoxDateDating.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void createBase_Click(object sender, EventArgs e)
        {
            human.addPeople(textBoxSurname.Text, textBoxName.Text, textBoxMidName.Text, textBoxAddress.Text, textBoxNumber.Text, textBoxEmail.Text, textBoxSemPoloj.Text, textBoxEdu.Text, textBoxLink.Text, textBoxBirthday.Text, textBoxDateDating.Text, id);
            human.DisplayMinDataByIdWithID(dataGridView1, id);
            human.DisplayMinDataByIdWithID(dataGridView3, id);
            Clear();
        }

        public void Clear()
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxAddress.Text = "";
            textBoxSemPoloj.Text = "";
            textBoxNumber.Text = "";
            textBoxEmail.Text = "";
            textBoxLink.Text = "";
            textBoxEdu.Text = "";
            textBoxDateDating.Text = "";
            textBoxBirthday.Text = "";
            textBoxMidName.Text = "";
            textBoxID.Text = "";

            textBoxIDProf.Text = "";
            textBoxProf.Text = "";
            textBoxDescProf.Text = "";
            textBoxID_ORG.Text = "";
            textBoxID_PEOPLE.Text = "";
            textBoxID_WORK.Text = "";

            textBoxIDorg.Text = "";
            textBoxNameOrg.Text = "";
            textBoxAddressOrg.Text = "";
            textBoxEmailOrg.Text = "";
            textBoxWebSiteorg.Text = "";
            textBoxDepartmentOrg.Text = "";
            textBoxIDWorkOrg.Text = "";

            textBoxIDWORK.Text = "";
            textBoxNameWork.Text = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            textBoxD_Q.Text = "";
            textBoxQ.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxNAture.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            human.changePeople(textBoxID.Text, textBoxSurname.Text, textBoxName.Text, textBoxMidName.Text, textBoxAddress.Text, textBoxNumber.Text, textBoxEmail.Text, textBoxSemPoloj.Text, textBoxEdu.Text, textBoxLink.Text, textBoxBirthday.Text, textBoxDateDating.Text, id);
            human.DisplayMinDataByIdWithID(dataGridView1, id);
            human.DisplayMinDataByIdWithID(dataGridView3, id);
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            human.delPeople(textBoxID.Text);
            human.DisplayMinDataByIdWithID(dataGridView1, id);
            human.DisplayMinDataByIdWithID(dataGridView3, id);
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prof.addProf(textBoxProf.Text, textBoxDescProf.Text, textBoxID_ORG.Text, textBoxID_WORK.Text, textBoxID_PEOPLE.Text, id);
            prof.DisplayData(dataGridView2, id);
            Clear();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxIDProf.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxProf.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDescProf.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxID_ORG.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxID_PEOPLE.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxID_WORK.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prof.changeProf(textBoxIDProf.Text , textBoxProf.Text, textBoxDescProf.Text, textBoxID_ORG.Text, textBoxID_WORK.Text, textBoxID_PEOPLE.Text, id);
            prof.DisplayData(dataGridView2, id);
            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prof.delProf(textBoxIDProf.Text);
            prof.DisplayData(dataGridView2, id);
            Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            org.addOrg(textBoxNameOrg.Text, textBoxAddressOrg.Text, textBoxEmailOrg.Text, textBoxWebSiteorg.Text, textBoxDepartmentOrg.Text, textBoxIDWorkOrg.Text);
            org.DisplayData(dataGridView4);
            org.DisplayData(dataGridView7);
            Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            org.changeOrg(textBoxIDorg.Text, textBoxNameOrg.Text, textBoxAddressOrg.Text, textBoxEmailOrg.Text, textBoxWebSiteorg.Text, textBoxDepartmentOrg.Text, textBoxIDWorkOrg.Text);
            org.DisplayData(dataGridView4);
            org.DisplayData(dataGridView7);
            Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            org.delOrg(textBoxIDorg.Text);
            org.DisplayData(dataGridView4);
            org.DisplayData(dataGridView7);
            Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            work.addWork(textBoxNameWork.Text);
            work.DisplayData(dataGridView5);
            work.DisplayData(dataGridView6);
            Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            work.changeWork(textBoxIDWORK.Text, textBoxNameWork.Text);
            work.DisplayData(dataGridView5);
            work.DisplayData(dataGridView6);
            Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            work.delWork(textBoxIDWORK.Text);
            work.DisplayData(dataGridView5);
            work.DisplayData(dataGridView6);
            Clear();
        }

        private void dataGridView7_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxIDorg.Text = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNameOrg.Text = dataGridView7.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAddressOrg.Text = dataGridView7.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxEmailOrg.Text = dataGridView7.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxWebSiteorg.Text = dataGridView7.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxDepartmentOrg.Text = dataGridView7.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxIDWorkOrg.Text = dataGridView7.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView6_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxIDWORK.Text = dataGridView6.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNameWork.Text = dataGridView6.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            qualities.addQuality(textBoxQ.Text ,textBoxD_Q.Text);
            qualities.DisplayData(dataGridViewQuality);
            Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            qualities.changeQuality(ID_QUALITY.Text ,textBoxQ.Text, textBoxD_Q.Text);
            qualities.DisplayData(dataGridViewQuality);
            Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            qualities.delQuality(ID_QUALITY.Text);
            qualities.DisplayData(dataGridViewQuality);
            Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            nature.addNature(textBoxNAture.Text);
            nature.DisplayData(dataGridViewNatureDating);
            Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            nature.changeNature(ID_NATURE.Text, textBoxNAture.Text);
            nature.DisplayData(dataGridViewNatureDating);
            Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            nature.delNature(ID_NATURE.Text);
            nature.DisplayData(dataGridViewNatureDating);
            Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            phone.addPhoneType(textBoxPhoneNumber.Text);
            phone.DisplayData(dataGridViewTelephone);
            Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            phone.changePhoneType(ID_TYPE.Text, textBoxPhoneNumber.Text);
            phone.DisplayData(dataGridViewTelephone);
            Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            phone.delPhoneType(ID_TYPE.Text);
            phone.DisplayData(dataGridViewTelephone);
            Clear();
        }

        private void dataGridViewQuality_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_QUALITY.Text = dataGridViewQuality.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxQ.Text = dataGridViewQuality.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxD_Q.Text = dataGridViewQuality.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridViewNatureDating_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_NATURE.Text  = dataGridViewNatureDating.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNAture.Text = dataGridViewNatureDating.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewTelephone_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_TYPE.Text = dataGridViewTelephone.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPhoneNumber.Text = dataGridViewTelephone.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            qualitiesPeople.addPersonalQualities_People(int.Parse(textBox2.Text), int.Parse(textBox1.Text), id);
            qualitiesPeople.DisplayData(dataGridView12, id);
            Clear();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            qualitiesPeople.delPersonalQualities_People(int.Parse(textBox2.Text), int.Parse(textBox1.Text), id);
            qualitiesPeople.DisplayData(dataGridView12, id);
            Clear();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            naturePeople.addNatureOfDating_People(int.Parse(textBox4.Text), int.Parse(textBox3.Text), id);
            naturePeople.DisplayData(dataGridView13, id);
            Clear();
        }
        private void button28_Click(object sender, EventArgs e)
        {
            naturePeople.delNatureOfDating_People(int.Parse(textBox4.Text), int.Parse(textBox3.Text), id);
            naturePeople.DisplayData(dataGridView13, id);
            Clear();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            phonePeople.addPhoneType_People(int.Parse(textBox6.Text), int.Parse(textBox5.Text), id);
            phonePeople.DisplayData(dataGridView11, id);
            Clear();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            phonePeople.delPhoneType_People(int.Parse(textBox6.Text), int.Parse(textBox5.Text), id);
            phonePeople.DisplayData(dataGridView11, id);
            Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form newForm = Application.OpenForms[1];
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Show();
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
