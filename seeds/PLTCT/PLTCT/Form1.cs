using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLTCT
{
    public partial class Form1 : Form
    {
        List<String> _orchard = new List<string> { "apple", "pear", "gooseberry", "blackcurrants" };
        List<String> _coldframes = new List<string> { "broccoli", "cabbage", "lettuce", "potatoes","raspberry","mint" };
        List<String> _thepits = new List<string> { "olive", "banana", "chilli" };
        List<String> _theraking = new List<string> { "sunflower", "geranium", "pelargonium", "willow" ,"strawberry"};
        List<String> _themonth = new List<string> { "(J) January", "(F) February", "(M) March", "(A) April", "(M) May" , "(J) June", "(J) July", "(A) August", "(S) September", "(O) October" ,"(N) November", "(D) December"};
        int mnMonth;
        List<int> _fruit = new List<int> {0,0,0,0 };
        List<int> _fruitcategory = new List<int> { 0, 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();
            int nCount;

            mnMonth = rnd1.Next(1, 13);
            lblMonth.Text = "Month = " + _themonth[mnMonth - 1];

            for (int i = 1; i <= 4; i++)
            {
                _fruitcategory[i - 1] = rnd1.Next(1, 5);
                switch (_fruitcategory[i - 1])
                {
                    case 1:
                        nCount = _orchard.Count;
                        _fruit[i - 1] = rnd1.Next(1, nCount + 1);
                        break;
                    case 2:
                        nCount = _coldframes.Count;
                        _fruit[i - 1] = rnd1.Next(1, nCount + 1);
                        break;
                    case 3:
                        nCount = _thepits.Count;
                        _fruit[i - 1] = rnd1.Next(1, nCount + 1);
                        break;
                    default:
                        nCount = _theraking.Count;
                        _fruit[i - 1] = rnd1.Next(1, nCount + 1);
                        break;
                }
            }

            chk1.Text = fFruit(_fruitcategory[0], _fruit[0]);
            chk2.Text = fFruit(_fruitcategory[1], _fruit[1]);
            chk3.Text = fFruit(_fruitcategory[2], _fruit[2]);
            chk4.Text = fFruit(_fruitcategory[3], _fruit[3]);
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            lst1.Text = null;
            lst2.Text = null;
            lst3.Text = null;
            lst4.Text = null;


        }
        private String fFruit(int nCategory,int nFruit)
        {
            switch (nCategory)
            {
                case 1:
                    return _orchard[nFruit - 1];
                case 2:
                    return _coldframes[nFruit - 1];
                case 3:
                    return _thepits[nFruit - 1];
                default:
                    return _theraking[nFruit - 1];
            }
        }

        private void fLookup(int nMode)
        {
            String sText = null;
            int nCount;

            switch (nMode)
            {
                case 1:
                    nCount = _orchard.Count;
                    for (int i = 1; i <= nCount; i++)
                    {
                        sText = sText + _orchard[i - 1] + "...";
                    }
                    MessageBox.Show("Items in L1 = " + sText);
                    break;
                case 2:
                    nCount = _coldframes.Count;
                    for (int i = 1; i <= nCount; i++)
                    {
                        sText = sText + _coldframes[i - 1] + "...";
                    }
                    MessageBox.Show("Items in L2 = " + sText);
                    break;
                case 3:
                    nCount = _thepits.Count;
                    for (int i = 1; i <= nCount; i++)
                    {
                        sText = sText + _thepits[i - 1] + "...";
                    }
                    MessageBox.Show("Items in L3 = " + sText);
                    break;
                default:
                    nCount = _theraking.Count;
                    for (int i = 1; i <= nCount; i++)
                    {
                        sText = sText + _theraking[i - 1] + "...";
                    }
                    MessageBox.Show("Items in L4 = " + sText);
                    break;
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

        private void btnLookup1_Click(object sender, EventArgs e)
        {
            fLookup(1);
        }

        private void btnLookup2_Click(object sender, EventArgs e)
        {
            fLookup(2);
        }

        private void btnLookup3_Click(object sender, EventArgs e)
        {
            fLookup(3);
        }

        private void btnLookup4_Click(object sender, EventArgs e)
        {
            fLookup(4);
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnChecklist_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }
    }
}
