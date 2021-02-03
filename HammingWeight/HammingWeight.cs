using System;
using System.Linq;

namespace OnlineCoding.HammingWeight
{
  public class HammingWeightItem
  {
    private readonly uint number;
    public HammingWeightItem(uint num)
    {
      number = num;
    }

    public int Weight()
    {
      var count = 0;
      uint n= number;
      for (int i = 0; i < 32; i++)
      {
        if (((n >> i) & 1) == 1)
        {
          count++;
        }
      }
      return count;
    }
  }
}