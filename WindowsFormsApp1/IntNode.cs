using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class IntNode: OneNode
    {
        int Info;
        public int Finfo { get { return Info; } set { Info = value; } }
        public IntNode(int a):base()
        {
            Finfo = a;
        }
        
        public override bool LoadNodeFromString (ref string st, ref int pos)
        {
            string buff="";
            while (pos < st.Length && Char.IsDigit(st[pos]))
            {
                buff += st[pos];
                ++pos;
            }
            int.TryParse(buff, out Info);
            return true;
        }
        public override string ToString()
        {
            return Finfo.ToString() + " ";
        }
        public override OneNode Copy()
        {
            IntNode result = new IntNode(this.Finfo);
            return result;
        }
    }
}
