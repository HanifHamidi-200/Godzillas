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
    public partial class fSub3 : Form
    {
        private List<String> _columns = new List<String> { "Planet9Possibilities" };
        private List<int> _count = new List<int> { 8};
        private List<String> _col1 = new List<String> { "IMMC interrupts FurtherProducts", "MowgliReaction sustains a LowerAltitude", "FarmersCrops doubles its DiamondRange", "EnergyPower redistributes ItsNodes", "PyramPrincipality makes further IntelligentDigging", "WomensVertical becomes more pronouned by ProsperityShip_measures", "EarthAndromeda starts designing its MissionControl" ,"RigelEarth looksto newdebuts to multiply its Outcrop"};
        private List<int> _value1 = new List<int> { 0, 0, 0, 0, 0, 0, 0,0 };
        private List<String> _data = new List<string> { null };
        private int mnItem;
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 8; i++)
            {
                _value1[i - 1] = rnd1.Next(1, 401);
            }

            _data[0] = null;
            mnItem = 1;
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
                sText = _col1[i - 1] + " = " + Convert.ToString(_value1[i - 1]);
                lst1.Items.Add(sText);
            }


            txtEntry.Text = _data[mnItem - 1];
        }

        private void fSave(String sText)
        {
            _data[mnItem - 1] = sText;
        }


        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave(txtEntry.Text);

        }
    }
}
