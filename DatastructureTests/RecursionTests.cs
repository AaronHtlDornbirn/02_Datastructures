using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresTests
{
    public class RecursionUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FixNumber_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var ite = ms.SumUpValues_Iterative(3);
            var rec = ms.SumUpValues_Recursive(3);
            Assert.AreEqual(ite, rec);
        }
        private class MySum
        {
            public int SumUpValues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }

            public int SumUpValues_Recursive(int number)
            {
                if (number == 1)
                    return number;

                return number + SumUpValues_Iterative(number - 1);
            }
        }
    }
}