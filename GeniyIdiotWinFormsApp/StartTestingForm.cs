using GeniyIdiotCommon;
using GeniyIdiotWinFormsApp;

namespace GeniusIdiotWindowsFormsApp1
{

    public partial class StartTestingForm : Form
    {
        TestData TestData;
        User User;
        int TimeAmount;

        public StartTestingForm(string userName)
        {
            InitializeComponent();
            User = new User(userName);
            TestData = new TestData(User);
        }

        public void StartTestingForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание! Для ответа на вопрос дается 10 секунд!");
            ShowNextQuestions();
            Timer.Enabled = true;
        }

        private void ShowNextQuestions()
        {
            TimeAmount = 10;

            var currentQuestion = TestData.GetNextQuestion();
            questionTextLable.Text = currentQuestion.Text;
            questionNumberLabel.Text = TestData.GetQuestionNumberText();
            nextButton.Enabled = false;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            TestData.AcceptAnswer(Convert.ToInt32(userAnswerTextBox.Text));
            AcceptAnswer();
        }

        private void userAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userAnswerTextBox.Text) || !Int32.TryParse(userAnswerTextBox.Text, out int number))
            {
                userAnswerErrorProvider.SetError(userAnswerTextBox, "Введите число в диапозоне от -2 147 483 648 до 2 147 483 647!");
                nextButton.Enabled = false;
            }
            else
            {
                userAnswerErrorProvider.Clear();
                nextButton.Enabled = true;
            }
        }

        private void AcceptAnswer()
        {
            if (TestData.End())
            {
                Timer.Stop();
                var message = TestData.CalculateDiagnoze();
                MessageBox.Show(message);
                Close();
                new RestartTestForm(User.Name).ShowDialog();
            }
            else
            {
                userAnswerTextBox.Clear();
                ShowNextQuestions();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = TimeAmount--.ToString();
            if (TimeAmount < 0)
            {
                TestData.AcceptAnswer(-0);
                AcceptAnswer();
            }
        }
    }
}
