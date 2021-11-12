using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace projectOnboardingCoding
{
  class Program
  {
    static void Main(string[] args)
    {

      //Test cases

      // List<double> test1 = new List<double>() { 84, 70, 42, 56 };
      // List<double> test2 = new List<double>() { 19, 38, 76, 133 };
      // List<double> test3 = new List<double>() { 120, 300, 95, 425, 625 };


      // GCD gcd = new GCD();
      // gcd.findGCD(test1);
      // Console.WriteLine(gcd.findGCD(test1));
      // Console.WriteLine(gcd.findGCD(test2));
      // Console.WriteLine(gcd.findGCD(test3));

      //Test cases for stock date
      // int[] arr = { 14, 12, 70, 15, 99, 65, 21, 90 };
      // int[] arr1 = { 14, 99, 70, 15, 12, 65, 21, 90 };

      // Console.WriteLine($"Max Profit 0: {Stock.stockPrices(arr)}");
      // Console.WriteLine($"Max Profit 1: {Stock.stockPrices(arr1)}");

      //Test cases for gcd
      // int[] arr = { 84, 70, 42, 56 };
      // int[] arr1 = { 19, 38, 76, 133 };
      // int[] arr2 = { 120, 300, 95, 425, 625 };


      // Console.WriteLine($"Greatest common denominator: {GCD.findGCD(arr)}");
      // Console.WriteLine($"Greatest common denominator: {GCD.findGCD(arr1)}");
      // Console.WriteLine($"Greatest common denominator: {GCD.findGCD(arr2)}");

      //Test cases for robot
      // int north = 20; int east = 30; int south = 10; int west = 40;
      // int north1 = 0; int east1 = 0;
      // int north2 = -10; int east2 = 20; int south2 = 10;

      // Console.WriteLine(Point.Position(TrackRobot.trackRobot(north, east, south, west)));
      // Console.WriteLine(Point.Position(TrackRobot.trackRobot(north1, east1)));
      // Console.WriteLine(Point.Position(TrackRobot.trackRobot(north2, east2, south2)));



      //Test cases for vending machine
      int selected = 1; int payment = 200;
      int selected1 = 2; int payment1 = 70;
      int selected2 = 3; int payment2 = 200;

      List<Product> products = new List<Product>();
      products.Add(new Product("cracker", 120));
      products.Add(new Product("juice", 90));



      Receipt rep = vendingMachine(selected, payment, products);
      rep.PrintReceipt();

      Receipt rep1 = vendingMachine(selected1, payment1, products);
      rep1.PrintReceipt();

      Receipt rep2 = vendingMachine(selected2, payment2, products);
      rep2.PrintReceipt();



    }




    public static Receipt vendingMachine(int selected, int payment, List<Product> products)
    {
      //determine the cost and name of the product from selected

      int cost = 120;
      string productName = " ";

      if (selected >= 1 && selected <= products.Count)
      { //crackers
        cost = products[selected - 1].Cost;
        productName = products[selected - 1].ProductName;
        return calculateChange(cost, payment, productName);

      }
      // else if (selected == 2)
      // { //juice
      //   cost = products[selected - 1].Cost;
      //   productName = products[selected - 1].ProductName;
      //   return calculateChange(cost, payment, productName);
      // }
      else
      {
        Receipt r = new Receipt();
        r.Product.ProductName = "Enter a valid product number";
        return r;
      }






    }

    public static Receipt calculateChange(int cost, int payment, string productName)
    {

      Receipt receipt = new Receipt();


      //check that they have enough money
      if (cost > payment)
      {
        receipt.Product.ProductName = "Not Enough money for this product.";
        return receipt;
      }

      receipt.Product.ProductName = productName;

      int change = payment - cost;

      while (change > 0)
      {
        int coinValue = findSmallestCoin(change);
        change = change - coinValue;
        receipt.Change.Add(coinValue);
      }

      return receipt;
    }

    public static int findSmallestCoin(int change)
    {
      List<int> coins = new List<int> { 500, 200, 50, 20, 10 };

      int smallerCoins = coins.Where(coin => coin <= change).First(); //this might be the index, not the value
      return smallerCoins;
    }





  }

  public class Receipt
  {

    public Product Product { get; set; } = new Product();

    public List<int> Change { get; set; } = new List<int>();

    public void PrintReceipt()
    {
      Console.WriteLine($"Product Name: {Product.ProductName}, Change:[ {string.Join(", ", Change)} ]");
    }
  }

  public class Product
  {

    public Product()
    {

    }

    public Product(string name, int price)
    {
      ProductName = name;
      Cost = price;
    }
    public string ProductName { get; set; }

    public int Cost { get; set; }
  }


}
