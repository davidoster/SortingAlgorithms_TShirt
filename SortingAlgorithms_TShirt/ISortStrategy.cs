using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    interface ISortStrategy
    {
        void SortBySizeAscending(List<TShirt> tShirts);
        void SortBySizeDescending(List<TShirt> tShirts);
        void SortByColorAscending(List<TShirt> tShirts);
        void SortByColorDescending(List<TShirt> tShirts);
        void SortByFabricAscending(List<TShirt> tShirts);
        void SortByFabricDescending(List<TShirt> tShirts);
        void SortBySizeThenColorThenFabricAscending(List<TShirt> tShirts);
        void SortBySizeThenColorThenFabricDescending(List<TShirt> tShirts);
    }
}
