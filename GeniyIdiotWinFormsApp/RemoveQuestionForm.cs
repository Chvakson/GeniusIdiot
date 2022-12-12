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
    public partial class RemoveQuestionForm : Form
    {
        List <Question> questions;

        public RemoveQuestionForm()
        {
            InitializeComponent();
            questions = QuestionsStorage.GetAll();
        }

        private void RemoveQuestionForm_Load(object sender, EventArgs e)
        {
            var questionNumber = 1;
            var rowsIndex = 0;
            foreach (var question in questions)
            {
                QuestionsListDataGridView.Rows.Add();
                QuestionsListDataGridView.Rows[rowsIndex].Cells[0].Value = questionNumber;
                QuestionsListDataGridView.Rows[rowsIndex].Cells[1].Value = question.Text;
                QuestionsListDataGridView.Rows[rowsIndex].Cells[2].Value = question.Answer;
                questionNumber++;
                rowsIndex++;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var questionIndex = QuestionsListDataGridView.CurrentCell.RowIndex;
            QuestionsListDataGridView.Rows.RemoveAt(questionIndex);
            QuestionsStorage.Remove(questionIndex);
            MessageBox.Show("Вопрос успешно удален из базы тестирования!");
        }
    }
}
