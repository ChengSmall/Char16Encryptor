using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheng.TXT16
{

    internal sealed class CharValueEquality : EqualityComparer<char>
    {

        public override bool Equals(char x, char y)
        {
            return x == y;
        }

        public override int GetHashCode(char obj)
        {
            return obj;
        }
    }

}
