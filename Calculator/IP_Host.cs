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
        string eightBitOneIP, eightBitTwoIP, eightBitThreeIP, eightBitFourIP;
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
            eightBitOneIP = "0"; eightBitTwoIP = "0"; eightBitThreeIP = "0"; eightBitFourIP = "0";

            for (int i = 1; i < 33; i++) // fill with "0" 
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
            string binaryHostOne = "";
            string binaryHostLast = "";
            string one = "1";
            for (int i = 1; i < 33; i++)
            {
                binaryHostOne += array32_HostOne_NetID[i];
                binaryHostLast += array32_HostLast_BC[i];
            }

            int ergebnisHostOne = Convert.ToInt32(binaryHostOne, 2) + Convert.ToInt32(one, 2);
            int ergebnisHostLast = Convert.ToInt32(binaryHostLast, 2) - Convert.ToInt32(one, 2);

            binaryHostOne = Convert.ToString(Convert.ToInt32(ergebnisHostOne), 2);
            binaryHostLast = Convert.ToString(Convert.ToInt32(ergebnisHostLast), 2);

            char[] newBinaryHostOne = binaryHostOne.ToCharArray();
            char[] newBinaryHostLast = binaryHostLast.ToCharArray();
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
        private void DualToDecStartIPHostOne(object sender, EventArgs e)
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
                eightBitOneIP = "0"; // zusammengesetzter String achtbit (8-Stellen)
                eightBitTwoIP = "0";
                eightBitThreeIP = "0";
                eightBitFourIP = "0";

                //----------------------    Host One
                for (int i = 1; i < 9; i++)
                {
                    eightBitOneIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne1.Text = Convert.ToString(Convert.ToInt64(eightBitOneIP, 2));
                for (int i = 9; i < 17; i++)
                {
                    eightBitTwoIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne2.Text = Convert.ToString(Convert.ToInt64(eightBitTwoIP, 2));
                for (int i = 17; i < 25; i++)
                {
                    eightBitThreeIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne3.Text = Convert.ToString(Convert.ToInt64(eightBitThreeIP, 2));
                for (int i = 25; i < 33; i++)
                {
                    eightBitFourIP += array32_HostOne_NetID[i];
                }
                textBoxHostOne4.Text = Convert.ToString(Convert.ToInt64(eightBitFourIP, 2));

                // -------------------------    Host last
                eightBitOneIP = "0"; // zusammengesetzter String achtbit (8-Stellen)
                eightBitTwoIP = "0";
                eightBitThreeIP = "0";
                eightBitFourIP = "0";

                for (int i = 1; i < 9; i++)
                {
                    eightBitOneIP += array32_HostLast_BC[i];
                }
                textBoxHostLast1.Text = Convert.ToString(Convert.ToInt64(eightBitOneIP, 2));
                for (int i = 9; i < 17; i++)
                {
                    eightBitTwoIP += array32_HostLast_BC[i];
                }
                textBoxHostLast2.Text = Convert.ToString(Convert.ToInt64(eightBitTwoIP, 2));
                for (int i = 17; i < 25; i++)
                {
                    eightBitThreeIP += array32_HostLast_BC[i];
                }
                textBoxHostLast3.Text = Convert.ToString(Convert.ToInt64(eightBitThreeIP, 2));
                for (int i = 25; i < 33; i++)
                {
                    eightBitFourIP += array32_HostLast_BC[i];
                }
                textBoxHostLast4.Text = Convert.ToString(Convert.ToInt64(eightBitFourIP, 2));
            }

        }
    }
}
