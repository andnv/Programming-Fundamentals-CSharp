
namespace _03.Floating_Equality
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine()); 
            double secondNum = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = 0;

            if (firstNum > secondNum)
            {
                difference = firstNum - secondNum;
            }
            else if (firstNum < secondNum)
            {
                difference = secondNum - firstNum;
            }
            else if (firstNum==secondNum)
            {
                difference = 0;
            }

            bool isEqual = false;

            if (difference < eps)
            {
                isEqual = true;
                Console.WriteLine(isEqual);
            }
            else if (difference >= eps)
            {
                isEqual = false;
                Console.WriteLine(isEqual);
            }
            
        }
    }
}
