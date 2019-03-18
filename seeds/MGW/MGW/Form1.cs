using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGW
{
    public partial class Form1 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _underlay8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<bool> _reveal1 = new List<bool> { false, false, false, false, false, false, false, false };
        private List<bool> _reveal2 = new List<bool> { false, false, false, false, false, false, false, false };
        private List<bool> _reveal3 = new List<bool> { false, false, false, false, false, false, false, false };
        private List<bool> _reveal4 = new List<bool> { false, false, false, false, false, false, false, false };
        private List<bool> _reveal5 = new List<bool> { false, false, false, false, false, false, false, false };
        private List<bool> _reveal6 = new List<bool> { false, false, false, false, false, false, false, false };
        private List<bool> _reveal7 = new List<bool> { false, false, false, false, false, false, false, false };
        private List<bool> _reveal8 = new List<bool> { false, false, false, false, false, false, false, false };
        private int nNumber;
        private int mnCol = 1, mnRow = 1,mnRotate=1;
     
        private void fMapping()
        {
            for (int i = 1; i <= 8; i++)
            {
                if (_reveal1[i - 1])
                {
                    _col1[i - 1] = _underlay1[i - 1];
                }
                if (_reveal2[i - 1])
                {
                    _col2[i - 1] = _underlay2[i - 1];
                }
                if (_reveal3[i - 1])
                {
                    _col3[i - 1] = _underlay3[i - 1];
                }
                if (_reveal4[i - 1])
                {
                    _col4[i - 1] = _underlay4[i - 1];
                }
                if (_reveal5[i - 1])
                {
                    _col5[i - 1] = _underlay5[i - 1];
                }
                if (_reveal6[i - 1])
                {
                    _col6[i - 1] = _underlay6[i - 1];
                }
                if (_reveal7[i - 1])
                {
                    _col7[i - 1] = _underlay7[i - 1];
                }
                if (_reveal8[i - 1])
                {
                    _col8[i - 1] = _underlay8[i - 1];
                }
            }
        }
        private void fClick(int nCol,int nRow)
        {

        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F ground1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F ground2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F item1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F item2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F item3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F item4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F item5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F item6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F item7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F well.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F YOU.png"),
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

        private void fUpdateStatus()
        {
    
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nCol = 0,nRow = 0;
            int nWell = rnd1.Next(10, 41);
            int nReveal = rnd1.Next(4, 9);
            int nType;

            for (int i = 1; i <= 8; i++)
            {
                _col1[i - 1] = 1;
                _col2[i - 1] = 1;
                _col3[i - 1] = 1;
                _col4[i - 1] = 1;
                _col5[i - 1] = 1;
                _col6[i - 1] = 1;
                _col7[i - 1] = 1;
                _col8[i - 1] = 1;
                _underlay1[i - 1] = rnd1.Next(3, 10);
                _underlay2[i - 1] = rnd1.Next(3, 10);
                _underlay3[i - 1] = rnd1.Next(3, 10);
                _underlay4[i - 1] = rnd1.Next(3, 10);
                _underlay5[i - 1] = rnd1.Next(3, 10);
                _underlay6[i - 1] = rnd1.Next(3, 10); 
                _underlay7[i - 1] = rnd1.Next(3, 10);
                _underlay8[i - 1] = rnd1.Next(3, 10);
                _reveal1[i - 1] = false;
                _reveal2[i - 1] = false;
                _reveal3[i - 1] = false;
                _reveal4[i - 1] = false;
                _reveal5[i - 1] = false;
                _reveal6[i - 1] = false;
                _reveal7[i - 1] = false;
                _reveal8[i - 1] = false;
            }
         
            for (int i = 1; i <= nWell; i++)
            {
                fFree(ref nCol, ref nRow,2);
                fPlace3(nCol, nRow, true);
                fPlace(nCol, nRow, 10, 1);
                fPlace(nCol, nRow, 10, 2);
            }
            for (int i = 1; i <= nReveal; i++)
            {
                fFree(ref nCol, ref nRow,3);
                fPlace3(nCol, nRow, true);
                nType = fType(nCol, nRow);
                fPlace(nCol, nRow, nType, 1);
                fPlace(nCol, nRow, nType, 2);
            }

           //fMapping();
            fUpdateDisplay();
            fUpdateStatus();
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            nType = _col1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _col1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _col1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _col1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = _col1[4];
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = _col1[5];
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = _col1[6];
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = _col1[7];
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            //2
            nType = _col2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _col2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _col2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _col2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = _col2[4];
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = _col2[5];
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = _col2[6];
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = _col2[7];
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = _col3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _col3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _col3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _col3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = _col3[4];
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = _col3[5];
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = _col3[6];
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = _col3[7];
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = _col4[0];
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = _col4[1];
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = _col4[2];
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = _col4[3];
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = _col4[4];
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = _col4[5];
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = _col4[6];
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = _col4[7];
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = _col5[0];
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = _col5[1];
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = _col5[2];
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = _col5[3];
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = _col5[4];
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = _col5[5];
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = _col5[6];
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = _col5[7];
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            //6
            nType = _col6[0];
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = _col6[1];
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = _col6[2];
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = _col6[3];
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = _col6[4];
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = _col6[5];
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = _col6[6];
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = _col6[7];
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            //7
            nType = _col7[0];
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = _col7[1];
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = _col7[2];
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = _col7[3];
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = _col7[4];
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = _col7[5];
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = _col7[6];
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = _col7[7];
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            //8
            nType = _col8[0];
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = _col8[1];
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = _col8[2];
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = _col8[3];
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = _col8[4];
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = _col8[5];
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = _col8[6];
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = _col8[7];
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

        }

        private void fPlace3(int nCol, int nRow, bool bType)
        {
            switch (nCol)
            {
                case 1:
                    _reveal1[nRow - 1] = bType;
                    break;
                case 2:
                    _reveal2[nRow - 1] = bType;
                    break;
                case 3:
                    _reveal3[nRow - 1] = bType;
                    break;
                case 4:
                    _reveal4[nRow - 1] = bType;
                    break;
                case 5:
                    _reveal5[nRow - 1] = bType;
                    break;
                case 6:
                    _reveal6[nRow - 1] = bType;
                    break;
                case 7:
                    _reveal7[nRow - 1] = bType;
                    break;
                default:
                    _reveal8[nRow - 1] = bType;
                    break;
            }

        }

        private void fPlace(int nCol, int nRow, int nType,int nMode)
        {
            if (nMode == 1)
            {
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = nType;
                        break;
                    case 2:
                        _col2[nRow - 1] = nType;
                        break;
                    case 3:
                        _col3[nRow - 1] = nType;
                        break;
                    case 4:
                        _col4[nRow - 1] = nType;
                        break;
                    case 5:
                        _col5[nRow - 1] = nType;
                        break;
                    case 6:
                        _col6[nRow - 1] = nType;
                        break;
                    case 7:
                        _col7[nRow - 1] = nType;
                        break;
                    default:
                        _col8[nRow - 1] = nType;
                        break;
                }

            }
            else
            {
                switch (nCol)
                {
                    case 1:
                        _underlay1[nRow - 1] = nType;
                        break;
                    case 2:
                        _underlay2[nRow - 1] = nType;
                        break;
                    case 3:
                        _underlay3[nRow - 1] = nType;
                        break;
                    case 4:
                        _underlay4[nRow - 1] = nType;
                        break;
                    case 5:
                        _underlay5[nRow - 1] = nType;
                        break;
                    case 6:
                        _underlay6[nRow - 1] = nType;
                        break;
                    case 7:
                        _underlay7[nRow - 1] = nType;
                        break;
                    default:
                        _underlay8[nRow - 1] = nType;
                        break;
                }

            }
        }
        private bool fType3(int nCol, int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _reveal1[nRow - 1];
                case 2:
                    return _reveal2[nRow - 1];
                case 3:
                    return _reveal3[nRow - 1];
                case 4:
                    return _reveal4[nRow - 1];
                case 5:
                    return _reveal5[nRow - 1];
                case 6:
                    return _reveal6[nRow - 1];
                case 7:
                    return _reveal7[nRow - 1];
                default:
                    return _reveal8[nRow - 1];
            }
        }

        private int fType(int nCol, int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _underlay1[nRow - 1];
                case 2:
                    return _underlay2[nRow - 1];
                case 3:
                    return _underlay3[nRow - 1];
                case 4:
                    return _underlay4[nRow - 1];
                case 5:
                    return _underlay5[nRow - 1];
                case 6:
                    return _underlay6[nRow - 1];
                case 7:
                    return _underlay7[nRow - 1];
                default:
                    return _underlay8[nRow - 1];
            }
        }

        private void fFree(ref int nCol, ref int nRow,int nMode)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            bool bType;

            if (nMode == 2)
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                bFound = true;
            }
            else
            {
                do
                {
                    nCol = rnd1.Next(1, 9);
                    nRow = rnd1.Next(1, 9);
                    bType = fType3(nCol, nRow);
                    if (bType == false)
                    {
                        bFound = true;
                    }
                } while (bFound == false);

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
