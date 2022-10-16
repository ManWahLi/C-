using System;

namespace Algorithm
{
  class Program
  {
    static bool BinarySearch(int[] inputArray, int item)
    {
      int min = 0;
      int max = inputArray.Length - 1;
      
      while (min <= max)
      {
        int mid = (min + max) / 2;
        if(item == inputArray[mid])
        {
          return true;
        }
        else if(item < inputArray[mid])
        {
          max = mid - 1;
        }
        else(item > inputArray[mid])
        {
          min = mid + 1;
        }
      }
      
      return false;
    }
  }
}
