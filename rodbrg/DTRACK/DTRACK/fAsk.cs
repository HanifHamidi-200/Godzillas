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
    public partial class fAsk : Form
    {
        private List<String> _ask = new List<string> { null, null, null, null };
        private String msFile="data.txt";
        private bool bWin = false;
        private int mnItem;
        private String msWin;
        private int nNumber;

        private void fFSave()
        {
            String sName = msFile;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {

                file.WriteLine("WIN");
                if (bWin)
                {
                    file.WriteLine("#WIN");
                }
                else
                {
                    file.WriteLine("#LOSE");
                }
                file.WriteLine("END");
                file.Close();
            }


        }

        private void fReset()
        {
            Random rnd1 = new Random();
            String sText;
            int nValue;
            int nDirection;

           msWin = "0000";
            for (int i = 1; i <= 4; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 7)
                {
                    fPlace("1", i);
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                nValue = rnd1.Next(1, 51);
                nDirection = rnd1.Next(1, 5);
                switch (nDirection)
                {
                    case 1:
                        sText = Convert.ToString(nValue) + "N";
                        break;
                    case 2:
                        sText = Convert.ToString(nValue) + "E";
                        break;
                    case 3:
                        sText = Convert.ToString(nValue) + "S";
                        break;
                    default:
                        sText = Convert.ToString(nValue) + "W";
                        break;
                }
                switch (i)
                {

                    case 1:
                        opt1.Text = sText;
                        break;
                    case 2:
                        opt2.Text = sText;
                        break;
                    case 3:
                        opt3.Text = sText;
                        break;
                    default:
                        opt4.Text = sText;
                        break;
                }

            }
        }
        private void fPlace(String sText, int nPos)
        {
            if (nPos == 4)
            {
                msWin = msWin.Substring(0, nPos -1) + sText;

            }
            else
            {
                msWin = msWin.Substring(0, nPos -1) + sText + msWin.Substring(nPos , (4 - nPos) );

            }
        }
        public fAsk()
        {
            InitializeComponent();
        }

        private void fAsk_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int nType = Convert.ToInt32(msWin.Substring(mnItem - 1));

            if (nType == 1)
            {
                bWin = true;
            }
            else
            {
                bWin = false;
            }
            fFSave();
            this.Close();
        }

        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            mnItem = 1;
        }

        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            mnItem = 2;
        }

        private void opt3_CheckedChanged(object sender, EventArgs e)
        {
            mnItem = 3;
        }

        private void opt4_CheckedChanged(object sender, EventArgs e)
        {
            mnItem = 4;
        }
    }
}
