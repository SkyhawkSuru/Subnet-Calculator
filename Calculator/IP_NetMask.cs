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
        string achtBitEinsM, achtBitZweiM, achtBitDreiM, achtBitVierM;
        int cidrValue = 0;
        int buttonTagValueCidrOne = 0;
        int buttonTagValueCidrZero = 0;
        public double HostsAnzahl = 0;
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
            achtBitEinsM = "0"; achtBitZweiM = "0"; achtBitDreiM = "0"; achtBitVierM = "0";

            for (int i = 1; i < 33; i++) // mit 0 auffüllen
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
            HostsAnzahl = 0;

            textBoxCIDR.Text = "0";
            textBoxAnzahlIPAdressden.Text = "0";
            textBoxAnzahlHosts.Text = "0";
        }
        public void avoidWrongInput(object sender, KeyPressEventArgs e)
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
            HostsAnzahl = Math.Pow(value, x);
            textBoxAnzahlIPAdressden.Text = Convert.ToString(HostsAnzahl);
            HostAnzahl(sender, e);
        }
        private void HostAnzahl(object sender, EventArgs e)
        {
            double anzahl = HostsAnzahl - 2;
            if (anzahl >= 2)
            {
                textBoxAnzahlHosts.Text = Convert.ToString(anzahl);
            }
            else
                textBoxAnzahlHosts.Text = "zu wenig IP Adressen";
        }

        private void blubM(object sender)
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
                array32_NetMask[Convert.ToInt32(btn.Tag)] = "0"; // 1-8 + 9-16 +17-24 + 25-32 extra funktion mit schleife
                buttonTagValueCidrZero = Convert.ToInt32(btn.Tag);
            }
        }
        private void dualToDecNetMaske(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            achtBitEinsM = "0"; // zusammengesetzter String achtbit (8-Stellen)
            achtBitZweiM = "0";
            achtBitDreiM = "0";
            achtBitVierM = "0";
            blubM(sender);

            // arry auffüllen
            if (btn.Text == "1") //Test
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

            // int btnRange =  8; // 1-32 möglich 
            int btnTag = Convert.ToInt32(btn.Tag);

            if (btnTag > 0 && btnTag < 9)
            {
                for (int i = 1; i < 9; i++)
                {
                    achtBitEinsM += array32_NetMask[i];
                }
                textBoxNetMask1.Text = Convert.ToString(Convert.ToInt64(achtBitEinsM, 2));
            }
            else if (btnTag > 8 && btnTag < 17)
            {
                for (int i = 9; i < 17; i++)
                {
                    achtBitZweiM += array32_NetMask[i];
                }
                textBoxNetMask2.Text = Convert.ToString(Convert.ToInt64(achtBitZweiM, 2));
            }
            else if (btnTag > 16 && btnTag < 25)
            {
                for (int i = 17; i < 25; i++)
                {
                    achtBitDreiM += array32_NetMask[i];
                }
                textBoxNetMask3.Text = Convert.ToString(Convert.ToInt64(achtBitDreiM, 2));
            }
            else if (btnTag > 24 && btnTag < 33)
            {
                for (int i = 25; i < 33; i++)
                {
                    achtBitVierM += array32_NetMask[i];
                }
                textBoxNetMask4.Text = Convert.ToString(Convert.ToInt64(achtBitVierM, 2));
            }

            // CIDR zählen
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
        private void decToDualMaske(object sender, EventArgs e)
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

                    for (int i = 1; i < array32_NetMask.Length; i++) // mit 0 auffüllen
                    {
                        if (array32_NetMask[i] == null)
                        {
                            array32_NetMask[i] += "0";
                        }
                    }
                    // Eingabe umwandel, umdrehen und in Buttons einfügen
                    string hlp = Convert.ToString(Convert.ToInt32(txb.Text), 2);

                    char[] btnx = hlp.ToCharArray();

                    char[] achtStellen = new char[8];
                    Array.Reverse(btnx);


                    // Array mit Nullen auffüllen die am Anfang stehen
                    for (int i = 0; i < btnx.Length; i++)
                    {
                        achtStellen[i] = btnx[i];
                    }

                    for (int i = btnx.Length; i < 8; i++)
                    {
                        achtStellen[i] = '0'; // auffüllen
                    }

                    // mit all button array abgleichen
                    int btnRange = Convert.ToInt32(txb.Tag) * 8; // 1-32 möglich 

                    for (int i = btnRange; i > btnRange - 8; i--)
                    {
                        array32_NetMask[i] = Convert.ToString(achtStellen[btnRange - i]);
                    }

                    // ip array 1-32 wird in Buttons 1-32 eingefügt    
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
                cidrValue = cidr; // cidr als variable überflüssig? -------------------------------------------------------->

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
                    // --- Ausgabe Textboxen ---
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
