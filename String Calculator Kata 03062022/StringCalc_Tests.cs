using NUnit.Framework;

namespace StringCalc
{
    public class StringcalcAdd
    {
        [Test]
        public void StringCalc_Add_EmptyReturns0()
        {
            var stringCalc = new StringCalc();
            var result = stringCalc.add("");
            Assert.AreEqual(0, result); 
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        public void StringCalc_Add_SingleIntReturnsInt(string inp, int Expected)
        {
            var stringCalc = new StringCalc();
            var result = stringCalc.add(inp);
            Assert.AreEqual(Expected, result);
        }

    }
}