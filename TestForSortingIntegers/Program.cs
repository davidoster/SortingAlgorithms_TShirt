using System.Linq;

namespace TestForSortingIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 90, 8, 5, 11, 9, 22, 7, 6, 1, 4 };

            // Step 1. assign to carryOn true 
            // Step 1. while carryOn check adjacent numbers
            // Step 2. if number 1 is greater than number two place 1 to the spot of two
            // Step 3. else go to the next number in line
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            var carryOn = true;
            while(carryOn)
            {
                carryOn = false;
                for(int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i+1]) 
                    {
                        // swap
                        var swap = array[i];
                        array[i] = array[i+1];
                        array[i+1] = swap;
                        carryOn = true;
                    }
                }
            }



            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}