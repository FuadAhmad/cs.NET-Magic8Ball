using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    /// <summary>
    /// Entry point for Magic 8 Ball program
    /// </summary>
    class Program
    {
        

        static void Main(string[] args)
        {
            // Preserve console color
            ConsoleColor consolColor = Console.ForegroundColor;

            TellPeopleWhoMadeIt();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("To Exit from this program enter 'quit' or 'end' or 'exit'.");
            Random randomObject = new Random();
            
            while(true)
            {
                string question = AskQuestion();
                
                if (question.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hey Ask a Question Fooool!!!");
                    continue;
                }
                if (question.ToLower() == "quit" || question.ToLower() == "end" || question.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Good Bay.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("  Program is quiting....");
                    break;
                }
                AnsweringYourQuestion(randomObject);
            }


            // clean up coloring
            Console.ForegroundColor = consolColor;
        }

        private static void AnsweringYourQuestion(Random randomObject)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Thinking about your question. Stand by...");
            // Wait for a while before answering
            int timeToWait = (randomObject.Next(4) + 1) * 1000;
            Thread.Sleep(timeToWait);

            int randNo = randomObject.Next(4);
            AnswerOfQuestion(randNo);
        }

        private static string AskQuestion()
        {
            // Promote for asking  a question and
            // store the question
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ask a Questin? ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();
            return questionString;
        }

        private static void TellPeopleWhoMadeIt()
        {
            // change console text color
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Magic 8 Ball (by : Fuad Ahmad)");
        }
        private static void AnswerOfQuestion(int randNo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            switch (randNo)
            {
                case 0:
                    {
                        Console.WriteLine("Yes");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("No");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Your are correct!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("OMG!Exactly");
                        break;
                    }
            }
        }
    }
}
