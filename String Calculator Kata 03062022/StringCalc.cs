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
                var delimiters = new[] { '\n', ',' };

                if (Numbers.StartsWith("//"))
                {
                    char customDelimiter = char.Parse(Numbers.Substring(2, 1));
                    delimiters = new[] { '\n', ',', customDelimiter};
                    Numbers = Numbers.Substring(3, Numbers.Length - 3);
                }

                var result = Numbers.Split(delimiters).Select(x => int.Parse(x)).Sum();
                return result;
            }
        }
    }

}
