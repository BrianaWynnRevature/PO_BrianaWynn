//define a product
class Product {

  constructor(name, price) {
    this.name = name;
    this.price = price;
  }
}

//define a receipt
class Receipt {
  constructor(product, change) {

    this.product = product;
    this.change = change;
  }

}

//Test cases
let selected = 1; let payment = 200;
let selected1 = 2; let payment1 = 70;
let selected2 = 3; let payment2 = 200;
let selected4 = 2; let payment4 = 90;

products = [new Product("cracker", 120), new Product("juice", 90)];

printReceipt(vendingMachine(selected, payment, products));
printReceipt(vendingMachine(selected1, payment1, products));
printReceipt(vendingMachine(selected2, payment2, products));
printReceipt(vendingMachine(selected4, payment4, products));
printReceipt(vendingMachine(0, 200, products));

//print the receipt
function printReceipt(receipt) {

  if (typeof receipt === 'string' || receipt instanceof String) {
    console.log(receipt);
  }
  else {
    console.log(`Product Name: ${receipt.product.name}, Change: [${receipt.change}]`)
  }
}
//Find the smallest coin to subtract
function findSmallestCoin(change) {
  let coins = [500, 200, 50, 20, 10];

  let smallerCoins = coins.filter(coin => coin <= change)
  return smallerCoins[0];
}

//calculate the change array
function calculateChange(cost, payment, productName) {
  let receipt = new Receipt();
  let receiptProduct = new Product();
  let receiptChange = [];
  receipt.product = receiptProduct;
  receipt.change = receiptChange;

  //check that they have enough money
  if (cost > payment) {
    return "Not enough money for this product."
  }


  receipt.product.name = productName;
  receipt.product.price = cost;

  //calculate the change
  let change = payment - cost;

  while (change > 0) {
    let coinValue = findSmallestCoin(change);
    change = change - coinValue;
    receipt.change.push(coinValue);
  }

  return receipt;

}

//set up the vending machine selection function
function vendingMachine(selected, payment, products) {
  //determine the cost and name of the product from selected
  let cost = 120;
  let productName = " ";

  if (selected >= 1 && selected <= products.length) {
    //crackers
    cost = products[selected - 1].price;
    productName = products[selected - 1].name;
    return calculateChange(cost, payment, productName);
  }
  else {
    return "Enter a valid product number";
  }
}