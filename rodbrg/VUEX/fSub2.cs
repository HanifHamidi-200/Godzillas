using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VUEX
{
    public partial class fSub2 : Form
    {
        private List<String> _columns = new List<String> { "RobotsAdhere", "BanksAdhere", "WorkingCompaniesAdhere", "Gerrick", "Mountains", "Technology", "Plan" };
        private List<int> _count = new List<int> { 4, 3, 7 ,3,6,3,4};
        private List<String> _col1 = new List<String> { "SelfinflictedRover", "BTSDealPayout", "DeNuclearisation", "UncleBuck", null, null ,null};
        private List<String> _col2 = new List<String> { "BaBBank", "BusinessTowers(2+3)", "NewWotf_IrishBorderChecks", null, null, null, null };
        private List<String> _col3 = new List<String> { "ChinaBurden_IncomingGoods", "ChinaSuggestedWorkingProtocol", "SwedenStorehouses", "SpanishStorehouses", "NorwayCustomsUnion", "CanadaCustomsUnion", "PatentDatabase" };
        private List<String> _col4 = new List<String> { "Swallowing", "Membership", "Intruder", null, null, null, null };
        private List<String> _col5 = new List<String> { "Mordor_Technology", "Gondor", "Evelyn", "Pumice", "Peckham_Technology", "Atrecht", null };
        private List<String> _col6 = new List<String> { "FranceEgyptRiver_BREXTCompany", "WMBInsight", "PlutoRex", null, null, null, null };
        private List<String> _col7 = new List<String> { "MICompany", "AICompany", "MosesDoa_Characters", "IngotAngkot_MonarchyPlan", null, null, null };
        private List<String> _data = new List<string> { null, null, null, null, null, null, null };
        private List<int> _value1 = new List<int> { 0, 0, 0, 0, 0, 0 ,0};
        private List<int> _value2 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value3 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value4 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value5 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value6 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value7 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private int mnItem;
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 7; i++)
            {
                _value1[i - 1] = rnd1.Next(1, 401);
                _value2[i - 1] = rnd1.Next(1, 401);
                _value3[i - 1] = rnd1.Next(1, 401);
                _value4[i - 1] = rnd1.Next(1, 401);
                _value5[i - 1] = rnd1.Next(1, 401);
                _value6[i - 1] = rnd1.Next(1, 401);
                _value7[i - 1] = rnd1.Next(1, 401);
            }

            for (int i = 1; i <= 7; i++)
            {
                _data[i - 1] = null;
            }
            mnItem = rnd1.Next(1, 8);
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText = null;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            fra1.Text = _columns[mnItem - 1];
            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                switch (mnItem)
                {
                    case 1:
                        sText = _col1[i - 1] + " = " + Convert.ToString(_value1[i - 1]);
                        break;
                    case 2:
                        sText = _col2[i - 1] + " = " + Convert.ToString(_value2[i - 1]);
                        break;
                    case 3:
                        sText = _col3[i - 1] + " = " + Convert.ToString(_value3[i - 1]);
                        break;
                    case 4:
                        sText = _col4[i - 1] + " = " + Convert.ToString(_value4[i - 1]);
                        break;
                    case 5:
                        sText = _col5[i - 1] + " = " + Convert.ToString(_value5[i - 1]);
                        break;
                    case 6:
                        sText = _col6[i - 1] + " = " + Convert.ToString(_value6[i - 1]);
                        break;
                     default:
                        sText = _col7[i - 1] + " = " + Convert.ToString(_value7[i - 1]);
                        break;
                }
                lst1.Items.Add(sText);
            }

            txtEntry.Text = _data[mnItem - 1];
        }

        private void fSave(String sText)
        {
            _data[mnItem - 1] = sText;
        }

        public fSub2()
        {
            InitializeComponent();
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnItem = 1;
            fUpdateDisplay();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fUpdateDisplay();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fUpdateDisplay();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mnItem = 4;
            fUpdateDisplay();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mnItem = 5;
            fUpdateDisplay();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            mnItem = 6;
            fUpdateDisplay();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mnItem = 7;
            fUpdateDisplay();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave(txtEntry.Text);

        }
    }
}
