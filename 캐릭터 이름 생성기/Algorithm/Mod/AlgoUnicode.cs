using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterNameGenerator.Algorithm.Mod
{
    class AlgoUnicode:IAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        public AlgoUnicode()
        {
            rnd = new Random(DateTime.Now.Millisecond);

            rnd.Next(0xAC00, 0xD7A3);
        }
        Random rnd;

        string IAlgorithm.Run()
        {
            throw new NotImplementedException();
        }
    }
}
