using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Notebook
{
    public partial class EditYourData : Form
    {
        User user = new User();

        int id;

        public EditYourData()
        {
            InitializeComponent();
        }

        public EditYourData(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void EditYourData_Load(object sender, EventArgs e)
        {
            string[] userData = user.getUserById(id);
            textBoxName.Text = userData[0];
            textBoxLoginReg.Text = userData[1]; 
            textBoxPasswordReg.Text = userData[2];
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form newForm = Application.OpenForms[1];
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Show();
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            user.changeUser(id, textBoxName.Text, textBoxLoginReg.Text, textBoxPasswordReg.Text);
        }
    }
}
