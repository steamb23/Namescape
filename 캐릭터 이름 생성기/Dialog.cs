using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharacterNameGenerator
{
    class Dialog
    {
        static string oops = "사용자가 처리할 수 없는 에러가 출력되었습니다!!\n제작자에게 이 사실을 알려주세요!\n\n";
        public static void Oops(Exception except)
        {
            MessageBox.Show(
                oops + except,
                "으악!");
        }
        public static void Oops(Exception except, string message)
        {
            MessageBox.Show(
                oops + except + "\n\n메세지: " + message,
                "으악!");
        }
    }
}
