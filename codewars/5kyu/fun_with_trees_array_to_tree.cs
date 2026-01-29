class Solution
{
    public static TreeNode ArrayToTree(int[] array)
    {
        var rootToReturn = new TreeNode(array[0]);
        var root = rootToReturn;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        for (int i = 1; i < array.Length && queue.Count > 0; ++i)
        {
            var currNode = queue.Dequeue();
            currNode.left = new TreeNode(array[i]);
            queue.Enqueue(currNode.left);
            if (i + 1 >= array.Length)
            {
                break;
            }

            currNode.right = new TreeNode(array[++i]);
            queue.Enqueue(currNode.right);
        }

        return rootToReturn;
    }
}

class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int value;

    public TreeNode(int value, TreeNode left, TreeNode right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }

    public TreeNode(int value)
    {
        this.value = value;
    }
}
