using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPOKER
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int mnCol, mnRow;
        private int nNumber;
        private int mnWin = 0;
        private bool mbMovelog;
        private int mnLogType;

        private bool bFullAcross(int nCol,int nRow)
        {
            bool bFound=false;
            int nPos, nType;

            for (int i = 1; i <= 8; i++)
            {
                nPos = (i - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                if (nType <= 2)
                {
                    bFound = true;
                }
            }

            return !bFound;
        }
        private bool bFullDown(int nCol, int nRow)
        {
            bool bFound = false;
            int nPos, nType;

            for (int i = 1; i <= 8; i++)
            {
                nPos = (nCol - 1) * 8 + i;
                nType = fHoletype(msShuffle2, nPos);
                if (nType <= 2)
                {
                    bFound = true;
                }
            }

            return !bFound;
        }

        private void fNext(bool bAcross,ref int nCol,ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFull;
            int nPos,nType;
            bool bFound=false;

            nNumber = rnd1.Next(1, 10);

            if (bAcross)
            {
                bFull = bFullAcross(nCol, nRow);
                if (bFull)
                {
                    do
                    {
                        nCol = rnd1.Next(1, 9);
                        nPos = (nCol - 1) * 8 + nRow;
                        nType = fHoletype(msShuffle1, nPos);
                        switch (nType)
                        {
                            case 11:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                            case 8:
                                break;
                            default:
                                bFound = true;
                                break;
                        }
                    } while (bFound == false);
                }
                else
                {
                    if (nNumber <= 5)
                    {
                        for (int i = 1; i <= 7; i++)
                        {
                            nCol += 1;
                            if (nCol == 9)
                            {
                                nCol = 1;
                            }
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle1, nPos);
                            switch (nType)
                            {
                                case 1:
                                    bFound = true;
                                    break;
                                case 2:
                                    bFound = true;
                                    break;
                                default:
                                    break;
                            }
                            if (bFound)
                            {
                                i = 7;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= 7; i++)
                        {
                            nCol -= 1;
                            if (nCol == 0)
                            {
                                nCol = 8;
                            }
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle1, nPos);
                            switch (nType)
                            {
                                case 1:
                                    bFound = true;
                                    break;
                                case 2:
                                    bFound = true;
                                    break;
                                default:
                                    break;
                            }
                            if (bFound)
                            {
                                i = 7;
                            }

                        }
                    }
                }
            }

            else
            {
                bFull = bFullDown(nCol, nRow);
                if (bFull)
                {
                    do
                    {
                        nRow = rnd1.Next(1, 9);
                        nPos = (nCol - 1) * 8 + nRow;
                        nType = fHoletype(msShuffle1, nPos);
                        switch (nType)
                        {
                            case 11:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                            case 8:
                                break;
                            default:
                                bFound = true;
                                break;
                        }
                    } while (bFound == false);
                }
                else
                {
                    if (nNumber <= 5)
                    {
                        for (int i = 1; i <= 7; i++)
                        {
                            nRow += 1;
                            if (nRow == 9)
                            {
                                nRow = 1;
                            }
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle1, nPos);
                            switch (nType)
                            {
                                case 1:
                                    bFound = true;
                                    break;
                                case 2:
                                    bFound = true;
                                    break;
                                default:
                                    break;
                            }
                            if (bFound)
                            {
                                i = 7;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= 7; i++)
                        {
                            nRow -= 1;
                            if (nRow == 0)
                            {
                                nRow = 8;
                            }
                            nPos = (nCol - 1) * 8 + nRow;
                            nType = fHoletype(msShuffle1, nPos);
                            switch (nType)
                            {
                                case 1:
                                    bFound = true;
                                    break;
                                case 2:
                                    bFound = true;
                                    break;
                                default:
                                    break;
                            }
                            if (bFound)
                            {
                                i = 7;
                            }

                        }
                    }

                }
            } 
        }
        private void fAccess()
        {
            Random rnd1 = new Random();
            int nType;
            int nLength = rnd1.Next(4, 11);
            int nCol = mnCol;
            int nRow = mnRow;
            bool bAcross = false;
            String sTwo;
            int nPos;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                nType = 3;
            }
            else
            {
                nType = 4;
            }
            sTwo = "0" + Convert.ToString(nType);

            for (int i = 1; i <= nLength; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    bAcross = true;
                }
                else
                {
                    bAcross = false;
                }
                fNext(bAcross, ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                fPlace(sTwo, nPos);
            }
            fUpdateDisplay();
        }

        private void fWin()
        {
            mnWin += 1;
            MessageBox.Show("You win", "Win" + Convert.ToString(mnWin));
        }


        private void fNav(int nMode)
        {
            int nCol = mnCol;
            int nRow = mnRow;
            int nPos, nType;
            String sTwo;

            switch (nMode)
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
                        nRow = 8;
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

            nPos = (nCol - 1) * 8 + nRow;
            nType = fHoletype(msShuffle2, nPos);

            if (mbMovelog)
            {
                switch (nType)
                {
                    case 3:
                        sTwo = "0"+Convert.ToString(mnLogType);
                        fPlace(sTwo, nPos);
                        sTwo = "01";
                        nPos = (mnCol - 1) + 8 + mnRow;
                        fPlace(sTwo, nPos);
                        fUpdateDisplay();
                        break;
                    case 4:
                        sTwo = "0" + Convert.ToString(mnLogType);
                        fPlace(sTwo, nPos);
                        sTwo = "01";
                        nPos = (mnCol - 1) + 8 + mnRow;
                        fPlace(sTwo, nPos);
                        fUpdateDisplay();
                        break;
                    default:
                        MessageBox.Show("You lose","GEnd");
                        fReset();
                        break;
                }
                mbMovelog = false;
            }
            else
            {
                switch (nType)
                {
                    case 11:
                        break;
                    case 12:
                        break;
                    case 5:
                        fAccess();
                        break;
                    case 6:
                        fAccess();
                        break;
                    case 7:
                        fAccess();
                        break;
                    case 8:
                        fAccess();
                        break;
                    default:
                        mnCol = nCol;
                        mnRow = nRow;
                        fUpdateDisplay();
                        break;
                }
            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;
            String sTwo = null;
            int nCol = 0, nRow = 0;
            int nPos = 0;
            int nStones = rnd1.Next(4, 15);

            msShuffle1 = "01020304050607080910111213141516171819202122232425262728293021323334353637383940414243444546474849505152535455565758596061626364";
            msShuffle2 = null;
            mbMovelog = false;
         
            for (int i = 1; i <= 64; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nValue = 1;
                }
                else
                {
                    nValue = 2;
                }
                sTwo = Convert.ToString(nValue);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
                msShuffle2 = msShuffle2 + sTwo;
            }

            fFree(ref nCol, ref nRow);
            nPos = (nCol - 1) * 8 + nRow;
            nValue = rnd1.Next(5, 9);
            mnLogType = nValue;
            sTwo = Convert.ToString(nValue);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            fPlace(sTwo, nPos);
            fFree(ref nCol, ref nRow);
            nPos = (nCol - 1) * 8 + nRow;
            nValue = rnd1.Next(5, 9);
            sTwo = "11";
            fPlace(sTwo, nPos);

            for (int i = 1; i <= nStones; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                nValue = rnd1.Next(5, 9);
                sTwo = "10";
                fPlace(sTwo, nPos);
            }

            fFree(ref nCol, ref nRow);
            mnCol = nCol;
            mnRow = nRow;

            fUpdateDisplay();

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
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 29);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 30);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 31);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 32);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 33);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 34);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 35);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 36);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 37);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 38);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 39);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 40);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle2, 41);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 42);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 43);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 44);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 45);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 46);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 47);
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 48);
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle2, 49);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 50);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 51);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 52);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 53);
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 54);
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 55);
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 56);
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            //8
            nType = fHoletype(msShuffle2, 57);
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 58);
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 59);
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 60);
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 61);
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 62);
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 63);
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 64);
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

            nType = 9;
            nRotate = 1;
            fIcon(nType, nRotate, mnCol, mnRow);
                
            
        }

        private void fIcon(int nType, int nRotate, int nCol, int nRow)
        {
            PictureBox _pic = new PictureBox();

            fPeek(nType, nRotate, ref _pic);

            switch (nCol)
            {
                case 1:
                    switch (nRow)
                    {
                        case 1:
                            pic11.Image = _pic.Image;
                            break;
                        case 2:
                            pic12.Image = _pic.Image;
                            break;
                        case 3:
                            pic13.Image = _pic.Image;
                            break;
                        case 4:
                            pic14.Image = _pic.Image;
                            break;
                        case 5:
                            pic15.Image = _pic.Image;
                            break;
                        case 6:
                            pic16.Image = _pic.Image;
                            break;
                        case 7:
                            pic17.Image = _pic.Image;
                            break;
                        default:
                            pic18.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:
                    switch (nRow)
                    {
                        case 1:
                            pic21.Image = _pic.Image;
                            break;
                        case 2:
                            pic22.Image = _pic.Image;
                            break;
                        case 3:
                            pic23.Image = _pic.Image;
                            break;
                        case 4:
                            pic24.Image = _pic.Image;
                            break;
                        case 5:
                            pic25.Image = _pic.Image;
                            break;
                        case 6:
                            pic26.Image = _pic.Image;
                            break;
                        case 7:
                            pic27.Image = _pic.Image;
                            break;
                        default:
                            pic28.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:
                    switch (nRow)
                    {
                        case 1:
                            pic31.Image = _pic.Image;
                            break;
                        case 2:
                            pic32.Image = _pic.Image;
                            break;
                        case 3:
                            pic33.Image = _pic.Image;
                            break;
                        case 4:
                            pic34.Image = _pic.Image;
                            break;
                        case 5:
                            pic35.Image = _pic.Image;
                            break;
                        case 6:
                            pic36.Image = _pic.Image;
                            break;
                        case 7:
                            pic37.Image = _pic.Image;
                            break;
                        default:
                            pic38.Image = _pic.Image;
                            break;
                    }
                    break;
                case 4:
                    switch (nRow)
                    {
                        case 1:
                            pic41.Image = _pic.Image;
                            break;
                        case 2:
                            pic42.Image = _pic.Image;
                            break;
                        case 3:
                            pic43.Image = _pic.Image;
                            break;
                        case 4:
                            pic44.Image = _pic.Image;
                            break;
                        case 5:
                            pic45.Image = _pic.Image;
                            break;
                        case 6:
                            pic46.Image = _pic.Image;
                            break;
                        case 7:
                            pic47.Image = _pic.Image;
                            break;
                        default:
                            pic48.Image = _pic.Image;
                            break;
                    }
                    break;
                case 5:
                    switch (nRow)
                    {
                        case 1:
                            pic51.Image = _pic.Image;
                            break;
                        case 2:
                            pic52.Image = _pic.Image;
                            break;
                        case 3:
                            pic53.Image = _pic.Image;
                            break;
                        case 4:
                            pic54.Image = _pic.Image;
                            break;
                        case 5:
                            pic55.Image = _pic.Image;
                            break;
                        case 6:
                            pic56.Image = _pic.Image;
                            break;
                        case 7:
                            pic57.Image = _pic.Image;
                            break;
                        default:
                            pic58.Image = _pic.Image;
                            break;
                    }
                    break;
                case 6:
                    switch (nRow)
                    {
                        case 1:
                            pic61.Image = _pic.Image;
                            break;
                        case 2:
                            pic62.Image = _pic.Image;
                            break;
                        case 3:
                            pic63.Image = _pic.Image;
                            break;
                        case 4:
                            pic64.Image = _pic.Image;
                            break;
                        case 5:
                            pic65.Image = _pic.Image;
                            break;
                        case 6:
                            pic66.Image = _pic.Image;
                            break;
                        case 7:
                            pic67.Image = _pic.Image;
                            break;
                        default:
                            pic68.Image = _pic.Image;
                            break;
                    }
                    break;
                case 7:
                    switch (nRow)
                    {
                        case 1:
                            pic71.Image = _pic.Image;
                            break;
                        case 2:
                            pic72.Image = _pic.Image;
                            break;
                        case 3:
                            pic73.Image = _pic.Image;
                            break;
                        case 4:
                            pic74.Image = _pic.Image;
                            break;
                        case 5:
                            pic75.Image = _pic.Image;
                            break;
                        case 6:
                            pic76.Image = _pic.Image;
                            break;
                        case 7:
                            pic77.Image = _pic.Image;
                            break;
                        default:
                            pic78.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
                    switch (nRow)
                    {
                        case 1:
                            pic81.Image = _pic.Image;
                            break;
                        case 2:
                            pic82.Image = _pic.Image;
                            break;
                        case 3:
                            pic83.Image = _pic.Image;
                            break;
                        case 4:
                            pic84.Image = _pic.Image;
                            break;
                        case 5:
                            pic85.Image = _pic.Image;
                            break;
                        case 6:
                            pic86.Image = _pic.Image;
                            break;
                        case 7:
                            pic87.Image = _pic.Image;
                            break;
                        default:
                            pic88.Image = _pic.Image;
                            break;
                    }
                    break;

            }

        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F marble1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F marble2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F electricity.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F fire.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F logs1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F logs2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F logs3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F logs4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F poker.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F randomstones.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F TargetPerimeter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
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
                default:
                    _pic2 = picture12;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private int fHoletype2(String sShuffle, int nSquare, ref int nRotate)
        {
            int nType = 0;
       
            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            nRotate = 1;
            return nType;
        }

        private void fCoordinates(int nSquare, ref int nCol, ref int nRow)
        {
            nCol = 1;

            if (nSquare > 8)
            {
                do
                {
                    nSquare -= 8;
                    nCol += 1;
                } while (nSquare > 8);

            }
            nRow = nSquare;
        }

        private void fPlace(String sText, int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (64 - nPos) * 2);
        }

        private void fFree(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType = 0, nPos = 0;

            do
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                if (nType <= 2)
                {
                    bFound = true;
                }
            } while (bFound != true);

        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }


        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnQNext_Click_1(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnMovelog_Click(object sender, EventArgs e)
        {
            mbMovelog = true;
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

        private void btnComply_Click(object sender, EventArgs e)
        {
            bool bFound = false;
            int nPos, nType;

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nPos = (i - 1) * 8 + j;
                    nType = fHoletype(msShuffle1, nPos);
                    if (nType == 11)
                    {
                        bFound = true;
                        goto endline;
                    }
                }
            }

        endline:;
            if (!bFound)
            {
                fWin();
                fReset();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

    }
}
