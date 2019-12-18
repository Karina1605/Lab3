using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    enum Sign { add, subst, mult, divide, empty}
    class SignNode: OneNode
    {
        Sign sign;
        public Sign Sign { get { return sign; } }
        static readonly char[] Sings = { '+', '-', '*', '/', '?' };
        public SignNode( Sign c): base()
        {
            sign = c;
        }
        public override OneNode Copy()
        {
            SignNode sign = new SignNode(this.sign);
            return sign;
        }
        public override bool LoadNodeFromString(ref string st, ref int pos)
        {
            bool res = true;
            if (pos >= st.Length)
                res = false;
            else
                if (st[pos] != '(')
                    res = false;
                else
                {
                    ++pos;
                    while (pos < st.Length && st[pos] == ' ')
                        ++pos;
                    left = OneNode.NewNode(ref st, ref pos);
                    if (left == null)
                        res = false;
                    else
                    {
                        while (pos < st.Length && st[pos] == ' ')
                            ++pos;
                        int p = Array.IndexOf(Sings, st[pos]);
                        if (pos == st.Length ||  p== -1 || p==4)
                            res = false;
                        else
                        {
                       
                            sign = (Sign)p;
                            MessageBox.Show("Sign in reading = " + st[pos] + " p = " + p+" si = "+sign);
                            ++pos;
                            right = OneNode.NewNode(ref st, ref pos);
                            if (right == null)
                                res = false;
                            else
                            {
                                while (pos < st.Length && st[pos] == ' ')
                                    ++pos;
                                if (pos == st.Length || st[pos] != ')')
                                    res = false;
                                else
                                    ++pos;
                                MessageBox.Show("res = " + res);
                            }
                        }
                    }
                }
            return res;
        }
        public override string ToString()
        {
            return Sings[(int)sign].ToString();
        }
    }
}
