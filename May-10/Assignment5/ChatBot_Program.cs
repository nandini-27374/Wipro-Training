using ConsoleApp1;

using System;
using System.Numerics;
using System.Reflection.Metadata;

class Program1
{
    static void Main()
    {
        ChatBot chatbot = new ChatBot();
        chatbot.greeting = "Good Morning";
        chatbot.question = "How are you?";
        chatbot.numericalquery = 42;

        chatbot.DisplayChatBot();
    }
}