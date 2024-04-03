using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube2
{
    public class MagibBall
    {
        private static string[] listAnswers =
        {
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
            var ran = new Random();
            string ransList = listAnswers[ran.Next(listAnswers.Length)];
            return $"{ransList}";
        }
    }
}
