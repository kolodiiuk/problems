#include <stack>
/**
* Definition for a binary tree node.
* */
  struct TreeNode
  {
      int val;
      TreeNode *left;
      TreeNode *right;
      TreeNode() : val(0), left(nullptr), right(nullptr) {}
      TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
      TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
  }
 /** };
 */
class Solution {
public:
    bool isSameTree(TreeNode* p, TreeNode* q) {
        std::stack<TreeNode*> stackP, stackQ;
        stackP.push(p);
        stackQ.push(q);
        while (!stackP.empty() && !stackQ.empty()) {
            TreeNode* nodeP = stackP.top();
            TreeNode* nodeQ = stackQ.top();
            stackP.pop();
            stackQ.pop();
            if (nodeP == NULL && nodeQ == NULL) continue;
            if (nodeP == NULL || nodeQ == NULL) return false;
            if (nodeP->val != nodeQ->val) return false;
            stackP.push(nodeP->left);
            stackP.push(nodeP->right);
            stackQ.push(nodeQ->left);
            stackQ.push(nodeQ->right);
        }
        return stackP.empty() && stackQ.empty();
    }
};
