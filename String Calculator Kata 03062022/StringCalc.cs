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
                var result = Numbers.Split(',').Select(x => int.Parse(x)).Sum();
                return result;
            }
        }
    }

}
