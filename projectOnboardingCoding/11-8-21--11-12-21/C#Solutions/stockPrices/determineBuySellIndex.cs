using System;
using System.Linq;

namespace projectOnboardingCoding
{
  public class Stock
  {
    public static int stockPrices(int[] prices)
    {

      int buyDay = prices.Min();
      int sellDay = prices.Max();

      int positionBuy = Array.IndexOf(prices, buyDay);
      int positionSell = Array.IndexOf(prices, sellDay);


      if (positionBuy <= positionSell)
      {
        return sellDay - buyDay;
      }
      else
      {

        int[] temp = new int[prices.Length - positionBuy];
        Array.Copy(prices, Array.IndexOf(prices, buyDay), temp, 0, (prices.Length - positionBuy));
        sellDay = temp.Max();
        return sellDay - buyDay;
      }
    }
  }
}