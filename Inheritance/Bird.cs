using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animals
    {
        public int WingSpan { get; set; }
        public bool DoesFly {  get; set; }
        public bool AmericasMascot { get; set; }
        public string Color { get; set; }

    }
}
