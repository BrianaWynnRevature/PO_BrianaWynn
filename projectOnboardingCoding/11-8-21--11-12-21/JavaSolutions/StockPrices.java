// package week1;

import java.util.*;
import java.util.stream.IntStream;

public class StockPrices {

  public static void main(String[] args) {
    // TODO Auto-generated method stub

    // Test cases for stock date
    int[] arr = { 14, 12, 70, 15, 99, 65, 21, 90 };
    int[] arr1 = { 14, 99, 70, 15, 12, 65, 21, 90 };

    System.out.println(String.format("Max Profit 0: %s", StockPrices(arr)));
    System.out.println(String.format("Max Profit 1: %s", StockPrices(arr1)));

  }

  public static int StockPrices(int[] prices) {
    // setup for finding max and min
    int[] pricesCopy = Arrays.copyOf(prices, prices.length);
    Arrays.sort(pricesCopy);

    // find the max and min values
    int buyDay = pricesCopy[0];
    int sellDay = pricesCopy[prices.length - 1];

    // find the positions of the max and min in original array
    int positionBuy = indexOf(prices, buyDay);
    int positionSell = indexOf(prices, sellDay);

    // check that the buy position is before the sell position

    if (positionBuy <= positionSell) {
      return sellDay - buyDay;
    }
    // otherwise assume that you still buy on the cheapest date and sell
    // on the next available highest date
    else {
      int[] temp = Arrays.copyOfRange(prices, positionBuy + 1, prices.length);
      Arrays.sort(temp);
      sellDay = temp[temp.length - 1];
      return sellDay - buyDay;

    }
  }

  public static int indexOf(int[] arr, int val) {
    return IntStream.range(0, arr.length).filter(i -> arr[i] == val).findFirst().orElse(-1);
  }

}
