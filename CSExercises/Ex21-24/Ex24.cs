
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("please enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int sn = r.Next(1, N + 1);
            double G=sn,Z;

            do
            {
                G = (G + N / G) / 2;
                Z = Math.Abs(G * G - N);
            }

            while (Z >= 0.0001);
            Console.Write(G);
        }
    }
}
