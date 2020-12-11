using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 3, 5, 67, 8, 56, 5, 5, 4, 3, 4, 5, 6, 3, 12, 6, 7, 54 };
            ArrayHandling.Print(firstArray);
            Console.ReadKey();
            var secondArray = ArrayHandling.RemoveDuplicates(firstArray);
            Console.Clear();
            ArrayHandling.Print(secondArray);
        }
    }

    public static class ArrayHandling
    {
        public static int[] RemoveDuplicates (int[] enteringArray)
        {
            var resultArray = new int[enteringArray.Length];

            var enteringCounter = 0;
            var resultCounter = 0;
            while(enteringCounter < enteringArray.Length)
            {
                var notRepeat = true;
                for (var i = 0; i < resultCounter; i++)
                {
                    if (enteringArray[enteringCounter] == resultArray[i])
                    {
                        notRepeat = false;
                        break;
                    }
                }

                if (notRepeat)
                    resultArray[resultCounter++] = enteringArray[enteringCounter];
                enteringCounter++;
            }

            Array.Resize(ref resultArray, resultCounter);
            return resultArray;
        }

        public static void Print(int[] enteringArray)
        {
            foreach (int number in enteringArray)
                Console.WriteLine(number);
        }
    }
}
