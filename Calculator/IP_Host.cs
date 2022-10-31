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
    public partial class IP_Host : UserControl
    {
        string achtBitEinsIP, achtBitZweiIP, achtBitDreiIP, achtBitVierIP;
        private bool clearAll;
        public int CIDR;
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
        public IP_Host()
        {
            InitializeComponent();
            array32_HostOne_NetID = new string[33];
            array32_HostLast_BC = new string[33];
        }

        public string[] array32_HostOne_NetID;
        public string[] array32_HostLast_BC;
        private void Clear()
        {
            achtBitEinsIP = "0"; achtBitZweiIP = "0"; achtBitDreiIP = "0"; achtBitVierIP = "0";

            for (int i = 1; i < 33; i++) // mit 0 auffüllen
            {
                array32_HostOne_NetID[i] = "0";
                array32_HostLast_BC[i] = "0";
            }
            textBoxHostOne1.Text = "0";
            textBoxHostOne2.Text = "0";
            textBoxHostOne3.Text = "0";
            textBoxHostOne4.Text = "0";

            textBoxHostLast1.Text = "0";
            textBoxHostLast2.Text = "0";
            textBoxHostLast3.Text = "0";
            textBoxHostLast4.Text = "0";

            CIDR = 0;
        }
        public string[] ValueArrayNetID // Eigenschaft - property
        {
            get { return array32_HostOne_NetID; }
            set { array32_HostOne_NetID[32] = value[32]; }
        }
        public string[] ValueArrayBC // Eigenschaft - property
        {
            get { return array32_HostLast_BC; }
            set { array32_HostLast_BC[32] = value[32]; }
        }
        public void Addition(object sender, EventArgs e)
        {
            string binarHostOne = "";
            string binarHostLast = "";
            string one = "1";
            for (int i = 1; i < 33; i++)
            {
                binarHostOne += array32_HostOne_NetID[i];
                binarHostLast += array32_HostLast_BC[i];
            }

            int ergebnisHostOne = Convert.ToInt32(binarHostOne, 2) + Convert.ToInt32(one, 2);
            int ergebnisHostLast = Convert.ToInt32(binarHostLast, 2) - Convert.ToInt32(one, 2);

            binarHostOne = Convert.ToString(Convert.ToInt32(ergebnisHostOne), 2);
            binarHostLast = Convert.ToString(Convert.ToInt32(ergebnisHostLast), 2);

            char[] newBinaryHostOne = binarHostOne.ToCharArray();
            char[] newBinaryHostLast = binarHostLast.ToCharArray();
            Array.Reverse(newBinaryHostOne);
            Array.Reverse(newBinaryHostLast);

            for (int i = 1; i < 33; i++) // alles auf null setzen
            {
                array32_HostOne_NetID[i] = "0";
                array32_HostLast_BC[i] = "0";
            }

            int RangeNumber = 32;
            for (int i = 32; i > RangeNumber - newBinaryHostOne.Length; i--)
            {
                array32_HostOne_NetID[i] = Convert.ToString(newBinaryHostOne[RangeNumber - i]);
                array32_HostLast_BC[i] = Convert.ToString(newBinaryHostLast[RangeNumber - i]);
            }
        }
        private void dualToDecStartIPHostOne(object sender, EventArgs e)
        {
            if (CIDR > 30)
            {
                Clear();
                textBoxHostOne1.Text = "keine Hosts";
                textBoxHostLast1.Text = "keine Hosts";
            }
            else
            {
                Addition(sender, e);

                Button btn = (Button)sender;
                achtBitEinsIP = "0"; // zusammengesetzter String achtbit (8-Stellen)
                achtBitZweiIP = "0";
                achtBitDreiIP = "0";
                achtBitVierIP = "0";

                //----------------------    Host One
                for (int i = 1; i < 9; i++)
                {
                    achtBitEinsIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne1.Text = Convert.ToString(Convert.ToInt64(achtBitEinsIP, 2));
                for (int i = 9; i < 17; i++)
                {
                    achtBitZweiIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne2.Text = Convert.ToString(Convert.ToInt64(achtBitZweiIP, 2));
                for (int i = 17; i < 25; i++)
                {
                    achtBitDreiIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne3.Text = Convert.ToString(Convert.ToInt64(achtBitDreiIP, 2));
                for (int i = 25; i < 33; i++)
                {
                    achtBitVierIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne4.Text = Convert.ToString(Convert.ToInt64(achtBitVierIP, 2));

                // -------------------------    Host last
                achtBitEinsIP = "0"; // zusammengesetzter String achtbit (8-Stellen)
                achtBitZweiIP = "0";
                achtBitDreiIP = "0";
                achtBitVierIP = "0";

                for (int i = 1; i < 9; i++)
                {
                    achtBitEinsIP += array32_HostLast_BC[i];
                }
                textBoxHostLast1.Text = Convert.ToString(Convert.ToInt64(achtBitEinsIP, 2));
                for (int i = 9; i < 17; i++)
                {
                    achtBitZweiIP += array32_HostLast_BC[i];
                }
                textBoxHostLast2.Text = Convert.ToString(Convert.ToInt64(achtBitZweiIP, 2));
                for (int i = 17; i < 25; i++)
                {
                    achtBitDreiIP += array32_HostLast_BC[i];
                }
                textBoxHostLast3.Text = Convert.ToString(Convert.ToInt64(achtBitDreiIP, 2));
                for (int i = 25; i < 33; i++)
                {
                    achtBitVierIP += array32_HostLast_BC[i];
                }
                textBoxHostLast4.Text = Convert.ToString(Convert.ToInt64(achtBitVierIP, 2));
            }

        }
    }
}
