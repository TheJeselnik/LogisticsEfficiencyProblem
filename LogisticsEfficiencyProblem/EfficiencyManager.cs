using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsEfficiencyProblem
{
    public class EfficiencyManager
    {

        public int FindProductMaximumOnTruck(int numBoxes, List<int> boxCountOfEachProduct, 
            int numProducts, List<int> productCountPerBox, int truckSize)
        {
            var maxProduct = 0;
            var boxes = new List<Box>();

            for (var i = 0; i < boxCountOfEachProduct.Count; i++)
            {
                for (var j = 0; j < boxCountOfEachProduct[i]; j++)
                {
                    var newBox = new Box(productCountPerBox[i], i);
                    boxes.Add(newBox);
                }
            }

            var sortedBoxes = boxes.OrderByDescending(sortedBox => sortedBox.ProductsInside).ToList();

            if (sortedBoxes.Count < 1)
            {
                return maxProduct;
            }

            for (var k = 0; k < truckSize; k++)
            {
                maxProduct += sortedBoxes[k].ProductsInside;
            }

            return maxProduct;
        }
    }
}
