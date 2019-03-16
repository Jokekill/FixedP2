using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class FixedNumber
    {    
        public abstract int ShiftAmount  {get;}       
    }

    class Q24_8 : FixedNumber
    {
        public override int ShiftAmount { get => 8;}
    }
    class Q16_16 : FixedNumber
    {
        public override int ShiftAmount { get => 16; }
    }
    class Q8_24 : FixedNumber
    {
        public override int ShiftAmount { get => 24; }
    }
}

