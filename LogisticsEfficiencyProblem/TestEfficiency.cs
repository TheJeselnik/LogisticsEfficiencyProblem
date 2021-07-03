using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogisticsEfficiencyProblem
{
    [TestClass]
    public class TestEfficiency
    {
        #region Test Methods

        [TestMethod]
        public void NoBoxesYieldsZero()
        {
            
        }

        [TestMethod]
        public void SingleBoxOfThreeYieldsThree()
        {

        }

        [TestMethod]
        public void VariedBoxesYieldMostEfficientConfiguration()
        {
            var boxCountOfEachProduct = new List<int>() { 1, 5, 3 };
            var productTypeCount = boxCountOfEachProduct.Count;
            var productCountPerBox = new List<int>() { 10, 7, 2 };

            var numBoxes = boxCountOfEachProduct.Sum();
            var truckSize = 5;
        }

        [TestMethod]
        public void TwoBoxesOfOneProduct_OneBoxOfTwoProductsWithOneSpace_YieldsTwoProducts()
        {

        }

        #endregion
    }
}
