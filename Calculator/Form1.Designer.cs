
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxSubnet = new System.Windows.Forms.TextBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxCIDR = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxNetID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_NetID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_B2 = new System.Windows.Forms.Label();
            this.lbl_Netmask = new System.Windows.Forms.Label();
            this.lbl_B1 = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.subnet_Table_AllSubnets1 = new Calculator.Subnet_Table_AllSubnets();
            this.subnet_Table_Count1 = new Calculator.Subnet_Table_Count();
            this.iP_HostMain = new Calculator.IP_Host();
            this.iP_NoChangeBC = new Calculator.IP_NoChange();
            this.iP_NoChangeNetID = new Calculator.IP_NoChange();
            this.iP_NetMask1 = new Calculator.IP_NetMask();
            this.iP_Changeable1 = new Calculator.IP_Changeable();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-5, -62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Subnetz Rechner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Letzter Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "1.Host";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculator.Properties.Resources.bits;
            this.pictureBox2.Location = new System.Drawing.Point(74, 423);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(736, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxSubnet
            // 
            this.textBoxSubnet.Location = new System.Drawing.Point(74, 479);
            this.textBoxSubnet.Multiline = true;
            this.textBoxSubnet.Name = "textBoxSubnet";
            this.textBoxSubnet.ReadOnly = true;
            this.textBoxSubnet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSubnet.Size = new System.Drawing.Size(736, 48);
            this.textBoxSubnet.TabIndex = 71;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(1003, 324);
            this.textBoxHost.Multiline = true;
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.ReadOnly = true;
            this.textBoxHost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHost.Size = new System.Drawing.Size(210, 76);
            this.textBoxHost.TabIndex = 70;
            // 
            // textBoxCIDR
            // 
            this.textBoxCIDR.Location = new System.Drawing.Point(1003, 235);
            this.textBoxCIDR.Multiline = true;
            this.textBoxCIDR.Name = "textBoxCIDR";
            this.textBoxCIDR.ReadOnly = true;
            this.textBoxCIDR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCIDR.Size = new System.Drawing.Size(210, 62);
            this.textBoxCIDR.TabIndex = 69;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Calculator.Properties.Resources.binar;
            this.pictureBox3.Location = new System.Drawing.Point(74, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(736, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxNetID
            // 
            this.textBoxNetID.Location = new System.Drawing.Point(1003, 88);
            this.textBoxNetID.Multiline = true;
            this.textBoxNetID.Name = "textBoxNetID";
            this.textBoxNetID.ReadOnly = true;
            this.textBoxNetID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNetID.Size = new System.Drawing.Size(210, 103);
            this.textBoxNetID.TabIndex = 67;
            this.textBoxNetID.Text = "Klick Me";
            this.textBoxNetID.Click += new System.EventHandler(this.Texte);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 66;
            this.button2.Text = "Broadcast";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MasketoBroadcast);
            // 
            // btn_NetID
            // 
            this.btn_NetID.Location = new System.Drawing.Point(816, 235);
            this.btn_NetID.Name = "btn_NetID";
            this.btn_NetID.Size = new System.Drawing.Size(75, 23);
            this.btn_NetID.TabIndex = 65;
            this.btn_NetID.Text = "Net ID";
            this.btn_NetID.UseVisualStyleBackColor = true;
            this.btn_NetID.Click += new System.EventHandler(this.NetID);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "BC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Net ID";
            // 
            // lbl_B2
            // 
            this.lbl_B2.AutoSize = true;
            this.lbl_B2.Location = new System.Drawing.Point(7, 178);
            this.lbl_B2.Name = "lbl_B2";
            this.lbl_B2.Size = new System.Drawing.Size(31, 13);
            this.lbl_B2.TabIndex = 61;
            this.lbl_B2.Text = "Binär";
            // 
            // lbl_Netmask
            // 
            this.lbl_Netmask.AutoSize = true;
            this.lbl_Netmask.Location = new System.Drawing.Point(7, 154);
            this.lbl_Netmask.Name = "lbl_Netmask";
            this.lbl_Netmask.Size = new System.Drawing.Size(55, 13);
            this.lbl_Netmask.TabIndex = 60;
            this.lbl_Netmask.Text = "Netmaske";
            // 
            // lbl_B1
            // 
            this.lbl_B1.AutoSize = true;
            this.lbl_B1.Location = new System.Drawing.Point(7, 111);
            this.lbl_B1.Name = "lbl_B1";
            this.lbl_B1.Size = new System.Drawing.Size(31, 13);
            this.lbl_B1.TabIndex = 59;
            this.lbl_B1.Text = "Binär";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(7, 88);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(17, 13);
            this.lbl_IP.TabIndex = 58;
            this.lbl_IP.Text = "IP";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(736, 800);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 77;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Clear);
            // 
            // subnet_Table_AllSubnets1
            // 
            this.subnet_Table_AllSubnets1.ClearAll = false;
            this.subnet_Table_AllSubnets1.Location = new System.Drawing.Point(74, 668);
            this.subnet_Table_AllSubnets1.Name = "subnet_Table_AllSubnets1";
            this.subnet_Table_AllSubnets1.Size = new System.Drawing.Size(558, 185);
            this.subnet_Table_AllSubnets1.TabIndex = 76;
            // 
            // subnet_Table_Count1
            // 
            this.subnet_Table_Count1.ClearAll = false;
            this.subnet_Table_Count1.Enabled = false;
            this.subnet_Table_Count1.Location = new System.Drawing.Point(74, 533);
            this.subnet_Table_Count1.Name = "subnet_Table_Count1";
            this.subnet_Table_Count1.Size = new System.Drawing.Size(518, 129);
            this.subnet_Table_Count1.TabIndex = 64;
            this.subnet_Table_Count1.Text_Changed += new System.EventHandler(this.AllSubnets);
            // 
            // iP_HostMain
            // 
            this.iP_HostMain.ClearAll = false;
            this.iP_HostMain.Location = new System.Drawing.Point(74, 351);
            this.iP_HostMain.Name = "iP_HostMain";
            this.iP_HostMain.Size = new System.Drawing.Size(817, 66);
            this.iP_HostMain.TabIndex = 57;
            this.iP_HostMain.ValueArrayBC = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.iP_HostMain.ValueArrayNetID = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
          
            // 
            // iP_NoChangeBC
            // 
            this.iP_NoChangeBC.ClearAll = false;
            this.iP_NoChangeBC.Location = new System.Drawing.Point(74, 293);
            this.iP_NoChangeBC.Name = "iP_NoChangeBC";
            this.iP_NoChangeBC.Size = new System.Drawing.Size(736, 52);
            this.iP_NoChangeBC.TabIndex = 56;
            this.iP_NoChangeBC.ValueArray = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            // 
            // iP_NoChangeNetID
            // 
            this.iP_NoChangeNetID.ClearAll = false;
            this.iP_NoChangeNetID.Location = new System.Drawing.Point(74, 235);
            this.iP_NoChangeNetID.Name = "iP_NoChangeNetID";
            this.iP_NoChangeNetID.Size = new System.Drawing.Size(736, 52);
            this.iP_NoChangeNetID.TabIndex = 55;
            this.iP_NoChangeNetID.ValueArray = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            // 
            // iP_NetMask1
            // 
            this.iP_NetMask1.ClearAll = false;
            this.iP_NetMask1.Location = new System.Drawing.Point(74, 148);
            this.iP_NetMask1.Name = "iP_NetMask1";
            this.iP_NetMask1.Size = new System.Drawing.Size(929, 81);
            this.iP_NetMask1.TabIndex = 54;
            // 
            // iP_Changeable1
            // 
            this.iP_Changeable1.ClearAll = false;
            this.iP_Changeable1.Location = new System.Drawing.Point(74, 87);
            this.iP_Changeable1.Name = "iP_Changeable1";
            this.iP_Changeable1.Size = new System.Drawing.Size(737, 55);
            this.iP_Changeable1.TabIndex = 53;
            this.iP_Changeable1.ValueArray = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 861);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.subnet_Table_AllSubnets1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxSubnet);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.textBoxCIDR);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxNetID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_NetID);
            this.Controls.Add(this.subnet_Table_Count1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_B2);
            this.Controls.Add(this.lbl_Netmask);
            this.Controls.Add(this.lbl_B1);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.iP_HostMain);
            this.Controls.Add(this.iP_NoChangeBC);
            this.Controls.Add(this.iP_NoChangeNetID);
            this.Controls.Add(this.iP_NetMask1);
            this.Controls.Add(this.iP_Changeable1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SubnetCalc By SkyhawkSuru ~ Github";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxSubnet;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxCIDR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxNetID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_NetID;
        private Subnet_Table_Count subnet_Table_Count1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_B2;
        private System.Windows.Forms.Label lbl_Netmask;
        private System.Windows.Forms.Label lbl_B1;
        private System.Windows.Forms.Label lbl_IP;
        private IP_Host iP_HostMain;
        private IP_NoChange iP_NoChangeBC;
        private IP_NoChange iP_NoChangeNetID;
        private IP_NetMask iP_NetMask1;
        private IP_Changeable iP_Changeable1;
        private System.Windows.Forms.Button btn_clear;
        private Subnet_Table_AllSubnets subnet_Table_AllSubnets1;
    }
}

