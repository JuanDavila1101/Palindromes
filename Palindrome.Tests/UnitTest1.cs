using System;
using Xunit;

namespace Palindrome.Tests
{
  public class PalindromeFinderTest
  {
    [Theory]
    [InlineData("Stars", false)]
    [InlineData("O, a kak Uwakov lil vo kawu kakao!", true)]
    [InlineData("Some men interpret nine memos", true)]
    [InlineData("red rum, sir, is murder", true)]
    [InlineData("no lemon, no melon", true)]
    [InlineData("never odd or even", true)]
    public void Determine_if_the_string_passed_is_a_palindrome(string palindromeString, bool expectedPalindromeResult)
    {
      var palindromeFinder = new PalindromeFinder();
      var isStringPalindrome = palindromeFinder.IsStringAPalindrome(palindromeString);
      Assert.Equal(expectedPalindromeResult, isStringPalindrome);
    }
  }
}
