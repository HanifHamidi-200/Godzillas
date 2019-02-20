using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTAB
{
    public partial class fSub1 : Form
    {
        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load_1(object sender, EventArgs e)
        {
           }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fTSub1 _dlg = new fTSub1();
            _dlg.ShowDialog();

        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fTSub2 _dlg = new fTSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click(object sender, EventArgs e)
        {
            fTSub3 _dlg = new fTSub3();
            _dlg.ShowDialog();

        }
    }
}
