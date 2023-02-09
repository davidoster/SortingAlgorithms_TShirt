using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    class QuickSortStrategy : ISortStrategy
    {
        static void QuickSortBySizeAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortBySizePartitionAscending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortBySizeAscending(tShirts, low, pi - 1);
                QuickSortBySizeAscending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizePartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Size < pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortBySizeDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortBySizePartitionDescending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortBySizeDescending(tShirts, low, pi - 1);
                QuickSortBySizeDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizePartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Size > pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortByColorAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortByColorPartitionAscending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortByColorAscending(tShirts, low, pi - 1);
                QuickSortByColorAscending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Color < pivot.Color)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortByColorDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortByColorPartitionDescending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortByColorDescending(tShirts, low, pi - 1);
                QuickSortByColorDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Color > pivot.Color)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortByFabricAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortByFabricPartitionAscending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortByFabricAscending(tShirts, low, pi - 1);
                QuickSortByFabricAscending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Fabric < pivot.Fabric)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortByFabricDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortByFabricPartitionDescending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortByFabricDescending(tShirts, low, pi - 1);
                QuickSortByFabricDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Fabric > pivot.Fabric)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortBySizeThenColorThenFabricAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortBySizeThenColorTheFabricPartitionAscending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortBySizeThenColorThenFabricAscending(tShirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricAscending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizeThenColorTheFabricPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Size < pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    if (tShirts[j].Color < pivot.Color)
                    {
                        i++;

                        // swap arr[i] and arr[j] 
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                    else if (tShirts[j].Color == pivot.Color)
                    {
                        if (tShirts[j].Fabric < pivot.Fabric)
                        {
                            i++;

                            // swap arr[i] and arr[j] 
                            TShirt temp = tShirts[i];
                            tShirts[i] = tShirts[j];
                            tShirts[j] = temp;
                        }
                    }
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortBySizeThenColorThenFabricDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortBySizeThenColorTheFabricPartitionDescending(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortBySizeThenColorThenFabricDescending(tShirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizeThenColorTheFabricPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Size > pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    if (tShirts[j].Color > pivot.Color)
                    {
                        i++;

                        // swap arr[i] and arr[j] 
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                    else if (tShirts[j].Color == pivot.Color)
                    {
                        if (tShirts[j].Fabric > pivot.Fabric)
                        {
                            i++;

                            // swap arr[i] and arr[j] 
                            TShirt temp = tShirts[i];
                            tShirts[i] = tShirts[j];
                            tShirts[j] = temp;
                        }
                    }
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        public void SortByColorAscending(List<TShirt> tShirts)
        {
            QuickSortByColorAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortByColorDescending(List<TShirt> tShirts)
        {
            QuickSortByColorDescending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortByFabricAscending(List<TShirt> tShirts)
        {
            QuickSortByFabricAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortByFabricDescending(List<TShirt> tShirts)
        {
            QuickSortByFabricDescending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeAscending(List<TShirt> tShirts)
        {
            QuickSortBySizeAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeDescending(List<TShirt> tShirts)
        {
            QuickSortBySizeDescending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeThenColorThenFabricAscending(List<TShirt> tShirts)
        {
            QuickSortBySizeThenColorThenFabricAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeThenColorThenFabricDescending(List<TShirt> tShirts)
        {
            QuickSortBySizeThenColorThenFabricDescending(tShirts, 0, tShirts.Count - 1);
        }
    }
}
