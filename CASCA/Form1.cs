using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASCA
{
    public partial class Form1 : Form
    {
        private List<int> _numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<bool> _use = new List<bool> { true, true, true, true, true, true, true, true, true, true, true, true };

        private void fClick(int nMode)
        {
            int nSmallest = fSmallest();
            int nClick;

            switch (nMode)
            {
                case 1:
                    nClick = Convert.ToInt32(lbl1.Text);
                    break;
                case 2:
                    nClick = Convert.ToInt32(lbl2.Text);
                    break;
                case 3:
                    nClick = Convert.ToInt32(lbl3.Text);
                    break;
                case 4:
                    nClick = Convert.ToInt32(lbl4.Text);
                    break;
                case 5:
                    nClick = Convert.ToInt32(lbl5.Text);
                    break;
                case 6:
                    nClick = Convert.ToInt32(lbl6.Text);
                    break;
                case 7:
                    nClick = Convert.ToInt32(lbl7.Text);
                    break;
                case 8:
                    nClick = Convert.ToInt32(lbl8.Text);
                    break;
                case 9:
                    nClick = Convert.ToInt32(lbl9.Text);
                    break;
                case 10:
                    nClick = Convert.ToInt32(lbl10.Text);
                    break;
                case 11:
                    nClick = Convert.ToInt32(lbl11.Text);
                    break;
                default:
                    nClick = Convert.ToInt32(lbl12.Text);
                    break;
            }

            if (nClick == nSmallest)
            {
                _use[nMode - 1] = false;
                fUpdateDisplay();
            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 12; i++)
            {
                _numbers[i - 1] = rnd1.Next(1, 101);
                _use[i - 1] = true;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lbl1.BackColor = Color.Yellow;
            lbl2.BackColor = Color.Yellow;
            lbl3.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl5.BackColor = Color.Yellow;
            lbl6.BackColor = Color.Yellow;
            lbl7.BackColor = Color.Yellow;
            lbl8.BackColor = Color.Yellow;
            lbl9.BackColor = Color.Yellow;
            lbl10.BackColor = Color.Yellow;
            lbl11.BackColor = Color.Yellow;
            lbl12.BackColor = Color.Yellow;

            lbl1.Text = Convert.ToString(_numbers[0]);
            lbl2.Text = Convert.ToString(_numbers[1]);
            lbl3.Text = Convert.ToString(_numbers[2]);
            lbl4.Text = Convert.ToString(_numbers[3]);
            lbl5.Text = Convert.ToString(_numbers[4]);
            lbl6.Text = Convert.ToString(_numbers[5]);
            lbl7.Text = Convert.ToString(_numbers[6]);
            lbl8.Text = Convert.ToString(_numbers[7]);
            lbl9.Text = Convert.ToString(_numbers[8]);
            lbl10.Text = Convert.ToString(_numbers[9]);
            lbl11.Text = Convert.ToString(_numbers[10]);
            lbl12.Text = Convert.ToString(_numbers[11]);

            if (_use[0] == false)
            {
                lbl1.BackColor = Color.LightGreen;
            }
            if (_use[1] == false)
            {
                lbl2.BackColor = Color.LightGreen;
            }
            if (_use[2] == false)
            {
                lbl3.BackColor = Color.LightGreen;
            }
            if (_use[3] == false)
            {
                lbl4.BackColor = Color.LightGreen;
            }
            if (_use[4] == false)
            {
                lbl5.BackColor = Color.LightGreen;
            }
            if (_use[5] == false)
            {
                lbl6.BackColor = Color.LightGreen;
            }
            if (_use[6] == false)
            {
                lbl7.BackColor = Color.LightGreen;
            }
            if (_use[7] == false)
            {
                lbl8.BackColor = Color.LightGreen;
            }
            if (_use[8] == false)
            {
                lbl9.BackColor = Color.LightGreen;
            }
            if (_use[9] == false)
            {
                lbl10.BackColor = Color.LightGreen;
            }
            if (_use[10] == false)
            {
                lbl11.BackColor = Color.LightGreen;
            }
            if (_use[11] == false)
            {
                lbl12.BackColor = Color.LightGreen;
            }
        }

        private int fSmallest()
        {
            String sText;
            String sTwo;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i = 1; i <= 12; i++)
            {
                if (_use[i - 1])
                {
                    sTwo = Convert.ToString(_numbers[i - 1]);
                    if (sTwo.Length == 1)
                    {
                        sTwo = "00" + sTwo;
                    }
                    if (sTwo.Length == 2)
                    {
                        sTwo = "0" + sTwo;
                    }
                    lst1.Items.Add(sTwo);
                }
            }
            lst1.Sorted = true;
            lst1.Sorted = false;
            lst1.SelectedIndex = 0;
            sText = Convert.ToString(lst1.Text);
            return Convert.ToInt32(sText);
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

        private void lbl1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            fClick(5);
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            fClick(6);
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            fClick(7);
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            fClick(8);
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            fClick(9);
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            fClick(10);
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            fClick(11);
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            fClick(12);
        }
    }
}
