using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALOOS
{
    public partial class fSub3 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private List<int> _numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo;
            int nValue;

            msShuffle = "01020304050607080910111213141516";
            msShuffle2 = null;

            for (int i = 1; i <= 16; i++)
            {
                nValue = rnd1.Next(1, 5);
                sTwo = Convert.ToString(nValue);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
                msShuffle2 = msShuffle2 + sTwo;
            }

            for (int i = 1; i <= 9; i++)
            {
                _numbers[i - 1] = 0;
            }

            fUpdateData();
            fUpdateDisplay();
        }

        private void fClick(int nMode, int nValue)
        {
            _numbers[nMode - 1] = nValue;
            fUpdateData();

        }
        private void fUpdateData()
        {
            lbl1.Text = Convert.ToString(_numbers[0]);
            lbl2.Text = Convert.ToString(_numbers[1]);
            lbl3.Text = Convert.ToString(_numbers[2]);
            lbl4.Text = Convert.ToString(_numbers[3]);
            lbl5.Text = Convert.ToString(_numbers[4]);
            lbl6.Text = Convert.ToString(_numbers[5]);
            lbl7.Text = Convert.ToString(_numbers[6]);
            lbl8.Text = Convert.ToString(_numbers[7]);
            lbl9.Text = Convert.ToString(_numbers[8]);

        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

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
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic5.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic6.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic7.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic8.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic9.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic10.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;
            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));

            return nType;
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F cloudvision.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F devilface.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F paddyfield.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F robot.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
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
                default:
                    _pic2 = picture6;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            fClick(1, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            fClick(2, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            fClick(3, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            fClick(4, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            fClick(5, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            fClick(6, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            fClick(7, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            fClick(8, Convert.ToInt32(txtPoints.Text));
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            fClick(9, Convert.ToInt32(txtPoints.Text));
        }
    }
}
