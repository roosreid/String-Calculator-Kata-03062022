namespace StringCalc
{
    public class StringCalc
    {
        public object add(string Numbers)
        {
            if (String.IsNullOrEmpty(Numbers))
            {
                return 0;
            }
            else
            {
                var splitlist = Numbers.Split(new[] { '\n', ',' }).Select(x => int.Parse(x));
                var result = splitlist.Sum();
                return result;
            }
        }
    }

}
