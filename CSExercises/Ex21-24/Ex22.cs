using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("please enter 2 numbers: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = A;
            int D = B;
            
           
            
            while (D!=C)
            {
                if (C > D)
               
                
                    C = C- D;

               
                else D=D-C;}
                
                int LCM = (A * B) / C;
                Console.WriteLine("HCF is {0} and LCM is {1}", C, LCM);

            }
        }
    }

