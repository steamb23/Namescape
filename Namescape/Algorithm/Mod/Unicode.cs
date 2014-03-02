using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm.Mod
{
    class Unicode : Algorithm
    {
        const int _UNICODE_RANGE_MIN = 0xac00;
        const int _UNICODE_RANGE_MAX = 0xd7a3;
        /// <summary>
        /// 유니코드의 한글 범위를 조합합니다.
        /// </summary>
        /// <param name="setting">설정값을 받습니다.</param>
        public Unicode(Setting setting)
        {
            for (int i = setting.CharLength; i != 0; i--)
            {
                result.Append((char)random.Next(_UNICODE_RANGE_MIN, _UNICODE_RANGE_MAX + 1));
            }
        }

    }
}
