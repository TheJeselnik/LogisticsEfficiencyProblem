using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsEfficiencyProblem
{
    public class Box
    {
        #region Properties

        public int ProductsInside { get; protected set; }

        public int ProductNumber { get; protected set; }

        #endregion

        #region Constructors

        public Box(int productsInside, int productNumber)
        {
            this.ProductsInside = productsInside;
            this.ProductNumber = productNumber;
        }

        #endregion
    }
}
