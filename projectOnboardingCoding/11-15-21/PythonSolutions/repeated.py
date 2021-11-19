# 1) Create a solution that checks if a given string consists of a sub-string pattern repeated multiple times to return True or False.

# Examples:
# repeated("a") --> False

# repeated("ababab") --> True

# repeated("aba") --> False

# repeated("abcabcabcabc") --> True

# repeated("aaxxtaaxztaaxxt") --> False

# find all the possible substrings in the given string
def substrings(string, length):

    subStrings = []
    for x in range(length, 0, -1):

        frontString = string[0:x]
        subStrings.append(frontString)

    return subStrings

# determine if a string has a pattern
# How does it work:
  # Use the substring function to find all of the substrings
  # Create a pattern using the substring equal in length to the original string
  # Compare the created pattern to the original string


def repeated(string):
    length = len(string)
    if(length <= 1):
        return False
    else:
        subStrings = substrings(string, length)
        for strings in subStrings:
            lengthOfSubstring = len(strings)
            if(lengthOfSubstring <= length/2):

                testString = strings * int((length/lengthOfSubstring))
                if(string == testString):
                    return True
        else:
            return False


# Test cases
print(repeated("ababab"))
print(repeated("a"))
print(repeated("aba"))
print(repeated("abcabcabcabc"))
print(repeated("aaxxtaaxztaaxxt"))
