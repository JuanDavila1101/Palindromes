using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
  public class PalindromeFinder
  {
    public bool IsStringAPalindrome(string palindromeString)
    {
      var listOfCharacterToOverlook = new List<char> {' ', ',', '\'', '!', '?', '.', ';', ':', '\"', '/', '\\', '-'};
      palindromeString = palindromeString.ToLower();

      for (int i = 0, x = palindromeString.Length - 1; i <= x; i++, x--)
      {
        while (listOfCharacterToOverlook.Contains(palindromeString[i])) {i++;}
        while (listOfCharacterToOverlook.Contains(palindromeString[x])) {x--;}
        if (palindromeString[i] != palindromeString[x]) return false;
      }
      return true;
    }
  }
}
