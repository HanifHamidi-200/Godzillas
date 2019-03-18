using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VEGEFC
{
    public partial class Form1 : Form
    {
        private List<int> _picture = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<String> _text1 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _text2 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _text3 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _text4 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _text5 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _text6 = new List<string> { null, null, null, null, null, null, null, null };
        private int mnItem;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 6; i++)
            {
                _picture[i - 1] = rnd1.Next(1, 3);
            }

            for (int i = 1; i <= 8; i++)
            {
                _text1[i - 1] = null;
                _text2[i - 1] = null;
                _text3[i - 1] = null;
                _text4[i - 1] = null;
                _text5[i - 1] = null;
                _text6[i - 1] = null;

            }

            mnItem = 1;
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            int nPicture = _picture[mnItem - 1];

            switch (nPicture)
            {
                case 1:
                    picBoard.Image = pic1.Image;
                    break;
                case 2:
                    picBoard.Image = pic2.Image;
                    break;
                default:
                    picBoard.Image = pic3.Image;
                    break;
            }

            switch (mnItem)
            {
                case 1:
                    txt1.Text = _text1[0];
                    txt2.Text = _text1[1];
                    txt3.Text = _text1[2];
                    txt4.Text = _text1[3];
                    txt5.Text = _text1[4];
                    txt6.Text = _text1[5];
                    txt7.Text = _text1[6];
                    txt8.Text = _text1[7];
                    break;
                case 2:
                    txt1.Text = _text2[0];
                    txt2.Text = _text2[1];
                    txt3.Text = _text2[2];
                    txt4.Text = _text2[3];
                    txt5.Text = _text2[4];
                    txt6.Text = _text2[5];
                    txt7.Text = _text2[6];
                    txt8.Text = _text2[7];
                    break;
                case 3:
                    txt1.Text = _text3[0];
                    txt2.Text = _text3[1];
                    txt3.Text = _text3[2];
                    txt4.Text = _text3[3];
                    txt5.Text = _text3[4];
                    txt6.Text = _text3[5];
                    txt7.Text = _text3[6];
                    txt8.Text = _text3[7];
                    break;
                case 4:
                    txt1.Text = _text4[0];
                    txt2.Text = _text4[1];
                    txt3.Text = _text4[2];
                    txt4.Text = _text4[3];
                    txt5.Text = _text4[4];
                    txt6.Text = _text4[5];
                    txt7.Text = _text4[6];
                    txt8.Text = _text4[7];
                    break;
                case 5:
                    txt1.Text = _text5[0];
                    txt2.Text = _text5[1];
                    txt3.Text = _text5[2];
                    txt4.Text = _text5[3];
                    txt5.Text = _text5[4];
                    txt6.Text = _text5[5];
                    txt7.Text = _text5[6];
                    txt8.Text = _text5[7];
                    break;
                default:
                    txt1.Text = _text6[0];
                    txt2.Text = _text6[1];
                    txt3.Text = _text6[2];
                    txt4.Text = _text6[3];
                    txt5.Text = _text6[4];
                    txt6.Text = _text6[5];
                    txt7.Text = _text6[6];
                    txt8.Text = _text6[7];
                    break;
            }
        }

        private void fSave()
        {
            switch (mnItem)
            {
                case 1:
                    _text1[0] = txt1.Text;
                    _text1[1] = txt2.Text;
                    _text1[2] = txt3.Text;
                    _text1[3] = txt4.Text;
                    _text1[4] = txt5.Text;
                    _text1[5] = txt6.Text;
                    _text1[6] = txt7.Text;
                    _text1[7] = txt8.Text;
                    break;
                case 2:
                    _text2[0] = txt1.Text;
                    _text2[1] = txt2.Text;
                    _text2[2] = txt3.Text;
                    _text2[3] = txt4.Text;
                    _text2[4] = txt5.Text;
                    _text2[5] = txt6.Text;
                    _text2[6] = txt7.Text;
                    _text2[7] = txt8.Text;
                    break;
                case 3:
                    _text3[0] = txt1.Text;
                    _text3[1] = txt2.Text;
                    _text3[2] = txt3.Text;
                    _text3[3] = txt4.Text;
                    _text3[4] = txt5.Text;
                    _text3[5] = txt6.Text;
                    _text3[6] = txt7.Text;
                    _text3[7] = txt8.Text;
                    break;
                case 4:
                    _text4[0] = txt1.Text;
                    _text4[1] = txt2.Text;
                    _text4[2] = txt3.Text;
                    _text4[3] = txt4.Text;
                    _text4[4] = txt5.Text;
                    _text4[5] = txt6.Text;
                    _text4[6] = txt7.Text;
                    _text4[7] = txt8.Text;
                    break;
                case 5:
                    _text5[0] = txt1.Text;
                    _text5[1] = txt2.Text;
                    _text5[2] = txt3.Text;
                    _text5[3] = txt4.Text;
                    _text5[4] = txt5.Text;
                    _text5[5] = txt6.Text;
                    _text5[6] = txt7.Text;
                    _text5[7] = txt8.Text;
                    break;
                default:
                    _text6[0] = txt1.Text;
                    _text6[1] = txt2.Text;
                    _text6[2] = txt3.Text;
                    _text6[3] = txt4.Text;
                    _text6[4] = txt5.Text;
                    _text6[5] = txt6.Text;
                    _text6[6] = txt7.Text;
                    _text6[7] = txt8.Text;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnItem = 1;
            fUpdateDisplay();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fUpdateDisplay();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fUpdateDisplay();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnItem = 4;
            fUpdateDisplay();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            mnItem = 5;
            fUpdateDisplay();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            mnItem = 6;
            fUpdateDisplay();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }
    }
}
