using System;

namespace GeniyIdiotCommon
{
    public class User
    {
        public string Name { get;}
        public string Diagnoze { get; set; }
        public int TrueAnswerCount { get; set; }

        public User(string name) 
        {
            Name = name;
        }
    }
}
