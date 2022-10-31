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
    public partial class Subnet_Table_Count : UserControl
    {        
        public int CIDR; // come in
        public int SubnetNumber;
        public int HostnumberForTable; // get out
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
        public Subnet_Table_Count()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            textBoxSubnetNumber.Text = "0";
            textBoxSubnetNumberIP.Text = "0";
            textBoxsubnetNumberHost.Text = "0";            
            CIDR = 0;
            SubnetNumber = 0;
            HostnumberForTable = 0;
            dataGridView2.Rows.Clear();
        }
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Field SubnetNumber Text Changed")]
        public event EventHandler Text_Changed;

        protected void Text_Change(object sender, EventArgs e)
        {
            if (this.Text_Changed != null)
                this.Text_Changed(this, e);
        }
        private void Table(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxSubnetNumber.BackColor = Color.White;
            try
            {
                if (CIDR >= 30)
                {
                    textBoxSubnetNumber.Text = "zu wenig IPs"; 
                    textBoxSubnetNumberIP.Text = "0";
                    textBoxsubnetNumberHost.Text = "0";
                }
                else if (Convert.ToInt32(textBoxSubnetNumber.Text) < 1)
                {
                    //do not delete cidr 
                    HostnumberForTable = 0;
                    textBoxSubnetNumber.Text = "0";
                    textBoxSubnetNumberIP.Text = "0";
                    textBoxsubnetNumberHost.Text = "0";
                    dataGridView2.Rows.Clear();
                }
                else
                {
                    double result = 0;

                    int bits = 32 - CIDR;
                    double IPHostNumber = Math.Pow(2, bits);
                    int MaxIP = Convert.ToInt32(IPHostNumber) / 4;

                    int inputSubnetNumber = Convert.ToInt32(textBoxSubnetNumber.Text);

                    if (inputSubnetNumber <= MaxIP)
                    {
                        for (int i = 1; i < bits - 1; i++)
                        {
                            double helpHosts = Math.Pow(2, i);
                            if (inputSubnetNumber <= helpHosts)
                            {
                                result = IPHostNumber / helpHosts;
                                SubnetNumber = Convert.ToInt32(helpHosts);
                                HostnumberForTable = Convert.ToInt32(result);
                                textBoxSubnetNumberIP.Text = Convert.ToString(result);
                                textBoxsubnetNumberHost.Text = Convert.ToString(result - 2);//new
                                break;
                            }
                        }
                    }
                    else
                    {
                        textBoxSubnetNumber.BackColor = Color.Red;
                        textBoxSubnetNumberIP.Text = "to high";
                        textBoxsubnetNumberHost.Text = "to high";
                    }
                    //-----------------------------------------------------------
                    //Datagridview
                    string[,] bitsSubNetze = new string[bits - 2, 2];

                    int count = 1;
                    for (int i = 0; i < bits - 2; i++)
                    {
                        bitsSubNetze[i, 0] = Convert.ToString(count);
                        bitsSubNetze[i, 1] = Convert.ToString(Math.Pow(2, count));
                        count++;
                    }

                    // Output
                    for (int i = 0; i < bits - 2; i++)
                    {
                        dataGridView2.Rows.Add(bitsSubNetze[i, 0], bitsSubNetze[i, 1]);
                    }

                    // InputbeNumberSubnet 
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToInt32(textBoxSubnetNumber.Text) < Convert.ToInt32(row.Cells[1].Value) || Convert.ToInt32(textBoxSubnetNumber.Text) == Convert.ToInt32(row.Cells[1].Value))
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only Numbers!");
            }
        }
    }
}
