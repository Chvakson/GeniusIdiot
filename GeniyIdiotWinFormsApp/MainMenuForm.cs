using GeniusIdiotWindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void StartTestingButton_Click(object sender, EventArgs e)
        {
            new UserNameForm().Show();
        }

        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
            new UserResultsForm().ShowDialog();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            new AddQuestionForm().ShowDialog();
        }

        private void RemoveQuestionButton_Click(object sender, EventArgs e)
        {
            new RemoveQuestionForm().ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
