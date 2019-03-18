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
    public partial class fSub2 : Form
    {
        private int mnItem;
        private List<int> _count = new List<int> { 4, 4, 5, 7 };
        private List<String> _catch = new List<string> { "PMI", "TLR", "HBO", "PLS" };
        private List<String> _col1 = new List<string> { null, null, null, null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null, null, null, null };
        private List<String> _col3 = new List<string> { null, null, null, null, null, null, null };
        private List<String> _col4 = new List<string> { null, null, null, null, null, null, null };
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;
            int nCount;
            String sCatch;
            String sLetter;

            for (int i = 1; i <= 4; i++)
            {
                nCount = _count[i - 1];
                sCatch = _catch[i - 1];
                for (int j = 1; j <= nCount; j++)
                {
                    nNumber = rnd1.Next(1, 4);
                    sLetter = sCatch.Substring(nNumber - 1, 1);
                    nValue = rnd1.Next(1, 100);
                    switch (i)
                    {
                        case 1:
                            _col1[j - 1] = sLetter + Convert.ToString(nValue);
                            break;
                        case 2:
                            _col2[j - 1] = sLetter + Convert.ToString(nValue);
                            break;
                        case 3:
                            _col3[j - 1] = sLetter + Convert.ToString(nValue);
                            break;
                        default:
                            _col4[j - 1] = sLetter + Convert.ToString(nValue);
                            break;
                    }
                }
            }
            mnItem = 1;
            fUpdateStatus();
            fUpdateDisplay(1);
        }

        private void fUpdateStatus()
        {
            lbl11.Text = _col1[0];
            lbl12.Text = _col1[1];
            lbl13.Text = _col1[2];
            lbl14.Text = _col1[3];

            lbl21.Text = _col2[0];
            lbl22.Text = _col2[1];
            lbl23.Text = _col2[2];
            lbl24.Text = _col2[3];

            lbl31.Text = _col3[0];
            lbl32.Text = _col3[1];
            lbl33.Text = _col3[2];
            lbl34.Text = _col3[3];
            lbl35.Text = _col3[4];

            lbl41.Text = _col4[0];
            lbl42.Text = _col4[1];
            lbl43.Text = _col4[2];
            lbl44.Text = _col4[3];
            lbl45.Text = _col4[4];
            lbl46.Text = _col4[5];
            lbl47.Text = _col4[6];
        }

        private void fUpdateDisplay(int nMode)
        {
            fra1.Visible = false;
            fra2.Visible = false;
            fra3.Visible = false;
            fra4.Visible = false;
            switch (nMode)
            {
                case 1:
                    fra1.Visible = true;
                    break;
                case 2:
                    fra2.Visible = true;
                    break;
                case 3:
                    fra3.Visible = true;
                    break;
                default:
                    fra4.Visible = true;
                    break;
            }
        }
        public fSub2()
        {
            InitializeComponent();
            fra2.Top = fra1.Top;
            fra2.Left = fra1.Left;
            fra3.Top = fra1.Top;
            fra3.Left = fra1.Left;
            fra4.Top = fra1.Top;
            fra4.Left = fra1.Left;

        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnItem = 1;
            fUpdateDisplay(1);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fUpdateDisplay(2);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fUpdateDisplay(3);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnItem = 4;
            fUpdateDisplay(4);

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
