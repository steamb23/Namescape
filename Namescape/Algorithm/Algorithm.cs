using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm
{
    abstract class Algorithm
    {
        private Setting setting;

        public Algorithm()
        {
        }

        public Algorithm(Setting setting)
        {
            // TODO: Complete member initialization
            this.setting = setting;
        }

        abstract public string Run();
    }
}
