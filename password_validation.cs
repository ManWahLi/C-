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
  
    static bool isPasswordComplexity(string s)
    {
      return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
    }
  }
}