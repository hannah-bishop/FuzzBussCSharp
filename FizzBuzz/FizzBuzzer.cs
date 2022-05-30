namespace FizzBuzz
{
  class FizzBuzzer
  {
    public void DoFizzBuzz()
    {
      DivisibleChecker divisablechecker = new DivisibleChecker();

      StringReturner stringreturner = new StringReturner();

      ExceptionsChecker exceptionsChecker = new ExceptionsChecker();

      for (int i=1; i<= 255; i++)
      {
        List<string>words = divisablechecker.CheckIsDivisible(i);

        words = exceptionsChecker.CheckExceptions(words, i);

        Console.WriteLine(stringreturner.ReturnString(words, i));

      }

      
    }
  }
}
