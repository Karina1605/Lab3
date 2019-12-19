using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class VarNode: OneNode
    {
        string variable;
        public override string GetString
        {
            get
            {
                return variable;
            }
        }
        public VarNode(string st): base()
        {
            variable = st;
        }
       
        public override bool LoadNodeFromString(ref string st, ref int pos)
        {
            string buff = "";
            while (pos<st.Length && st[pos]>='a' && pos<='z')
            {
                buff += st[pos];
                ++pos;
            }
            variable = buff;
            return true;
        }
        public override string ToString()
        {
            return variable;
        }
        public override OneNode Copy()
        {
            return new VarNode(this.variable);
        }
    }
}
