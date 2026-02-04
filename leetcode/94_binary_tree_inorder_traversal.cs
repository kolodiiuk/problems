/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null) {
            return new List<int>();
        }

        var res = new List<int>();
        Traverse(root, res);

        return res;

        void Traverse(TreeNode root, List<int> r) {
            if (root is not null) {
                Traverse(root.left, r);
                r.Add(root.val);
                Traverse(root.right, r);
            }
        }
    }

    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null) {
            return new List<int>();
        }

        var res = new List<int>();
        var stack = new Stack<TreeNode>();
        var curr = root;
        stack.Push(curr);

        while (stack.Count != 0 && curr != null) {
            if (curr.left == null || res.Count != 0 && res[res.Count - 1] == curr.val) {
                curr = stack.Pop();
                res.Add(curr.val);
                if (curr.right != null) {
                    stack.Push(curr.right);
                    curr = curr.right;
                }
            } else if (curr.left != null) {
                stack.Push(curr.left);
                curr = curr.left;
            }
        }

        return res;
    }
}
