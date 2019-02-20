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
    public partial class fTSub2 : Form
    {
        private int mnList = 0, mnItem = 0;

        private void fGet(String sFName)
        {
            String sLine;
            int nCount;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sFName))
                {

                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    sLine = sr.ReadLine();
                    nCount = Convert.ToInt32(sLine);
                    for (int i = 1; i <= nCount; i++)
                    {
                        sLine = sr.ReadLine();
                        lstViewer.Items.Add(sLine);
                    }
                    sr.Close();
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }


        }

        private void fShow()
        {
            String sFName;

            if (lstViewer.Items.Count > 0)
            {
                do
                {
                    lstViewer.Items.RemoveAt(0);
                } while (lstViewer.Items.Count > 0);
            }

            switch (mnList)
            {
                case 1:
                    lst1.SelectedIndex = mnItem - 1;
                    sFName = lst1.Text;
                    break;
                case 2:
                    lst2.SelectedIndex = mnItem - 1;
                    sFName = lst2.Text;
                    break;
                case 3:
                    lst3.SelectedIndex = mnItem - 1;
                    sFName = lst3.Text;
                    break;
                default:
                    goto lineend;
            }

            fGet(sFName);

        lineend:;

        }
        public fTSub2()
        {
            InitializeComponent();
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            DialogResult r;
            int nPos = 0;
            String sFName;

            r = dlg1.ShowDialog();
            if (r == DialogResult.OK)
            {
                sFName = dlg1.FileName;
                for (int i = sFName.Length; i >= 1; i--)
                {
                    if (sFName.Substring(i - 1, 1) == "\\")
                    {
                        nPos = i - 1;
                        i = 0;
                    }
                }
                sFName = sFName.Substring(nPos + 1, sFName.Length - nPos - 1);
                lst1.Items.Add(sFName);
            }
        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            DialogResult r;
            int nPos = 0;
            String sFName;

            r = dlg1.ShowDialog();
            if (r == DialogResult.OK)
            {
                sFName = dlg1.FileName;
                for (int i = sFName.Length; i >= 1; i--)
                {
                    if (sFName.Substring(i - 1, 1) == "\\")
                    {
                        nPos = i - 1;
                        i = 0;
                    }
                }
                sFName = sFName.Substring(nPos + 1, sFName.Length - nPos - 1);
                lst2.Items.Add(sFName);
            }
        }

        private void Lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lst1_Click(object sender, EventArgs e)
        {
            mnList = 1;
            mnItem = lst1.SelectedIndex + 1;
            fShow();
        }

        private void Lst2_Click(object sender, EventArgs e)
        {
            mnList = 2;
            mnItem = lst2.SelectedIndex + 1;
            fShow();

        }

        private void Lst3_Click(object sender, EventArgs e)
        {
            mnList = 3;
            mnItem = lst3.SelectedIndex + 1;
            fShow();

        }

        private void fTSub2_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd3_Click(object sender, EventArgs e)
        {
            DialogResult r;
            int nPos = 0;
            String sFName;

            r = dlg1.ShowDialog();
            if (r == DialogResult.OK)
            {
                sFName = dlg1.FileName;
                for (int i = sFName.Length; i >= 1; i--)
                {
                    if (sFName.Substring(i - 1, 1) == "\\")
                    {
                        nPos = i - 1;
                        i = 0;
                    }
                }
                sFName = sFName.Substring(nPos + 1, sFName.Length - nPos - 1);
                lst3.Items.Add(sFName);
            }

        }
    }
}
