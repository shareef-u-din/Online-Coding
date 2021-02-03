using System;

namespace OnlineCoding.BinarySearchTree
{
  public class Tree
  {
    public TreeNode Root { get; private set; } 
    public Tree(TreeNode root)
    {
      Root = root;
    }

    public TreeNode CreateNode(int val)
    {
      return new TreeNode
      {
        val = val,
        left = null,
        right = null,
      };
    }
    public TreeNode AddNode(int val)
    {
      TreeNode node = CreateNode(val);
      if (Root == null)
      {
        Root = node;
        return Root;
      }
      var tempRoot = Root;
      TreeNode endNode = null;
      while (tempRoot != null)
      {
        if (tempRoot.val > val)
        {
          endNode = tempRoot;
          tempRoot = tempRoot.left;

        }
        else
        {
          endNode = tempRoot;
          tempRoot = tempRoot.right;
        }
      }
      if (endNode.val > val)
        endNode.left = node;
      else
        endNode.right = node;
      return Root;
    }

    public TreeNode TrimBST(TreeNode root, int low, int high)
    {
      if (root == null) return root;
      if (root.val < low)
        return TrimBST(root.right, low, high);
      if (root.val > high)
        return TrimBST(root.left, low, high);
      var tempRoot  = root;
      var parent = root;

      while(tempRoot != null){
        if(tempRoot.val < low){
          parent.left = tempRoot.right;
        }
        else parent = tempRoot;
        tempRoot=parent.left;
      }
      tempRoot = root;
      parent = root;
      while (tempRoot != null)
      {
        if (tempRoot.val > high)
        {
          parent.right = tempRoot.left;
        }
        else
         parent = tempRoot;
        tempRoot = parent.right;
      }

       
      return root;
    }

  }
}