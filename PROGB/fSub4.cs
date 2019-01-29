using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGB
{
    public partial class fSub4 : Form
    {
        public fSub4()
        {
            InitializeComponent();
        }

        private void fSub4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                lst1.Items.Add(txt1.Text);
            }
        }

        private void btnRLast_Click(object sender, EventArgs e)
        {
            int nCount;

            if (lst1.Items.Count > 0)
            {
                nCount = lst1.Items.Count;
                lst1.Items.RemoveAt(nCount - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }
    }
}

