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
                if (Numbers.Contains("\n"))
                {
                    var result = Numbers.Split('\n').Select(x => int.Parse(x)).Sum();
                    return result;
                }
                else
                {
                    var result = Numbers.Split(',').Select(x => int.Parse(x)).Sum();
                    return result;
                }

            }
        }
    }

}
