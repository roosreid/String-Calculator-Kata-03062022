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
                if (Numbers.StartsWith("//"))
                {
                    var delimiter = Numbers.Substring(2, 1);
                    Numbers = Numbers.Substring(3, Numbers.Length - 3);
                    return Numbers.Split(delimiter).Select(x => int.Parse(x)).Sum();
                }
                var result = Numbers.Split(new[] { '\n', ',' }).Select(x => int.Parse(x)).Sum();
                return result;
            }
        }
    }

}
