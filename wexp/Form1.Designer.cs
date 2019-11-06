namespace wexp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBaseScore = new System.Windows.Forms.Panel();
            this.panelBSHighlight = new System.Windows.Forms.Panel();
            this.tbBaseScore = new System.Windows.Forms.TextBox();
            this.panelSubScores = new System.Windows.Forms.Panel();
            this.lblSubScoreDisk = new System.Windows.Forms.Label();
            this.lblSubScoreGaming = new System.Windows.Forms.Label();
            this.lblSubScoreGraphics = new System.Windows.Forms.Label();
            this.lblSubScoreMemory = new System.Windows.Forms.Label();
            this.lblSubScoreProcessor = new System.Windows.Forms.Label();
            this.panelRatingDes = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelComponent = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.btnGetBenchMark = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parsedXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winSATInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbAssessmentFiles = new System.Windows.Forms.ToolStripComboBox();
            this.reloadAssessmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panelBaseScore.SuspendLayout();
            this.panelBSHighlight.SuspendLayout();
            this.panelSubScores.SuspendLayout();
            this.panelRatingDes.SuspendLayout();
            this.panelComponent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelBaseScore);
            this.panel1.Controls.Add(this.panelSubScores);
            this.panel1.Controls.Add(this.panelRatingDes);
            this.panel1.Controls.Add(this.panelComponent);
            this.panel1.Location = new System.Drawing.Point(43, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 490);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro SemiExt", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1109, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Base Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "SubScore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "What is rated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Component";
            // 
            // panelBaseScore
            // 
            this.panelBaseScore.BackColor = System.Drawing.Color.Silver;
            this.panelBaseScore.Controls.Add(this.panelBSHighlight);
            this.panelBaseScore.Location = new System.Drawing.Point(1095, 53);
            this.panelBaseScore.Name = "panelBaseScore";
            this.panelBaseScore.Size = new System.Drawing.Size(254, 386);
            this.panelBaseScore.TabIndex = 4;
            // 
            // panelBSHighlight
            // 
            this.panelBSHighlight.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelBSHighlight.Controls.Add(this.tbBaseScore);
            this.panelBSHighlight.Location = new System.Drawing.Point(19, 95);
            this.panelBSHighlight.Name = "panelBSHighlight";
            this.panelBSHighlight.Size = new System.Drawing.Size(217, 197);
            this.panelBSHighlight.TabIndex = 8;
            this.panelBSHighlight.TabStop = true;
            // 
            // tbBaseScore
            // 
            this.tbBaseScore.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbBaseScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBaseScore.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseScore.ForeColor = System.Drawing.SystemColors.Info;
            this.tbBaseScore.Location = new System.Drawing.Point(60, 63);
            this.tbBaseScore.Name = "tbBaseScore";
            this.tbBaseScore.ReadOnly = true;
            this.tbBaseScore.Size = new System.Drawing.Size(100, 58);
            this.tbBaseScore.TabIndex = 1;
            this.tbBaseScore.Text = "0.0";
            this.tbBaseScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelSubScores
            // 
            this.panelSubScores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSubScores.Controls.Add(this.lblSubScoreDisk);
            this.panelSubScores.Controls.Add(this.lblSubScoreGaming);
            this.panelSubScores.Controls.Add(this.lblSubScoreGraphics);
            this.panelSubScores.Controls.Add(this.lblSubScoreMemory);
            this.panelSubScores.Controls.Add(this.lblSubScoreProcessor);
            this.panelSubScores.Location = new System.Drawing.Point(910, 53);
            this.panelSubScores.Name = "panelSubScores";
            this.panelSubScores.Size = new System.Drawing.Size(188, 386);
            this.panelSubScores.TabIndex = 3;
            // 
            // lblSubScoreDisk
            // 
            this.lblSubScoreDisk.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubScoreDisk.Location = new System.Drawing.Point(0, 318);
            this.lblSubScoreDisk.Name = "lblSubScoreDisk";
            this.lblSubScoreDisk.Size = new System.Drawing.Size(184, 40);
            this.lblSubScoreDisk.TabIndex = 8;
            this.lblSubScoreDisk.Text = "0.0";
            this.lblSubScoreDisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreGaming
            // 
            this.lblSubScoreGaming.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubScoreGaming.Location = new System.Drawing.Point(0, 244);
            this.lblSubScoreGaming.Name = "lblSubScoreGaming";
            this.lblSubScoreGaming.Size = new System.Drawing.Size(184, 40);
            this.lblSubScoreGaming.TabIndex = 7;
            this.lblSubScoreGaming.Text = "0.0";
            this.lblSubScoreGaming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreGraphics
            // 
            this.lblSubScoreGraphics.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubScoreGraphics.Location = new System.Drawing.Point(0, 175);
            this.lblSubScoreGraphics.Name = "lblSubScoreGraphics";
            this.lblSubScoreGraphics.Size = new System.Drawing.Size(184, 40);
            this.lblSubScoreGraphics.TabIndex = 6;
            this.lblSubScoreGraphics.Text = "0.0";
            this.lblSubScoreGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreMemory
            // 
            this.lblSubScoreMemory.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubScoreMemory.Location = new System.Drawing.Point(0, 106);
            this.lblSubScoreMemory.Name = "lblSubScoreMemory";
            this.lblSubScoreMemory.Size = new System.Drawing.Size(184, 40);
            this.lblSubScoreMemory.TabIndex = 5;
            this.lblSubScoreMemory.Text = "0.0";
            this.lblSubScoreMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreProcessor
            // 
            this.lblSubScoreProcessor.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubScoreProcessor.Location = new System.Drawing.Point(0, 40);
            this.lblSubScoreProcessor.Name = "lblSubScoreProcessor";
            this.lblSubScoreProcessor.Size = new System.Drawing.Size(184, 40);
            this.lblSubScoreProcessor.TabIndex = 4;
            this.lblSubScoreProcessor.Text = "0.0";
            this.lblSubScoreProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRatingDes
            // 
            this.panelRatingDes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRatingDes.Controls.Add(this.label15);
            this.panelRatingDes.Controls.Add(this.label14);
            this.panelRatingDes.Controls.Add(this.label13);
            this.panelRatingDes.Controls.Add(this.label12);
            this.panelRatingDes.Controls.Add(this.label11);
            this.panelRatingDes.Location = new System.Drawing.Point(405, 53);
            this.panelRatingDes.Name = "panelRatingDes";
            this.panelRatingDes.Size = new System.Drawing.Size(505, 386);
            this.panelRatingDes.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "Data transfer rate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(323, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "3D gaming graphics performance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Desktop graphics performance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Memory operations per second";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myriad Pro Light SemiExt", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Calculations per second";
            // 
            // panelComponent
            // 
            this.panelComponent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelComponent.Controls.Add(this.label10);
            this.panelComponent.Controls.Add(this.label9);
            this.panelComponent.Controls.Add(this.label8);
            this.panelComponent.Controls.Add(this.label7);
            this.panelComponent.Controls.Add(this.label6);
            this.panelComponent.Location = new System.Drawing.Point(20, 53);
            this.panelComponent.Name = "panelComponent";
            this.panelComponent.Size = new System.Drawing.Size(386, 386);
            this.panelComponent.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Primary Disk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gaming";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Graphics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Memory (RAM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Processor";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1326, 683);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Update:";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(201, 99);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(91, 24);
            this.lblLastUpdate.TabIndex = 7;
            this.lblLastUpdate.Text = "Unknown";
            // 
            // btnGetBenchMark
            // 
            this.btnGetBenchMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetBenchMark.Image = global::wexp.Properties.Resources.iconfinder_cnrclient_1031;
            this.btnGetBenchMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetBenchMark.Location = new System.Drawing.Point(1086, 99);
            this.btnGetBenchMark.Name = "btnGetBenchMark";
            this.btnGetBenchMark.Size = new System.Drawing.Size(352, 35);
            this.btnGetBenchMark.TabIndex = 8;
            this.btnGetBenchMark.Text = "&Rerun Benchmark";
            this.btnGetBenchMark.UseVisualStyleBackColor = true;
            this.btnGetBenchMark.Click += new System.EventHandler(this.btnGetBenchMark_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1493, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.openToolStripMenuItem.Text = "&Open XML Source File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parsedXmlToolStripMenuItem,
            this.winSATInfoToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.reloadAssessmentsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // parsedXmlToolStripMenuItem
            // 
            this.parsedXmlToolStripMenuItem.Name = "parsedXmlToolStripMenuItem";
            this.parsedXmlToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.parsedXmlToolStripMenuItem.Text = "&Parsed Xml";
            this.parsedXmlToolStripMenuItem.Click += new System.EventHandler(this.parsedXmlToolStripMenuItem_Click);
            // 
            // winSATInfoToolStripMenuItem
            // 
            this.winSATInfoToolStripMenuItem.Name = "winSATInfoToolStripMenuItem";
            this.winSATInfoToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.winSATInfoToolStripMenuItem.Text = "&WinSAT Info";
            this.winSATInfoToolStripMenuItem.Click += new System.EventHandler(this.winSATInfoToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbAssessmentFiles});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.historyToolStripMenuItem.Text = "Assessment &History";
            // 
            // tscbAssessmentFiles
            // 
            this.tscbAssessmentFiles.AutoSize = false;
            this.tscbAssessmentFiles.Name = "tscbAssessmentFiles";
            this.tscbAssessmentFiles.Size = new System.Drawing.Size(700, 33);
            this.tscbAssessmentFiles.SelectedIndexChanged += new System.EventHandler(this.tscbAssessmentFiles_SelectedIndexChanged);
            // 
            // reloadAssessmentsToolStripMenuItem
            // 
            this.reloadAssessmentsToolStripMenuItem.Name = "reloadAssessmentsToolStripMenuItem";
            this.reloadAssessmentsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.reloadAssessmentsToolStripMenuItem.Text = "&Reload History";
            this.reloadAssessmentsToolStripMenuItem.Click += new System.EventHandler(this.reloadAssessmentsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1493, 780);
            this.Controls.Add(this.btnGetBenchMark);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1515, 836);
            this.MinimumSize = new System.Drawing.Size(1515, 836);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 10+ Experience Score";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBaseScore.ResumeLayout(false);
            this.panelBSHighlight.ResumeLayout(false);
            this.panelBSHighlight.PerformLayout();
            this.panelSubScores.ResumeLayout(false);
            this.panelRatingDes.ResumeLayout(false);
            this.panelRatingDes.PerformLayout();
            this.panelComponent.ResumeLayout(false);
            this.panelComponent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBaseScore;
        private System.Windows.Forms.Panel panelBSHighlight;
        private System.Windows.Forms.TextBox tbBaseScore;
        private System.Windows.Forms.Panel panelSubScores;
        private System.Windows.Forms.Panel panelRatingDes;
        private System.Windows.Forms.Panel panelComponent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Button btnGetBenchMark;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubScoreDisk;
        private System.Windows.Forms.Label lblSubScoreGaming;
        private System.Windows.Forms.Label lblSubScoreGraphics;
        private System.Windows.Forms.Label lblSubScoreMemory;
        private System.Windows.Forms.Label lblSubScoreProcessor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parsedXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winSATInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscbAssessmentFiles;
        private System.Windows.Forms.ToolStripMenuItem reloadAssessmentsToolStripMenuItem;
    }
}

