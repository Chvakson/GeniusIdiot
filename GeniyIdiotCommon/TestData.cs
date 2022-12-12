namespace GeniyIdiotCommon
{

    public class TestData
    {
        List<Question> questions;
        Question currentQuestion;
        User user;
        int questionsCount;
        int questionNumber = 0;

        public TestData(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAll();
            questionsCount = questions.Count;   
        }

        public Question GetNextQuestion()
        {
            Random random = new Random();
            int randomIndex = random.Next(questions.Count);
            currentQuestion = questions[randomIndex];
            questionNumber++;
            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var trueAnswer = currentQuestion.Answer;
            if (userAnswer == trueAnswer)
            {
                user.TrueAnswerCount++;
            }
            questions.Remove(currentQuestion);
        }

        public string GetQuestionNumberText()
        {
            return $"Вопрос №{questionNumber}";
        }

        public string CalculateDiagnoze()
        {
            user.Diagnoze = Diagnoze.Calculate(questionsCount, user.TrueAnswerCount);
            UserResultsStorage.Append(user);
            return $"Количество верных ответов:{user.TrueAnswerCount}\n{user.Name}, ваш диагноз: {user.Diagnoze}";
        }

        public void ResetData()
        {
            questions = QuestionsStorage.GetAll();
            questionNumber = 0;
            user.TrueAnswerCount = 0;
        }

        public bool End()
        {
            return questions.Count == 0;
        }
    }


}
