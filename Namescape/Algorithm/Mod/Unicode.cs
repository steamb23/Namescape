using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm.Mod
{
    class Unicode : Algorithm
    {
        private const int _unicodeRangeMin = 0xac00;
        private const int _unicodeRangeMax = 0xd7a3;
        /// <summary>
        /// 유니코드의 한글 범위를 조합합니다.
        /// </summary>
        /// <param name="setting">설정값을 받습니다.</param>
        public Unicode(Setting setting)
        {
            for (int i = setting.CharLength; i != 0; i--)
            {
                result.Append((char)random.Next(0xac00, 0xd7a3 + 1));
            }
        }

    }
}
