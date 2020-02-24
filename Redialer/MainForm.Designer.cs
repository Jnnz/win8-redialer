namespace Redialer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.detectedList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkNoBytesTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkAutoDial = new System.Windows.Forms.CheckBox();
            this.chkNoBytes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.chkHosted = new System.Windows.Forms.CheckBox();
            this.nudRetry = new System.Windows.Forms.NumericUpDown();
            this.lbRetry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetry)).BeginInit();
            this.SuspendLayout();
            // 
            // detectedList
            // 
            this.detectedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detectedList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedList.FormattingEnabled = true;
            this.detectedList.IntegralHeight = false;
            this.detectedList.ItemHeight = 21;
            this.detectedList.Location = new System.Drawing.Point(13, 18);
            this.detectedList.Margin = new System.Windows.Forms.Padding(2);
            this.detectedList.Name = "detectedList";
            this.detectedList.Size = new System.Drawing.Size(262, 142);
            this.detectedList.TabIndex = 0;
            this.detectedList.SelectedIndexChanged += new System.EventHandler(this.detectedList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status Window:";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Location = new System.Drawing.Point(11, 324);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(355, 64);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Double click to open";
            this.notifyIcon.BalloonTipTitle = "Redialer";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Redialer";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // checkNoBytesTimer
            // 
            this.checkNoBytesTimer.Interval = 30000;
            this.checkNoBytesTimer.Tick += new System.EventHandler(this.checkNoBytesTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detected Connections:";
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.Location = new System.Drawing.Point(286, 104);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(80, 39);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.stopButton.Enabled = false;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.Location = new System.Drawing.Point(286, 61);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(80, 39);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startButton.Enabled = false;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.Location = new System.Drawing.Point(286, 18);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 39);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Options:";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(16, 177);
            this.chkAutoStart.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(128, 17);
            this.chkAutoStart.TabIndex = 7;
            this.chkAutoStart.Text = "Start with Windows";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // chkAutoDial
            // 
            this.chkAutoDial.AutoSize = true;
            this.chkAutoDial.Location = new System.Drawing.Point(16, 199);
            this.chkAutoDial.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoDial.Name = "chkAutoDial";
            this.chkAutoDial.Size = new System.Drawing.Size(225, 17);
            this.chkAutoDial.TabIndex = 8;
            this.chkAutoDial.Text = "Auto Start Dialing(Default Connection)";
            this.chkAutoDial.UseVisualStyleBackColor = true;
            this.chkAutoDial.CheckedChanged += new System.EventHandler(this.chkAutoDial_CheckedChanged);
            // 
            // chkNoBytes
            // 
            this.chkNoBytes.AutoSize = true;
            this.chkNoBytes.Location = new System.Drawing.Point(16, 221);
            this.chkNoBytes.Margin = new System.Windows.Forms.Padding(2);
            this.chkNoBytes.Name = "chkNoBytes";
            this.chkNoBytes.Size = new System.Drawing.Size(187, 17);
            this.chkNoBytes.TabIndex = 9;
            this.chkNoBytes.Text = "Disconnect/Connect if no bytes";
            this.chkNoBytes.UseVisualStyleBackColor = true;
            this.chkNoBytes.CheckedChanged += new System.EventHandler(this.chkNoBytes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username/Password for PPPOE connections";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(14, 280);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(76, 22);
            this.txtUserName.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 280);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(76, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.Location = new System.Drawing.Point(173, 279);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 24);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // chkHosted
            // 
            this.chkHosted.AutoSize = true;
            this.chkHosted.Location = new System.Drawing.Point(16, 243);
            this.chkHosted.Margin = new System.Windows.Forms.Padding(2);
            this.chkHosted.Name = "chkHosted";
            this.chkHosted.Size = new System.Drawing.Size(149, 17);
            this.chkHosted.TabIndex = 15;
            this.chkHosted.Text = "Restart Hosted Network";
            this.chkHosted.UseVisualStyleBackColor = true;
            this.chkHosted.CheckedChanged += new System.EventHandler(this.chkHosted_CheckedChanged);
            // 
            // nudRetry
            // 
            this.nudRetry.Location = new System.Drawing.Point(286, 198);
            this.nudRetry.Name = "nudRetry";
            this.nudRetry.Size = new System.Drawing.Size(80, 22);
            this.nudRetry.TabIndex = 16;
            this.nudRetry.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbRetry
            // 
            this.lbRetry.AutoSize = true;
            this.lbRetry.Location = new System.Drawing.Point(283, 179);
            this.lbRetry.Name = "lbRetry";
            this.lbRetry.Size = new System.Drawing.Size(36, 13);
            this.lbRetry.TabIndex = 17;
            this.lbRetry.Text = "Retry:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 399);
            this.Controls.Add(this.lbRetry);
            this.Controls.Add(this.nudRetry);
            this.Controls.Add(this.chkHosted);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkNoBytes);
            this.Controls.Add(this.chkAutoDial);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.detectedList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Redialer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudRetry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox detectedList;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer checkNoBytesTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aboutButton;
        public System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkAutoDial;
        private System.Windows.Forms.CheckBox chkNoBytes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox chkHosted;
        private System.Windows.Forms.NumericUpDown nudRetry;
        private System.Windows.Forms.Label lbRetry;
    }
}

