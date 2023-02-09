using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    class SortManager
    {
        static void PrintList(List<TShirt> tShirts)
        {
            foreach (var tshirt in tShirts)
            {
                Console.WriteLine($"Name: {tshirt.Name} Size: {tshirt.Size} Color: {tshirt.Color} Fabric: {tshirt.Fabric}");
            }
        }

        static void PrintTimingResults(TimeSpan BubbleSortTimeSpan, TimeSpan QuickSortTimeSpan, TimeSpan BucketSortTimeSpan)
        {
            Console.WriteLine("Bubblesort took {0} milliseconds to execute.", BubbleSortTimeSpan.TotalMilliseconds);
            Console.WriteLine("Quicksort took {0} milliseconds to execute.", QuickSortTimeSpan.TotalMilliseconds);
            Console.WriteLine("Bucketsort took {0} milliseconds to execute.", BucketSortTimeSpan.TotalMilliseconds);

            if (BucketSortTimeSpan.TotalMilliseconds < QuickSortTimeSpan.TotalMilliseconds)
            {
                if (BucketSortTimeSpan.TotalMilliseconds < BubbleSortTimeSpan.TotalMilliseconds)
                {
                    Console.WriteLine("Bucketsort was the fastest algorithm.");
                }
                else
                {
                    Console.WriteLine("Bubblesort was the fastest algorithm.");
                }
            }
            else
            {
                if (QuickSortTimeSpan.TotalMilliseconds < BubbleSortTimeSpan.TotalMilliseconds)
                {
                    Console.WriteLine("Quicksort was the fastest algorithm.");
                }
                else
                {
                    Console.WriteLine("Bubblesort was the fastest algorithm.");
                }
            }
        }

        public void UndoSorting(List<TShirt> unsorted, TShirtList sorted)
        {
            for (int i = 0; i < 100; i++)
            {
                sorted.TShirts[i] = unsorted[i];
            }
        }

        public void SortBySizeAscending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {

            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortBySizeAscending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by size using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeAscending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by size using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeAscending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by size using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }

        public void SortBySizeDescending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {

            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortBySizeDescending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by size using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeDescending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by size using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeDescending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by size using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }

        public void SortByColorAscending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {

            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortByColorAscending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by color using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByColorAscending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by color using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByColorAscending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by color using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }

        public void SortByColorDescending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {

            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortByColorDescending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by color using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByColorDescending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by color using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByColorDescending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by color using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }

        public void SortByFabricAscending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {

            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortByFabricAscending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by fabric using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByFabricAscending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by fabric using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByFabricAscending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by fabric using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }

        public void SortByFabricDescending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {

            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortByFabricDescending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by fabric using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByFabricDescending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by fabric using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortByFabricDescending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by fabric using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }

        public void SortBySizeThenColorThenFabricAscending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {
            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortBySizeThenColorThenFabricAscending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by size then color then fabric using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeThenColorThenFabricAscending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by size then color then fabric using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeThenColorThenFabricAscending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted ascending by size then color then fabric using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }

        public void SortBySizeThenColorThenFabricDescending(List<TShirt> randomTShirtsUnsorted, TShirtList tShirtList)
        {
            Stopwatch stopWatch = new Stopwatch();
            TimeSpan BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan;

            Console.WriteLine("The T-Shirts list unsorted:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            tShirtList.SetSortStrategy(new BubbleSortStrategy());

            stopWatch.Start();
            tShirtList.SortBySizeThenColorThenFabricDescending();
            stopWatch.Stop();
            BubbleSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by size then color then fabric using Bubblesort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new QuickSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeThenColorThenFabricDescending();
            stopWatch.Stop();
            QuickSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by size then color then fabric using Quicksort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();
            UndoSorting(randomTShirtsUnsorted, tShirtList);
            tShirtList.SetSortStrategy(new BucketSortStrategy());

            stopWatch.Restart();
            tShirtList.SortBySizeThenColorThenFabricDescending();
            stopWatch.Stop();
            BucketSortTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("T-Shirts list sorted descending by size then color then fabric using Bucketsort:");
            PrintList(tShirtList.TShirts);
            Console.WriteLine();

            PrintTimingResults(BubbleSortTimeSpan, QuickSortTimeSpan, BucketSortTimeSpan);
        }
    }
}
