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
    public partial class fSub1 : Form
    {
        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;

            nValue = rnd1.Next(1, 101);
            txt1.Text = Convert.ToString(nValue);
            nValue = rnd1.Next(1, 101);
            txt2.Text = Convert.ToString(nValue);
            nValue = rnd1.Next(1, 101);
            txt3.Text = Convert.ToString(nValue);
            nValue = rnd1.Next(1, 101);
            txt4.Text = Convert.ToString(nValue);
        }
        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
