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
    public partial class fTSub1 : Form
    {
        private String sText = null;

        private void fSave(String sFName)
        {
            String sLine;
            int nCount = lst1.Items.Count;

            try
            {   // Open the text file using a stream reader.
                using (StreamWriter sw = new StreamWriter(sFName))
                {

                    // Read the stream to a string, and write the string to the console.
                    sw.WriteLine("LIST");
                    sw.WriteLine(Convert.ToString(nCount));
                    for (int i = 1; i <= nCount; i++)
                    {
                        lst1.SelectedIndex = i - 1;
                        sLine = lst1.Text;
                        sw.WriteLine(sLine);
                    }
                    sw.WriteLine("END");
                    sw.Close();
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }


        }

        private void fClear()
        {
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
        }
        public fTSub1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fClear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int nPos = lst1.Items.Count;

            lst1.Items.RemoveAt(nPos - 1);
        }

        private void fTSub1_Load_1(object sender, EventArgs e)
        {
            fClear();

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            sText = sText + " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sText = sText + "Glpx";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sText = sText + "HEAD";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sText = sText + "LEG";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sText = sText + "PTURN";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sText = sText + "PEND";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sText != null)
            {
                lst1.Items.Add(sText);
                sText = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) != 0)
                {
                    sText = sText + Convert.ToString((Convert.ToInt32(textBox1.Text)));
                }

            }
            catch
            {
                goto lineend;
            }

        lineend:;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSave.Text != "")
            {
                fSave(txtSave.Text);
            }
        }
    }
}
