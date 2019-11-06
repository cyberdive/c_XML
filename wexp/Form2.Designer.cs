namespace wexp
{
    partial class frmWinSATInfo
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
            this.lblWinSatVersion = new System.Windows.Forms.Label();
            this.lblWinSATModulePath = new System.Windows.Forms.Label();
            this.lblWinSATCmdLine = new System.Windows.Forms.Label();
            this.btnfrmWinSATInfoClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOSName = new System.Windows.Forms.Label();
            this.lblOsBuild = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWinSatVersion
            // 
            this.lblWinSatVersion.AutoSize = true;
            this.lblWinSatVersion.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinSatVersion.Location = new System.Drawing.Point(18, 21);
            this.lblWinSatVersion.Name = "lblWinSatVersion";
            this.lblWinSatVersion.Size = new System.Drawing.Size(168, 18);
            this.lblWinSatVersion.TabIndex = 0;
            this.lblWinSatVersion.Text = "WinSAT Version :";
            // 
            // lblWinSATModulePath
            // 
            this.lblWinSATModulePath.AutoSize = true;
            this.lblWinSATModulePath.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinSATModulePath.Location = new System.Drawing.Point(18, 47);
            this.lblWinSATModulePath.Name = "lblWinSATModulePath";
            this.lblWinSATModulePath.Size = new System.Drawing.Size(168, 18);
            this.lblWinSATModulePath.TabIndex = 1;
            this.lblWinSATModulePath.Text = "Module Path    :";
            // 
            // lblWinSATCmdLine
            // 
            this.lblWinSATCmdLine.AutoSize = true;
            this.lblWinSATCmdLine.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinSATCmdLine.Location = new System.Drawing.Point(18, 73);
            this.lblWinSATCmdLine.Name = "lblWinSATCmdLine";
            this.lblWinSATCmdLine.Size = new System.Drawing.Size(168, 18);
            this.lblWinSATCmdLine.TabIndex = 2;
            this.lblWinSATCmdLine.Text = "Cmd Line       :";
            // 
            // btnfrmWinSATInfoClose
            // 
            this.btnfrmWinSATInfoClose.Location = new System.Drawing.Point(626, 262);
            this.btnfrmWinSATInfoClose.Name = "btnfrmWinSATInfoClose";
            this.btnfrmWinSATInfoClose.Size = new System.Drawing.Size(112, 35);
            this.btnfrmWinSATInfoClose.TabIndex = 3;
            this.btnfrmWinSATInfoClose.Text = "&Close";
            this.btnfrmWinSATInfoClose.UseVisualStyleBackColor = true;
            this.btnfrmWinSATInfoClose.Click += new System.EventHandler(this.btnfrmWinSATInfoClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Benchmark Program Information";
            // 
            // lblOSName
            // 
            this.lblOSName.AutoSize = true;
            this.lblOSName.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSName.Location = new System.Drawing.Point(18, 99);
            this.lblOSName.Name = "lblOSName";
            this.lblOSName.Size = new System.Drawing.Size(168, 18);
            this.lblOSName.TabIndex = 5;
            this.lblOSName.Text = "OS Name        :";
            // 
            // lblOsBuild
            // 
            this.lblOsBuild.AutoSize = true;
            this.lblOsBuild.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsBuild.Location = new System.Drawing.Point(18, 125);
            this.lblOsBuild.Name = "lblOsBuild";
            this.lblOsBuild.Size = new System.Drawing.Size(168, 18);
            this.lblOsBuild.TabIndex = 6;
            this.lblOsBuild.Text = "OS Build       :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblWinSATCmdLine);
            this.panel1.Controls.Add(this.lblOsBuild);
            this.panel1.Controls.Add(this.lblWinSatVersion);
            this.panel1.Controls.Add(this.lblOSName);
            this.panel1.Controls.Add(this.lblWinSATModulePath);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 168);
            this.panel1.TabIndex = 7;
            // 
            // frmWinSATInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(750, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfrmWinSATInfoClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWinSATInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinSatVersion;
        private System.Windows.Forms.Label lblWinSATModulePath;
        private System.Windows.Forms.Label lblWinSATCmdLine;
        private System.Windows.Forms.Button btnfrmWinSATInfoClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOSName;
        private System.Windows.Forms.Label lblOsBuild;
        private System.Windows.Forms.Panel panel1;
    }
}