using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos
{
    internal class SLNode
    {

        private int _val;
        internal SLNode i_next = null;

        public int val
        {
            set { _val = value; }
            get { return _val; }
        }

        public SLNode(int n)
        {
            val = n;
        }

    }
}
