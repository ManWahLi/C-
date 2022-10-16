using System;
using System.Linq;

namespace Alogrithms
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(isPasswordComplexity("Hell0"));
    }
    
    // An alogrithms to check password complexity. A password must contain at least one uppercase, one lowercase and one number.
    // param: input string
    // return: bool
    static bool isPasswordComplexity(string s)
    {
      return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
    }
  }
}
