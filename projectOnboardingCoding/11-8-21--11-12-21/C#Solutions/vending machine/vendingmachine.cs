using System;
using System.Collections.Generic;
using System.Linq;
namespace projectOnboardingCoding
{
  public class VendingMachine
  {
    // //initialize products list and fill it
    // List<Product> products = new List<Product>();
    // products.Add(new Product("cracker", 120));
    // products.Add(new Product("juice", 90));
    // Receipt rep = vendingMachine(selected, payment, products);
    // rep.PrintReceipt();
    // Receipt rep1 = vendingMachine(selected1, payment1, products);
    // rep1.PrintReceipt();
    // Receipt rep2 = vendingMachine(selected2, payment2, products);
    // rep2.PrintReceipt();

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
  }//eoc

  /// <summary>
  /// define a receipt
  /// </summary>
  public class Receipt
  {

    public Product Product { get; set; } = new Product();

    public List<int> Change { get; set; } = new List<int>();

    public void PrintReceipt()
    {
      Console.WriteLine($"Product Name: {Product.ProductName}, Change:[ {string.Join(", ", Change)} ]");
    }
  }

  /// <summary>
  /// define a product
  /// </summary>
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
}//eon



