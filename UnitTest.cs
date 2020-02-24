using System;

public static class UnitTest
{
  public static void TestIsPalindromeA() 
  {
    Console.WriteLine("Test IsPalindrome: Problem A");
    Solution s = new Solution();
    
    bool answer = s.IsPalindrome(121);
    
    Assert(answer, true, "121 is a palindrome of 121.");
    Console.WriteLine();
  }

  public static void TestIsPalindromeB() 
  {
    Console.WriteLine("Test IsPalindrome: Problem B");
    Solution s = new Solution();
    
    bool answer = s.IsPalindrome(-121);
    
    Assert(answer, false, "121- is NOT a palindrome of -121.");
    Console.WriteLine();
  }

  public static void TestIsPalindromeC() 
  {
    Console.WriteLine("Test IsPalindrome: Problem C");
    Solution s = new Solution();
    
    bool answer = s.IsPalindrome(10);
    
    Assert(answer, false, "01 is NOT a palindrome of 10.");
    Console.WriteLine();
  }

  public static void Assert(bool value, bool check, string testcase) 
  {
      if (value == check)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }
}