
namespace _04.Array_Rotation
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
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            long rotations = long.Parse(Console.ReadLine());
            long timesToRotate = rotations % arr.Length; /* ОПТИМИЗИРАНЕ НА КОДА:
            НЕ променя стойностите, когато са ПО-МАЛКИ от дължината на масива -> върти for-цикъла. 
            Ако стойността НАДХВЪРЛЯ дължината на масива, се приема, 
            че завъртанията се повтарят и се получава първоначалния масив -> не изпълняваме for-цикъла.!!!*/

            for (int r = 1; r <= timesToRotate; r++)
            {
                int firstNum = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length-1] = firstNum;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
