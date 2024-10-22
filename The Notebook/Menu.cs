using System;
using System.Windows.Forms;

namespace The_Notebook
{
    public partial class Menu : Form
    {
        User user = new User();
        People people = new People();
        int id = 0;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void buttonReadPeople_Click(object sender, EventArgs e)
        {
            ReadPeople edit = new ReadPeople(id);
            edit.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string name = user.getNameUserById(id);
            int count = people.getCountAccount(id);

            if (count == 0)
            {
                label1.Text = name + ", у вас пока нету контактов в нашей системе,\nно вы можете их добавить";
            }
            else 
            {
                string word;
                if (count % 10 == 1 && count % 100 != 11)
                {
                    word = "контакт";
                }
                else if ((count % 10 >= 2 && count % 10 <= 4) && (count % 100 < 10 || count % 100 >= 20))
                {
                    word = "контакта";
                }
                else
                {
                    word = "контактов";
                }

                label1.Text = name + ", у вас " + count + " " + word + " в нашей системе";
            }
        }

        private void buttonRedactorData_Click(object sender, EventArgs e)
        {
            EditYourData edit = new EditYourData(id);
            edit.Show();
        }

        private void buttonChangePeople_Click(object sender, EventArgs e)
        {
            ChanhePeople change = new ChanhePeople(id);
            change.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form newForm = Application.OpenForms[0];
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormingBirthdayGreetings edit = new FormingBirthdayGreetings(id);
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
