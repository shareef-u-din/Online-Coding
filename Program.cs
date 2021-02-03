using System;
using OnlineCoding.BinarySearchTree;
using OnlineCoding.HammingWeight;

namespace OnlineCoding
{
  class Program
  {
    static void Main(string[] args)
    {
    //   HammingWeightItem hm = new HammingWeightItem(00000000000000000000000000001011);
    //   int count = hm.Weight();
    //   System.Console.WriteLine("*******************************************");
      
      Tree tree = new Tree(new TreeNode(1));
      //tree.AddNode(1);
      tree.AddNode(2);
      var root = tree.Root;
     tree.TrimBST(root,2,4);
      System.Console.WriteLine("*******************************************");
      System.Console.WriteLine("***************END****************");
    }
  }
}
