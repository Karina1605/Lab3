using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class OneNode
    {
        public OneNode left { get; set; }
        public OneNode right { get; set; }
        public OneNode()
        {
            left = right = null;
        }
        public abstract bool LoadNodeFromString(ref string st, ref int pos);
        
    }
}
