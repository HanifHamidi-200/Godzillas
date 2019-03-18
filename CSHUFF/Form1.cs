using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHUFF
{
    public partial class Form1 : Form
    {
        private void fReset()
        {
            Random rnd1 = new Random();
            int n1 = rnd1.Next(1, 4);
            int n2 = rnd1.Next(1, 4);
            int n3 = rnd1.Next(1, 4);

            txt11.Text = "c";
            txt12.Text = "c++";
            txt13.Text = "c#";

            switch (n1)
            {
                case 1:
                    txt21.Text = "c";
                    break;
                case 2:
                    txt21.Text = "c++";
                    break;
                default:
                    txt21.Text = "c#";
                    break;
            }
            switch (n2)
            {
                case 1:
                    txt22.Text = "c";
                    break;
                case 2:
                    txt22.Text = "c++";
                    break;
                default:
                    txt22.Text = "c#";
                    break;
            }
            switch (n3)
            {
                case 1:
                    txt23.Text = "c";
                    break;
                case 2:
                    txt23.Text = "c++";
                    break;
                default:
                    txt23.Text = "c#";
                    break;
            }

            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;
            txt5.Text = null;

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

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }
    }
}
