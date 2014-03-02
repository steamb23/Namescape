using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm
{
    /// <summary>
    /// 알고리즘 제작시 필수적으로 상속해야하는 인터페이스입니다.
    /// </summary>
    internal interface IAlgorithm
    {
        /// <summary>
        /// 초기화된 세팅 값에 따라 문자를 조합합니다.
        /// </summary>
        string Result
        {
            get;
        }
    }
}
