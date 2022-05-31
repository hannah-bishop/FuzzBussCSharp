namespace FizzBuzz
{
    class DivisibleChecker
    {
        private bool StartsWithB(string testString)
        {
            return testString[0] == 'B';
        }
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
                words = words.Where(word => word != "Fizz" && word != "Buzz" && word != "Bang").ToList();
            }
            if (number % 13 == 0)
            {
                int firstBIndex = words.FindIndex(StartsWithB);
                if (firstBIndex == -1)
                {
                    words.Add("Fezz");
                }
                else 
                {
                    words.Insert(firstBIndex, "Fezz");
                }
            }
            if (number % 17 == 0) 
            {
              words.Reverse();
            }

            return words;
            
        }   
    }
}