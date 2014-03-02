using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape
{
    struct Setting
    {
        int charLength;
        public Setting(int charLength)
        {
            this.charLength = charLength;
        }
        public int CharLength
        {
            get
            {
                return charLength;
            }
        }
    }
}
