using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Racing_Game_AssignS;

namespace Racing_Game_AssignSTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ground obj = new Ground();
            int y = obj.jump();
            if (y > 1)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestFinshMethod1()
        {
            Ground obj = new Ground();
           int y= obj.finishPoint();
            if (y == 690)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestBudgetMethod1()
        {
            calculateBudget obj = new calculateBudget();
            int y=obj.BudgetCal(1,30,100,2);
            if (y == 70)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }   }
}
