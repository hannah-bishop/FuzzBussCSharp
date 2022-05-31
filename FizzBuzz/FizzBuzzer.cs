namespace FizzBuzz
{
  class FizzBuzzer
  {
    public void PrintString(int number, List<string>words)
    {
      string returnWord = "";
        
      for (int i=0; i< words.Count; i++)
      {
        returnWord += words[i];
      }

      Console.WriteLine( returnWord.Length > 0 ? returnWord : number.ToString());
    }
    public void DoFizzBuzz()
    {
      DivisibleChecker divisableChecker = new DivisibleChecker();

      for (int i=1; i<= 255; i++)
      {
        List<string>words = divisableChecker.CheckIsDivisible(i);

        PrintString(i, words);

      }
    }
  }
}
