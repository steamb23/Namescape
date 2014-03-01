using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Namescape.Algorithm.Mod
{
    class AlgoKoreanName : IAlgorithm
    {
        /// <summary>
        /// 한국어 인명용한자표에 나온 한자들의 발음만 조합합니다.
        /// </summary>
        /// <param name="setting"></param>
        public AlgoKoreanName(Setting setting)
        {
            //개발전 메모: 두음 법칙도 적용해야함. 망할.
        }
        string IAlgorithm.Result
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //외부파일은 쓰기싫어서 string 배열로함.
        public static string[] KoreanName = new string[]
        {
            //배열을 만들어 쓸거라서 나중을 기약하지.
        };
    }
}
