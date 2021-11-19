
// author: Briana Wynn
// date: 11/17/21

//Task
// One to retrieve all
// unique substrings that start and end with a vowel.

// Examples:
// getConsonantSubstrings("aviation")
// --> ["n", "t", "tion", "v", "viat", "viation"]

// getConsonantSubstrings("motor")
// -->["m", "mot", "motor", "r", "t", "tor"]

// Notes:
// - Remember the output array should have unique values.
// - The word itself counts as a potential substring.
// - Exclude the empty string when outputting the array.


//Test cases
console.log(consonants("apple"));
console.log(consonants("hmm"));
console.log(consonants("laugh"));
console.log(consonants("bare"));
console.log(consonants("atone"));
console.log(consonants("I"));
console.log(consonants("Identical"));
console.log(consonants("aviation"));
console.log(consonants("motor"));


function consonants(string) {

  let lowerString = string.toLowerCase();
  let result = [];
  let consonants = ['b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'];

  for (let i = string.length; i >= 0; i--) {
    for (let j = 0; j <= string.length; j++) {
      let frontString = lowerString.substring(0, i);
      let backString = lowerString.substring(j, string.length);
      let middleString = lowerString.substring(i, j);

      if (consonants.includes(frontString[0]) && consonants.includes(frontString[frontString.length - 1])) {
        //check if the letter is already in result
        if (!result.includes(frontString)) {
          result.push(frontString);
        }
      }
      if (consonants.includes(backString[0]) && consonants.includes(backString[backString.length - 1])) {
        //check if the letter is already in result
        if (!result.includes(backString)) {
          result.push(backString);
        }
      }
      if (consonants.includes(middleString[0]) && consonants.includes(middleString[middleString.length - 1])) {
        //check if the letter is already in result
        if (!result.includes(middleString)) {
          result.push(middleString);
        }
      }

    }
  }

  return result.sort();
}