using System;
using System.Windows.Forms;

namespace The_Notebook
{
    public partial class ReadPeople : Form
    {
        ReportServise report = new ReportServise();
        People people = new People();
        
        int id = 0;

        public ReadPeople()
        {
            InitializeComponent();
        }

        public ReadPeople(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ReadPeople_Load(object sender, EventArgs e)
        {
            people.DisplayFullDataById(dataGridView1, id);
        }

        private void buttonRedactorData_Click(object sender, EventArgs e)
        {
            people.DisplayDataByAlphabet(dataGridView1, id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            people.DisplayDataByDating(dataGridView1, id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            people.DisplayFullDataById(dataGridView1, id);
            textBoxNatureDating.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            people.DisplayDataByNatureDating(dataGridView1, id, textBoxNatureDating.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            report.ExportExcel(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report.ExportWord(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form newForm = Application.OpenForms[1];
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            people.DisplayFullDataByIdByAdditions(dataGridView1, id);
        }
    }
}