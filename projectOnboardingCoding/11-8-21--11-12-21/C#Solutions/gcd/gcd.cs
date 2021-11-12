using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace CodingChallenges
{

  public class GCD
  {
    //Create a function that takes an array of numbers and returns the greatest common factor of those numbers.

    public static int findGCD(int[] arr)
    {
      int arrMin = arr.Min();
      int[] possibles = new int[arrMin];
      int count = 0;


      for (int i = 0; i < arrMin; i++)
      {
        possibles[i] = i + 1;
        // Console.WriteLine(possibles[i]);
      }

      for (int i = possibles.Length - 1; i >= 1; i--)
      {
        for (int j = 0; j <= arr.Length - 1; j++)
        {

          if (arr[j] % possibles[i] == 0)
          {

            count++;
            if (count == 4)
            {
              return possibles[i];
            }

          }
          else if (arr[j] % possibles[i] != 0)
          {
            count = 0;
          }


        }

      }

      return 0; //should be hit if there is no gcd, but that shouldn't happen because 1 will always be the gcd
    }

  }//eoc

}//eon
