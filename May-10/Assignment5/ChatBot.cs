using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ChatBot
    {
        public string greeting;
        public string question;
        public int numericalquery;

        public void DisplayChatBot()
        {
            Console.WriteLine($"greeting:{greeting}");
            Console.WriteLine($"question: {question}");
            Console.WriteLine($"numericalquery:{numericalquery}");
        }
    }
}