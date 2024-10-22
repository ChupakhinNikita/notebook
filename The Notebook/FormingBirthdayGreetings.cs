using System;
using System.Windows.Forms;

namespace The_Notebook
{
    public partial class FormingBirthdayGreetings : Form
    {

        User user = new User();
        ReportServise report = new ReportServise();
        People people = new People();

        int id;
        public FormingBirthdayGreetings()
        {
            InitializeComponent();
        }

        public FormingBirthdayGreetings(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form newForm = Application.OpenForms[1];
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Show();
            this.Close();
        }

        private void FormingBirthdayGreetings_Load(object sender, EventArgs e)
        {
            people.DisplayFullDataById(dataGridView1, id);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            report.ExportExcel(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            report.ExportWord(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myName = user.getNameUserById(id);
            MessageBox.Show("С днем рождения, [Имя именинника]!\r\n\r\nПусть этот день станет началом новых приключений, исполнения заветных желаний и счастливых моментов. Желаю тебе неиссякаемой энергии и оптимизма, чтобы каждый день был наполнен радостью и успехами. Пусть тебе сопутствует удача во всех делах и ты всегда окружен заботой и любовью близких людей.\r\n\r\nС наилучшими пожеланиями, " + myName, "Шаблон №1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string myName = user.getNameUserById(id);
            MessageBox.Show("Дорогой(ая) [Имя именинника],\r\n\r\nПоздравляю тебя с днем рождения! Желаю тебе огромного счастья, здоровья и успехов во всех начинаниях. Пусть этот день будет наполнен радостью, улыбками и любовью. Желаю, чтобы твои мечты сбывались, а жизнь была полна ярких и незабываемых моментов.\r\n\r\nС теплом и искренними пожеланиями,\r\n" + myName, "Шаблон №2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            people.DisplayFullDataByIdByBirthday(dataGridView1, id, textBoxNAture.Text, textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            people.DisplayFullDataById(dataGridView1, id);
            textBox1.Text = "";
            textBoxNAture.Text = "";
        }
    }
}
