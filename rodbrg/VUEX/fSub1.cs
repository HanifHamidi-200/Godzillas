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
    public partial class fSub1 : Form
    {
        private List<String> _columns = new List<String> { "BORLNDTranscription", "SYBASEHideout", "SYBASETowers", "VuexBotService", "VuexBusiness", "VuexCogslever", "VuexCommonData", "VuexCommonDisplay", "VuexCumnor", "VuexDynamo", "VuexEdith", "VuexFertile", "VuexKRDT", "VuexNotification", "VuexPresskit", "VuexSelence", "VuexSolo", "VuexTeams" };
        private List<int> _count = new List<int> { 4, 4, 3, 3, 4, 2, 3, 4, 2, 4, 1, 2, 2, 6, 4, 5, 2, 3 };
        private List<String> _col1 = new List<String> { "EntityFramework", "MicrosoftSecurityResponseCentre", "PowerShell", "Xamarin", null, null };
        private List<String> _col2 = new List<String> { "Exchange", "MicrosoftStream", "SystemCentre", "SystemCentreConfigurationManager", null, null };
        private List<String> _col3 = new List<String> { "Dynamics365", "F#", "MicrosoftWorkplaceAnalyticsAndMyanalytics", null, null, null };
        private List<String> _col4 = new List<String> { "C#", "MicrosoftQuantumDevelopment", "Office", null, null, null };
        private List<String> _col5 = new List<String> { "CortanaSkills", "EnterpriseMobility+Security", "SkypeForBusiness", "Windows", null, null };
        private List<String> _col6 = new List<String> { "AzureBotService", "MicrosoftFlow", null, null, null, null };
        private List<String> _col7 = new List<String> { "FastTrackForMicrosoft365", "PlayReady", "VisualBasic", null, null, null };
        private List<String> _col8 = new List<String> { "BingAds", "HealthVault", "Microsoft365Enterprise", "SharePoint", null, null };
        private List<String> _col9 = new List<String> { "Virtualization", "Yammer", null, null, null, null };
        private List<String> _col10 = new List<String> { "AzureDevOps", "InternetInformationServices", "MicrosoftMachineLearningServer", "Project", null, null };
        private List<String> _col11 = new List<String> { "MicrosoftManagedDesktop", null, null, null, null, null };
        private List<String> _col12 = new List<String> { "C++", "MicrosoftEducation", null, null, null, null };
        private List<String> _col13 = new List<String> { "ASP.NET", "CommonDataService", null, null, null, null };
        private List<String> _col14 = new List<String> { "CognitiveToolkitCNTK", "InTune", "MicrosoftHPCPack2016", "PowerApps", "PowerBI", "VisualStudioIDE" };
        private List<String> _col15 = new List<String> { "DashboardServices", "Microsoft365Business", "NuGet", "VisualStudio", null, null };
        private List<String> _col16 = new List<String> { "Azure", "BiztalkServer", "Kaizala", "PowerQuery", "SQLServer", null };
        private List<String> _col17 = new List<String> { "AzureIoTCentral", "OneDrive", null, null, null, null };
        private List<String> _col18 = new List<String> { ".NET", "HealthBot", "MicrosoftTeams", null, null, null };
        private List<String> _data = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _value1 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value2 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value3 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value4 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value5 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value6 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value7 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value8 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value9 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value10 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value11 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value12 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value13 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value14 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value15 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value16 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value17 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value18 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private int mnItem;
        private int nNumber;


        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 6; i++)
            {
                _value1[i - 1] = rnd1.Next(1, 401);
                _value2[i - 1] = rnd1.Next(1, 401);
                _value3[i - 1] = rnd1.Next(1, 401);
                _value4[i - 1] = rnd1.Next(1, 401);
                _value5[i - 1] = rnd1.Next(1, 401);
                _value6[i - 1] = rnd1.Next(1, 401);
                _value7[i - 1] = rnd1.Next(1, 401);
                _value8[i - 1] = rnd1.Next(1, 401);
                _value9[i - 1] = rnd1.Next(1, 401);
                _value10[i - 1] = rnd1.Next(1, 401);
                _value11[i - 1] = rnd1.Next(1, 401);
                _value12[i - 1] = rnd1.Next(1, 401);
                _value13[i - 1] = rnd1.Next(1, 401);
                _value14[i - 1] = rnd1.Next(1, 401);
                _value15[i - 1] = rnd1.Next(1, 401);
                _value16[i - 1] = rnd1.Next(1, 401);
                _value17[i - 1] = rnd1.Next(1, 401);
                _value18[i - 1] = rnd1.Next(1, 401);
            }

            for (int i = 1; i <= 18; i++)
            {
                _data[i - 1] = null;
            }
            mnItem = rnd1.Next(1, 19);
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText=null;

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
                    case 7:
                        sText = _col7[i - 1] + " = " + Convert.ToString(_value7[i - 1]);
                        break;
                    case 8:
                        sText = _col8[i - 1] + " = " + Convert.ToString(_value8[i - 1]);
                        break;
                    case 9:
                        sText = _col9[i - 1] + " = " + Convert.ToString(_value9[i - 1]);
                        break;
                    case 10:
                        sText = _col10[i - 1] + " = " + Convert.ToString(_value10[i - 1]);
                        break;
                    case 11:
                        sText = _col11[i - 1] + " = " + Convert.ToString(_value11[i - 1]);
                        break;
                    case 12:
                        sText = _col12[i - 1] + " = " + Convert.ToString(_value12[i - 1]);
                        break;
                    case 13:
                        sText = _col13[i - 1] + " = " + Convert.ToString(_value13[i - 1]);
                        break;
                    case 14:
                        sText = _col14[i - 1] + " = " + Convert.ToString(_value14[i - 1]);
                        break;
                    case 15:
                        sText = _col15[i - 1] + " = " + Convert.ToString(_value15[i - 1]);
                        break;
                    case 16:
                        sText = _col16[i - 1] + " = " + Convert.ToString(_value16[i - 1]);
                        break;
                    case 17:
                        sText = _col17[i - 1] + " = " + Convert.ToString(_value17[i - 1]);
                        break;
                    default:
                        sText = _col18[i - 1] + " = " + Convert.ToString(_value18[i - 1]);
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

        private void fShow(int nMode)
        {
            tab1.Visible = false;
            tab2.Visible = false;
            if (nMode == 1)
            {
                tab1.Visible = true;
            }
            else
            {
                tab2.Visible = true;
            }
        }
        public fSub1()
        {
            InitializeComponent();
            tab2.Left = tab1.Left;
            tab2.Top = tab1.Top;
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fShow(1);
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

        private void button2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fUpdateDisplay();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fUpdateDisplay();

        }

    
        private void button4_Click_1(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            mnItem = 8;
            fUpdateDisplay();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            mnItem = 9;
            fUpdateDisplay();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            mnItem = 10;
            fUpdateDisplay();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            mnItem = 11;
            fUpdateDisplay();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            mnItem = 12;
            fUpdateDisplay();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            mnItem = 13;
            fUpdateDisplay();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            mnItem = 14;
            fUpdateDisplay();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            mnItem = 15;
            fUpdateDisplay();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            mnItem = 16;
            fUpdateDisplay();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            mnItem = 17;
            fUpdateDisplay();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            mnItem = 18;
            fUpdateDisplay();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave(txtEntry.Text);
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void tab2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
