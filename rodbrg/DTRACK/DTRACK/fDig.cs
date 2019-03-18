using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTRACK
{
    public partial class fDig : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private int mnCol, mnRow, mnRotate;
        private int nNumber;
        public bool mbCatch = false;

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo;
            int nPos2 = rnd1.Next(1, 4);
            int nPos;
              int nCol=0, nRow = 0;
            int nBlocks = rnd1.Next(2, 9);

            msShuffle = "0102030405060708091011121314151617181920212223242526272829303132";
            msShuffle2 = null;

            for (int i = 1; i <= 16; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {

                    sTwo = "01";
                }
                else
                {
                    sTwo = "02";

                }
                msShuffle2 = msShuffle2 + sTwo;
              }

            fFree(ref nCol, ref nRow);
            nPos = (nCol - 1) * 4 + nRow;
            sTwo = "03";
            fPlace(sTwo, nPos);
            for (int i = 1; i <= nBlocks; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 4 + nRow;
                sTwo = "04";
                fPlace(sTwo, nPos);
            }
          
            fFree(ref nCol, ref nRow);
            mnCol = nCol;
            mnRow = nRow;
            mnRotate = rnd1.Next(1, 5);

            fUpdateDisplay();
        }

        private void fUpdatePlayers()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = mnRotate;

            nType = 5;
            switch (mnCol)
            {
                case 1:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic11.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic12.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic13.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic14.Image = _pic.Image;
                            break;
                              }
                    break;
                case 2:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic21.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic22.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic23.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic24.Image = _pic.Image;
                            break;
                                }
                    break;
                case 3:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic31.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic32.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic33.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic34.Image = _pic.Image;
                            break;
               }
                    break;
                case 4:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic41.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic42.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic43.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic44.Image = _pic.Image;
                            break;
                    }
                    break;
            }
        }

        private void fNav(int nMode)
        {
            Random rnd1 = new Random();
            int nType;
            int nCol=mnCol, nRow=mnRow;

            switch (nMode)
            {
                case 1:
                    nRow -= 1;
                    break;
                case 2:
                    nCol += 1;
                    nRow -= 1;
                    break;
                case 3:
                    nCol += 1;
                    break;
                case 4:
                    nCol += 1;
                    nRow += 1;
                    break;
                case 5:
                    nRow += 1;
                    break;
                case 6:
                    nCol -= 1;
                    nRow += 1;
                    break;
                case 7:
                    nCol -= 1;
                    break;
                default:
                    nCol -= 1;
                    nRow -= 1;
                    break;
            }
            if (nCol == 0)
            {
                nCol = 4;
            }
            if (nCol == 5)
            {
                nCol = 1;
            }
            if (nRow == 0)
            {
                nRow = 4;
            }
            if (nRow == 5)
            {
                nRow = 1;
            }
        
            nType = Convert.ToInt32(fData(nCol, nRow));
            if (nType == 3)
            {
                this.Close();
            }
            else
            {
                if (nType == 4)
                {

                }
                else
                {
                    mnCol = nCol;
                    mnRow = nRow;
                    mnRotate = rnd1.Next(1, 5);
                    fUpdateDisplay();
                }
            }
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
       
            //2
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
        
            //3
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
       
            //4
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
         
            
            fUpdatePlayers();
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F back1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F back2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F diamond.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F woodblock.png"),
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

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;
            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));

            return nType;
        }

        private void fPlace(String sText, int nPos)
        {
            if (nPos == 16)
            {
                msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText;

            }
            else
            {
                msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (16 - nPos) * 2);

            }
        }

        private void fFree(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            String sData;
            int nValue;

            do
            {
                nCol = rnd1.Next(1, 5);
                nRow = rnd1.Next(1, 5);
                sData = fData(nCol, nRow);
                nValue = Convert.ToInt32(sData);
                if (nValue <= 2)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }

        private String fData(int nCol, int nRow)
        {
            int nPos = (nCol - 1) * 4 + nRow;
            String sTwo = msShuffle2.Substring(nPos * 2 - 2, 2);

            return sTwo;
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            fNav(3);
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            fNav(4);
        }

        private void btnNav5_Click(object sender, EventArgs e)
        {
            fNav(5);
        }

        private void btnNav6_Click(object sender, EventArgs e)
        {
            fNav(6);
        }

        private void btnNav7_Click(object sender, EventArgs e)
        {
            fNav(7);

        }

        private void btnNav8_Click(object sender, EventArgs e)
        {
            fNav(8);
        }

        public fDig()
        {
            InitializeComponent();
        }

        private void fDig_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
