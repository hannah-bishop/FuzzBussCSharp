namespace FizzBuzz 
{
    class ExceptionsChecker
    {
        public List<string> CheckExceptions(List<string>words , int number)
        {
            if (words.Contains("Bong"))
            {
                words = words.Where(word => word != "Fizz" && word != "Buzz" && word != "Bang").ToList();
            }
            
            if (number % 13 == 0)
            {
                for (int i=0; i<words.Count; i++)
                {
                    if (words[i].Contains("B"))
                    {
                        int indexOfB = i;
                        List<string>wordsBeginning = words.GetRange(0,i);
                        wordsBeginning.Add("Fezz");
                        List<string>wordsEnding = words.GetRange(i, words.Count - i );
                        words = wordsBeginning.Concat(wordsEnding).ToList();
                        break;
                    }
                }
            }

            return words;
        }
    }
}