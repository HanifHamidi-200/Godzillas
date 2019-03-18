using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWINLN
{
    public partial class Form1 : Form
    {
        private List<String> _text = new List<string> { null, null, null, null, null };
        private List<String> _col1 = new List<string> { null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null };
        private List<String> _col3 = new List<string> { null, null, null, null };

        private String fName()
        {
            Random rnd1 = new Random();
            int nValue=rnd1.Next(1,101);
            String sLetter = Convert.ToString((char)(rnd1.Next(1, 27) + 64));

            return sLetter + Convert.ToString(nValue);
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;

            nValue = rnd1.Next(1, 40001);
            _text[0] = Convert.ToString(nValue);
            nValue = rnd1.Next(1, 40001);
            _text[2] = Convert.ToString(nValue);
            nValue = rnd1.Next(1, 101);
            _text[1] = Convert.ToString(nValue)+"%";
            nValue = rnd1.Next(1, 101);
            _text[3] = Convert.ToString(nValue) + "%";
            nValue = rnd1.Next(1, 101);
            _text[4] = Convert.ToString(nValue) + "%e";

            for(int i = 1; i <= 4; i++)
            {
                _col1[i - 1] = fName();
                _col2[i - 1] = fName();
                _col3[i - 1] = fName();

            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            txtCost1.Text = _text[0];
            txtTS1.Text = _text[1];
            txtCost2.Text = _text[2];
            txtTS2.Text = _text[3];
            txtCropout.Text = _text[4];

            txt11.Text = _col1[0];
            txt12.Text = _col1[1];
            txt13.Text = _col1[2];
      /*      txt140.Text = _col1[3];

            txt21.Text = _col2[0];
            txt22.Text = _col2[1];
            txt23.Text = _col2[2];
            txt24.Text = _col2[3];

            txt31.Text = _col3[0];
            txt32.Text = _col3[1];
            txt33.Text = _col3[2];
            txt34.Text = _col3[3];

    */
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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnVersion2_Click(object sender, EventArgs e)
        {
            fVersion2 _dlg = new fVersion2();
            _dlg.ShowDialog();
        }

        private void btnVersion3_Click(object sender, EventArgs e)
        {
            fVersion3 _dlg = new fVersion3();
            _dlg.ShowDialog();

        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }
    }
}
