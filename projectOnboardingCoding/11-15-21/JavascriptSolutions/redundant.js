//Task:
// 2) Write a function redundant that takes in a string 'str' and returns a function that returns 'str'.

// Examples
// const f1 = redundant("apple")
// f1() --> "apple"

// const f2 = redundant("pear")
// f2() --> "pear"

// const f3 = redundant("")
// f3() -->""

// Notes:
// Your function should return a 'function', not a string.

//Test cases
let str = "apple"
let str1 = "pear"
let str2 = ""

console.log(redundant(str));
console.log(redundant(str1));
console.log(redundant(str2));




//function

function redundant(str) {
  return function stringReturner(str) { return str }

}




