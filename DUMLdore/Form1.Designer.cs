namespace DUMLdore
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
            this.components = new System.ComponentModel.Container();
            this.btnLoadFW = new System.Windows.Forms.Button();
            this.btnFlashFW = new System.Windows.Forms.Button();
            this.btnBackupFW = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoGoggles = new System.Windows.Forms.RadioButton();
            this.rdoRemote = new System.Windows.Forms.RadioButton();
            this.rdoAircraft = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnDDD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFW
            // 
            this.btnLoadFW.Location = new System.Drawing.Point(88, 114);
            this.btnLoadFW.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFW.Name = "btnLoadFW";
            this.btnLoadFW.Size = new System.Drawing.Size(140, 20);
            this.btnLoadFW.TabIndex = 0;
            this.btnLoadFW.Text = "Load Firmware";
            this.btnLoadFW.UseVisualStyleBackColor = true;
            this.btnLoadFW.Click += new System.EventHandler(this.btnLoadFW_Click);
            // 
            // btnFlashFW
            // 
            this.btnFlashFW.Enabled = false;
            this.btnFlashFW.Location = new System.Drawing.Point(88, 138);
            this.btnFlashFW.Margin = new System.Windows.Forms.Padding(2);
            this.btnFlashFW.Name = "btnFlashFW";
            this.btnFlashFW.Size = new System.Drawing.Size(140, 20);
            this.btnFlashFW.TabIndex = 1;
            this.btnFlashFW.Text = "Flash Firmware";
            this.btnFlashFW.UseVisualStyleBackColor = true;
            this.btnFlashFW.Click += new System.EventHandler(this.btnFlashFW_Click);
            // 
            // btnBackupFW
            // 
            this.btnBackupFW.Enabled = false;
            this.btnBackupFW.Location = new System.Drawing.Point(88, 162);
            this.btnBackupFW.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackupFW.Name = "btnBackupFW";
            this.btnBackupFW.Size = new System.Drawing.Size(140, 20);
            this.btnBackupFW.TabIndex = 2;
            this.btnBackupFW.Text = "Backup Firmware";
            this.btnBackupFW.UseVisualStyleBackColor = true;
            this.btnBackupFW.Click += new System.EventHandler(this.btnBackupFW_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(71, 238);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = " ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Drone Firmware Utility";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rdoGoggles);
            this.groupBox1.Controls.Add(this.rdoRemote);
            this.groupBox1.Controls.Add(this.rdoAircraft);
            this.groupBox1.Location = new System.Drawing.Point(-73, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(406, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoGoggles
            // 
            this.rdoGoggles.AutoSize = true;
            this.rdoGoggles.Location = new System.Drawing.Point(105, 49);
            this.rdoGoggles.Margin = new System.Windows.Forms.Padding(2);
            this.rdoGoggles.Name = "rdoGoggles";
            this.rdoGoggles.Size = new System.Drawing.Size(64, 17);
            this.rdoGoggles.TabIndex = 2;
            this.rdoGoggles.TabStop = true;
            this.rdoGoggles.Text = "Goggles";
            this.rdoGoggles.UseVisualStyleBackColor = true;
            // 
            // rdoRemote
            // 
            this.rdoRemote.AutoSize = true;
            this.rdoRemote.Location = new System.Drawing.Point(105, 29);
            this.rdoRemote.Margin = new System.Windows.Forms.Padding(2);
            this.rdoRemote.Name = "rdoRemote";
            this.rdoRemote.Size = new System.Drawing.Size(98, 17);
            this.rdoRemote.TabIndex = 1;
            this.rdoRemote.TabStop = true;
            this.rdoRemote.Text = "Remote Control";
            this.rdoRemote.UseVisualStyleBackColor = true;
            // 
            // rdoAircraft
            // 
            this.rdoAircraft.AutoSize = true;
            this.rdoAircraft.Checked = true;
            this.rdoAircraft.Location = new System.Drawing.Point(105, 8);
            this.rdoAircraft.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAircraft.Name = "rdoAircraft";
            this.rdoAircraft.Size = new System.Drawing.Size(58, 17);
            this.rdoAircraft.TabIndex = 0;
            this.rdoAircraft.TabStop = true;
            this.rdoAircraft.Text = "Aircraft";
            this.rdoAircraft.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 278);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 15);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(317, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(71, 251);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.github.com/jezzab/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Enabled = false;
            this.btnUnlock.Location = new System.Drawing.Point(88, 186);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(140, 20);
            this.btnUnlock.TabIndex = 13;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnDDD
            // 
            this.btnDDD.Location = new System.Drawing.Point(88, 210);
            this.btnDDD.Margin = new System.Windows.Forms.Padding(2);
            this.btnDDD.Name = "btnDDD";
            this.btnDDD.Size = new System.Drawing.Size(140, 20);
            this.btnDDD.TabIndex = 14;
            this.btnDDD.Text = "DankDroneDownloader";
            this.btnDDD.UseVisualStyleBackColor = true;
            this.btnDDD.Click += new System.EventHandler(this.btnDDD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 326);
            this.Controls.Add(this.btnDDD);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBackupFW);
            this.Controls.Add(this.btnFlashFW);
            this.Controls.Add(this.btnLoadFW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " DUMLdore V1.90 - jezzab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFW;
        private System.Windows.Forms.Button btnFlashFW;
        private System.Windows.Forms.Button btnBackupFW;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGoggles;
        private System.Windows.Forms.RadioButton rdoRemote;
        private System.Windows.Forms.RadioButton rdoAircraft;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnDDD;
    }
}

