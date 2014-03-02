using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm.Mod
{
    /// <summary>
    /// 알고리즘 제작에 관한 공통적인 멤버를 제공합니다.
    /// 이 클래스를 사용하여 좀더 간단하게 짤 수 있습니다.
    /// </summary>
    internal class Algorithm : IAlgorithm
    {
        public Random random = new Random(DateTime.Now.Millisecond);
        public StringBuilder result = new StringBuilder();
        public Setting setting;

        string IAlgorithm.Result
        {
            get
            {
                return result.ToString();
            }
        }
    }
}
