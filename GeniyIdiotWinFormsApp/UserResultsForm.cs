using GeniyIdiotCommon;
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
    public partial class UserResultsForm : Form
    {
        public UserResultsForm()
        {
            InitializeComponent();
        }

        //private void UserResultsForm_Load(object sender, DataGridViewCellEventArgs e)
        //{
        //    var results = UserResultsStorage.GetAll();
        //    foreach (var result in results)
        //    {
        //        ResultsDataGridView.Rows.Add(result);
        //    }
        //}

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultsStorage.GetAll();
            foreach (var result in results)
            {
                ResultsDataGridView.Rows.Add(result.Name, result.TrueAnswerCount, result.Diagnoze);
            }
        }
    }
}
