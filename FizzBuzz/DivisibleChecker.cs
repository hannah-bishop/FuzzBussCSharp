namespace FizzBuzz
{
    class DivisibleChecker
    {
        public List<string> CheckIsDivisible(int number)
        {
            List<string>words = new List<string>{};
           
            if (number % 3 == 0)
            {
                words.Add("Fizz");
            }
            if (number % 5 == 0)
            {
                words.Add("Buzz");
            }
            if (number % 7 == 0)
            {
                words.Add("Bang");
            }
            if (number % 11 == 0)
            {
                words.Add("Bong");
            }
            return words;
            
        }   
    }
}