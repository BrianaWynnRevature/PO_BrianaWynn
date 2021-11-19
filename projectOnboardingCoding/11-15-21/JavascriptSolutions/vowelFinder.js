
// author: Briana Wynn
// date: 11/17/21

//Task
// One to retrieve all
// unique substrings that start and end with a vowel.

// Examples:
// getVowelSubstrings("apple")
// --> ["a", "apple", "e"]

// getVowelSubstrings("hmm") --> []

// Notes:
// - Remember the output array should have unique values.
// - The word itself counts as a potential substring.
// - Exclude the empty string when outputting the array.


//Test cases
console.log(vowels("apple"));
console.log(vowels("hmm"));
console.log(vowels("laugh"));
console.log(vowels("bare"));
console.log(vowels("atone"));
console.log(vowels("I"));
console.log(vowels("Identical"));


function vowels(string) {

  let result = [];
  let vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'J', 'K'];

  for (let i = string.length; i >= 0; i--) {
    for (let j = 0; j <= string.length; j++) {
      let frontString = string.substring(0, i);
      let backString = string.substring(j, string.length);
      let middleString = string.substring(i, j);

      if (vowels.includes(frontString[0]) && vowels.includes(frontString[frontString.length - 1])) {
        //check if the letter is already in result
        if (!result.includes(frontString)) {
          result.push(frontString);
        }
      }
      if (vowels.includes(backString[0]) && vowels.includes(backString[backString.length - 1])) {
        //check if the letter is already in result
        if (!result.includes(backString)) {
          result.push(backString);
        }
      }
      if (vowels.includes(middleString[0]) && vowels.includes(middleString[middleString.length - 1])) {
        //check if the letter is already in result
        if (!result.includes(middleString)) {
          result.push(middleString);
        }
      }

    }
  }

  return result.sort();
}