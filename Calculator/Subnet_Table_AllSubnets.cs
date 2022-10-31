using System;
using System.Collections;
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
    public partial class Subnet_Table_AllSubnets : UserControl
    {
        //ori
        public string[] array32_IP_Sub_NetID = new string[33]; // come in
        public int hostnumber; // come in
        public int SubnetNumber; // come in
        public int CIDR; // come in

        string achtBitEinsIP, achtBitZweiIP, achtBitDreiIP, achtBitVierIP;

        string[,] NetIDHost1HostLBC = new string[4, 33];
        string[] HelpNetIDHost1HostLBC = new string[4];

        public int count = 0;
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

        public Subnet_Table_AllSubnets()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            HelpNetIDHost1HostLBC[0] = "";
            HelpNetIDHost1HostLBC[1] = "";
            HelpNetIDHost1HostLBC[2] = "";
            HelpNetIDHost1HostLBC[3] = "";
            achtBitEinsIP = ""; achtBitZweiIP = ""; achtBitDreiIP = ""; achtBitVierIP = "";
            count = 0;
            for (int i = 0; i < 33; i++)
            {
                NetIDHost1HostLBC[0, i] = "";
                NetIDHost1HostLBC[1, i] = "";
                NetIDHost1HostLBC[2, i] = "";
                NetIDHost1HostLBC[3, i] = "";
            }
            dataGridView1.Rows.Clear();
        }
        private int Addition2(ref int count)
        {
            int hostNumberint;
            string hostNumber;
            string binarNetIDnew = "";
            string binarHostOne = "";
            string binarHostLast = "";
            string binarNetID = "";
            string binarBC = "";
            string one = "1";
            string two = "10";
            int ergebnisHostOne;
            //-------------------------------------
            int countBC = count + 1;
            int hostNumberintBC = 0;

            //-------------------------------------

            hostNumberint = hostnumber * count;
            hostNumberintBC = hostnumber * countBC;

            hostNumber = Convert.ToString(Convert.ToInt32(hostNumberint), 2);
            string hostNumberBC = Convert.ToString(Convert.ToInt32(hostNumberintBC), 2);

            for (int i = 1; i < 33; i++) //stay

            {
                binarNetID += array32_IP_Sub_NetID[i];
            }
            //-------------------------------------------------------------------------------------------------------------------------
            int ergebnisNetID = Convert.ToInt32(hostNumber, 2) + Convert.ToInt32(binarNetID, 2);

            ergebnisHostOne = Convert.ToInt32(binarNetID, 2) + Convert.ToInt32(one, 2) + Convert.ToInt32(hostNumber, 2);

            int ergebnisHostLast = Convert.ToInt32(binarNetID, 2) + Convert.ToInt32(hostNumberBC, 2) - Convert.ToInt32(two, 2); // drauf ausgelegt das count mit 1 beginnt
            int ergebnisBC = Convert.ToInt32(binarNetID, 2) + Convert.ToInt32(hostNumberBC, 2) - Convert.ToInt32(one, 2);

            binarNetIDnew = Convert.ToString(Convert.ToInt32(ergebnisNetID), 2);
            binarHostOne = Convert.ToString(Convert.ToInt32(ergebnisHostOne), 2);
            binarHostLast = Convert.ToString(Convert.ToInt32(ergebnisHostLast), 2);
            binarBC = Convert.ToString(Convert.ToInt32(ergebnisBC), 2);

            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            //umwandeln - kann man den string direkt drehen und umwandlung in char überflüssig ? string als array behandeln...
            char[] newBinaryNetIDnew = binarNetIDnew.ToCharArray();
            char[] newBinaryHostOne = binarHostOne.ToCharArray();
            char[] newBinaryHostLast = binarHostLast.ToCharArray();
            char[] newBinaryBC = binarBC.ToCharArray();
            Array.Reverse(newBinaryNetIDnew);
            Array.Reverse(newBinaryHostOne);
            Array.Reverse(newBinaryHostLast);
            Array.Reverse(newBinaryBC);

            for (int i = 1; i < 33; i++) // alles auf null setzen
            {
                NetIDHost1HostLBC[0, i] = "0";
                NetIDHost1HostLBC[1, i] = "0";
                NetIDHost1HostLBC[2, i] = "0";
                NetIDHost1HostLBC[3, i] = "0";
            }

            int RangeNumber = 32;
            for (int i = 32; i > RangeNumber - newBinaryHostOne.Length; i--)
            {
                NetIDHost1HostLBC[0, i] = Convert.ToString(newBinaryNetIDnew[RangeNumber - i]);
                NetIDHost1HostLBC[1, i] = Convert.ToString(newBinaryHostOne[RangeNumber - i]);
                NetIDHost1HostLBC[2, i] = Convert.ToString(newBinaryHostLast[RangeNumber - i]);
                NetIDHost1HostLBC[3, i] = Convert.ToString(newBinaryBC[RangeNumber - i]);
            }
            return count;
        }
        private void dualToDecStartIPHostOne(object sender, EventArgs e)
        {
            Clear();
            if (CIDR >= 30)
            {
                Clear();
            }
            else if (hostnumber == 0)
            {
                Clear();
            }
            else
            {
                for (int a = 0; a < SubnetNumber; a++)
                {
                    Addition2(ref count);
                    count++;
                    Button btn = (Button)sender;

                    for (int b = 0; b < 4; b++)
                    {
                        achtBitEinsIP = "0"; // zusammengesetzter String achtbit (8-Stellen)
                        achtBitZweiIP = "0";
                        achtBitDreiIP = "0";
                        achtBitVierIP = "0";

                        for (int i = 1; i < 9; i++)
                        {
                            achtBitEinsIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] = Convert.ToString(Convert.ToInt64(achtBitEinsIP, 2));
                        for (int i = 9; i < 17; i++)
                        {
                            achtBitZweiIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] += "." + Convert.ToString(Convert.ToInt64(achtBitZweiIP, 2));
                        for (int i = 17; i < 25; i++)
                        {
                            achtBitDreiIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] += "." + Convert.ToString(Convert.ToInt64(achtBitDreiIP, 2));
                        for (int i = 25; i < 33; i++)
                        {
                            achtBitVierIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] += "." + Convert.ToString(Convert.ToInt64(achtBitVierIP, 2));
                    }

                    dataGridView1.Rows.Add(Convert.ToString(a + 1), HelpNetIDHost1HostLBC[0], HelpNetIDHost1HostLBC[1], HelpNetIDHost1HostLBC[2], HelpNetIDHost1HostLBC[3]);
                }
            }

        }
    }
}
