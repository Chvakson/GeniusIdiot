using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniusIdiotWindowsFormsApp1;
using GeniyIdiotCommon;

namespace GeniyIdiotWinFormsApp
{
    public partial class UserNameForm : Form
    {
        public UserNameForm()
        {
            InitializeComponent();
        }

        private void InputUserNameButton_Click(object sender, EventArgs e)
        {
            var startTesting = new StartTestingForm(userNameTextBox.Text);
            startTesting.Show();
            Close();
        }
    }
}
