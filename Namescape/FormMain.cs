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
            Setting setting = new Setting(CharLength);

            //라디오 버튼 확인
            if (algorithmRadio_Unicode.Checked)
            {
                algorithm = new Algorithm.Mod.Unicode(setting);
            }
            string result = algorithm.Result;
#if DEBUG
            Clipboard.SetText(result);
            ResultBox.Text = result;
#else
            try //이래야 배포후 문제생겼을 때 처리 쉬워짐
            {
                Clipboard.SetText(result);
                ResultBox.Text = result;
            }
            catch(NullReferenceException except) //Null은 체크해야..
            {
                Dialog.Oops(except);
            }
            catch(NotImplementedException except)
            {
                Dialog.Oops(except, "제작자가 구현을 깜박한듯 -ㅅ-");
            }
#endif

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
