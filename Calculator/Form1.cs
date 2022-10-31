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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Show();
        }
        private void NetID(object sender, EventArgs e)
        {
            for (int i = 1; i < iP_NoChangeNetID.ValueArray.Length; i++) // mit 0 auffüllen
            {
                if (iP_NoChangeNetID.ValueArray[i] == null)
                {
                    iP_NoChangeNetID.ValueArray[i] += "0";
                }
            }
            for (int i = 1; i < iP_Changeable1.ValueArray.Length; i++)
            {
                if (iP_Changeable1.ValueArray[i] == "1" && iP_NetMask1.ValueArray[i] == "1")
                {
                    iP_NetMask1._theList_btn[i - 1].BackColor = Color.Green;
                    iP_Changeable1._theList_btn[i - 1].BackColor = Color.Green;
                    iP_NoChangeNetID.ValueArray[i] = "1";
                    iP_NoChangeNetID._theList_btn[i - 1].Text = "1";
                }
                else
                {
                    iP_NetMask1._theList_btn[i - 1].BackColor = Color.Red;
                    iP_Changeable1._theList_btn[i - 1].BackColor = Color.Red;
                    iP_NoChangeNetID.ValueArray[i] = "0";
                    iP_NoChangeNetID._theList_btn[i - 1].Text = "0";
                }
            }
            // info für AllSubnets
            for (int i = 1; i < 33; i++) // füllt den rest mit NetID auf
            {
                subnet_Table_AllSubnets1.array32_IP_Sub_NetID[i] = iP_NoChangeNetID.ValueArray[i];
            }
        }
        private void MasketoBroadcast(object sender, EventArgs e)
        {
            // netmask1.CIDR

            for (int i = 32; i > iP_NetMask1.CIDR; i--) // füllt array von hinten mit einsen
            {
                iP_NoChangeBC.ValueArray[i] = "1";
                iP_NoChangeBC._theList_btn[i - 1].Text = "1";
            }

            for (int i = iP_NetMask1.CIDR; i > 0; i--) // füllt den rest mit NetID auf
            {
                iP_NoChangeBC.ValueArray[i] = iP_NoChangeNetID.ValueArray[i];
                iP_NoChangeBC._theList_btn[i - 1].Text = iP_NoChangeNetID.ValueArray[i];
            }

            // ------------------------------------------Buttons--------------------------------
            int count = 1;
            foreach (Button button in iP_NoChangeBC._theList_btn)
            {               
                button.Text = iP_NoChangeBC.ValueArray[count];

                count++;
            }
            // ------------------------------------------Color Buttons--------------------------------
            count = 1;
            foreach (Button button in iP_NoChangeBC._theList_btn)
            {
                button.BackColor = Color.LightGray; // clear Color to default
                count++;
            }
            // show how to get BC Address
            for (int i = iP_NetMask1.CIDR + 1; i < iP_NoChangeBC.ValueArray.Length; i++)
            {
                iP_NoChangeBC._theList_btn[i - 1].BackColor = Color.Orange;
                iP_NoChangeNetID._theList_btn[i - 1].BackColor = Color.Orange;
            }
            for (int i = 1; i < iP_NetMask1.CIDR + 1; i++)
            {
                iP_NoChangeNetID._theList_btn[i - 1].BackColor = Color.LightBlue;
            }

            iP_NetMask1._theList_textBox[0].BackColor = Color.LightBlue;

            // Übergabe an Userelement Hosts
            for (int i = 1; i < 33; i++) // füllt den rest mit NetID auf
            {
                iP_HostMain.ValueArrayNetID[i] = iP_NoChangeNetID.ValueArray[i];
                iP_HostMain.ValueArrayBC[i] = iP_NoChangeBC.ValueArray[i];
            }         
            iP_HostMain.CIDR = iP_NetMask1.CIDR;
            CalculateNumberSubnet_h();
            subnet_Table_Count1.Enabled = true;
        }       
        private void CalculateNumberSubnet_h()
        {
            subnet_Table_Count1.CIDR = iP_NetMask1.CIDR;
        }
        private void AllSubnets(object sender, EventArgs e)
        {            
            subnet_Table_AllSubnets1.hostnumber = subnet_Table_Count1.HostnumberForTable; //256 müsste 64
            subnet_Table_AllSubnets1.SubnetNumber = subnet_Table_Count1.SubnetNumber;
            subnet_Table_AllSubnets1.CIDR = iP_NetMask1.CIDR;   
        }
        private void Clear(object sender, EventArgs e)
        {
            iP_Changeable1.ClearAll = true;
            iP_NoChangeNetID.ClearAll = true;
            iP_NoChangeBC.ClearAll = true;
            iP_NetMask1.ClearAll = true;
            iP_HostMain.ClearAll = true;
            subnet_Table_Count1.ClearAll = true;
            subnet_Table_AllSubnets1.ClearAll = true;
            for (int i = 1; i < iP_NoChangeNetID.ValueArray.Length; i++) // mit 0 auffüllen
            {
                iP_NetMask1._theList_btn[i - 1].BackColor = Color.LightGray;
                iP_Changeable1._theList_btn[i - 1].BackColor = Color.LightGray;
                iP_NoChangeBC._theList_btn[i - 1].BackColor = Color.LightGray;
                iP_NoChangeNetID._theList_btn[i - 1].BackColor = Color.LightGray;
            }
        }
        private void Texte(object sender, EventArgs e)
        {
            DescriptionLearn descriptionLearn = new DescriptionLearn();

            textBoxNetID.Text = descriptionLearn.TextNetID;
            textBoxCIDR.Text = descriptionLearn.CIDR;
            textBoxHost.Text = descriptionLearn.Host;
            textBoxSubnet.Text = descriptionLearn.Subnet;
        }        
    }
}
