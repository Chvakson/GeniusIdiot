namespace GeniyIdiotCommon
{
    public static class Diagnoze
    {
        public static string Get(int trueAnswersCount)
        {
            string diagnoze = "";
            switch (trueAnswersCount)
            {
                case 0: diagnoze = "Идиот"; break;
                case 1: diagnoze = "Кретин"; break;
                case 2: diagnoze = "Дурак"; break;
                case 3: diagnoze = "Нормальный"; break;
                case 4: diagnoze = "Талант"; break;
                case 5: diagnoze = "Гений"; break;
            }
            return diagnoze;
        }

        public static string Calculate(int questionsCount, int trueAnswersCount)
        {
            int minTrueAnswersDiagnizesCounts = 5;
            int diagnozeCode = 0;
            double minTrueAnswersCount = (double)questionsCount / minTrueAnswersDiagnizesCounts;
            for (int i = 1; trueAnswersCount >= minTrueAnswersCount * i; i++)
            {
                diagnozeCode++;
                continue;
            }
            return Get(diagnozeCode);
        }
    }
}
