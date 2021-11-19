import java.util.ArrayList;
import java.util.List;

// Java:
// 1) Write a function that returns true if a string consists of ascending or
// ascending AND consecutive numbers.

// Examples
// ascending("232425") --> true
// // Consecutive numbers 23, 24, 25

// ascending("2324256") --> false
// // No matter how this string is divided, the numbers are not consecutive.

// ascending("444445") --> true
// // Consecutive numbers 444 and 445.
// Notes
// A number can consist of any number of digits, so long as the numbers are
// adjacent to each other, and the string has at least two of them.

class ConsecutiveNumbers {
  public static void main(String[] args) {
    // Test cases
    String testString = "232425";
    // String testString1 = "232425";
    // String testString2 = "232425";

    List<Integer> testList = new ArrayList<Integer>();
    testList.add(23);
    testList.add(24);
    testList.add(25);

    System.out.println(ascending(testList));

    // System.out.println(testString.substring(0, 2));
    // System.out.println(testString.substring(2, 4));
    // System.out.println(testString.substring(4, 6));

    // System.out.println(determineSubstring(testString));

  }

  public static boolean determineSubstring(String string) {
    // How to get the given intervals
    for (int i = string.length() - 1; i >= 1; i--) {
      if (string.length() % i == 0) {

        List<Integer> stringsToInts = new ArrayList<Integer>();
        // How to split a string at the given interval
        for (int j = i; j < string.length();) {
          String splitString = string.substring(j, j + i);
          // add to a list we can access outside of the loop
          stringsToInts.add(Integer.parseInt(splitString));

          return ascending(stringsToInts);
        }
      }
    }

  }

  public static boolean ascending(List<Integer> parsedString) {
    int count = 0;
    for (int i = 0; i < parsedString.size() - 1; i++) {
      if (parsedString.get(i) < parsedString.get(i + 1)) {
        count++;
        if (count == parsedString.size() - 1) {
          return true;
        }
      }
    }
    return false;
  }

}