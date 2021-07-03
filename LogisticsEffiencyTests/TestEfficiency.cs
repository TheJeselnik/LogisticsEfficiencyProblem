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

        private EfficiencyManager efficiencyManager;

        [TestInitialize]
        public void Initialize()
        {
            this.efficiencyManager = new EfficiencyManager();
        }


        #region Test Methods

        [TestMethod]
        public void NoBoxesYieldsZero()
        {
            var boxCountOfEachProduct = new List<int>();
            var productTypeCount = boxCountOfEachProduct.Count;
            var productCountPerBox = new List<int>();

            var numBoxes = boxCountOfEachProduct.Sum();
            var truckSize = 1;

            var expected = 0;
            Assert.AreEqual(expected, this.efficiencyManager.FindProductMaximumOnTruck(numBoxes,
                boxCountOfEachProduct, productTypeCount, productCountPerBox, truckSize));
        }

        [TestMethod]
        public void FullTruckYieldsZero()
        {
            var boxCountOfEachProduct = new List<int>() { 1, 5, 3 };
            var productTypeCount = boxCountOfEachProduct.Count;
            var productCountPerBox = new List<int>() { 10, 7, 2 };

            var numBoxes = boxCountOfEachProduct.Sum();
            var truckSize = 0;

            var expected = 0;
            Assert.AreEqual(expected, this.efficiencyManager.FindProductMaximumOnTruck(numBoxes,
                boxCountOfEachProduct, productTypeCount, productCountPerBox, truckSize));
        }

        [TestMethod]
        public void SingleBoxOfThreeYieldsThree()
        {
            var boxCountOfEachProduct = new List<int>() { 1 };
            var productTypeCount = boxCountOfEachProduct.Count;
            var productCountPerBox = new List<int>() { 3 };

            var numBoxes = boxCountOfEachProduct.Sum();
            var truckSize = 1;

            var expected = 3;
            Assert.AreEqual(expected, this.efficiencyManager.FindProductMaximumOnTruck(numBoxes,
                boxCountOfEachProduct, productTypeCount, productCountPerBox, truckSize));
        }

        [TestMethod]
        public void VariedBoxesYieldMostEfficientConfiguration()
        {
            var boxCountOfEachProduct = new List<int>() { 1, 5, 3 };
            var productTypeCount = boxCountOfEachProduct.Count;
            var productCountPerBox = new List<int>() { 10, 7, 2 };

            var numBoxes = boxCountOfEachProduct.Sum();
            var truckSize = 6;

            var expected = 45;
            Assert.AreEqual(expected, this.efficiencyManager.FindProductMaximumOnTruck(numBoxes,
                boxCountOfEachProduct, productTypeCount, productCountPerBox, truckSize));
        }

        [TestMethod]
        public void TwoBoxesOfOneProduct_OneBoxOfTwoProductsWithOneSpace_YieldsTwoProducts()
        {
            var boxCountOfEachProduct = new List<int>() { 2, 1 };
            var productTypeCount = boxCountOfEachProduct.Count;
            var productCountPerBox = new List<int>() { 1, 2 };

            var numBoxes = boxCountOfEachProduct.Sum();
            var truckSize = 1;

            var expected = 2;
            Assert.AreEqual(expected, this.efficiencyManager.FindProductMaximumOnTruck(numBoxes,
                boxCountOfEachProduct, productTypeCount, productCountPerBox, truckSize));
        }

        #endregion
    }
}
