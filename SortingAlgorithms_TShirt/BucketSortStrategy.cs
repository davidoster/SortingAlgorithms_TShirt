using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    class BucketSortStrategy : ISortStrategy
    {
        public void SortByColorAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Color maxValue = tShirts[0].Color;
            Color minValue = tShirts[0].Color;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxValue)
                    maxValue = tShirts[i].Color;

                if (tShirts[i].Color < minValue)
                    minValue = tShirts[i].Color;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Color - minValue] == null)
                {
                    bucket[tShirts[i].Color - minValue] = new LinkedList<TShirt>();
                }

                bucket[tShirts[i].Color - minValue].AddLast(tShirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void SortByColorDescending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Color maxValue = tShirts[0].Color;
            Color minValue = tShirts[0].Color;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxValue)
                    maxValue = tShirts[i].Color;

                if (tShirts[i].Color < minValue)
                    minValue = tShirts[i].Color;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxValue - tShirts[i].Color] == null)
                {
                    bucket[maxValue - tShirts[i].Color] = new LinkedList<TShirt>();
                }

                bucket[maxValue - tShirts[i].Color].AddLast(tShirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void SortByFabricAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Fabric maxValue = tShirts[0].Fabric;
            Fabric minValue = tShirts[0].Fabric;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxValue)
                    maxValue = tShirts[i].Fabric;

                if (tShirts[i].Fabric < minValue)
                    minValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Fabric - minValue] == null)
                {
                    bucket[tShirts[i].Fabric - minValue] = new LinkedList<TShirt>();
                }

                bucket[tShirts[i].Fabric - minValue].AddLast(tShirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void SortByFabricDescending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Fabric maxValue = tShirts[0].Fabric;
            Fabric minValue = tShirts[0].Fabric;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxValue)
                    maxValue = tShirts[i].Fabric;

                if (tShirts[i].Fabric < minValue)
                    minValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxValue - tShirts[i].Fabric] == null)
                {
                    bucket[maxValue - tShirts[i].Fabric] = new LinkedList<TShirt>();
                }

                bucket[maxValue - tShirts[i].Fabric].AddLast(tShirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void SortBySizeAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Size maxValue = tShirts[0].Size; 
            Size minValue = tShirts[0].Size;
            
            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxValue)
                    maxValue = tShirts[i].Size;

                if (tShirts[i].Size < minValue)
                    minValue = tShirts[i].Size;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Size - minValue] == null)
                {
                    bucket[tShirts[i].Size - minValue] = new LinkedList<TShirt>();
                }

                bucket[tShirts[i].Size - minValue].AddLast(tShirts[i]);
            }
            
            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void SortBySizeDescending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Size maxValue = tShirts[0].Size;
            Size minValue = tShirts[0].Size;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxValue)
                    maxValue = tShirts[i].Size;

                if (tShirts[i].Size < minValue)
                    minValue = tShirts[i].Size;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxValue - tShirts[i].Size] == null)
                {
                    bucket[maxValue - tShirts[i].Size] = new LinkedList<TShirt>();
                }

                bucket[maxValue - tShirts[i].Size].AddLast(tShirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void SortBySizeThenColorThenFabricAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Size maxSizeValue = tShirts[0].Size;
            Size minSizeValue = tShirts[0].Size;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxSizeValue)
                    maxSizeValue = tShirts[i].Size;

                if (tShirts[i].Size < minSizeValue)
                    minSizeValue = tShirts[i].Size;
            }

            Color maxColorValue = tShirts[0].Color;
            Color minColorValue = tShirts[0].Color;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxColorValue)
                    maxColorValue = tShirts[i].Color;

                if (tShirts[i].Color < minColorValue)
                    minColorValue = tShirts[i].Color;
            }

            Fabric maxFabricValue = tShirts[0].Fabric;
            Fabric minFabricValue = tShirts[0].Fabric;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxFabricValue)
                    maxFabricValue = tShirts[i].Fabric;

                if (tShirts[i].Fabric < minFabricValue)
                    minFabricValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[,,] bucket = new LinkedList<TShirt>[maxSizeValue - minSizeValue + 1, maxColorValue - minColorValue + 1, maxFabricValue - minFabricValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Size - minSizeValue, tShirts[i].Color - minColorValue, tShirts[i].Fabric - minFabricValue] == null)
                {
                    bucket[tShirts[i].Size - minSizeValue, tShirts[i].Color - minColorValue, tShirts[i].Fabric - minFabricValue] = new LinkedList<TShirt>();
                }

                // All XS, RED, WOOL T-Shirts go to bucket[0,0,0], all XS, RED, COTTON go to bucket[0,0,1], etc.
                bucket[tShirts[i].Size - minSizeValue, tShirts[i].Color - minColorValue, tShirts[i].Fabric - minFabricValue].AddLast(tShirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                for (int j = 0; j < bucket.GetLength(1); j++)
                {
                    for (int m = 0; m < bucket.GetLength(2); m++)
                    {
                        if (bucket[i,j,m] != null)
                        {
                            LinkedListNode<TShirt> node = bucket[i,j,m].First;

                            while (node != null)
                            {
                                tShirts[k] = node.Value;
                                node = node.Next;
                                k++;
                            }
                        }
                    }
                }
            }
        }

        public void SortBySizeThenColorThenFabricDescending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
            {
                return;
            }

            Size maxSizeValue = tShirts[0].Size;
            Size minSizeValue = tShirts[0].Size;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxSizeValue)
                    maxSizeValue = tShirts[i].Size;

                if (tShirts[i].Size < minSizeValue)
                    minSizeValue = tShirts[i].Size;
            }

            Color maxColorValue = tShirts[0].Color;
            Color minColorValue = tShirts[0].Color;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxColorValue)
                    maxColorValue = tShirts[i].Color;

                if (tShirts[i].Color < minColorValue)
                    minColorValue = tShirts[i].Color;
            }

            Fabric maxFabricValue = tShirts[0].Fabric;
            Fabric minFabricValue = tShirts[0].Fabric;

            for (int i = 1; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxFabricValue)
                    maxFabricValue = tShirts[i].Fabric;

                if (tShirts[i].Fabric < minFabricValue)
                    minFabricValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[,,] bucket = new LinkedList<TShirt>[maxSizeValue - minSizeValue + 1, maxColorValue - minColorValue + 1, maxFabricValue - minFabricValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxSizeValue - tShirts[i].Size, maxColorValue - tShirts[i].Color, maxFabricValue - tShirts[i].Fabric] == null)
                {
                    bucket[maxSizeValue - tShirts[i].Size, maxColorValue - tShirts[i].Color, maxFabricValue - tShirts[i].Fabric] = new LinkedList<TShirt>();
                }

                // All XXXL, VIOLET, SILK T-Shirts go to bucket[0,0,0], all XXXL, VIOLET, CASHMERE go to bucket[0,0,1], etc.
                bucket[maxSizeValue - tShirts[i].Size, maxColorValue - tShirts[i].Color, maxFabricValue - tShirts[i].Fabric].AddLast(tShirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                for (int j = 0; j < bucket.GetLength(1); j++)
                {
                    for (int m = 0; m < bucket.GetLength(2); m++)
                    {
                        if (bucket[i, j, m] != null)
                        {
                            LinkedListNode<TShirt> node = bucket[i, j, m].First;

                            while (node != null)
                            {
                                tShirts[k] = node.Value;
                                node = node.Next;
                                k++;
                            }
                        }
                    }
                }
            }
        }
    }
}
