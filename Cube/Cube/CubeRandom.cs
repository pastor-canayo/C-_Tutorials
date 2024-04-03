using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    public static class CubeRandom
    {
         private static string[] listAnswers = {
            "it is certain", 
            "It is decidedly so", 
            "Without a doubt", 
            "Yes definitely",
            "As I see it, yes",
                 "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
                 "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don’t count on it",
                 "My reply is no",
            "My sources say no",
            "Without a doubt",
            "Outlook not so good", 
            "Very doubtful"
        };

        public static string GenerateList()
        {
            var rand = new Random();
            string randList = listAnswers[rand.Next(listAnswers.Length)];
            return $"{randList}";
        }
    }
}
