
namespace Calculator
{
    partial class Subnet_Table_Count
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxsubnetzAnzahlIP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSubnetzAnzahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsubnetzAnzahlHost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(273, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(241, 122);
            this.dataGridView2.TabIndex = 204;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = " bits";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Anzahl der bits";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Anzahl der Subnetze";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 203;
            this.label14.Text = "IP Adressen";
            // 
            // textBoxsubnetzAnzahlIP
            // 
            this.textBoxsubnetzAnzahlIP.Location = new System.Drawing.Point(97, 34);
            this.textBoxsubnetzAnzahlIP.Name = "textBoxsubnetzAnzahlIP";
            this.textBoxsubnetzAnzahlIP.ReadOnly = true;
            this.textBoxsubnetzAnzahlIP.Size = new System.Drawing.Size(170, 20);
            this.textBoxsubnetzAnzahlIP.TabIndex = 202;
            this.textBoxsubnetzAnzahlIP.Tag = "1";
            this.textBoxsubnetzAnzahlIP.Text = "0";
            this.textBoxsubnetzAnzahlIP.TextChanged += new System.EventHandler(this.Text_Change);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 201;
            this.label13.Text = "Subnetzanzahl";
            // 
            // textBoxSubnetzAnzahl
            // 
            this.textBoxSubnetzAnzahl.Location = new System.Drawing.Point(97, 3);
            this.textBoxSubnetzAnzahl.Name = "textBoxSubnetzAnzahl";
            this.textBoxSubnetzAnzahl.Size = new System.Drawing.Size(170, 20);
            this.textBoxSubnetzAnzahl.TabIndex = 200;
            this.textBoxSubnetzAnzahl.Tag = "1";
            this.textBoxSubnetzAnzahl.Text = "0";
            this.textBoxSubnetzAnzahl.TextChanged += new System.EventHandler(this.Tabelle2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 206;
            this.label1.Text = "Hosts / Subnetz";
            // 
            // textBoxsubnetzAnzahlHost
            // 
            this.textBoxsubnetzAnzahlHost.Location = new System.Drawing.Point(96, 61);
            this.textBoxsubnetzAnzahlHost.Name = "textBoxsubnetzAnzahlHost";
            this.textBoxsubnetzAnzahlHost.ReadOnly = true;
            this.textBoxsubnetzAnzahlHost.Size = new System.Drawing.Size(170, 20);
            this.textBoxsubnetzAnzahlHost.TabIndex = 205;
            this.textBoxsubnetzAnzahlHost.Tag = "1";
            this.textBoxsubnetzAnzahlHost.Text = "0";
            // 
            // Subnet_Table_Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxsubnetzAnzahlHost);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxsubnetzAnzahlIP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSubnetzAnzahl);
            this.Name = "Subnet_Table_Count";
            this.Size = new System.Drawing.Size(516, 127);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxsubnetzAnzahlIP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSubnetzAnzahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsubnetzAnzahlHost;
    }
}
