using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    class BubbleSortStrategy : ISortStrategy
    {
        public void SortByColorAscending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Color > tShirts[j + 1].Color)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public void SortByColorDescending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Color < tShirts[j + 1].Color)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public void SortByFabricAscending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Fabric > tShirts[j + 1].Fabric)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public void SortByFabricDescending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Fabric < tShirts[j + 1].Fabric)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public void SortBySizeAscending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size > tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public void SortBySizeDescending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size < tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public void SortBySizeThenColorThenFabricAscending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size > tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                    else if (tShirts[j].Size == tShirts[j + 1].Size)
                    {
                        if (tShirts[j].Color > tShirts[j + 1].Color)
                        {
                            temp = tShirts[j];
                            tShirts[j] = tShirts[j + 1];
                            tShirts[j + 1] = temp;
                            swapped = true;
                        }
                        else if (tShirts[j].Color == tShirts[j + 1].Color)
                        {
                            if (tShirts[j].Fabric > tShirts[j + 1].Fabric)
                            {
                                temp = tShirts[j];
                                tShirts[j] = tShirts[j + 1];
                                tShirts[j + 1] = temp;
                                swapped = true;
                            }
                        }
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }

        public void SortBySizeThenColorThenFabricDescending(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size < tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                    else if(tShirts[j].Size == tShirts[j + 1].Size)
                    {
                        if(tShirts[j].Color < tShirts[j + 1].Color)
                        {
                            temp = tShirts[j];
                            tShirts[j] = tShirts[j + 1];
                            tShirts[j + 1] = temp;
                            swapped = true;
                        }
                        else if(tShirts[j].Color == tShirts[j + 1].Color)
                        {
                            if(tShirts[j].Fabric < tShirts[j + 1].Fabric)
                            {
                                temp = tShirts[j];
                                tShirts[j] = tShirts[j + 1];
                                tShirts[j + 1] = temp;
                                swapped = true;
                            }
                        }
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
    }
}
