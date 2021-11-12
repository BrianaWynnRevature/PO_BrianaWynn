// package week1;

import java.util.*;

public class GreatestCommonDenominator {

  public static void main(String[] args) {
    // TODO Auto-generated method stub
    int[] test1 = { 84, 70, 42, 56 };
    int[] test2 = { 19, 38, 76, 133 };
    int[] test3 = { 120, 300, 95, 425, 625 };

    System.out.println(findGCD(test1));
    System.out.println(findGCD(test2));
    System.out.println(findGCD(test3));
  }

  public static int findGCD(int[] arr) {
    Arrays.sort(arr);
    int arrMin = arr[0];
    int[] possibles = new int[arrMin];
    int count = 0;

    for (int i = 0; i < arrMin; i++) {
      possibles[i] = i + 1;
      // Console.WriteLine(possibles[i]);
    }

    for (int i = possibles.length - 1; i >= 1; i--) {
      for (int j = 0; j <= arr.length - 1; j++) {

        if (arr[j] % possibles[i] == 0) {

          count++;
          if (count == 4) {
            return possibles[i];
          }

        } else if (arr[j] % possibles[i] != 0) {
          count = 0;
        }
      }
    }

    return 0; // should be hit if there is no gcd, but that shouldn't happen because 1 will
              // always be the gcd
  }
}
