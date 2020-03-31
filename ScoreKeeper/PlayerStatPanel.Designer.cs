namespace ScoreKeeper
{
    partial class PlayerStatPanel
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnFoulShotMade = new System.Windows.Forms.Button();
            this.btnFoulShotMiss = new System.Windows.Forms.Button();
            this.btnInsideMiss = new System.Windows.Forms.Button();
            this.btnInsideMade = new System.Windows.Forms.Button();
            this.btnFGMiss = new System.Windows.Forms.Button();
            this.btnFGMade = new System.Windows.Forms.Button();
            this.btn3Miss = new System.Windows.Forms.Button();
            this.btn3Made = new System.Windows.Forms.Button();
            this.btnRebound = new System.Windows.Forms.Button();
            this.btnSteals = new System.Windows.Forms.Button();
            this.btnCommitTurnOver = new System.Windows.Forms.Button();
            this.btnAssist = new System.Windows.Forms.Button();
            this.lblInsideStat = new System.Windows.Forms.Label();
            this.lblFieldStat = new System.Windows.Forms.Label();
            this.btnCommitFoul = new System.Windows.Forms.Button();
            this.lblFoulStat = new System.Windows.Forms.Label();
            this.cbCorrect = new System.Windows.Forms.CheckBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.lbl3PtStat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDefPress = new System.Windows.Forms.Button();
            this.btnSports = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.Location = new System.Drawing.Point(98, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Billy";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNumber.Location = new System.Drawing.Point(9, 10);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(53, 37);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "22";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(10, 73);
            this.btnIn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(179, 166);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblMin.Location = new System.Drawing.Point(66, 178);
            this.lblMin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(62, 37);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "0:0";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // btnFoulShotMade
            // 
            this.btnFoulShotMade.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoulShotMade.AutoSize = true;
            this.btnFoulShotMade.Location = new System.Drawing.Point(7, 40);
            this.btnFoulShotMade.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnFoulShotMade.Name = "btnFoulShotMade";
            this.btnFoulShotMade.Size = new System.Drawing.Size(161, 101);
            this.btnFoulShotMade.TabIndex = 5;
            this.btnFoulShotMade.Text = "Foul Made";
            this.btnFoulShotMade.UseVisualStyleBackColor = true;
            this.btnFoulShotMade.Click += new System.EventHandler(this.click_MadeFoul);
            // 
            // btnFoulShotMiss
            // 
            this.btnFoulShotMiss.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoulShotMiss.AutoSize = true;
            this.btnFoulShotMiss.Location = new System.Drawing.Point(7, 164);
            this.btnFoulShotMiss.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnFoulShotMiss.Name = "btnFoulShotMiss";
            this.btnFoulShotMiss.Size = new System.Drawing.Size(161, 64);
            this.btnFoulShotMiss.TabIndex = 6;
            this.btnFoulShotMiss.Text = "Missed";
            this.btnFoulShotMiss.UseVisualStyleBackColor = true;
            this.btnFoulShotMiss.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInsideMiss
            // 
            this.btnInsideMiss.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsideMiss.AutoSize = true;
            this.btnInsideMiss.Location = new System.Drawing.Point(182, 164);
            this.btnInsideMiss.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInsideMiss.Name = "btnInsideMiss";
            this.btnInsideMiss.Size = new System.Drawing.Size(161, 64);
            this.btnInsideMiss.TabIndex = 9;
            this.btnInsideMiss.Text = "Missed";
            this.btnInsideMiss.UseVisualStyleBackColor = true;
            this.btnInsideMiss.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsideMade
            // 
            this.btnInsideMade.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsideMade.AutoSize = true;
            this.btnInsideMade.Location = new System.Drawing.Point(182, 40);
            this.btnInsideMade.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInsideMade.Name = "btnInsideMade";
            this.btnInsideMade.Size = new System.Drawing.Size(161, 101);
            this.btnInsideMade.TabIndex = 8;
            this.btnInsideMade.Text = "In Paint Made";
            this.btnInsideMade.UseVisualStyleBackColor = true;
            this.btnInsideMade.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFGMiss
            // 
            this.btnFGMiss.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnFGMiss.AutoSize = true;
            this.btnFGMiss.Location = new System.Drawing.Point(357, 164);
            this.btnFGMiss.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnFGMiss.Name = "btnFGMiss";
            this.btnFGMiss.Size = new System.Drawing.Size(161, 64);
            this.btnFGMiss.TabIndex = 12;
            this.btnFGMiss.Text = "Missed";
            this.btnFGMiss.UseVisualStyleBackColor = true;
            this.btnFGMiss.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFGMade
            // 
            this.btnFGMade.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnFGMade.AutoSize = true;
            this.btnFGMade.Location = new System.Drawing.Point(357, 40);
            this.btnFGMade.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnFGMade.Name = "btnFGMade";
            this.btnFGMade.Size = new System.Drawing.Size(161, 101);
            this.btnFGMade.TabIndex = 11;
            this.btnFGMade.Text = "FG Made";
            this.btnFGMade.UseVisualStyleBackColor = true;
            this.btnFGMade.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn3Miss
            // 
            this.btn3Miss.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btn3Miss.AutoSize = true;
            this.btn3Miss.Location = new System.Drawing.Point(532, 164);
            this.btn3Miss.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn3Miss.Name = "btn3Miss";
            this.btn3Miss.Size = new System.Drawing.Size(161, 64);
            this.btn3Miss.TabIndex = 15;
            this.btn3Miss.Text = "Missed";
            this.btn3Miss.UseVisualStyleBackColor = true;
            this.btn3Miss.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn3Made
            // 
            this.btn3Made.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btn3Made.AutoSize = true;
            this.btn3Made.Location = new System.Drawing.Point(532, 40);
            this.btn3Made.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn3Made.Name = "btn3Made";
            this.btn3Made.Size = new System.Drawing.Size(161, 101);
            this.btn3Made.TabIndex = 14;
            this.btn3Made.Text = "3pt Made";
            this.btn3Made.UseVisualStyleBackColor = true;
            this.btn3Made.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnRebound
            // 
            this.btnRebound.Location = new System.Drawing.Point(1305, 142);
            this.btnRebound.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnRebound.Name = "btnRebound";
            this.btnRebound.Size = new System.Drawing.Size(163, 97);
            this.btnRebound.TabIndex = 18;
            this.btnRebound.Text = "Rebound";
            this.btnRebound.UseVisualStyleBackColor = true;
            this.btnRebound.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSteals
            // 
            this.btnSteals.Location = new System.Drawing.Point(1126, 142);
            this.btnSteals.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSteals.Name = "btnSteals";
            this.btnSteals.Size = new System.Drawing.Size(163, 97);
            this.btnSteals.TabIndex = 17;
            this.btnSteals.Text = "Steal";
            this.btnSteals.UseVisualStyleBackColor = true;
            this.btnSteals.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnCommitTurnOver
            // 
            this.btnCommitTurnOver.Location = new System.Drawing.Point(1683, 142);
            this.btnCommitTurnOver.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCommitTurnOver.Name = "btnCommitTurnOver";
            this.btnCommitTurnOver.Size = new System.Drawing.Size(241, 97);
            this.btnCommitTurnOver.TabIndex = 20;
            this.btnCommitTurnOver.Text = "Commit Turnover";
            this.btnCommitTurnOver.UseVisualStyleBackColor = true;
            this.btnCommitTurnOver.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnAssist
            // 
            this.btnAssist.Location = new System.Drawing.Point(923, 142);
            this.btnAssist.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAssist.Name = "btnAssist";
            this.btnAssist.Size = new System.Drawing.Size(163, 97);
            this.btnAssist.TabIndex = 21;
            this.btnAssist.Text = "Assist";
            this.btnAssist.UseVisualStyleBackColor = true;
            this.btnAssist.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // lblInsideStat
            // 
            this.lblInsideStat.AutoSize = true;
            this.lblInsideStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInsideStat.Location = new System.Drawing.Point(182, 0);
            this.lblInsideStat.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblInsideStat.Name = "lblInsideStat";
            this.lblInsideStat.Size = new System.Drawing.Size(161, 32);
            this.lblInsideStat.TabIndex = 23;
            this.lblInsideStat.Text = "0-0 (0%)";
            this.lblInsideStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFieldStat
            // 
            this.lblFieldStat.AutoSize = true;
            this.lblFieldStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldStat.Location = new System.Drawing.Point(357, 0);
            this.lblFieldStat.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFieldStat.Name = "lblFieldStat";
            this.lblFieldStat.Size = new System.Drawing.Size(161, 32);
            this.lblFieldStat.TabIndex = 24;
            this.lblFieldStat.Text = "0-0 (0%)";
            this.lblFieldStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCommitFoul
            // 
            this.btnCommitFoul.Location = new System.Drawing.Point(1937, 142);
            this.btnCommitFoul.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCommitFoul.Name = "btnCommitFoul";
            this.btnCommitFoul.Size = new System.Drawing.Size(209, 97);
            this.btnCommitFoul.TabIndex = 29;
            this.btnCommitFoul.Text = "Commit Foul";
            this.btnCommitFoul.UseVisualStyleBackColor = true;
            this.btnCommitFoul.Click += new System.EventHandler(this.button13_Click);
            // 
            // lblFoulStat
            // 
            this.lblFoulStat.AutoSize = true;
            this.lblFoulStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoulStat.Location = new System.Drawing.Point(7, 0);
            this.lblFoulStat.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFoulStat.Name = "lblFoulStat";
            this.lblFoulStat.Size = new System.Drawing.Size(161, 32);
            this.lblFoulStat.TabIndex = 31;
            this.lblFoulStat.Text = "0-0 (0%)";
            this.lblFoulStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCorrect
            // 
            this.cbCorrect.AutoSize = true;
            this.cbCorrect.Location = new System.Drawing.Point(2013, 20);
            this.cbCorrect.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cbCorrect.Name = "cbCorrect";
            this.cbCorrect.Size = new System.Drawing.Size(158, 36);
            this.cbCorrect.TabIndex = 32;
            this.cbCorrect.Text = "Correction";
            this.cbCorrect.UseVisualStyleBackColor = true;
            this.cbCorrect.CheckedChanged += new System.EventHandler(this.cbCorrect_CheckedChanged);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(1481, 142);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(163, 97);
            this.btnBlock.TabIndex = 33;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // lbl3PtStat
            // 
            this.lbl3PtStat.AutoSize = true;
            this.lbl3PtStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3PtStat.Location = new System.Drawing.Point(532, 0);
            this.lbl3PtStat.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl3PtStat.Name = "lbl3PtStat";
            this.lbl3PtStat.Size = new System.Drawing.Size(161, 32);
            this.lbl3PtStat.TabIndex = 35;
            this.lbl3PtStat.Text = "0-0 (0%)";
            this.lbl3PtStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.lblFoulStat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl3PtStat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFoulShotMade, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFoulShotMiss, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInsideStat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInsideMade, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInsideMiss, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFGMade, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFieldStat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3Made, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFGMiss, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn3Miss, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 244);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(976, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 77);
            this.button1.TabIndex = 37;
            this.button1.Text = "General";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDefPress
            // 
            this.btnDefPress.Location = new System.Drawing.Point(1268, 15);
            this.btnDefPress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDefPress.Name = "btnDefPress";
            this.btnDefPress.Size = new System.Drawing.Size(186, 77);
            this.btnDefPress.TabIndex = 38;
            this.btnDefPress.Text = "Defense";
            this.btnDefPress.UseVisualStyleBackColor = true;
            this.btnDefPress.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnSports
            // 
            this.btnSports.Location = new System.Drawing.Point(1481, 15);
            this.btnSports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSports.Name = "btnSports";
            this.btnSports.Size = new System.Drawing.Size(225, 77);
            this.btnSports.TabIndex = 39;
            this.btnSports.Text = "Sportsmanship: 0";
            this.btnSports.UseVisualStyleBackColor = true;
            this.btnSports.Click += new System.EventHandler(this.btnSports_Click);
            // 
            // PlayerStatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSports);
            this.Controls.Add(this.btnDefPress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.cbCorrect);
            this.Controls.Add(this.btnCommitFoul);
            this.Controls.Add(this.btnAssist);
            this.Controls.Add(this.btnCommitTurnOver);
            this.Controls.Add(this.btnRebound);
            this.Controls.Add(this.btnSteals);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "PlayerStatPanel";
            this.Size = new System.Drawing.Size(2191, 260);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnFoulShotMade;
        private System.Windows.Forms.Button btnFoulShotMiss;
        private System.Windows.Forms.Button btnInsideMiss;
        private System.Windows.Forms.Button btnInsideMade;
        private System.Windows.Forms.Button btnFGMiss;
        private System.Windows.Forms.Button btnFGMade;
        private System.Windows.Forms.Button btn3Miss;
        private System.Windows.Forms.Button btn3Made;
        private System.Windows.Forms.Button btnRebound;
        private System.Windows.Forms.Button btnSteals;
        private System.Windows.Forms.Button btnCommitTurnOver;
        private System.Windows.Forms.Button btnAssist;
        private System.Windows.Forms.Label lblInsideStat;
        private System.Windows.Forms.Label lblFieldStat;
        private System.Windows.Forms.Button btnCommitFoul;
        private System.Windows.Forms.Label lblFoulStat;
        private System.Windows.Forms.CheckBox cbCorrect;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Label lbl3PtStat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDefPress;
        private System.Windows.Forms.Button btnSports;
    }
}
