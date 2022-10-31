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
        // public double HostsAnzahl; 
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
            textBoxSubnetzAnzahl.Text = "0";
            textBoxsubnetzAnzahlIP.Text = "0";
            textBoxsubnetzAnzahlHost.Text = "0";            
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
        private void Tabelle2(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBoxSubnetzAnzahl.BackColor = Color.White;
            try
            {
                if (CIDR >= 30)
                {
                    textBoxSubnetzAnzahl.Text = "zu wenig IPs"; // letzte tabelle geht noch
                    textBoxsubnetzAnzahlIP.Text = "0";
                    textBoxsubnetzAnzahlHost.Text = "0";
                }
                else if (Convert.ToInt32(textBoxSubnetzAnzahl.Text) < 1)
                {
                    //cidr darf nicht gelöscht werden
                    HostnumberForTable = 0;
                    textBoxSubnetzAnzahl.Text = "0";
                    textBoxsubnetzAnzahlIP.Text = "0";
                    textBoxsubnetzAnzahlHost.Text = "0";
                    dataGridView2.Rows.Clear();
                }
                else
                {
                    double ergebnis = 0;

                    int bits = 32 - CIDR;
                    double IPHostAnzahl = Math.Pow(2, bits);
                    int MaxIP = Convert.ToInt32(IPHostAnzahl) / 4;

                    int eingabeSubnetnumber = Convert.ToInt32(textBoxSubnetzAnzahl.Text);

                    if (eingabeSubnetnumber <= MaxIP)
                    {
                        for (int i = 1; i < bits - 1; i++)
                        {
                            double helpHosts = Math.Pow(2, i);
                            if (eingabeSubnetnumber <= helpHosts)
                            {
                                ergebnis = IPHostAnzahl / helpHosts;
                                SubnetNumber = Convert.ToInt32(helpHosts);
                                HostnumberForTable = Convert.ToInt32(ergebnis);
                                textBoxsubnetzAnzahlIP.Text = Convert.ToString(ergebnis);
                                textBoxsubnetzAnzahlHost.Text = Convert.ToString(ergebnis - 2);//new
                                break;
                            }
                        }
                    }
                    else
                    {
                        textBoxSubnetzAnzahl.BackColor = Color.Red;
                        textBoxsubnetzAnzahlIP.Text = "to high";
                        textBoxsubnetzAnzahlHost.Text = "to high";
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

                    // Ausgabe
                    for (int i = 0; i < bits - 2; i++)
                    {
                        dataGridView2.Rows.Add(bitsSubNetze[i, 0], bitsSubNetze[i, 1]);
                    }

                    // EingabeAnzahlSubnetze 
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToInt32(textBoxSubnetzAnzahl.Text) < Convert.ToInt32(row.Cells[1].Value) || Convert.ToInt32(textBoxSubnetzAnzahl.Text) == Convert.ToInt32(row.Cells[1].Value))
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
