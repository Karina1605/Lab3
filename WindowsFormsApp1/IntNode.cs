using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class IntNode: OneNode
    {
        int Finfo;
        public IntNode(int a):base()
        {
            Finfo = a;
        }
        
        public override bool LoadNodeFromString (ref string st, ref int pos)
        {
            string buff="";
            while (pos < st.Length && st[pos] >= '0' && st[pos]<='9')
            {
                buff += st[pos];
                pos++;
            }
            int.TryParse(buff, out Finfo);
            return true;
        }
        public override string ToString()
        {
            return Finfo.ToString() + " ";
        }
        
    }
}
