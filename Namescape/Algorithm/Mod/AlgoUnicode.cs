using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm.Mod
{
    class AlgoUnicode:IAlgorithm
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        int charLength;
        StringBuilder result = new StringBuilder();

        public AlgoUnicode(Setting setting)
        {
            charLength = setting.CharLength;
        }

        string IAlgorithm.Run()
        {
            //name[0] = (char)rnd.Next(0xAC00, 0xD7A3+1);
            for (int i = charLength; i != 0; i--)
            {
                result.Append((char)rnd.Next(0xac00, 0xd7a3+1));
            }
            return result.ToString();
        }
    }
}
