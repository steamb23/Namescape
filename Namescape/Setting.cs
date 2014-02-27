using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape
{
    class Setting
    {
        int charLength;
        public Setting(decimal charLength)
        {
            this.charLength = (int)charLength;
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
