
namespace Installer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.versionText = new System.Windows.Forms.TextBox();
            this.installInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F);
            this.button2.Location = new System.Drawing.Point(156, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Install";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // versionText
            // 
            this.versionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.versionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionText.Font = new System.Drawing.Font("Arial", 9.8F);
            this.versionText.ForeColor = System.Drawing.Color.White;
            this.versionText.Location = new System.Drawing.Point(3, 1);
            this.versionText.Multiline = true;
            this.versionText.Name = "versionText";
            this.versionText.ReadOnly = true;
            this.versionText.Size = new System.Drawing.Size(610, 86);
            this.versionText.TabIndex = 7;
            this.versionText.Text = "3Hack by Explodingbill\r\nThis installer always gets the latest version\r\nso no need" +
    " to get any other installer";
            this.versionText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // installInfo
            // 
            this.installInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.installInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.installInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installInfo.Font = new System.Drawing.Font("Arial", 9.8F);
            this.installInfo.ForeColor = System.Drawing.Color.White;
            this.installInfo.Location = new System.Drawing.Point(156, 233);
            this.installInfo.Name = "installInfo";
            this.installInfo.ReadOnly = true;
            this.installInfo.Size = new System.Drawing.Size(312, 19);
            this.installInfo.TabIndex = 8;
            this.installInfo.Text = "Click to begin installation";
            this.installInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(625, 325);
            this.Controls.Add(this.installInfo);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox versionText;
        private System.Windows.Forms.TextBox installInfo;
    }
}

