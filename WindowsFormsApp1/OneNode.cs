using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    abstract class OneNode
    { 
        public abstract string GetString { get; }
        public OneNode left;
        public OneNode right;
        public OneNode()
        {
            left = right = null;
        }
        public abstract bool LoadNodeFromString(ref string st, ref int pos);
        public abstract OneNode Copy();
        public static OneNode NewNode (ref string st,ref int pos)
        {
            OneNode res = null;
            while (pos < st.Length && st[pos] == ' ')
                ++pos;
            //MessageBox.Show("In ONENODE, '" + st[pos] + "'");
            if (pos<st.Length)
            {
                if (Char.IsLower(st[pos]))
                    res = new VarNode("");
                else
                   if (Char.IsDigit(st[pos]))
                    res = new IntNode(0);
                else
                    if (st[pos] == '(')
                    res = new SignNode(Sign.empty);
            }
            if (res != null && !res.LoadNodeFromString(ref st, ref pos))
                res = null;
            return res;
        }
        public static void DelNode(OneNode node)
        {
            if (node!=null)
                {
                if (node.left != null)
                    DelNode(node.left);
                if (node.right != null)
                    DelNode(node.right);
                node = null;
            }
        }
        public override string ToString()
        {
            return "";
        }
    }
}
