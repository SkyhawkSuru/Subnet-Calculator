using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class IP_NetMask : UserControl
    {
        public List<Button> _theList_btn = new List<Button>();
        public List<TextBox> _theList_textBox = new List<TextBox>();
        string eightBitOneM, eightBitTwoM, eightBitThreeM, eightBitFourM;
        int cidrValue = 0;
        int buttonTagValueCidrOne = 0;
        int buttonTagValueCidrZero = 0;
        public double HostsNumber = 0;
        private bool clearAll;
        public bool ClearAll
        {
            get
            {
                return clearAll;
            }
            set
            {
                clearAll = value;
                if (clearAll)
                {
                    Clear();
                }
            }
        }

        public string[] array32_NetMask; // = new string[33];

        public string[] ValueArray // Eigenschaft - property
        {
            get { return array32_NetMask; }
        }
        public IP_NetMask()
        {
            InitializeComponent();
            PopulateList();
            array32_NetMask = new string[33];
        }
        public int CIDR
        {
            get { return cidrValue; }
        }
        private void Clear()
        {
            eightBitOneM = "0"; eightBitTwoM = "0"; eightBitThreeM = "0"; eightBitFourM = "0";

            for (int i = 1; i < 33; i++) // fill with "0" 
            {
                array32_NetMask[i] = "0";
                ValueArray[i] = "0";
                _theList_btn[i - 1].Text = "0";
                ValueArray[i] = "0";
            }
            textBoxNetMask1.Text = "0";
            textBoxNetMask2.Text = "0";
            textBoxNetMask3.Text = "0";
            textBoxNetMask4.Text = "0";

            cidrValue = 0;
            buttonTagValueCidrOne = 0;
            buttonTagValueCidrZero = 0;
            HostsNumber = 0;

            textBoxCIDR.Text = "0";
            textBoxNumberIPAddreses.Text = "0";
            textBoxNumberHosts.Text = "0";
        }
        public void AvoidWrongInput(object sender, KeyPressEventArgs e)
        {
            if (!"0123456789".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PopulateList()
        {
            _theList_btn.AddRange(new Button[]
            {
                 btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8,
                 btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16,
                 btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24,
                 btn25, btn26, btn27, btn28, btn29, btn30, btn31, btn32
            });
            _theList_textBox.AddRange(new TextBox[]
            {
                 textBoxCIDR
            });
        }
        private void HostIPAdressen(object sender, EventArgs e)
        {
            int x = 32 - cidrValue;
            int value = 2;
            HostsNumber = Math.Pow(value, x);
            textBoxNumberIPAddreses.Text = Convert.ToString(HostsNumber);
            HostAnzahl(sender, e);
        }
        private void HostAnzahl(object sender, EventArgs e)
        {
            double number = HostsNumber - 2;
            if (number >= 2)
            {
                textBoxNumberHosts.Text = Convert.ToString(number);
            }
            else
                textBoxNumberHosts.Text = "zu wenig IP Adressen";
        }

        private void RegisterHumanInput(object sender)
        {
            Button btn = (Button)sender;

            if (btn.Text == "0")
            {
                btn.Text = "1";
                array32_NetMask[Convert.ToInt32(btn.Tag)] = "1";
                buttonTagValueCidrOne = Convert.ToInt32(btn.Tag);
            }
            else
            {
                btn.Text = "0";
                array32_NetMask[Convert.ToInt32(btn.Tag)] = "0"; 
                buttonTagValueCidrZero = Convert.ToInt32(btn.Tag);
            }
        }
        private void DualToDecNetMaske(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            eightBitOneM = "0"; // String chain 8-bit (8-Stellen)
            eightBitTwoM = "0";
            eightBitThreeM = "0";
            eightBitFourM = "0";
            RegisterHumanInput(sender);

            // fill arry 
            if (btn.Text == "1") 
            {
                for (int i = 1; i <= buttonTagValueCidrOne; i++)
                {
                    array32_NetMask[i] = "1";
                }
            }
            else
            {
                for (int i = buttonTagValueCidrZero; i < 33; i++)
                {
                    array32_NetMask[i] = "0";
                }
            }

            // int btnRange =  8; // 1-32 possible 
            int btnTag = Convert.ToInt32(btn.Tag);

            if (btnTag > 0 && btnTag < 9)
            {
                for (int i = 1; i < 9; i++)
                {
                    eightBitOneM += array32_NetMask[i];
                }
                textBoxNetMask1.Text = Convert.ToString(Convert.ToInt64(eightBitOneM, 2));
            }
            else if (btnTag > 8 && btnTag < 17)
            {
                for (int i = 9; i < 17; i++)
                {
                    eightBitTwoM += array32_NetMask[i];
                }
                textBoxNetMask2.Text = Convert.ToString(Convert.ToInt64(eightBitTwoM, 2));
            }
            else if (btnTag > 16 && btnTag < 25)
            {
                for (int i = 17; i < 25; i++)
                {
                    eightBitThreeM += array32_NetMask[i];
                }
                textBoxNetMask3.Text = Convert.ToString(Convert.ToInt64(eightBitThreeM, 2));
            }
            else if (btnTag > 24 && btnTag < 33)
            {
                for (int i = 25; i < 33; i++)
                {
                    eightBitFourM += array32_NetMask[i];
                }
                textBoxNetMask4.Text = Convert.ToString(Convert.ToInt64(eightBitFourM, 2));
            }

            // count CIDR 
            int countOne = 0;

            for (int i = 1; i < array32_NetMask.Length; i++)
            {
                if (array32_NetMask[i] == "1")
                {
                    countOne++;
                }
                else
                    break;
            }
            textBoxCIDR.Text = Convert.ToString(countOne);
            cidrValue = countOne;
        }
        private void DecToDualMaske(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            try
            {

                if (txb.Text == null || txb.Text == "")
                {
                    txb.Text = "0";
                }
                int hlpBool = Convert.ToInt32(txb.Text);

                if (hlpBool > 255 || hlpBool < 0)
                {
                    txb.BackColor = Color.Red;
                }
                else
                {
                    txb.BackColor = Color.White;

                    for (int i = 1; i < array32_NetMask.Length; i++) // fill with "0"
                    {
                        if (array32_NetMask[i] == null)
                        {
                            array32_NetMask[i] += "0";
                        }
                    }
                    // input change, turn and insert to Buttons
                    string hlp = Convert.ToString(Convert.ToInt32(txb.Text), 2);

                    char[] btnx = hlp.ToCharArray();

                    char[] achtStellen = new char[8];
                    Array.Reverse(btnx);


                    // fill Array with zero stand in the front
                    for (int i = 0; i < btnx.Length; i++)
                    {
                        achtStellen[i] = btnx[i];
                    }

                    for (int i = btnx.Length; i < 8; i++)
                    {
                        achtStellen[i] = '0'; // fill
                    }

                    // compare all button array 
                    int btnRange = Convert.ToInt32(txb.Tag) * 8; // 1-32 possible 

                    for (int i = btnRange; i > btnRange - 8; i--)
                    {
                        array32_NetMask[i] = Convert.ToString(achtStellen[btnRange - i]);
                    }

                    // ip array 1-32 insert in Buttons 1-32     
                    int count = 1;
                    foreach (Button button in _theList_btn)
                    {
                        button.Text = array32_NetMask[count];

                        count++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers.");
            }
        }
        private void CalculateCIDR(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCIDR.Text == null || textBoxCIDR.Text == "")
                {
                    textBoxCIDR.Text = "0";
                }
                int cidr = Convert.ToInt32(textBoxCIDR.Text);
                cidrValue = cidr; 

                if (cidr > 32 || cidr < 0)
                {
                    textBoxCIDR.BackColor = Color.Red;
                }
                else
                {
                    textBoxCIDR.BackColor = Color.White;

                    for (int i = 1; i < cidr + 1; i++)
                    {
                        array32_NetMask[i] = "1";
                    }
                    if (cidr < 32)
                    {
                        for (int i = cidr + 1; i < array32_NetMask.Length; i++)
                        {
                            array32_NetMask[i] = "0";
                        }
                    }
                    int count = 1;
                    foreach (Button button in _theList_btn)
                    {
                        button.Text = array32_NetMask[count];

                        count++;
                    }
                    // --- Output Textboxes ---
                    string achtBitEinsMaske = "";
                    for (int i = 1; i < 9; i++)
                    {
                        achtBitEinsMaske += array32_NetMask[i];
                    }
                    textBoxNetMask1.Text = Convert.ToString(Convert.ToInt64(achtBitEinsMaske, 2));
                    string achtBitZweiMaske = "";
                    for (int i = 9; i < 17; i++)
                    {
                        achtBitZweiMaske += array32_NetMask[i];
                    }
                    textBoxNetMask2.Text = Convert.ToString(Convert.ToInt64(achtBitZweiMaske, 2));
                    string achtBitDreiMaske = "";
                    for (int i = 17; i < 25; i++)
                    {
                        achtBitDreiMaske += array32_NetMask[i];
                    }
                    textBoxNetMask3.Text = Convert.ToString(Convert.ToInt64(achtBitDreiMaske, 2));
                    string achtBitVierMaske = "";
                    for (int i = 25; i < 33; i++)
                    {
                        achtBitVierMaske += array32_NetMask[i];
                    }
                    textBoxNetMask4.Text = Convert.ToString(Convert.ToInt64(achtBitVierMaske, 2));

                    HostIPAdressen(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only Numbers!");
            }
        }


    }
}
