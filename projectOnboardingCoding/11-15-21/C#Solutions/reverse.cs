using System;

namespace projectOnboardingCoding
{
  public class Reverse
  {
    // 1) Given a string, create a function to reverse the case.
    // All lower-cased letters should be upper-cased, and vice versa.

    // Examples
    // ReverseCase("Happy Birthday") --> "hAPPY bIRTHDAY"

    // ReverseCase("MANY THANKS") --> "many thanks"

    // ReverseCase("sPoNtAnEoUs") --> "SpOnTaNeOuS"

    static void Main(string[] args)
    {
      //Test case
      string test = "Happy Birthday";
      string test1 = "MANY THANKS";
      string test2 = "sPoNtAnEoUs";

      Console.WriteLine(reverse(test));
      Console.WriteLine(reverse(test1));
      Console.WriteLine(reverse(test2));

    }

    static string reverse(string str)
    {
      Char[] str1 = str.ToCharArray();
      //iterate through the string and check each letter
      for (int i = 0; i < str1.Length; i++)
      {
        if (Char.IsUpper(str1[i]))
        {
          str1[i] = Char.ToLower(str[i]);

        }

        else
        {
          str1[i] = Char.ToUpper(str[i]);
        }
      }

      return new string(str1);
    }
  }//Eoc
}//eon