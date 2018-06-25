using System;
using System.Collections.Generic;


public class Palindrome
{
  public string someWord;
  public Palindrome (string palindromeWord)
  {
    someWord = palindromeWord;
  }
  public bool PalindromeChecker()
  {

    string reversedWord = "";
    for (int i = 0; i < someWord.Length; i++)
    {
      reversedWord = reversedWord + someWord[(someWord.Length - 1) - i];
    }
    return someWord.Equals(reversedWord);
  }
}


class Program
{

  static void Main()
  {
    Console.WriteLine("Enter a word that you want to check for Palindromeness:");
    string isThisAPalindrome = Console.ReadLine();
    Palindrome newPalindrome = new Palindrome (isThisAPalindrome);
    if(newPalindrome.PalindromeChecker())
    {
      Console.WriteLine("This is a palindrome yay");
    }
    else
    {
      Console.WriteLine("It's not a palindrome idiot");
    }
  }
}
