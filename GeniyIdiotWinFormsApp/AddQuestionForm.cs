using GeniyIdiotCommon;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var text = InputQuestionTextBox.Text;
            var answer = Convert.ToInt32(InputAnswerTextBox.Text);  
            var question = new Question(text, answer);
            QuestionsStorage.Append(question);
            MessageBox.Show("Ваш вопрос успешно добавлен в базу тестирования!");
            Close();
        }

        private void InputQuestionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputQuestionTextBox.Text))
            {
                userInputErrorProvider.SetError(InputQuestionTextBox, "Пустая строка. Введите ваш вопрос!");
                AddButton.Enabled = false;
            }
            else
            {
                userInputErrorProvider.Clear();
                AddButton.Enabled = true;
            }
        }

        private void InputAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputAnswerTextBox.Text) || !Int32.TryParse(InputAnswerTextBox.Text, out int number))
            {
                userInputErrorProvider.SetError(InputAnswerTextBox, "Введите число в диапозоне от -2 147 483 648 до 2 147 483 647!");
                AddButton.Enabled = false;
            }
            else
            {
                userInputErrorProvider.Clear();
                AddButton.Enabled = true;
            }
        }
    }
}
