using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiotCommon
{
    public static class UserResultsStorage
    {
        private static string fileName = "testResults.json";

        public static void Append(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            Save(usersResults);
        }

        public static List<User> GetAll()
        {
            if (!File.Exists(fileName))
            {
                return new List<User>();    
            }
            var data = FileSystem.Get(fileName);
            var userResults = JsonConvert.DeserializeObject<List<User>>(data);
            return userResults;
        }

        public static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileSystem.Save(fileName, jsonData);
        }
    }
}
