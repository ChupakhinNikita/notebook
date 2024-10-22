using System;
using System.Windows.Forms;

namespace The_Notebook
{
    public partial class Registration : Form
    {
        private User user = new User();
        private int id = -1;

        public Registration()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            user.addUser(textBoxName.Text, textBoxLoginReg.Text, textBoxPasswordReg.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form newForm = Application.OpenForms[0];
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Show();
            this.Close();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
