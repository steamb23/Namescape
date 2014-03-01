using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm.Mod
{
    class AlgoUnicode:IAlgorithm
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        StringBuilder result = new StringBuilder();
        /// <summary>
        /// 유니코드의 한글 범위를 조합합니다.
        /// </summary>
        /// <param name="setting">설정값을 </param>
        public AlgoUnicode(Setting setting)
        {
            for (int i = setting.CharLength; i != 0; i--)
            {
                result.Append((char)rnd.Next(0xac00, 0xd7a3 + 1));
            }
        }

        string IAlgorithm.Result
        {
            get
            {   
                return result.ToString();
            }
        }
    }
}
