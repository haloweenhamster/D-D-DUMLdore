namespace DDDUMLdore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDDD = new System.Windows.Forms.ToolStripButton();
            this.btnDUML = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dDDmu = new System.Windows.Forms.ToolStripMenuItem();
            this.dUMLmu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDDD,
            this.btnDUML});
            this.toolStrip1.Location = new System.Drawing.Point(5, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(574, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDDD
            // 
            this.btnDDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDDD.Image = ((System.Drawing.Image)(resources.GetObject("btnDDD.Image")));
            this.btnDDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDDD.Name = "btnDDD";
            this.btnDDD.Size = new System.Drawing.Size(134, 22);
            this.btnDDD.Text = "DankDroneDownloader";
            this.btnDDD.Click += new System.EventHandler(this.btnDDD_Click);
            // 
            // btnDUML
            // 
            this.btnDUML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDUML.Image = ((System.Drawing.Image)(resources.GetObject("btnDUML.Image")));
            this.btnDUML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDUML.Name = "btnDUML";
            this.btnDUML.Size = new System.Drawing.Size(68, 22);
            this.btnDUML.Text = "DUMLdore";
            this.btnDUML.Click += new System.EventHandler(this.btnDUML_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDDmu,
            this.dUMLmu});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dDDmu
            // 
            this.dDDmu.Name = "dDDmu";
            this.dDDmu.Size = new System.Drawing.Size(43, 20);
            this.dDDmu.Text = "DDD";
            this.dDDmu.Click += new System.EventHandler(this.dDDmu_Click);
            // 
            // dUMLmu
            // 
            this.dUMLmu.Name = "dUMLmu";
            this.dUMLmu.Size = new System.Drawing.Size(52, 20);
            this.dUMLmu.Text = "DUML";
            this.dUMLmu.Click += new System.EventHandler(this.dUMLmu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " D-D-DUMLdore";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDDD;
        private System.Windows.Forms.ToolStripButton btnDUML;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dDDmu;
        private System.Windows.Forms.ToolStripMenuItem dUMLmu;
    }
}

