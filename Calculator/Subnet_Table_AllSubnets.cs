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
        //original
        public string[] array32_IP_Sub_NetID = new string[33]; // come in
        public int hostnumber; // come in
        public int SubnetNumber; // come in
        public int CIDR; // come in

        string eightBitOneIP, eightBitTwoIP, eightBitThreeIP, eightBitFourIP;

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
            eightBitOneIP = ""; eightBitTwoIP = ""; eightBitThreeIP = ""; eightBitFourIP = "";
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
            string binaryNetIDnew = "";
            string binaryHostOne = "";
            string binaryHostLast = "";
            string binaryNetID = "";
            string binaryBC = "";
            string one = "1";
            string two = "10";
            int resultHostOne;
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
                binaryNetID += array32_IP_Sub_NetID[i];
            }
            //-------------------------------------------------------------------------------------------------------------------------
            int resultNetID = Convert.ToInt32(hostNumber, 2) + Convert.ToInt32(binaryNetID, 2);

            resultHostOne = Convert.ToInt32(binaryNetID, 2) + Convert.ToInt32(one, 2) + Convert.ToInt32(hostNumber, 2);

            int ergebnisHostLast = Convert.ToInt32(binaryNetID, 2) + Convert.ToInt32(hostNumberBC, 2) - Convert.ToInt32(two, 2); // count starts with 1 !
            int ergebnisBC = Convert.ToInt32(binaryNetID, 2) + Convert.ToInt32(hostNumberBC, 2) - Convert.ToInt32(one, 2);

            binaryNetIDnew = Convert.ToString(Convert.ToInt32(resultNetID), 2);
            binaryHostOne = Convert.ToString(Convert.ToInt32(resultHostOne), 2);
            binaryHostLast = Convert.ToString(Convert.ToInt32(ergebnisHostLast), 2);
            binaryBC = Convert.ToString(Convert.ToInt32(ergebnisBC), 2);

            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            //umwandeln - kann man den string direkt drehen und umwandlung in char überflüssig ? string als array behandeln...
            char[] newBinaryNetIDnew = binaryNetIDnew.ToCharArray();
            char[] newBinaryHostOne = binaryHostOne.ToCharArray();
            char[] newBinaryHostLast = binaryHostLast.ToCharArray();
            char[] newBinaryBC = binaryBC.ToCharArray();
            Array.Reverse(newBinaryNetIDnew);
            Array.Reverse(newBinaryHostOne);
            Array.Reverse(newBinaryHostLast);
            Array.Reverse(newBinaryBC);

            for (int i = 1; i < 33; i++) // set all to zero
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
        private void DualToDecStartIPHostOne(object sender, EventArgs e)
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
                        eightBitOneIP = "0"; // String chain 8-bit (8-Stellen)
                        eightBitTwoIP = "0";
                        eightBitThreeIP = "0";
                        eightBitFourIP = "0";

                        for (int i = 1; i < 9; i++)
                        {
                            eightBitOneIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] = Convert.ToString(Convert.ToInt64(eightBitOneIP, 2));
                        for (int i = 9; i < 17; i++)
                        {
                            eightBitTwoIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] += "." + Convert.ToString(Convert.ToInt64(eightBitTwoIP, 2));
                        for (int i = 17; i < 25; i++)
                        {
                            eightBitThreeIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] += "." + Convert.ToString(Convert.ToInt64(eightBitThreeIP, 2));
                        for (int i = 25; i < 33; i++)
                        {
                            eightBitFourIP += NetIDHost1HostLBC[b, i];
                        }
                        HelpNetIDHost1HostLBC[b] += "." + Convert.ToString(Convert.ToInt64(eightBitFourIP, 2));
                    }

                    dataGridView1.Rows.Add(Convert.ToString(a + 1), HelpNetIDHost1HostLBC[0], HelpNetIDHost1HostLBC[1], HelpNetIDHost1HostLBC[2], HelpNetIDHost1HostLBC[3]);
                }
            }

        }
    }
}
