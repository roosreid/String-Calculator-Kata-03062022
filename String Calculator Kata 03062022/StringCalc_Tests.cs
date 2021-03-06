using NUnit.Framework;

namespace StringCalc
{
    public class StringcalcAdd
    {
        private StringCalc _stringCalc = new StringCalc(); 

        [Test]
        public void StringCalc_Add_EmptyReturns0()
        {
            var result = _stringCalc.add("");
            Assert.AreEqual(0, result); 
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        public void StringCalc_Add_SingleIntReturnsInt(string inp, int Expected)
        {
            var result = _stringCalc.add(inp);
            Assert.AreEqual(Expected, result);
        }

        [TestCase("1,2", 3)]
        [TestCase("2,3", 5)]
        [TestCase("3,4", 7)]
        public void StringCalc_Add_TwoIntsInListReturnSum(string inp, int Expected)
        {
            var result = _stringCalc.add(inp);
            Assert.AreEqual(Expected, result);
        }



        [TestCase("1,2,3", 6)]
        [TestCase("2,3,4,5", 14)]
        [TestCase("1,1,1,1,1,1,1,1", 8)]
        public void StringCalc_Add_UnknownNumberOFIntsInListReturnSum(string inp, int Expected)
        {
            var result = _stringCalc.add(inp);
            Assert.AreEqual(Expected, result);
        }

        [TestCase("1\n2", 3)]
        [TestCase("2,3\n5", 10)]
        [TestCase("1\n1\n1", 3)]
        public void StringCalc_Add_AllowsNewLineCharacteraswellascomma(string inp, int Expected)
        {
            var result = _stringCalc.add(inp);
            Assert.AreEqual(Expected, result);
        }

        [TestCase("1,2", 3)]
        [TestCase("1\n2", 3)]
        [TestCase("//&1&1", 2)]
        [TestCase("1,2\n1", 4)]
        [TestCase("//&1&1,2", 4)]
        [TestCase("//&1&1\n2", 4)]
        [TestCase("//&1&1\n2,1", 5)]
        public void StringCalc_Add_AllowsCustomDelimeter(string inp, int Expected)
        {
            var result = _stringCalc.add(inp);
            Assert.AreEqual(Expected, result);
        }

    }
}