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
            this.lblDefense = new System.Windows.Forms.Label();
            this.btnRebound = new System.Windows.Forms.Button();
            this.btnSteals = new System.Windows.Forms.Button();
            this.btnCommitTurnOver = new System.Windows.Forms.Button();
            this.btnAssist = new System.Windows.Forms.Button();
            this.lblInsideStat = new System.Windows.Forms.Label();
            this.lblFieldStat = new System.Windows.Forms.Label();
            this.lblAssistStat = new System.Windows.Forms.Label();
            this.lblStealStat = new System.Windows.Forms.Label();
            this.lblTOStat = new System.Windows.Forms.Label();
            this.lblReboundStat = new System.Windows.Forms.Label();
            this.lblFoulAgainstStat = new System.Windows.Forms.Label();
            this.btnCommitFoul = new System.Windows.Forms.Button();
            this.lblFoulStat = new System.Windows.Forms.Label();
            this.cbCorrect = new System.Windows.Forms.CheckBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.lblBlockStat = new System.Windows.Forms.Label();
            this.lbl3PtStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(90, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Billy";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(8, 8);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(53, 37);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "22";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(9, 57);
            this.btnIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(165, 130);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(61, 139);
            this.lblMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(62, 37);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "0:0";
            // 
            // btnFoulShotMade
            // 
            this.btnFoulShotMade.Location = new System.Drawing.Point(192, 46);
            this.btnFoulShotMade.Margin = new System.Windows.Forms.Padding(6);
            this.btnFoulShotMade.Name = "btnFoulShotMade";
            this.btnFoulShotMade.Size = new System.Drawing.Size(150, 60);
            this.btnFoulShotMade.TabIndex = 5;
            this.btnFoulShotMade.Text = "Foul Made";
            this.btnFoulShotMade.UseVisualStyleBackColor = true;
            this.btnFoulShotMade.Click += new System.EventHandler(this.click_MadeFoul);
            // 
            // btnFoulShotMiss
            // 
            this.btnFoulShotMiss.Location = new System.Drawing.Point(192, 115);
            this.btnFoulShotMiss.Margin = new System.Windows.Forms.Padding(6);
            this.btnFoulShotMiss.Name = "btnFoulShotMiss";
            this.btnFoulShotMiss.Size = new System.Drawing.Size(150, 50);
            this.btnFoulShotMiss.TabIndex = 6;
            this.btnFoulShotMiss.Text = "Missed";
            this.btnFoulShotMiss.UseVisualStyleBackColor = true;
            this.btnFoulShotMiss.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInsideMiss
            // 
            this.btnInsideMiss.Location = new System.Drawing.Point(354, 115);
            this.btnInsideMiss.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsideMiss.Name = "btnInsideMiss";
            this.btnInsideMiss.Size = new System.Drawing.Size(150, 50);
            this.btnInsideMiss.TabIndex = 9;
            this.btnInsideMiss.Text = "Missed";
            this.btnInsideMiss.UseVisualStyleBackColor = true;
            this.btnInsideMiss.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsideMade
            // 
            this.btnInsideMade.Location = new System.Drawing.Point(354, 46);
            this.btnInsideMade.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsideMade.Name = "btnInsideMade";
            this.btnInsideMade.Size = new System.Drawing.Size(150, 60);
            this.btnInsideMade.TabIndex = 8;
            this.btnInsideMade.Text = "In Paint Made";
            this.btnInsideMade.UseVisualStyleBackColor = true;
            this.btnInsideMade.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFGMiss
            // 
            this.btnFGMiss.Location = new System.Drawing.Point(514, 115);
            this.btnFGMiss.Margin = new System.Windows.Forms.Padding(6);
            this.btnFGMiss.Name = "btnFGMiss";
            this.btnFGMiss.Size = new System.Drawing.Size(150, 50);
            this.btnFGMiss.TabIndex = 12;
            this.btnFGMiss.Text = "Missed";
            this.btnFGMiss.UseVisualStyleBackColor = true;
            this.btnFGMiss.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFGMade
            // 
            this.btnFGMade.Location = new System.Drawing.Point(514, 46);
            this.btnFGMade.Margin = new System.Windows.Forms.Padding(6);
            this.btnFGMade.Name = "btnFGMade";
            this.btnFGMade.Size = new System.Drawing.Size(150, 60);
            this.btnFGMade.TabIndex = 11;
            this.btnFGMade.Text = "FG Made";
            this.btnFGMade.UseVisualStyleBackColor = true;
            this.btnFGMade.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn3Miss
            // 
            this.btn3Miss.Location = new System.Drawing.Point(676, 115);
            this.btn3Miss.Margin = new System.Windows.Forms.Padding(6);
            this.btn3Miss.Name = "btn3Miss";
            this.btn3Miss.Size = new System.Drawing.Size(150, 50);
            this.btn3Miss.TabIndex = 15;
            this.btn3Miss.Text = "Missed";
            this.btn3Miss.UseVisualStyleBackColor = true;
            this.btn3Miss.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn3Made
            // 
            this.btn3Made.Location = new System.Drawing.Point(676, 46);
            this.btn3Made.Margin = new System.Windows.Forms.Padding(6);
            this.btn3Made.Name = "btn3Made";
            this.btn3Made.Size = new System.Drawing.Size(150, 60);
            this.btn3Made.TabIndex = 14;
            this.btn3Made.Text = "3pt Made";
            this.btn3Made.UseVisualStyleBackColor = true;
            this.btn3Made.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Location = new System.Drawing.Point(1084, 12);
            this.lblDefense.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(92, 25);
            this.lblDefense.TabIndex = 19;
            this.lblDefense.Text = "Defense";
            // 
            // btnRebound
            // 
            this.btnRebound.Location = new System.Drawing.Point(1191, 82);
            this.btnRebound.Margin = new System.Windows.Forms.Padding(6);
            this.btnRebound.Name = "btnRebound";
            this.btnRebound.Size = new System.Drawing.Size(150, 44);
            this.btnRebound.TabIndex = 18;
            this.btnRebound.Text = "Rebound";
            this.btnRebound.UseVisualStyleBackColor = true;
            this.btnRebound.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSteals
            // 
            this.btnSteals.Location = new System.Drawing.Point(1025, 82);
            this.btnSteals.Margin = new System.Windows.Forms.Padding(6);
            this.btnSteals.Name = "btnSteals";
            this.btnSteals.Size = new System.Drawing.Size(150, 44);
            this.btnSteals.TabIndex = 17;
            this.btnSteals.Text = "Steal";
            this.btnSteals.UseVisualStyleBackColor = true;
            this.btnSteals.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnCommitTurnOver
            // 
            this.btnCommitTurnOver.Location = new System.Drawing.Point(1553, 80);
            this.btnCommitTurnOver.Margin = new System.Windows.Forms.Padding(6);
            this.btnCommitTurnOver.Name = "btnCommitTurnOver";
            this.btnCommitTurnOver.Size = new System.Drawing.Size(222, 44);
            this.btnCommitTurnOver.TabIndex = 20;
            this.btnCommitTurnOver.Text = "Commit Turnover";
            this.btnCommitTurnOver.UseVisualStyleBackColor = true;
            this.btnCommitTurnOver.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnAssist
            // 
            this.btnAssist.Location = new System.Drawing.Point(838, 71);
            this.btnAssist.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssist.Name = "btnAssist";
            this.btnAssist.Size = new System.Drawing.Size(150, 44);
            this.btnAssist.TabIndex = 21;
            this.btnAssist.Text = "Assist";
            this.btnAssist.UseVisualStyleBackColor = true;
            this.btnAssist.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // lblInsideStat
            // 
            this.lblInsideStat.AutoSize = true;
            this.lblInsideStat.Location = new System.Drawing.Point(378, 16);
            this.lblInsideStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInsideStat.Name = "lblInsideStat";
            this.lblInsideStat.Size = new System.Drawing.Size(94, 25);
            this.lblInsideStat.TabIndex = 23;
            this.lblInsideStat.Text = "0-0 (0%)";
            // 
            // lblFieldStat
            // 
            this.lblFieldStat.AutoSize = true;
            this.lblFieldStat.Location = new System.Drawing.Point(545, 20);
            this.lblFieldStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFieldStat.Name = "lblFieldStat";
            this.lblFieldStat.Size = new System.Drawing.Size(94, 25);
            this.lblFieldStat.TabIndex = 24;
            this.lblFieldStat.Text = "0-0 (0%)";
            // 
            // lblAssistStat
            // 
            this.lblAssistStat.AutoSize = true;
            this.lblAssistStat.Location = new System.Drawing.Point(898, 40);
            this.lblAssistStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAssistStat.Name = "lblAssistStat";
            this.lblAssistStat.Size = new System.Drawing.Size(24, 25);
            this.lblAssistStat.TabIndex = 25;
            this.lblAssistStat.Text = "0";
            // 
            // lblStealStat
            // 
            this.lblStealStat.AutoSize = true;
            this.lblStealStat.Location = new System.Drawing.Point(1096, 46);
            this.lblStealStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStealStat.Name = "lblStealStat";
            this.lblStealStat.Size = new System.Drawing.Size(24, 25);
            this.lblStealStat.TabIndex = 26;
            this.lblStealStat.Text = "0";
            // 
            // lblTOStat
            // 
            this.lblTOStat.AutoSize = true;
            this.lblTOStat.Location = new System.Drawing.Point(1655, 46);
            this.lblTOStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTOStat.Name = "lblTOStat";
            this.lblTOStat.Size = new System.Drawing.Size(24, 25);
            this.lblTOStat.TabIndex = 27;
            this.lblTOStat.Text = "0";
            // 
            // lblReboundStat
            // 
            this.lblReboundStat.AutoSize = true;
            this.lblReboundStat.Location = new System.Drawing.Point(1251, 40);
            this.lblReboundStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReboundStat.Name = "lblReboundStat";
            this.lblReboundStat.Size = new System.Drawing.Size(24, 25);
            this.lblReboundStat.TabIndex = 28;
            this.lblReboundStat.Text = "0";
            // 
            // lblFoulAgainstStat
            // 
            this.lblFoulAgainstStat.AutoSize = true;
            this.lblFoulAgainstStat.Location = new System.Drawing.Point(1853, 46);
            this.lblFoulAgainstStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoulAgainstStat.Name = "lblFoulAgainstStat";
            this.lblFoulAgainstStat.Size = new System.Drawing.Size(24, 25);
            this.lblFoulAgainstStat.TabIndex = 30;
            this.lblFoulAgainstStat.Text = "0";
            // 
            // btnCommitFoul
            // 
            this.btnCommitFoul.Location = new System.Drawing.Point(1787, 82);
            this.btnCommitFoul.Margin = new System.Windows.Forms.Padding(6);
            this.btnCommitFoul.Name = "btnCommitFoul";
            this.btnCommitFoul.Size = new System.Drawing.Size(150, 44);
            this.btnCommitFoul.TabIndex = 29;
            this.btnCommitFoul.Text = "Commit Foul";
            this.btnCommitFoul.UseVisualStyleBackColor = true;
            this.btnCommitFoul.Click += new System.EventHandler(this.button13_Click);
            // 
            // lblFoulStat
            // 
            this.lblFoulStat.AutoSize = true;
            this.lblFoulStat.Location = new System.Drawing.Point(214, 17);
            this.lblFoulStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoulStat.Name = "lblFoulStat";
            this.lblFoulStat.Size = new System.Drawing.Size(94, 25);
            this.lblFoulStat.TabIndex = 31;
            this.lblFoulStat.Text = "0-0 (0%)";
            // 
            // cbCorrect
            // 
            this.cbCorrect.AutoSize = true;
            this.cbCorrect.Location = new System.Drawing.Point(1612, 137);
            this.cbCorrect.Margin = new System.Windows.Forms.Padding(6);
            this.cbCorrect.Name = "cbCorrect";
            this.cbCorrect.Size = new System.Drawing.Size(143, 29);
            this.cbCorrect.TabIndex = 32;
            this.cbCorrect.Text = "Correction";
            this.cbCorrect.UseVisualStyleBackColor = true;
            this.cbCorrect.CheckedChanged += new System.EventHandler(this.cbCorrect_CheckedChanged);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(1353, 82);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(150, 44);
            this.btnBlock.TabIndex = 33;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // lblBlockStat
            // 
            this.lblBlockStat.AutoSize = true;
            this.lblBlockStat.Location = new System.Drawing.Point(1415, 51);
            this.lblBlockStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBlockStat.Name = "lblBlockStat";
            this.lblBlockStat.Size = new System.Drawing.Size(24, 25);
            this.lblBlockStat.TabIndex = 34;
            this.lblBlockStat.Text = "0";
            // 
            // lbl3PtStat
            // 
            this.lbl3PtStat.AutoSize = true;
            this.lbl3PtStat.Location = new System.Drawing.Point(698, 20);
            this.lbl3PtStat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl3PtStat.Name = "lbl3PtStat";
            this.lbl3PtStat.Size = new System.Drawing.Size(94, 25);
            this.lbl3PtStat.TabIndex = 35;
            this.lbl3PtStat.Text = "0-0 (0%)";
            // 
            // PlayerStatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl3PtStat);
            this.Controls.Add(this.lblBlockStat);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.cbCorrect);
            this.Controls.Add(this.lblFoulStat);
            this.Controls.Add(this.lblFoulAgainstStat);
            this.Controls.Add(this.btnCommitFoul);
            this.Controls.Add(this.lblReboundStat);
            this.Controls.Add(this.lblTOStat);
            this.Controls.Add(this.lblStealStat);
            this.Controls.Add(this.lblAssistStat);
            this.Controls.Add(this.lblFieldStat);
            this.Controls.Add(this.lblInsideStat);
            this.Controls.Add(this.btnAssist);
            this.Controls.Add(this.btnCommitTurnOver);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.btnRebound);
            this.Controls.Add(this.btnSteals);
            this.Controls.Add(this.btn3Miss);
            this.Controls.Add(this.btn3Made);
            this.Controls.Add(this.btnFGMiss);
            this.Controls.Add(this.btnFGMade);
            this.Controls.Add(this.btnInsideMiss);
            this.Controls.Add(this.btnInsideMade);
            this.Controls.Add(this.btnFoulShotMiss);
            this.Controls.Add(this.btnFoulShotMade);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlayerStatPanel";
            this.Size = new System.Drawing.Size(2022, 197);
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
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Button btnRebound;
        private System.Windows.Forms.Button btnSteals;
        private System.Windows.Forms.Button btnCommitTurnOver;
        private System.Windows.Forms.Button btnAssist;
        private System.Windows.Forms.Label lblInsideStat;
        private System.Windows.Forms.Label lblFieldStat;
        private System.Windows.Forms.Label lblAssistStat;
        private System.Windows.Forms.Label lblStealStat;
        private System.Windows.Forms.Label lblTOStat;
        private System.Windows.Forms.Label lblReboundStat;
        private System.Windows.Forms.Label lblFoulAgainstStat;
        private System.Windows.Forms.Button btnCommitFoul;
        private System.Windows.Forms.Label lblFoulStat;
        private System.Windows.Forms.CheckBox cbCorrect;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Label lblBlockStat;
        private System.Windows.Forms.Label lbl3PtStat;
    }
}
