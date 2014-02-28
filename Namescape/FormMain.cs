using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Namescape
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        int CharLength
        {
            get
            {
                return (int)this.charLength.Value;
            }
        }

        private void CNG_Form_Load(object sender, EventArgs e)
        {
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            Algorithm.IAlgorithm algorithm = null;
            string result = "a";
            //알고리즘 구분 :)

            if (algorithmRadio_Unicode.Checked)
            {
                algorithm = new Algorithm.Mod.AlgoUnicode(new Setting(this.charLength.Value));
            }
            //null인지 체크
#if DEBUG
            result = algorithm.Result;
#else
            try
            {
                algorithm.Run();
            }
            catch(NullReferenceException except)
            {
                Dialog.Oops(except);
            }
            catch(NotImplementedException except)
            {
                Dialog.Oops(except, "제작자가 깜박한듯 -ㅅ-");
            }
#endif
            //Console.WriteLine(result);
            Clipboard.SetText(result);
            ResultBox.Text = result;

        }
    }
}
