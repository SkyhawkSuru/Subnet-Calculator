
namespace Calculator
{
    partial class IP_Host
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxHostLast4 = new System.Windows.Forms.TextBox();
            this.textBoxHostLast3 = new System.Windows.Forms.TextBox();
            this.textBoxHostLast2 = new System.Windows.Forms.TextBox();
            this.textBoxHostLast1 = new System.Windows.Forms.TextBox();
            this.textBoxHostOne4 = new System.Windows.Forms.TextBox();
            this.textBoxHostOne3 = new System.Windows.Forms.TextBox();
            this.textBoxHostOne2 = new System.Windows.Forms.TextBox();
            this.textBoxHostOne1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 201;
            this.button1.Text = "Hosts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.dualToDecStartIPHostOne);
            // 
            // textBoxHostLast4
            // 
            this.textBoxHostLast4.Location = new System.Drawing.Point(564, 40);
            this.textBoxHostLast4.Name = "textBoxHostLast4";
            this.textBoxHostLast4.ReadOnly = true;
            this.textBoxHostLast4.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostLast4.TabIndex = 200;
            this.textBoxHostLast4.Tag = "4";
            this.textBoxHostLast4.Text = "0";
            // 
            // textBoxHostLast3
            // 
            this.textBoxHostLast3.Location = new System.Drawing.Point(379, 40);
            this.textBoxHostLast3.Name = "textBoxHostLast3";
            this.textBoxHostLast3.ReadOnly = true;
            this.textBoxHostLast3.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostLast3.TabIndex = 199;
            this.textBoxHostLast3.Tag = "3";
            this.textBoxHostLast3.Text = "0";
            // 
            // textBoxHostLast2
            // 
            this.textBoxHostLast2.Location = new System.Drawing.Point(192, 40);
            this.textBoxHostLast2.Name = "textBoxHostLast2";
            this.textBoxHostLast2.ReadOnly = true;
            this.textBoxHostLast2.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostLast2.TabIndex = 198;
            this.textBoxHostLast2.Tag = "2";
            this.textBoxHostLast2.Text = "0";
            // 
            // textBoxHostLast1
            // 
            this.textBoxHostLast1.Location = new System.Drawing.Point(4, 40);
            this.textBoxHostLast1.Name = "textBoxHostLast1";
            this.textBoxHostLast1.ReadOnly = true;
            this.textBoxHostLast1.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostLast1.TabIndex = 197;
            this.textBoxHostLast1.Tag = "1";
            this.textBoxHostLast1.Text = "0";
            // 
            // textBoxHostOne4
            // 
            this.textBoxHostOne4.Location = new System.Drawing.Point(564, 3);
            this.textBoxHostOne4.Name = "textBoxHostOne4";
            this.textBoxHostOne4.ReadOnly = true;
            this.textBoxHostOne4.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostOne4.TabIndex = 196;
            this.textBoxHostOne4.Tag = "4";
            this.textBoxHostOne4.Text = "0";
            // 
            // textBoxHostOne3
            // 
            this.textBoxHostOne3.Location = new System.Drawing.Point(379, 3);
            this.textBoxHostOne3.Name = "textBoxHostOne3";
            this.textBoxHostOne3.ReadOnly = true;
            this.textBoxHostOne3.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostOne3.TabIndex = 195;
            this.textBoxHostOne3.Tag = "3";
            this.textBoxHostOne3.Text = "0";
            // 
            // textBoxHostOne2
            // 
            this.textBoxHostOne2.Location = new System.Drawing.Point(192, 3);
            this.textBoxHostOne2.Name = "textBoxHostOne2";
            this.textBoxHostOne2.ReadOnly = true;
            this.textBoxHostOne2.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostOne2.TabIndex = 194;
            this.textBoxHostOne2.Tag = "2";
            this.textBoxHostOne2.Text = "0";
            // 
            // textBoxHostOne1
            // 
            this.textBoxHostOne1.Location = new System.Drawing.Point(4, 3);
            this.textBoxHostOne1.Name = "textBoxHostOne1";
            this.textBoxHostOne1.ReadOnly = true;
            this.textBoxHostOne1.Size = new System.Drawing.Size(170, 20);
            this.textBoxHostOne1.TabIndex = 193;
            this.textBoxHostOne1.Tag = "1";
            this.textBoxHostOne1.Text = "0";
            // 
            // IP_Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHostLast4);
            this.Controls.Add(this.textBoxHostLast3);
            this.Controls.Add(this.textBoxHostLast2);
            this.Controls.Add(this.textBoxHostLast1);
            this.Controls.Add(this.textBoxHostOne4);
            this.Controls.Add(this.textBoxHostOne3);
            this.Controls.Add(this.textBoxHostOne2);
            this.Controls.Add(this.textBoxHostOne1);
            this.Name = "IP_Host";
            this.Size = new System.Drawing.Size(816, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxHostLast4;
        private System.Windows.Forms.TextBox textBoxHostLast3;
        private System.Windows.Forms.TextBox textBoxHostLast2;
        private System.Windows.Forms.TextBox textBoxHostLast1;
        private System.Windows.Forms.TextBox textBoxHostOne4;
        private System.Windows.Forms.TextBox textBoxHostOne3;
        private System.Windows.Forms.TextBox textBoxHostOne2;
        private System.Windows.Forms.TextBox textBoxHostOne1;
    }
}
