using System;

namespace SyntaxAndSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // int answer = 4;
            // string response;

            //if (answer < 9)
            //{
            //response = answer + " is less than nine";
            //  Console.WriteLine();
            //}
            //else
            //{
            //response = answer + “greater than or equal to nine”;
            //}

            var answer = 4;

            var response = (answer < 9) ? ($"{answer} is less than nine") : ($"{answer} is greater than or equal to nine");

            Console.WriteLine(response);




        }
    }
}
