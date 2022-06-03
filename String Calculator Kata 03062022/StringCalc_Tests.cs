using NUnit.Framework;

namespace StringCalc
{
    public class StringcalcAdd
    {
        [Test]
        public void StringCal_Add_EmptyReturns0()
        {
            var stringCalc = new StringCalc();
            var result = stringCalc.add("");
            Assert.AreEqual(0, result); 
        }

    }
}