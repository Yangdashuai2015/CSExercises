using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Console.Write("please enter 2 numbers: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = A;
            int D = B;


            bool st = true;
            while (st)
            {
                if (C != D)
                {
                    C = Math.Max(C, D);
                    D = Math.Min(C, D);
                    C = C - D;

                }
                else st = false;

                Console.WriteLine(C);
            }
        }
    }
}