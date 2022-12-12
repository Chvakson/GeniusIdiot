using System;
using System.Collections.Generic;
using System.Linq;
using GeniyIdiotCommon;

namespace GeniusIdiotConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            bool userExitAnswer = true;
            while (userExitAnswer == true)
            {
                PrintProgramMenu();
                int userInputNumber = IsNumber(Console.ReadLine());
                switch (userInputNumber)
                {
                    case 1: TestingUser(); break;
                    case 2: AddNewQueston(); break;
                    case 3: CreateQueston(); break;
                    case 4: PrintUserResultsTable(); break;
                    case 5: userExitAnswer = false; break;
                }
            }
            Console.WriteLine();
        }

        static void PrintProgramMenu()
        {
            Console.WriteLine("Введите номер действия:");
            Console.WriteLine("1. Начать тестирование");
            Console.WriteLine("2. Добавить новый вопрос в базу тестирования");
            Console.WriteLine("3. Удалить существующий вопрос из базы тестирования");
            Console.WriteLine("4. Показать таблицу результатов тестирования");
            Console.WriteLine("5. Выход");
        }

        static void TestingUser()
        {
            Console.WriteLine("Введите через пробел ваши фамилию имя и отчество");
            var user = new User(Console.ReadLine());
            var testData = new TestData(user);
            Console.WriteLine();
            string userAnswer = "да";
            while (userAnswer == "да")
            {
                while (!testData.End())
                {
                    var currentQuestion = testData.GetNextQuestion();
                    Console.WriteLine($"{testData.GetQuestionNumberText()}\n{currentQuestion.Text}");
                    testData.AcceptAnswer(IsNumber(Console.ReadLine()));
                }
                Console.WriteLine(testData.CalculateDiagnoze());
                Console.WriteLine("\nХотите снова пройти тест?\nВведите \"да\" или \"нет\"");
                testData.ResetData();
                userAnswer = AnswerYesNo(Console.ReadLine());
            }
        }
        static void AddNewQueston()
        {
            Console.WriteLine("Введите ваш вопрос");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на ваш вопрос");
            var answer = IsNumber(Console.ReadLine());
            var question = new Question(text, answer);
            QuestionsStorage.Append(question);
            Console.WriteLine("Ваш вопрос успешно добавлен в базу тестирования!\n");
        }

        static void CreateQueston()
        {
            int questionNumber = 1;
            var questions = QuestionsStorage.GetAll();
            if (questions.Count == 0)
                Console.WriteLine("В базе тестирования нет вопросов\n");
            else
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    Console.WriteLine($"{questionNumber++}.{questions[i].Text}");
                }
                Console.WriteLine("Введите номер вопроса, который хотите удалить");
                var removeQuestionNumber = IsNumber(Console.ReadLine());
                while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
                {
                    Console.WriteLine($"Введите число от 1 до {questions.Count}!");
                    removeQuestionNumber = IsNumber(Console.ReadLine());
                }
                QuestionsStorage.Remove(removeQuestionNumber - 1);
                Console.WriteLine("Вопрос успешно удален из базы тестирования!\n");
            }
        }

        static void PrintUserResultsTable()
        {
            string tableFormat = "| {0, -30} | {1, -30} | {2, -10} |";
            int stringLength = string.Format(tableFormat, "arg1", "arg2", "arg3").Length;
            Console.WriteLine(new string('-', stringLength));
            Console.WriteLine(tableFormat, "ФИО", "Количество правильных ответов", "Диагноз");
            Console.WriteLine(new string('-', stringLength));
            foreach (User user in UserResultsStorage.GetAll())
            {
                Console.WriteLine(tableFormat, user.Name, user.TrueAnswerCount, user.Diagnoze);
            }
            Console.WriteLine(new string('-', stringLength));
        }

        static string AnswerYesNo(string userAnswer)
        {
            while (userAnswer != "да" && userAnswer != "нет")
            {
                Console.WriteLine("Неверный ввод! Повторите попытку!");
                userAnswer = Console.ReadLine().ToLower();
            }
            return userAnswer;
        }

        static int IsNumber(string userAnswer)
        {
            int number;
            while (true)
            {
                if (int.TryParse(userAnswer, out number))
                {
                    break;
                }
                Console.WriteLine("Неверный ввод! Введите число в диапозоне от -2 147 483 648 до 2 147 483 647!");
                userAnswer = Console.ReadLine();
            }
            return number;
        }
    }
}
