using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAZERN
{
    public partial class Form1 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private String msRotate;
        private int mnItem = 1;
        private int mnCol, mnRow,mnRotate;
        private bool mbShow;

        private void fClick(int nCol, int nRow)
        {
            Random rnd1 = new Random();
            String sTwo;
            int nPos;

            if (mbShow)
            {


                mnCol = nCol;
                mnRow = nRow;
                mnRotate = rnd1.Next(1, 5);
                mbShow = true;

                fUpdateDisplay();
            }
            else
            {
                mnCol = nCol;
                mnRow = nRow;
                nPos = (nCol - 1) * 8 + nRow;
                sTwo = Convert.ToString(mnItem);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
                fPlace(sTwo, nPos);
                fUpdateDisplay();
            }
        }

        private bool fClear(int nCol, int nRow)
        {
            int nPos = (nCol - 1) * 8 + nRow;
            int nType = fHoletype(msShuffle2, nPos);

            if (nType == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private String fPossibles(int nCol, int nRow)
        {
            int nNextcol = nCol + 1;
            int nNextrow = nRow + 1;
            bool bAcross = false;
            bool bDown = false;
            bool bClear = false;
            String sText = null;

            if (nNextcol == 9)
            {
                bAcross = false;
            }
            else
            {
                bClear = fClear(nNextcol, nRow);
                bAcross = bClear;
            }

            if (bAcross)
            {
                sText = sText + "1A";
            }

            if (nNextrow == 9)
            {
                bDown = false;
            }
            else
            {
                bClear = fClear(nCol, nNextrow);
                bDown = bClear;
            }

            if (bDown)
            {
                sText = sText + "1D";
            }

            sText = sText + "2R";
            return sText;
        }

        private String fTwo(int nMode)
        {
            Random rnd1 = new Random();
            int nValue;
            String sTwo;

            if (nMode == 1)
            {
                nValue = rnd1.Next(3, 6);
            }
            else
            {
                nValue = rnd1.Next(6, 9);
            }

            sTwo = "0" + Convert.ToString(nValue);
            return sTwo;
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;
            String sTwo = null;
            int nPos = 0;
            int nType;
            String sPossibles, sUse;
            int nLength;
            int nPos2;
            String sSave;

            msShuffle = "01020304050607080910111213141516171819202122232425262728293021323334353637383940414243444546474849505152535455565758596061626364";
            msShuffle2 = null;
            mbShow = false;


            for (int i = 1; i <= 64; i++)
            {
                sTwo = "01";
                msShuffle2 = msShuffle2 + sTwo;
                msRotate = msRotate + sTwo;
            }

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nPos = (i - 1) * 8 + j;
                    nType = fHoletype(msShuffle2, nPos);
                    if (nType == 1)
                    {
                        sPossibles = fPossibles(i, j);
                        nLength = sPossibles.Length / 2;
                        nPos2 = rnd1.Next(1, nLength + 1);
                        sUse = sPossibles.Substring((nPos2 - 1) * 2, 2);
                        switch (sUse)
                        {
                            case "1A":
                                nPos = (i - 1) * 8 + j;
                                sTwo = fTwo(1);
                                sSave = sTwo;
                                fPlace(sTwo, nPos);
                                sTwo = "02";
                                fPlace2(sTwo, nPos);
                                nPos = (i) * 8 + j;
                                sTwo = sSave;
                                fPlace(sTwo, nPos);
                                sTwo = "04";
                                fPlace2(sTwo, nPos);
                                break;
                            case "1D":
                                nPos = (i - 1) * 8 + j;
                                sTwo = fTwo(1);
                                sSave = sTwo;
                                fPlace(sTwo, nPos);
                                sTwo = "03";
                                fPlace2(sTwo, nPos);
                                nPos = (i - 1) * 8 + j + 1;
                                sTwo = sSave;
                                fPlace(sTwo, nPos);
                                sTwo = "01";
                                fPlace2(sTwo, nPos);
                                break;
                            default:
                                nPos = (i - 1) * 8 + j;
                                sTwo = fTwo(2);
                                fPlace(sTwo, nPos);
                                nValue = rnd1.Next(1, 5);
                                sTwo = "0" + Convert.ToString(nValue);
                                fPlace2(sTwo, nPos);
                                break;
                        }
                    }
                }
            }

            fUpdateDisplay();

        }
        private void fPlace(String sText, int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (64 - nPos) * 2);
        }
        private void fPlace2(String sText, int nPos)
        {
            msRotate = msRotate.Substring(0, nPos * 2 - 2) + sText + msRotate.Substring(nPos * 2, (64 - nPos) * 2);
        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }

        private int fHoletype2(String sShuffle, int nSquare, ref int nRotate)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            nRotate = Convert.ToInt32(msRotate.Substring(nSquare * 2 - 2, 2));

            return nType;
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F corridor.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F arrow.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Type1A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Type1B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Type1C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Type2A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Type2B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F Type2C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F Type3A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F Type3B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F Type3C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F Type4A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F Type4B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F Type4C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F Type5A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F Type5B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F Type5C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F Type6A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F Type6B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Type6C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
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
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                case 16:
                    _pic2 = picture16;
                    break;
                case 17:
                    _pic2 = picture17;
                    break;
                case 18:
                    _pic2 = picture18;
                    break;
                case 19:
                    _pic2 = picture19;
                    break;
                case 20:
                    _pic2 = picture20;
                    break;
                default:
                    _pic2 = picture21;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }


        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype2(msShuffle2, 1, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 2, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 3, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 4, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 5, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 6, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 7, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 8, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            //2
            nType = fHoletype2(msShuffle2, 9, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 10, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 11, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 12, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 13, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 14, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 15, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 16, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = fHoletype2(msShuffle2, 17, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 18, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 19, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 20, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 21, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 22, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 23, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 24, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = fHoletype2(msShuffle2, 25, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 26, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 27, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 28, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 29, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 30, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 31, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 32, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = fHoletype2(msShuffle2, 33, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 34, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 35, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 36, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 37, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 38, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 39, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 40, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            //6
            nType = fHoletype2(msShuffle2, 41, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 42, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 43, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 44, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 45, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 46, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 47, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 48, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            //7
            nType = fHoletype2(msShuffle2, 49, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 50, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 51, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 52, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 53, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 54, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 55, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 56, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            //8
            nType = fHoletype2(msShuffle2, 57, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 58, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 59, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 60, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 61, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 62, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 63, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = fHoletype2(msShuffle2, 64, ref nRotate);
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

            if (mbShow)
            {
                fIcon();
                fUpdateStatus();
            }
        }

        private void fUpdateStatus()
        {
            String sCoord = Convert.ToString(mnCol) + Convert.ToString(mnRow);
            String sText = "typeof(" + sCoord + ") = ";
            int nPos = (mnCol - 1) * 8 + mnRow;
            int nRotate = 0, nRotateSave;
            int nType = fHoletype2(msShuffle2, nPos,ref nRotate);
            int nCol = mnCol;
            int nRow = mnRow;
            String sType,sType2,sText3;
            

            switch (nType)
            {
                case 3:
                    sType = "EdgeNorth";
                    break;
                case 4:
                    sType = "EdgeNorth";
                    break;
                case 5:
                    sType = "EdgeNorth";
                    break;
                case 6:
                    sType = "SQUARE";
                    break;
                case 7:
                    sType = "SQUARE";
                    break;
                case 8:
                    sType = "SQUARE";
                    break;
                case 9:
                    sType = "CORRIDOREdge";
                    break;
                case 10:
                    sType = "CORRIDOREdge";
                    break;
                default:
                    sType = "CORRIDOREdge";
                    break;
            }
            if (sType == "EdgeNorth")
            {
                 switch (nRotate)
                {
                    case 1:
                        switch (mnRotate)
                        {
                            case 1:
                                break;
                            case 3:
                                break;
                            default:
                                sType = "EdgeTurn";
                                break;
                        }
                        break;
                    case 3:
                        switch (mnRotate)
                        {
                            case 1:
                                break;
                            case 3:
                                break;
                            default:
                                sType = "EdgeTurn";
                                break;
                        }
                         break;
                    default:
                        switch (mnRotate)
                        {
                            case 2:
                                break;
                            case 4:
                                break;
                            default:
                                sType = "EdgeTurn";
                                break;
                        }
                         break;
                }
            }
            if (sType == "CORRIDOREdge")
            {
                switch (nRotate)
                {
                    case 1:
                        switch (mnRotate)
                        {
                            case 2:
                                break;
                            case 4:
                                break;
                            default:
                                sType = "CORRIDORInside";
                                break;
                        }
                        break;
                    case 3:
                        switch (mnRotate)
                        {
                            case 2:
                                break;
                            case 4:
                                break;
                            default:
                                sType = "CORRIDORInside";
                                break;
                        }
                        break;
                    default:
                        switch (mnRotate)
                        {
                            case 1:
                                break;
                            case 3:
                                break;
                            default:
                                sType = "CORRIDORInside";
                                break;
                        }
                        break;
                }
            }
            sText = sText + sType;

            lbl1.Text = sText;

            nRotateSave = nRotate;
            fNext(mnRotate, ref nCol, ref nRow);
            sCoord = Convert.ToString(nCol) + Convert.ToString(nRow);
            sText = "typeof(" + sCoord + ") = ";
            nPos = (nCol - 1) * 8 + nRow;
            nType = fHoletype2(msShuffle2, nPos, ref nRotate);


            switch (nType)
            {
                case 3:
                    sType2 = "EdgeNorth";
                    break;
                case 4:
                    sType2 = "EdgeNorth";
                    break;
                case 5:
                    sType2 = "EdgeNorth";
                    break;
                case 6:
                    sType2 = "SQUARE";
                    break;
                case 7:
                    sType2 = "SQUARE";
                    break;
                case 8:
                    sType2 = "SQUARE";
                    break;
                case 9:
                    sType2 = "CORRIDOREdge";
                    break;
                case 10:
                    sType2 = "CORRIDOREdge";
                    break;
                default:
                    sType2 = "CORRIDOREdge";
                    break;
            }
            
            if (sType2 == "EdgeNorth")
            {
                switch (nRotate)
                {
                    case 1:
                        switch (mnRotate)
                        {
                            case 1:
                                break;
                            case 3:
                                break;
                            default:
                                sType2 = "EdgeTurn";
                                break;
                        }
                        break;
                    case 3:
                        switch (mnRotate)
                        {
                            case 1:
                                break;
                            case 3:
                                break;
                            default:
                                sType2 = "EdgeTurn";
                                break;
                        }
                        break;
                    default:
                        switch (mnRotate)
                        {
                            case 2:
                                break;
                            case 4:
                                break;
                            default:
                                sType2 = "EdgeTurn";
                                break;
                        }
                        break;
                }
            }
            if (sType2 == "CORRIDOREdge")
            {
                switch (nRotate)
                {
                    case 1:
                        switch (mnRotate)
                        {
                            case 2:
                                break;
                            case 4:
                                break;
                            default:
                                sType2 = "CORRIDORInside";
                                break;
                        }
                        break;
                    case 3:
                        switch (mnRotate)
                        {
                            case 2:
                                break;
                            case 4:
                                break;
                            default:
                                sType2 = "CORRIDORInside";
                                break;
                        }
                        break;
                    default:
                        switch (mnRotate)
                        {
                            case 1:
                                break;
                            case 3:
                                break;
                            default:
                                sType2 = "CORRIDORInside";
                                break;
                        }
                        break;
                }
            }
            sText = sText + sType2;
            lbl2.Text = sText;

            sText3 = fFix(sType, sType2);
            lbl3.Text = "fix = " + sText3;
            
            
        }

        private String fFix(String sText1,String sText2)
        {
            String sText3=null;

            if (sText1 == "SQUARE")
            {
                if (sText2 == "SQUARE")
                {
                    sText3 = "TWOFold";
                }
                else if(sText2 == "EdgeNorth")
                {
                    sText3 = "EdgeNorth+CORR";
                }
                else if (sText2 == "EdgeTurn")
                {
                    sText3 = "EdgeNorth+LP";
                }
                else if (sText2 == "CORRIDOREdge")
                {
                    sText3 = "EdgeNorth+TP";
                }
                else
                {
                    sText3 = "NONE";
                }
            }
            else if (sText1 == "EdgeNorth")
            {
                if (sText2 == "SQUARE")
                {
                    sText3 = "CORR+EdgeNorth";
                }
                else if (sText2 == "EdgeNorth")
                {
                    sText3 = "CORR2";
                }
                else if (sText2 == "EdgeTurn")
                {
                    sText3 = "CORR+LP";
                }
                else if (sText2 == "CORRIDOREdge")
                {
                    sText3 = "CORR+TP";
                }
                else
                {
                    sText3 = "NONE";
                }
            }
            else if (sText1 == "EdgeTurn")
            {
                if (sText2 == "SQUARE")
                {
                    sText3 = "LP+EdgeNorth";
                }
                else if (sText2 == "EdgeNorth")
                {
                    sText3 = "LP+CORR";
                }
                else if (sText2 == "EdgeTurn")
                {
                    sText3 = "LP2";
                }
                else if (sText2 == "CORRIDOREdge")
                {
                    sText3 = "LP+TP";
                }
                else
                {
                    sText3 = "NONE";
                }
            }
            else if (sText1 == "CORRIDOREdge")
            {
                if (sText2 == "SQUARE")
                {
                    sText3 = "TP+EdgeNorth";
                }
                else if (sText2 == "EdgeNorth")
                {
                    sText3 = "TP+CORR";
                }
                else if (sText2 == "EdgeTurn")
                {
                    sText3 = "TP+LP";
                }
                else if (sText2 == "CORRIDOREdge")
                {
                    sText3 = "TP2";
                }
                else
                {
                    sText3 = "NONE";
                }
            }
            else
            {
                sText3 = "NONE";
            }

            return sText3;
        }

        private void fNext(int nRotate,ref int nCol,ref int nRow)
        {
            switch (nRotate)
            {
                case 1:
                    nRow -= 1;
                    if (nRow == 0)
                    {
                        nRow = 8;
                    }
                    break;
                case 2:
                    nCol += 1;
                    if (nCol == 9)
                    {
                        nCol = 1;
                    }
                    break;
                case 3:
                    nRow += 1;
                    if (nRow == 9)
                    {
                        nRow = 1;
                    }
                    break;
                default:
                    nCol -= 1;
                    if (nCol == 0)
                    {
                        nCol = 8;
                    }
                    break;
            }
        }


        private void fIcon()
        {
            PictureBox _pic = new PictureBox();
            int nType = 2;
            int nRotate = mnRotate;

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
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic15.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic16.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic17.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic18.Image = _pic.Image;
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
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic25.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic26.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic27.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic28.Image = _pic.Image;
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
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic35.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic36.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic37.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic38.Image = _pic.Image;
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
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic45.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic46.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic47.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic48.Image = _pic.Image;
                            break;
                    }
                    break;
                case 5:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic51.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic52.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic53.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic54.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic55.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic56.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic57.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic58.Image = _pic.Image;
                            break;
                    }
                    break;
                case 6:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic61.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic62.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic63.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic64.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic65.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic66.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic67.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic68.Image = _pic.Image;
                            break;
                    }
                    break;
                case 7:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic71.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic72.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic73.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic74.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic75.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic76.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic77.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic78.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
                    switch (mnRow)
                    {
                        case 1:
                            fPeek(nType, nRotate, ref _pic);
                            pic81.Image = _pic.Image;
                            break;
                        case 2:
                            fPeek(nType, nRotate, ref _pic);
                            pic82.Image = _pic.Image;
                            break;
                        case 3:
                            fPeek(nType, nRotate, ref _pic);
                            pic83.Image = _pic.Image;
                            break;
                        case 4:
                            fPeek(nType, nRotate, ref _pic);
                            pic84.Image = _pic.Image;
                            break;
                        case 5:
                            fPeek(nType, nRotate, ref _pic);
                            pic85.Image = _pic.Image;
                            break;
                        case 6:
                            fPeek(nType, nRotate, ref _pic);
                            pic86.Image = _pic.Image;
                            break;
                        case 7:
                            fPeek(nType, nRotate, ref _pic);
                            pic87.Image = _pic.Image;
                            break;
                        default:
                            fPeek(nType, nRotate, ref _pic);
                            pic88.Image = _pic.Image;
                            break;
                    }
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

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            mnItem = 1;
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            fClick(1, 1);
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            fClick(1, 2);
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            fClick(1, 3);
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            fClick(1, 4);
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            fClick(1, 5);
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            fClick(1, 6);
        }

        private void pic17_Click(object sender, EventArgs e)
        {
            fClick(1, 7);
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            fClick(1, 8);
        }

        private void pic21_Click(object sender, EventArgs e)
        {
            fClick(2, 1);
        }

        private void pic22_Click(object sender, EventArgs e)
        {
            fClick(2, 2);
        }

        private void pic23_Click(object sender, EventArgs e)
        {
        
            fClick(2, 3);
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            fClick(2, 4);
        }

        private void pic25_Click(object sender, EventArgs e)
        {
            fClick(2, 5);
        }

        private void pic26_Click(object sender, EventArgs e)
        {
            fClick(2, 6);
        }

        private void pic27_Click(object sender, EventArgs e)
        {
            fClick(2, 7);
        }

        private void pic28_Click(object sender, EventArgs e)
        {
            fClick(2, 8);
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            fClick(3, 1);
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            fClick(3, 2);
        }

        private void pic33_Click(object sender, EventArgs e)
        {
            fClick(3, 3);
        }

        private void pic34_Click(object sender, EventArgs e)
        {
            fClick(3, 4);
        }

        private void pic35_Click(object sender, EventArgs e)
        {
            fClick(3, 5);
        }

        private void pic36_Click(object sender, EventArgs e)
        {
            fClick(3, 6);
        }

        private void pic37_Click(object sender, EventArgs e)
        { 
            fClick(3, 7);
        }

        private void pic38_Click(object sender, EventArgs e)
        {
            fClick(3, 8);
        }

        private void pic41_Click(object sender, EventArgs e)
        {
            fClick(4, 1);
        }

        private void pic42_Click(object sender, EventArgs e)
        {
            fClick(4, 2);
        }

        private void pic43_Click(object sender, EventArgs e)
        {
            fClick(4, 3);
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            fClick(4, 4);
        }

        private void pic45_Click(object sender, EventArgs e)
        {
            fClick(4, 5);
        }

        private void pic46_Click(object sender, EventArgs e)
        {
            fClick(4, 6);
        }

        private void pic47_Click(object sender, EventArgs e)
        {
            fClick(4, 7);
        }

        private void pic48_Click(object sender, EventArgs e)
        {
            fClick(4, 8);
        }

        private void pic51_Click(object sender, EventArgs e)
        {
            fClick(5, 1);
        }

        private void pic52_Click(object sender, EventArgs e)
        {
            fClick(5, 2);
        }

        private void pic53_Click(object sender, EventArgs e)
        {
            fClick(5, 3);
        }

        private void pic54_Click(object sender, EventArgs e)
        {
            fClick(5, 4);
        }

        private void pic55_Click(object sender, EventArgs e)
        {
            fClick(5, 5);
        }

        private void pic56_Click(object sender, EventArgs e)
        {
            fClick(5, 6);
        }

        private void pic57_Click(object sender, EventArgs e)
        {
            fClick(5, 7);
        }

        private void pic58_Click(object sender, EventArgs e)
        {
            fClick(5, 8);
        }

        private void pic61_Click(object sender, EventArgs e)
        {
            fClick(6, 1);
        }

        private void pic62_Click(object sender, EventArgs e)
        {
            fClick(6, 2);
        }

        private void pic63_Click(object sender, EventArgs e)
        {
            fClick(6, 3);
        }

        private void pic64_Click(object sender, EventArgs e)
        {
            fClick(6, 4);
        }

        private void pic65_Click(object sender, EventArgs e)
        {
            fClick(6, 5);
        }

        private void pic66_Click(object sender, EventArgs e)
        {
            fClick(6, 6);
        }

        private void pic67_Click(object sender, EventArgs e)
        {
            fClick(6, 7);
        }

        private void pic68_Click(object sender, EventArgs e)
        {
            fClick(6, 8);
        }

        private void pic71_Click(object sender, EventArgs e)
        {
            fClick(7, 1);
        }

        private void pic72_Click(object sender, EventArgs e)
        {
            fClick(7, 2);
        }

        private void pic73_Click(object sender, EventArgs e)
        {
            fClick(7, 3);
        }

        private void pic74_Click(object sender, EventArgs e)
        {
            fClick(7, 4);
        }

        private void pic75_Click(object sender, EventArgs e)
        {
            fClick(7, 5);
        }

        private void pic76_Click(object sender, EventArgs e)
        {
            fClick(7, 6);
        }

        private void pic77_Click(object sender, EventArgs e)
        {
            fClick(7, 7);
        }

        private void pic78_Click(object sender, EventArgs e)
        {
            fClick(7, 8);
        }

        private void pic81_Click(object sender, EventArgs e)
        {
            fClick(8, 1);
        }

        private void pic82_Click(object sender, EventArgs e)
        {
            fClick(8, 2);
        }

        private void pic83_Click(object sender, EventArgs e)
        {
            fClick(8, 3);
        }

        private void pic84_Click(object sender, EventArgs e)
        {
            fClick(8, 4);
        }

        private void pic85_Click(object sender, EventArgs e)
        {
            fClick(8, 5);
        }

        private void pic86_Click(object sender, EventArgs e)
        {
            fClick(8, 6);
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            int nType, nRotate=0;
            int nPos=(mnCol-1)*8+mnRow;
            String sTwo;

            if (mbShow)
            {
                mnRotate++;
                if (mnRotate == 5)
                {
                    mnRotate = 1;
                }
                fIcon();
                fUpdateStatus();
            }
            else
            {
                nType = fHoletype2(msShuffle2, nPos, ref nRotate);
                nRotate++;
                if (nRotate == 5)
                {
                    nRotate = 1;
                }
                sTwo = "0" + Convert.ToString(nRotate);
                fPlace2(sTwo, nPos);
                fUpdateDisplay();
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (mbShow)
            {
                mbShow = false;
                btnSelect.Text = "select = OFF";
            }
            else
            {
                mbShow = true;
                btnSelect.Text = "select = ON";
            }
            fUpdateDisplay();
        }

        private void PicAdd12_Click(object sender, EventArgs e)
        {
            mnItem = 12;

        }

        private void PicAdd13_Click(object sender, EventArgs e)
        {
            mnItem = 13;

        }

        private void PicAdd14_Click(object sender, EventArgs e)
        {
            mnItem = 14;

        }

        private void PicAdd15_Click(object sender, EventArgs e)
        {
            mnItem = 15;

        }

        private void PicAdd16_Click(object sender, EventArgs e)
        {
            mnItem = 16;

        }

        private void PicAdd17_Click(object sender, EventArgs e)
        {
            mnItem = 17;

        }

        private void PicAdd18_Click(object sender, EventArgs e)
        {
            mnItem = 18;

        }

        private void PicAdd19_Click(object sender, EventArgs e)
        {
            mnItem = 19;

        }

        private void PicAdd20_Click(object sender, EventArgs e)
        {
            mnItem = 20;

        }

        private void PicAdd3_Click(object sender, EventArgs e)
        {
            mnItem = 3;

        }

        private void PicAdd4_Click(object sender, EventArgs e)
        {
            mnItem = 4;

        }

        private void PicAdd5_Click(object sender, EventArgs e)
        {
            mnItem = 5;

        }

        private void PicAdd9_Click(object sender, EventArgs e)
        {
            mnItem = 9;

        }

        private void PicAdd10_Click(object sender, EventArgs e)
        {
            mnItem = 10;

        }

        private void PicAdd11_Click(object sender, EventArgs e)
        {
            mnItem = 11;

        }

        private void pic87_Click(object sender, EventArgs e)
        {
            fClick(8, 7);
        }

        private void pic88_Click(object sender, EventArgs e)
        {
            fClick(8, 8);
        }
    }
}