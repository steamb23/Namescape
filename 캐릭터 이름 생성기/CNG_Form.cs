using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharacterNameGenerator
{
    public partial class CNG_Form : Form
    {
        public CNG_Form()
        {
            InitializeComponent();
        }

        private void CNG_Form_Load(object sender, EventArgs e)
        {
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            Algorithm.IAlgorithm algorithm = null;
            //알고리즘 구분 :)
            if (algorithmRadio_Random.Checked)
            {
                algorithm = new Algorithm.Mod.AlgoRandom();
            }
            else if (algorithmRadio_Unicode.Checked)
            {
                algorithm = new Algorithm.Mod.AlgoUnicode();
            }
            //null인지 체크하고 ㄱㄱ
            try
            {
                algorithm.Run();
            }
            catch(NullReferenceException except)
            {
                Dialog.Oops(except, "선택한 알고리즘을 확인해주세요.");
            }
            catch(NotImplementedException except)
            {
                Dialog.Oops(except, "제작자가 멍청하네요. (본인 디스)");
            }
        }
    }
}
