using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFAKE
{
    public partial class Form1 : Form
    {
        private List<String> _text1 = new List<string> { "lines going down", "lines going across", "lines going up" };
        private List<String> _text2 = new List<string> { "in the corner", "in the margin", "underneath the closet" };
        private List<String> _text3 = new List<string> { "aligned", "at opposite poles" };
        private List<String> _text4 = new List<string> { "symbol enhanced" };
        private List<String> _text5 = new List<string> { "3d representation of data" };
        private List<int> _sum = new List<int> { 3,3, 2, 1, 1 };
        private int mnCount;
        private List<String> _item = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<bool> _but = new List<bool> { false, false, false, false, false, false, false, false, false, false };
        private List<bool> _check = new List<bool> { false, false, false, false, false, false, false, false, false, false };
        private int nNumber;
        private int mnFake=0, mnReal=0;
        private String msShuffle;
        private String msShuffle2;
        private int mnItem;
        private int mnFeeling;
        private List<int> _time = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _length = new List<int> { 0, 0 };
        private List<int> _width = new List<int> { 0, 0 };
        private List<int> _height = new List<int> { 0, 0 };




        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F off1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F off2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F off3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F off4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F on1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F on2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F on3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F on4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        
            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                default:
                    _pic2 = picture9;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;
        
            nType = Convert.ToInt32(msShuffle2.Substring((nSquare - 1)*2, 2));
            return nType;
        }

        private void fSelect()
        {
            Random rnd1 = new Random();
            int nType = mnItem + 4;
            String sTwo = "0" + Convert.ToString(nType);
            PictureBox _pic = new PictureBox();
            int nRotate = 1;

            msShuffle2 = "01020304";
            fPlace(sTwo, mnItem);

         
            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic1.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic2.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic3.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic4.Image = _pic.Image;

            mnFeeling = rnd1.Next(1, 4);

            switch (mnFeeling)
            {
                case 1:
                    lblFeeling.Text = "perplexed";
                    break;
                case 2:
                    lblFeeling.Text = "syndicate";
                    break;
                default:
                    lblFeeling.Text = "astable";
                    break;
            }
        }

        private void fPlace(String sText, int nPos)
        {
            if (nPos == 4)
            {
                msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText;

            }
            else
            {
                msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (4 - nPos) * 2);

            }
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nCount = rnd1.Next(4, 11);
            int nPos, nSum, nVersion;
            String sText;
            int nVersion2;
            int nCount2;
            char sLetter1, sLetter2;
            int nHalf, nAdd;

            mnCount = nCount;
            btnFake.Text = "FAKE" + Convert.ToString(mnFake);
            btnReal.Text = "REAL" + Convert.ToString(mnReal);
            txt1.Text = null;

            for (int i = 1; i <= nCount; i++)
            {
                nPos = rnd1.Next(1, 6);
                nSum = _sum[nPos - 1];
                nVersion = rnd1.Next(1, nSum + 1);
                switch (nPos)
                {
                    case 1:
                        sText = _text1[nVersion - 1];
                        nCount2 = rnd1.Next(1, 4);
                        sText = Convert.ToString(nCount2) + " " + sText;
                        break;
                    case 2:
                        sText = _text2[nVersion - 1];
                        nVersion2 = rnd1.Next(1, 4);
                        switch (nVersion2)
                        {
                            case 1:
                                sText = "brooch " + sText;
                                break;
                            case 2:
                                sText = "sword " + sText;
                                break;
                            default:
                                sText = "cigarette " + sText;
                                break;
                        }
                        break;
                    case 3:
                        sText = _text3[nVersion - 1];
                        nCount2 = rnd1.Next(1, 4);
                        nVersion2 = rnd1.Next(1, 4);
                        switch (nVersion2)
                        {
                            case 1:
                                sText = Convert.ToString(nCount2) + " swans " + sText;
                                break;
                            case 2:
                                sText = Convert.ToString(nCount2) + " geese " + sText;
                                break;
                            default:
                                sText = Convert.ToString(nCount2) + " tiger " + sText;
                                break;
                        }
                        break;
                    case 4:
                        sText = _text4[nVersion - 1];
                        sLetter1 = (char)(rnd1.Next(1, 27) + 64);
                        sLetter2 = (char)(rnd1.Next(1, 27) + 64);
                        sText = Convert.ToString(sLetter1) + Convert.ToString(sLetter2) + " " + sText;
                        break;
                    default:
                        sText = _text5[nVersion - 1];
                        break;

                }
                _item[i - 1] = sText;
            }

            fBut();
            fCheck();

            for (int i = 1; i <= 16; i++)
            {
                _time[i - 1] = rnd1.Next(1, 5);
            }
            _length[0] = rnd1.Next(1, 201);
            nHalf=_length[0]/2;
            nAdd = rnd1.Next(1, nHalf + 1);
            _length[1] = _length[0] + nAdd;
            _width[0] = rnd1.Next(1, 201);
            nHalf = _width[0] / 2;
            nAdd = rnd1.Next(1, nHalf + 1);
            _width[1] = _width[0] + nAdd;
            _height[0] = rnd1.Next(1, 201);
            nHalf = _height[0] / 2;
            nAdd = rnd1.Next(1, nHalf + 1);
            _height[1] = _height[0] + nAdd;

            fUpdateDisplay();

            mnItem = rnd1.Next(1, 5);
            fSelect();
        }

        private void fBut()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= mnCount; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _but[i - 1] = true;

                }
                else
                {
                    _but[i - 1] = false;
                }
            }
        }
        private void fCheck()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= mnCount; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _check[i - 1] = true;

                }
                else
                {
                    _check[i - 1] = false;
                }
            }
        }
        private void fUpdateDisplay()
        {
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);

            }

            for (int i = 1; i <= mnCount; i++)
            {
                sText = _item[i - 1];
                if (_but[i - 1])
                {
                    sText = "[BUT]" + sText;
                }
                if (_check[i - 1])
                {
                    sText = "[CHECK]" + sText;
                }
                lst1.Items.Add(sText);
            }
            lst1.Sorted = true;
            lst1.Sorted = false;

            lblTime1.Text = "T" + Convert.ToString(_time[0]);
            lblTime2.Text = "T" + Convert.ToString(_time[1]);
            lblTime3.Text = "T" + Convert.ToString(_time[2]);
            lblTime4.Text = "T" + Convert.ToString(_time[3]);
            lblTime5.Text = "T" + Convert.ToString(_time[4]);
            lblTime6.Text = "T" + Convert.ToString(_time[5]);
            lblTime7.Text = "T" + Convert.ToString(_time[6]);
            lblTime8.Text = "T" + Convert.ToString(_time[7]);
            lblTime9.Text = "T" + Convert.ToString(_time[8]);
            lblTime10.Text = "T" + Convert.ToString(_time[9]);
            lblTime11.Text = "T" + Convert.ToString(_time[10]);
            lblTime12.Text = "T" + Convert.ToString(_time[11]);
            lblTime13.Text = "T" + Convert.ToString(_time[12]);
            lblTime14.Text = "T" + Convert.ToString(_time[13]);
            lblTime15.Text = "T" + Convert.ToString(_time[14]);
            lblTime16.Text = "T" + Convert.ToString(_time[15]);

            lblLength1.Text = Convert.ToString(_length[0]);
            lblLength2.Text ="extendsto="+ Convert.ToString(_length[0]);
            lblWidth1.Text = Convert.ToString(_width[0]);
            lblWidth2.Text = "extendsto=" + Convert.ToString(_width[0]);
            lblHeight1.Text = Convert.ToString(_height[0]);
            lblHeight2.Text = "extendsto=" + Convert.ToString(_height[0]);

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

        private void btnBut_Click(object sender, EventArgs e)
        {
            fBut();
            fUpdateDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mnFake += 1;
            fReset();
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            mnReal += 1;
            fReset();

        }

   

        private void pic1_Click_1(object sender, EventArgs e)
        {
            mnItem = 1;
            fSelect();


        }

        private void pic2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fSelect();

        }

        private void pic3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fSelect();

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            mnItem = 4;
            fSelect();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            fCheck();
            fUpdateDisplay();
        }
    }
}
