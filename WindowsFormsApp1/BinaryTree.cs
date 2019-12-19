using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BinaryTree
    {
        OneNode Root;
        public BinaryTree()
        {
            Root = new VarNode("X");
        }
        public bool TryLaodFromString (string st)
        {
            bool res = true;
            Clear();
            //Root = null;
            int pos = 0;
            Root = OneNode.NewNode(ref st, ref pos);
            //MessageBox.Show("In load tree "+ Root.ToString());
            while (pos < st.Length && st[pos] == ' ')
                ++pos;
            if (pos!=st.Length || Root==null)
            {
                //MessageBox.Show("Can't");
                Clear();
                res = false;
            }
            return res;
        }
        public void Clear()
        {
            Root = new VarNode("X");
        }
        public override string ToString()
        {
            string res;
            if (Root.ToString() != "")
                res = Root.ToString();
            else
                res = "";
            return res;
        }
        bool  TryClear(ref OneNode R, ref int count)
        {
            bool res = true;
            if (R!=null)
            {
                OneNode l = R.left;
                OneNode r = R.right;
                if (Root is SignNode)
                {
                    if (l == null || r == null)
                        return false;
                    Sign s = ((SignNode)R).Sign;
                   // MessageBox.Show("Here, s = " + s.ToString());
                    if (l is IntNode && r is IntNode)
                    {
                        int left = ((IntNode)l).Finfo;
                        int right = ((IntNode)r).Finfo;
                        switch (s)
                        {
                            case Sign.mult:
                                R= new IntNode(left * right);
                                ++count;
                                break;
                            case Sign.add:
                                R = new IntNode(left + right);
                                ++count;
                                break;
                            case Sign.divide:
                                if (right == 0)
                                    return false;
                                else
                                    R = new IntNode(left / right);
                                    ++count;
                                break;
                            case Sign.subst:
                                R = new IntNode(left - right);
                                ++count;
                                break;
                            default: return false;
                        }
                    }
                    else
                        switch (s)
                        {
                            case Sign.add:
                                if (l is IntNode && ((IntNode)l).Finfo == 0)
                                {
                                    R = R.right;
                                    ++count;
                                    TryClear(ref R, ref count);
                                }
                                else
                                    if (r is IntNode && ((IntNode)r).Finfo == 0)
                                    {
                                        R = R.left;
                                        ++count;
                                        TryClear(ref R, ref count);
                                    }
                                    else
                                    {
                                        TryClear(ref R.left, ref count);
                                        TryClear(ref R.right, ref count);
                                    }
                                break;
                            case Sign.divide:
                                if (l is IntNode && ((IntNode)l).Finfo == 0)
                                {
                                    R = new IntNode(0);
                                    ++count;
                                }
                                else
                                if (r is IntNode)
                                {
                                    if (((IntNode)r).Finfo == 0)
                                        return false;
                                    else
                                    if (((IntNode)r).Finfo == 1)
                                    {
                                        R = R.left;
                                        ++count;
                                        TryClear(ref R, ref count);
                                    }
                                }
                                else
                                {
                                    TryClear(ref R.left, ref count);
                                    TryClear(ref R.right, ref count);
                                }
                                break;
                            case Sign.mult:
                                if (l is IntNode)
                                {
                                    if (((IntNode)l).Finfo == 0)
                                    {
                                        ++count;
                                        R = new IntNode(0);
                                    }
                                    else
                                        if (((IntNode)l).Finfo == 1)
                                        {
                                            R = R.right;
                                            ++count;
                                            TryClear(ref R, ref count);
                                        }
                                }
                                else
                                    if (r is IntNode)
                                    {
                                        if (((IntNode)r).Finfo == 0)
                                        {
                                            R = new IntNode(0);
                                            ++count;
                                        }
                                        else
                                            if (((IntNode)r).Finfo == 1)
                                            {
                                                R = R.left;
                                                ++count;
                                                TryClear(ref R, ref count);
                                            }
                                    }
                                    else
                                    {
                                        TryClear(ref R.left, ref count);
                                        TryClear(ref R.right, ref count);
                                    }
                                break;
                            case Sign.subst:
                                if (r is IntNode && ((IntNode)r).Finfo == 0)
                                {
                                    R = R.left;
                                    ++count;
                                    TryClear(ref R, ref count);
                                }
                                else
                                {
                                    TryClear(ref R.left, ref count);
                                    TryClear(ref R.right, ref count);
                                }
                                break;
                            default: return false;
                        }

                }
            }
            return res;
        }
        public void Simplify()
        {
            int count = 0;
            bool res;
            do
            {
                count = 0;
                res= TryClear(ref Root, ref count);
            } while (count != 0 && res);
            if (!res)
                Clear();
            
        }
        void PrintOnScreen(OneNode one, TreeNode tree)
        {
            if(one!=null)
            {
                if (one.left!=null)
                {
                    TreeNode tl = new TreeNode(one.left.GetString);
                    tree.Nodes.Add(tl);
                    PrintOnScreen(one.left, tl);
                }
                if(one.right!=null)
                {
                    TreeNode tr = new TreeNode(one.right.GetString);
                    tree.Nodes.Add(tr);
                    PrintOnScreen(one.right, tr);
                }
                
            }
            
        }
        public void Print (TreeView tree)
        {
            TreeNode tr = new TreeNode(Root.GetString);
            tree.Nodes.Add(tr);
            PrintOnScreen(Root, tr);
        }
    }
}