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
    public partial class fSub1 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<String> _text1 = new List<string> { null, null, null, null, null, null, null, null, null };
        private List<String> _text2 = new List<string> { null, null, null, null, null, null, null, null, null };
        private List<String> _text3 = new List<string> { null, null, null, null, null, null, null, null, null };
        private List<String> _text4 = new List<string> { null, null, null, null, null, null, null, null, null };
        private int mnQLevelPos, mnKaloosPos, mnIMMCPos;
        private int mnQLevelLength, mnKaloosLength;
        private int mnHighlight;

        private void fClear()
        {
            lbl11.BackColor = Color.Yellow;
            lbl12.BackColor = Color.Yellow;
            lbl13.BackColor = Color.Yellow;
            lbl14.BackColor = Color.Yellow;
            lbl15.BackColor = Color.Yellow;
            lbl16.BackColor = Color.Yellow;
            lbl17.BackColor = Color.Yellow;
            lbl18.BackColor = Color.Yellow;
            lbl19.BackColor = Color.Yellow;

            lbl21.BackColor = Color.Yellow;
            lbl22.BackColor = Color.Yellow;
            lbl23.BackColor = Color.Yellow;
            lbl24.BackColor = Color.Yellow;
            lbl25.BackColor = Color.Yellow;
            lbl26.BackColor = Color.Yellow;
            lbl27.BackColor = Color.Yellow;
            lbl28.BackColor = Color.Yellow;
            lbl29.BackColor = Color.Yellow;

            lbl31.BackColor = Color.Yellow;
            lbl32.BackColor = Color.Yellow;
            lbl33.BackColor = Color.Yellow;
            lbl34.BackColor = Color.Yellow;
            lbl35.BackColor = Color.Yellow;
            lbl36.BackColor = Color.Yellow;
            lbl37.BackColor = Color.Yellow;
            lbl38.BackColor = Color.Yellow;
            lbl39.BackColor = Color.Yellow;

            lbl41.BackColor = Color.Yellow;
            lbl42.BackColor = Color.Yellow;
            lbl43.BackColor = Color.Yellow;
            lbl44.BackColor = Color.Yellow;
            lbl45.BackColor = Color.Yellow;
            lbl46.BackColor = Color.Yellow;
            lbl47.BackColor = Color.Yellow;
            lbl48.BackColor = Color.Yellow;
            lbl49.BackColor = Color.Yellow;

        }

        private void fColour()
        {
            //1
            if (_col1[0] != 0)
            {
                lbl11.BackColor = Color.LightGreen;
            }
            if (_col1[1] != 0)
            {
                lbl12.BackColor = Color.LightGreen;
            }
            if (_col1[2] != 0)
            {
                lbl13.BackColor = Color.LightGreen;
            }
            if (_col1[3] != 0)
            {
                lbl14.BackColor = Color.LightGreen;
            }
            if (_col1[4] != 0)
            {
                lbl15.BackColor = Color.LightGreen;
            }
            if (_col1[5] != 0)
            {
                lbl16.BackColor = Color.LightGreen;
            }
            if (_col1[6] != 0)
            {
                lbl17.BackColor = Color.LightGreen;
            }
            if (_col1[7] != 0)
            {
                lbl18.BackColor = Color.LightGreen;
            }
            if (_col1[8] != 0)
            {
                lbl19.BackColor = Color.LightGreen;
            }

            //2
            if (_col2[0] != 0)
            {
                lbl21.BackColor = Color.LightGreen;
            }
            if (_col2[1] != 0)
            {
                lbl22.BackColor = Color.LightGreen;
            }
            if (_col2[2] != 0)
            {
                lbl23.BackColor = Color.LightGreen;
            }
            if (_col2[3] != 0)
            {
                lbl24.BackColor = Color.LightGreen;
            }
            if (_col2[4] != 0)
            {
                lbl25.BackColor = Color.LightGreen;
            }
            if (_col2[5] != 0)
            {
                lbl26.BackColor = Color.LightGreen;
            }
            if (_col2[6] != 0)
            {
                lbl27.BackColor = Color.LightGreen;
            }
            if (_col2[7] != 0)
            {
                lbl28.BackColor = Color.LightGreen;
            }
            if (_col2[8] != 0)
            {
                lbl29.BackColor = Color.LightGreen;
            }


            //3
            if (_col3[0] != 0)
            {
                lbl31.BackColor = Color.LightGreen;
            }
            if (_col3[1] != 0)
            {
                lbl32.BackColor = Color.LightGreen;
            }
            if (_col3[2] != 0)
            {
                lbl33.BackColor = Color.LightGreen;
            }
            if (_col3[3] != 0)
            {
                lbl34.BackColor = Color.LightGreen;
            }
            if (_col3[4] != 0)
            {
                lbl35.BackColor = Color.LightGreen;
            }
            if (_col3[5] != 0)
            {
                lbl36.BackColor = Color.LightGreen;
            }
            if (_col3[6] != 0)
            {
                lbl37.BackColor = Color.LightGreen;
            }
            if (_col3[7] != 0)
            {
                lbl38.BackColor = Color.LightGreen;
            }
            if (_col3[8] != 0)
            {
                lbl39.BackColor = Color.LightGreen;
            }


            //4
            if (_col4[0] != 0)
            {
                lbl41.BackColor = Color.LightGreen;
            }
            if (_col4[1] != 0)
            {
                lbl42.BackColor = Color.LightGreen;
            }
            if (_col4[2] != 0)
            {
                lbl43.BackColor = Color.LightGreen;
            }
            if (_col4[3] != 0)
            {
                lbl44.BackColor = Color.LightGreen;
            }
            if (_col4[4] != 0)
            {
                lbl45.BackColor = Color.LightGreen;
            }
            if (_col4[5] != 0)
            {
                lbl46.BackColor = Color.LightGreen;
            }
            if (_col4[6] != 0)
            {
                lbl47.BackColor = Color.LightGreen;
            }
            if (_col4[7] != 0)
            {
                lbl48.BackColor = Color.LightGreen;
            }
            if (_col4[8] != 0)
            {
                lbl49.BackColor = Color.LightGreen;
            }

        }
        private void fHighlight(int nCol)
        {
            switch (nCol)
            {
                case 1:
                    //1
                    if (_col1[0] != 0)
                    {
                        lbl11.BackColor = Color.LightBlue;
                    }
                    if (_col1[1] != 0)
                    {
                        lbl12.BackColor = Color.LightBlue;
                    }
                    if (_col1[2] != 0)
                    {
                        lbl13.BackColor = Color.LightBlue;
                    }
                    if (_col1[3] != 0)
                    {
                        lbl14.BackColor = Color.LightBlue;
                    }
                    if (_col1[4] != 0)
                    {
                        lbl15.BackColor = Color.LightBlue;
                    }
                    if (_col1[5] != 0)
                    {
                        lbl16.BackColor = Color.LightBlue;
                    }
                    if (_col1[6] != 0)
                    {
                        lbl17.BackColor = Color.LightBlue;
                    }
                    if (_col1[7] != 0)
                    {
                        lbl18.BackColor = Color.LightBlue;
                    }
                    if (_col1[8] != 0)
                    {
                        lbl19.BackColor = Color.LightBlue;
                    }
                    break;
                case 2:
                    //2
                    if (_col2[0] != 0)
                    {
                        lbl21.BackColor = Color.LightBlue;
                    }
                    if (_col2[1] != 0)
                    {
                        lbl22.BackColor = Color.LightBlue;
                    }
                    if (_col2[2] != 0)
                    {
                        lbl23.BackColor = Color.LightBlue;
                    }
                    if (_col2[3] != 0)
                    {
                        lbl24.BackColor = Color.LightBlue;
                    }
                    if (_col2[4] != 0)
                    {
                        lbl25.BackColor = Color.LightBlue;
                    }
                    if (_col2[5] != 0)
                    {
                        lbl26.BackColor = Color.LightBlue;
                    }
                    if (_col2[6] != 0)
                    {
                        lbl27.BackColor = Color.LightBlue;
                    }
                    if (_col2[7] != 0)
                    {
                        lbl28.BackColor = Color.LightBlue;
                    }
                    if (_col2[8] != 0)
                    {
                        lbl29.BackColor = Color.LightBlue;
                    }
                    break;
                case 3:
                    //3
                    if (_col3[0] != 0)
                    {
                        lbl31.BackColor = Color.LightBlue;
                    }
                    if (_col3[1] != 0)
                    {
                        lbl32.BackColor = Color.LightBlue;
                    }
                    if (_col3[2] != 0)
                    {
                        lbl33.BackColor = Color.LightBlue;
                    }
                    if (_col3[3] != 0)
                    {
                        lbl34.BackColor = Color.LightBlue;
                    }
                    if (_col3[4] != 0)
                    {
                        lbl35.BackColor = Color.LightBlue;
                    }
                    if (_col3[5] != 0)
                    {
                        lbl36.BackColor = Color.LightBlue;
                    }
                    if (_col3[6] != 0)
                    {
                        lbl37.BackColor = Color.LightBlue;
                    }
                    if (_col3[7] != 0)
                    {
                        lbl38.BackColor = Color.LightBlue;
                    }
                    if (_col3[8] != 0)
                    {
                        lbl39.BackColor = Color.LightBlue;
                    }
                    break;
                default:
                    //4
                    if (_col4[0] != 0)
                    {
                        lbl41.BackColor = Color.LightBlue;
                    }
                    if (_col4[1] != 0)
                    {
                        lbl42.BackColor = Color.LightBlue;
                    }
                    if (_col4[2] != 0)
                    {
                        lbl43.BackColor = Color.LightBlue;
                    }
                    if (_col4[3] != 0)
                    {
                        lbl44.BackColor = Color.LightBlue;
                    }
                    if (_col4[4] != 0)
                    {
                        lbl45.BackColor = Color.LightBlue;
                    }
                    if (_col4[5] != 0)
                    {
                        lbl46.BackColor = Color.LightBlue;
                    }
                    if (_col4[6] != 0)
                    {
                        lbl47.BackColor = Color.LightBlue;
                    }
                    if (_col4[7] != 0)
                    {
                        lbl48.BackColor = Color.LightBlue;
                    }
                    if (_col4[8] != 0)
                    {
                        lbl49.BackColor = Color.LightBlue;
                    }
                    break;

            }

        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nCol, nRow;

            msShuffle = "010203040506070809101112131415161718192021222324252627282930313233343536";
            mnQLevelPos = rnd1.Next(1, 5);
            do
            {
                mnKaloosPos = rnd1.Next(1, 5);
            } while (mnKaloosPos == mnQLevelPos);
            mnIMMCPos = rnd1.Next(1, 5);
            mnQLevelLength = rnd1.Next(1, 8);
            mnKaloosLength = rnd1.Next(1, 8);
            mnHighlight = rnd1.Next(1, 5);

            fClear();
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;

            for (int i = 1; i <= 9; i++)
            {
                _col1[i - 1] = 0;
                _col2[i - 1] = 0;
                _col3[i - 1] = 0;
                _col4[i - 1] = 0;
                _text1[i - 1] = "-";
                _text2[i - 1] = "-";
                _text3[i - 1] = "-";
                _text4[i - 1] = "-";
            }

            nCol = mnQLevelPos;
            nRow = 8 - mnQLevelLength;
            for (int i = 8 - mnQLevelLength; i <= 7; i++)
            {
                switch (nCol)
                {
                    case 1:
                        _col1[i - 1] = rnd1.Next(1, 201);
                        _text1[i - 1] = "(" + Convert.ToString(_col1[i - 1]) + ")";
                        break;
                    case 2:
                        _col2[i - 1] = rnd1.Next(1, 201);
                        _text2[i - 1] = "(" + Convert.ToString(_col2[i - 1]) + ")";
                        break;
                    case 3:
                        _col3[i - 1] = rnd1.Next(1, 201);
                        _text3[i - 1] = "(" + Convert.ToString(_col3[i - 1]) + ")";
                        break;
                    default:
                        _col4[i - 1] = rnd1.Next(1, 201);
                        _text4[i - 1] = "(" + Convert.ToString(_col4[i - 1]) + ")";
                        break;
                }
            }
            switch (nCol)
            {
                case 1:
                    _text1[nRow - 1] = "QLEVEL (" + Convert.ToString(_col1[nRow - 1]) + ")";
                    break;
                case 2:
                    _text2[nRow - 1] = "QLEVEL (" + Convert.ToString(_col2[nRow - 1]) + ")";
                    break;
                case 3:
                    _text3[nRow - 1] = "QLEVEL (" + Convert.ToString(_col3[nRow - 1]) + ")";
                    break;
                default:
                    _text4[nRow - 1] = "QLEVEL (" + Convert.ToString(_col4[nRow - 1]) + ")";
                    break;
            }

            nCol = mnKaloosPos;
            nRow = 8 - mnKaloosLength;
            for (int i = 8 - mnKaloosLength; i <= 7; i++)
            {
                switch (nCol)
                {
                    case 1:
                        _col1[i - 1] = rnd1.Next(1, 201);
                        _text1[i - 1] = "(" + Convert.ToString(_col1[i - 1]) + ")";
                        break;
                    case 2:
                        _col2[i - 1] = rnd1.Next(1, 201);
                        _text2[i - 1] = "(" + Convert.ToString(_col2[i - 1]) + ")";
                        break;
                    case 3:
                        _col3[i - 1] = rnd1.Next(1, 201);
                        _text3[i - 1] = "(" + Convert.ToString(_col3[i - 1]) + ")";
                        break;
                    default:
                        _col4[i - 1] = rnd1.Next(1, 201);
                        _text4[i - 1] = "(" + Convert.ToString(_col4[i - 1]) + ")";
                        break;
                }
            }
            switch (nCol)
            {
                case 1:
                    _text1[nRow - 1] = "KALOOS (" + Convert.ToString(_col1[nRow - 1]) + ")";
                    break;
                case 2:
                    _text2[nRow - 1] = "KALOOS (" + Convert.ToString(_col2[nRow - 1]) + ")";
                    break;
                case 3:
                    _text3[nRow - 1] = "KALOOS (" + Convert.ToString(_col3[nRow - 1]) + ")";
                    break;
                default:
                    _text4[nRow - 1] = "KALOOS (" + Convert.ToString(_col4[nRow - 1]) + ")";
                    break;
            }

            nRow = 8;
            _col1[nRow - 1] = rnd1.Next(1, 201);
            _text1[nRow - 1] = " PYRAM (" + Convert.ToString(_col1[nRow - 1]) + ")";
            _col2[nRow - 1] = rnd1.Next(1, 201);
            _text2[nRow - 1] = " PYRAM (" + Convert.ToString(_col2[nRow - 1]) + ")";
            _col3[nRow - 1] = rnd1.Next(1, 201);
            _text3[nRow - 1] = " PYRAM (" + Convert.ToString(_col3[nRow - 1]) + ")";
            _col4[nRow - 1] = rnd1.Next(1, 201);
            _text4[nRow - 1] = " PYRAM (" + Convert.ToString(_col4[nRow - 1]) + ")";

            nRow = 9;
            switch (mnIMMCPos)
            {
                case 1:
                    _col1[nRow - 1] = rnd1.Next(1, 201);
                    _text1[nRow - 1] = " IMMC (" + Convert.ToString(_col1[nRow - 1]) + ")";
                    break;
                case 2:
                    _col2[nRow - 1] = rnd1.Next(1, 201);
                    _text2[nRow - 1] = " IMMC (" + Convert.ToString(_col2[nRow - 1]) + ")";
                    break;
                case 3:
                    _col3[nRow - 1] = rnd1.Next(1, 201);
                    _text3[nRow - 1] = " IMMC (" + Convert.ToString(_col3[nRow - 1]) + ")";
                    break;
                default:
                    _col4[nRow - 1] = rnd1.Next(1, 201);
                    _text4[nRow - 1] = " IMMC (" + Convert.ToString(_col4[nRow - 1]) + ")";
                    break;
            }
            fColour();
            fHighlight(mnHighlight);

            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnHighlight = 1;

            fClear();
            fColour();
            fHighlight(mnHighlight);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnHighlight = 2;

            fClear();
            fColour();
            fHighlight(mnHighlight);


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnHighlight = 3;

            fClear();
            fColour();
            fHighlight(mnHighlight);


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnHighlight = 4;

            fClear();
            fColour();
            fHighlight(mnHighlight);


        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
        }

        private void fUpdateDisplay()
        {
            lbl11.Text = _text1[0];
            lbl12.Text = _text1[1];
            lbl13.Text = _text1[2];
            lbl14.Text = _text1[3];
            lbl15.Text = _text1[4];
            lbl16.Text = _text1[5];
            lbl17.Text = _text1[6];
            lbl18.Text = _text1[7];
            lbl19.Text = _text1[8];

            lbl21.Text = _text2[0];
            lbl22.Text = _text2[1];
            lbl23.Text = _text2[2];
            lbl24.Text = _text2[3];
            lbl25.Text = _text2[4];
            lbl26.Text = _text2[5];
            lbl27.Text = _text2[6];
            lbl28.Text = _text2[7];
            lbl29.Text = _text2[8];

            lbl31.Text = _text3[0];
            lbl32.Text = _text3[1];
            lbl33.Text = _text3[2];
            lbl34.Text = _text3[3];
            lbl35.Text = _text3[4];
            lbl36.Text = _text3[5];
            lbl37.Text = _text3[6];
            lbl38.Text = _text3[7];
            lbl39.Text = _text3[8];

            lbl41.Text = _text4[0];
            lbl42.Text = _text4[1];
            lbl43.Text = _text4[2];
            lbl44.Text = _text4[3];
            lbl45.Text = _text4[4];
            lbl46.Text = _text4[5];
            lbl47.Text = _text4[6];
            lbl48.Text = _text4[7];
            lbl49.Text = _text4[8];
        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
