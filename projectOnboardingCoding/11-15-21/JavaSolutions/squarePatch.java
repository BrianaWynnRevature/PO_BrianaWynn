import java.util.ArrayList;
import java.util.List;

// 2) Create a function that takes an integer and outputs an n x n square solely consisting of the integer n.

// Examples
// squarePatch(3) --> [
// [3, 3, 3],
// [3, 3, 3],
// [3, 3, 3]
// ]

// squarePatch(5) --> [
// [5, 5, 5, 5, 5],
// [5, 5, 5, 5, 5],
// [5, 5, 5, 5, 5],
// [5, 5, 5, 5, 5],
// [5, 5, 5, 5, 5]
// ]

// squarePatch(1) --> [
// [1]
// ]

// squarePatch(0) --> []
// Notes
// n >= 0.
// If n = 0, return an empty array.

public class squarePatch {

  public static void main(String[] args) {

    // Test cases
    int dimension = 3;
    int dimension1 = 5;
    int dimension2 = 1;
    int dimension3 = 0;

    printPatch(squarePatch(dimension));
    printPatch(squarePatch(dimension1));
    printPatch(squarePatch(dimension2));
    printPatch(squarePatch(dimension3));

  }

  public static int[][] squarePatch(int n) {
    int[][] board = new int[n][n];
    for (int i = 0; i < board.length; i++) {
      for (int j = 0; j < board[i].length; j++) {
        board[i][j] = n;
      }
    }
    return board;

    // now let's print a two dimensional array in Java

  }

  public static void printPatch(int[][] board) {
    // check the length of the board
    if (board.length == 0) {
      System.out.println("[]");
    } else {
      for (int[] a : board) {
        System.out.print("[ ");
        for (int i : a) {
          System.out.print(i + ", ");
        }
        System.out.print("], ");
        System.out.println("\n ");
      }
    }
  }
}
