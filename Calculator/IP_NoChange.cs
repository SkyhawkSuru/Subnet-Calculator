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
    public partial class IP_NoChange : UserControl
    {
        public List<Button> _theList_btn = new List<Button>();
        string achtBitEinsIP, achtBitZweiIP, achtBitDreiIP, achtBitVierIP;
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
        public IP_NoChange()
        {
            InitializeComponent();
            PopulateList();
            array32_IP = new string[33];
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
        }
        private void Clear()
        {
            achtBitEinsIP = "0"; achtBitZweiIP = "0"; achtBitDreiIP = "0"; achtBitVierIP = "0";

            for (int i = 1; i < 33; i++) // mit 0 auffüllen
            {
                array32_IP[i] = "0";
                ValueArray[i] = "0";
                _theList_btn[i - 1].Text = "0";
            }
            textBoxIP1.Text = "0";
            textBoxIP2.Text = "0";
            textBoxIP3.Text = "0";
            textBoxIP4.Text = "0";
        }

        private void dualToDecStartIP(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            achtBitEinsIP = "0"; // zusammengesetzter String achtbit (8-Stellen)
            achtBitZweiIP = "0";
            achtBitDreiIP = "0";
            achtBitVierIP = "0";

            for (int i = 1; i < 9; i++)
            {
                achtBitEinsIP += array32_IP[i];
            }
            textBoxIP1.Text = Convert.ToString(Convert.ToInt64(achtBitEinsIP, 2));


            for (int i = 9; i < 17; i++)
            {
                achtBitZweiIP += array32_IP[i];
            }
            textBoxIP2.Text = Convert.ToString(Convert.ToInt64(achtBitZweiIP, 2));

            for (int i = 17; i < 25; i++)
            {
                achtBitDreiIP += array32_IP[i];
            }
            textBoxIP3.Text = Convert.ToString(Convert.ToInt64(achtBitDreiIP, 2));

            for (int i = 25; i < 33; i++)
            {
                achtBitVierIP += array32_IP[i];
            }
            textBoxIP4.Text = Convert.ToString(Convert.ToInt64(achtBitVierIP, 2));
        }

        private string[] array32_IP; // = new string[33];

        public string[] ValueArray // Eigenschaft - property
        {
            get { return array32_IP; }
            set { array32_IP[32] = value[32]; }
        }
    }
}
