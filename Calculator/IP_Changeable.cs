﻿using System;
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
    public partial class IP_Changeable : UserControl
    {
        public string[] array32_IP; // = new string[33];
        public string[] ValueArray // Eigenschaft - property
        {
            get { return array32_IP; }
            set { array32_IP[32] = value[32]; }
        }
        public List<Button> _theList_btn = new List<Button>();
        string eightBitOneIP, eightBitTwoIP, eightBitThreeIP, eightBitFourIP;
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
        public IP_Changeable()
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
            eightBitOneIP = "0"; eightBitTwoIP = "0"; eightBitThreeIP = "0"; eightBitFourIP = "0";

            for (int i = 1; i < 33; i++) 
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
        public void AvoidWrongInput(object sender, KeyPressEventArgs e)
        {
            if (!"0123456789".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void DecToDualIP(object sender, EventArgs e)
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

                    for (int i = 1; i < array32_IP.Length; i++)  
                    {
                        if (array32_IP[i] == null)
                        {
                            array32_IP[i] += "0";
                        }
                    }
                    // input change, turn and insert Buttons 
                    string hlp = Convert.ToString(Convert.ToInt32(txb.Text), 2);

                    char[] btnx = hlp.ToCharArray();

                    char[] achtStellen = new char[8];
                    Array.Reverse(btnx);


                    // fill Array with zero - stand in the front
                    for (int i = 0; i < btnx.Length; i++)
                    {
                        achtStellen[i] = btnx[i];
                    }

                    for (int i = btnx.Length; i < 8; i++)
                    {
                        achtStellen[i] = '0'; // fill
                    }

                    // compare with all button array 
                    int btnRange = Convert.ToInt32(txb.Tag) * 8; // 1-32 possible 

                    for (int i = btnRange; i > btnRange - 8; i--)
                    {
                        array32_IP[i] = Convert.ToString(achtStellen[btnRange - i]);
                    }

                    // ip array 1-32 insert to Buttons 1-32     
                    int count = 1;

                    foreach (Button button in _theList_btn)
                    {                       
                        button.Text = array32_IP[count];

                        count++;
                    }                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers");
            }
        }
        private void RegisterHumanInput(object sender)
        {
            Button btn = (Button)sender;
            if (btn.Text == "0")
            {
                btn.Text = "1";
                array32_IP[Convert.ToInt32(btn.Tag)] = "1";
            }
            else
            {
                btn.Text = "0";
                array32_IP[Convert.ToInt32(btn.Tag)] = "0";
            }
        }
        private void DualToDecStartIP(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            eightBitOneIP = "0"; // String chain 8-bit (8-Stellen)
            eightBitTwoIP = "0";
            eightBitThreeIP = "0";
            eightBitFourIP = "0";
            RegisterHumanInput(sender);

            // fill arry 
            for (int i = 1; i < array32_IP.Length; i++)
            {
                if (array32_IP[i] == null)
                {
                    array32_IP[i] += "0";
                }
            }
            // int btnRange =  8; // 1-32 possible 
            int btnTag = Convert.ToInt32(btn.Tag);

            if (btnTag > 0 && btnTag < 9)
            {
                for (int i = 1; i < 9; i++)
                {
                    eightBitOneIP += array32_IP[i];
                }
                textBoxIP1.Text = Convert.ToString(Convert.ToInt64(eightBitOneIP, 2));
            }
            else if (btnTag > 8 && btnTag < 17)
            {
                for (int i = 9; i < 17; i++)
                {
                    eightBitTwoIP += array32_IP[i];
                }
                textBoxIP2.Text = Convert.ToString(Convert.ToInt64(eightBitTwoIP, 2));
            }
            else if (btnTag > 16 && btnTag < 25)
            {
                for (int i = 17; i < 25; i++)
                {
                    eightBitThreeIP += array32_IP[i];
                }
                textBoxIP3.Text = Convert.ToString(Convert.ToInt64(eightBitThreeIP, 2));
            }
            else if (btnTag > 24 && btnTag < 33)
            {
                for (int i = 25; i < 33; i++)
                {
                    eightBitFourIP += array32_IP[i];
                }
                textBoxIP4.Text = Convert.ToString(Convert.ToInt64(eightBitFourIP, 2));
            }
        }
    }
}
