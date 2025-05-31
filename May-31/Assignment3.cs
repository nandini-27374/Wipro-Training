/*

3. Quiz Application (OOP + Collections)
Concepts: Class design, Dictionary, Random, User input Task:
Create a class Question with text, options, correct answer
Store questions in a list
Display random questions and score the user's answers.

*/

using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        string[] questions = {
            "What is the capital of Bihar?",
            "What is the largest continent in the world?",
            "What is the  chemical Symbol for water?"
        };

        string[,] options =
        {
            { "1.Patna", "2.Kohima", "3.Bangalore", "4.Chennai"
            },
            { "1.Africa", "2.North America", "3.Europe", "4.Asia"
            },
            { "1.HCL", "2.NH3", "3.H2O", "4.CH4"
            }

        };
        int[] answers = { 1, 4, 3 };

        int score = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"\nQuestion {i + 1}:{questions[i]}");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(options[i, j]);
            }

            Console.Write("Your answer is between 1- 4 :");
            int userAnswer;

            while (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer < 1 || userAnswer > 4)
            {
                Console.Write("Invalid input.Please enter a number between 1 and 4:");
            }

            if (userAnswer == answers[i])
            {
                Console.WriteLine("Correct");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong");
            }
        }

        Console.WriteLine($"\nQuiz completed, Your score is {score}/3");
    }
}

/*

Output:

Question 1:What is the capital of Bihar?
1.Patna
2.Kohima
3.Bangalore
4.Chennai
Your answer is between 1- 4 :1
Correct

Question 2:What is the largest continent in the world?
1.Africa
2.North America
3.Europe
4.Asia
Your answer is between 1- 4 :4
Correct

Question 3:What is the  chemical Symbol for water?
1.HCL
2.NH3
3.H2O
4.CH4
Your answer is between 1- 4 :4
Wrong

Quiz completed, Your score is 2/3
*/