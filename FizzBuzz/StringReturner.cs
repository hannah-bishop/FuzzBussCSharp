namespace FizzBuzz
{
    class StringReturner {
        public string ReturnString(List<string>words , int number)
        {
            string returnWord = "";

            
            if (number % 17 == 0) 
            {
                for (int i=words.Count -1; i>=0; i--)
                {
                    returnWord += words[i];
                }
            }
            else
            {
                for (int i=0; i< words.Count; i++)
                {
                    returnWord += words[i];
                }
            }
            

            if (returnWord.Length > 0)
            {
                return returnWord;
            }
            else
            {
                return number.ToString();
            }
        }
    }
}