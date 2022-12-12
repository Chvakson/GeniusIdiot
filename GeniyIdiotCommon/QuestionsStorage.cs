using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;

namespace GeniyIdiotCommon
{
    public static class QuestionsStorage
    {
        private static string fileName = "questionsAnswers.json";

        public static List<Question> GetAll()
        {
            var questions = new List<Question>();
            if (File.Exists(fileName))
            {
                var data = FileSystem.Get(fileName);
                questions = JsonConvert.DeserializeObject<List<Question>>(data);
            }

            else
            {
                questions.Add(new Question("Сколько цифр 9 в ряду чисел от 1 до 100?", 20));
                questions.Add(new Question("Сколько дециметров в одном метре?", 10));
                questions.Add(new Question("На руках - 10 пальцев. Сколько пальцев на 10 руках?", 50));
                questions.Add(new Question("Сколько будет половина четверти одной десятой от 400?", 5));
                questions.Add(new Question("У фермера 17 овец, и все, кроме 9, умирают. Сколько осталось?", 9));
                FileSystem.Save(fileName, JsonConvert.SerializeObject(questions, Formatting.Indented));
            }
            return questions;
        }

        public static void Append(Question newQuestion)
        {
            var questions = GetAll();
            questions.Add(newQuestion);
            FileSystem.Save(fileName, JsonConvert.SerializeObject(questions, Formatting.Indented));
        }

        public static void Remove(int removeQuestionIndex)
        {
            var questions = GetAll();
            questions.RemoveAt(removeQuestionIndex);
            FileSystem.Save(fileName, JsonConvert.SerializeObject(questions, Formatting.Indented)); 
        }
    }
}
