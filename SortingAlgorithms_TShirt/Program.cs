using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    class Program
    {
        private static Random random = new Random();

        static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void Main(string[] args)
        {
            List<TShirt> randomTShirtsUnsorted = new List<TShirt>();
            TShirt tShirt;
            SortManager sortManager = new SortManager();
            TShirtList tShirtList = new TShirtList();
            tShirtList.TShirts = new List<TShirt>();

            for (int i = 0; i < 100; i++)
            {
                tShirt = new TShirt(RandomString(10), (Color)random.Next(0, 7), (Size)random.Next(0, 7), (Fabric)random.Next(0, 7));
                randomTShirtsUnsorted.Add(tShirt);
                tShirtList.TShirts.Add(tShirt);
            }

            Console.WriteLine("Press any key to proceed to sorting ascending by size.");
            Console.ReadKey();
            sortManager.SortBySizeAscending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to proceed to sorting descending by size.");
            Console.ReadKey();
            sortManager.UndoSorting(randomTShirtsUnsorted, tShirtList);
            sortManager.SortBySizeDescending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to proceed to sorting ascending by color.");
            Console.ReadKey();
            sortManager.UndoSorting(randomTShirtsUnsorted, tShirtList);
            sortManager.SortByColorAscending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to proceed to sorting descending by color.");
            Console.ReadKey();
            sortManager.UndoSorting(randomTShirtsUnsorted, tShirtList);
            sortManager.SortByColorDescending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to proceed to sorting ascending by fabric.");
            Console.ReadKey();
            sortManager.UndoSorting(randomTShirtsUnsorted, tShirtList);
            sortManager.SortByFabricAscending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to proceed to sorting descending by fabric.");
            Console.ReadKey();
            sortManager.UndoSorting(randomTShirtsUnsorted, tShirtList);
            sortManager.SortByFabricDescending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to proceed to sorting ascending by size then color then fabric.");
            Console.ReadKey();
            sortManager.UndoSorting(randomTShirtsUnsorted, tShirtList);
            sortManager.SortBySizeThenColorThenFabricAscending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to proceed to sorting descending by size then color then fabric.");
            Console.ReadKey();
            sortManager.UndoSorting(randomTShirtsUnsorted, tShirtList);
            sortManager.SortBySizeThenColorThenFabricDescending(randomTShirtsUnsorted, tShirtList);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
        }
    }
}
