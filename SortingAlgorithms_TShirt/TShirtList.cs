using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    class TShirtList
    {
        private ISortStrategy _sortStrategy;

        public List<TShirt> TShirts { get; set; }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SortBySizeAscending()
        {
            _sortStrategy.SortBySizeAscending(TShirts);
        }

        public void SortBySizeDescending()
        {
            _sortStrategy.SortBySizeDescending(TShirts);
        }

        public void SortByColorAscending()
        {
            _sortStrategy.SortByColorAscending(TShirts);
        }

        public void SortByColorDescending()
        {
            _sortStrategy.SortByColorDescending(TShirts);
        }

        public void SortByFabricAscending()
        {
            _sortStrategy.SortByFabricAscending(TShirts);
        }

        public void SortByFabricDescending()
        {
            _sortStrategy.SortByFabricDescending(TShirts);
        }

        public void SortBySizeThenColorThenFabricAscending()
        {
            _sortStrategy.SortBySizeThenColorThenFabricAscending(TShirts);
        }

        public void SortBySizeThenColorThenFabricDescending()
        {
            _sortStrategy.SortBySizeThenColorThenFabricDescending(TShirts);
        }
    }
}
