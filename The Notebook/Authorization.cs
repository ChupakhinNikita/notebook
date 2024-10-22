using System;
using System.Windows.Forms;

namespace The_Notebook
{
    public partial class Authorization : Form
    {
        private User user = new User();
        private int id = 0;

        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                id = user.authUser(textBoxLogin.Text, textBoxPassword.Text);
                if (id == -1)
                {
                    MessageBox.Show("Пользователя с такими данными не найдено.\nПопробуйте снова!", "Внимание!");
                }
                else {
                    Menu menu = new Menu(id);
                    menu.Show();
                    this.Hide();
                }
            }
            else 
            {
                MessageBox.Show("Введите данные контакта");
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
        }
    }
}
