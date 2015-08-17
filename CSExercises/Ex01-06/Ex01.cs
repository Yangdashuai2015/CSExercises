using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            int N ;
            Console.Write("please enter a interger N:\n");
            N = Convert.ToInt32(Console.ReadLine());
            Random X = new Random();
            int G = X.Next(1, N);
            Console.Write("the random num is " + G + "\n");
            double S = Convert.ToDouble(G);
            double J = Convert.ToDouble(N);
            // Console.Write(S + "    " + J);
            double S_square = S;
            while (S_square != J)
            {
                S = (S + J / S) / 2;
                S_square = Math.Round(S * S, 5);
                S = Math.Round(S, 5);
                Console.Write("the square root is {0:0.00000}\n", S);

            };
        }
    }
}