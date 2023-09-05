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
            lblName = new Label();
            lblNumber = new Label();
            btnIn = new Button();
            lblMin = new Label();
            btnGoalMade = new Button();
            btnShotTaken = new Button();
            btnPassMade = new Button();
            btnCommitTurnOver = new Button();
            btnCommitFoul = new Button();
            cbCorrect = new CheckBox();
            btnSave = new Button();
            btnAssist = new Button();
            btnSteals = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDefPress = new Button();
            btnSports = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(128, 13);
            lblName.Margin = new Padding(9, 0, 9, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 46);
            lblName.TabIndex = 0;
            lblName.Text = "Billy";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber.Location = new Point(12, 13);
            lblNumber.Margin = new Padding(9, 0, 9, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(64, 46);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "22";
            // 
            // btnIn
            // 
            btnIn.Location = new Point(13, 64);
            btnIn.Margin = new Padding(9, 10, 9, 10);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(234, 103);
            btnIn.TabIndex = 2;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.BackColor = SystemColors.ControlLight;
            lblMin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMin.Location = new Point(2161, 94);
            lblMin.Margin = new Padding(9, 0, 9, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(75, 46);
            lblMin.TabIndex = 4;
            lblMin.Text = "0:0";
            lblMin.Click += lblMin_Click;
            // 
            // btnGoalMade
            // 
            btnGoalMade.AutoSize = true;
            btnGoalMade.Dock = DockStyle.Fill;
            btnGoalMade.Name = "btnGoalMade";
            btnGoalMade.TabIndex = 5;
            btnGoalMade.Text = "GOAL\r\n0";
            btnGoalMade.UseVisualStyleBackColor = true;
            btnGoalMade.Click += click_MadeGoal;
            // 
            // btnShotTaken
            // 
            btnShotTaken.AutoSize = true;
            btnShotTaken.Dock = DockStyle.Fill;
            btnShotTaken.Name = "btnShotTaken";
            btnShotTaken.TabIndex = 8;
            btnShotTaken.Text = "Shot\r\n0";
            btnShotTaken.UseVisualStyleBackColor = true;
            btnShotTaken.Click += click_ShotTaken;
            // 
            // btnPassMade
            // 
            btnPassMade.AutoSize = true;
            btnPassMade.Dock = DockStyle.Fill;
            btnPassMade.Name = "btnPassMade";
            btnPassMade.TabIndex = 11;
            btnPassMade.Text = "Pass\r\n0";
            btnPassMade.UseVisualStyleBackColor = true;
            btnPassMade.Click += click_PassMade;
            // 
            // btnCommitTurnOver
            // 
            btnCommitTurnOver.Dock = DockStyle.Fill;
            btnCommitTurnOver.Name = "btnCommitTurnOver";
            btnCommitTurnOver.TabIndex = 20;
            btnCommitTurnOver.Text = "Turnover\r\n0";
            btnCommitTurnOver.UseVisualStyleBackColor = true;
            btnCommitTurnOver.Click += click_Turnover;
            // 
            // btnCommitFoul
            // 
            btnCommitFoul.Dock = DockStyle.Fill;
            btnCommitFoul.Name = "btnCommitFoul";
            btnCommitFoul.TabIndex = 29;
            btnCommitFoul.Text = "Commit Foul\r\n0";
            btnCommitFoul.UseVisualStyleBackColor = true;
            btnCommitFoul.Click += click_FoulCommit;
            // 
            // cbCorrect
            // 
            cbCorrect.AutoSize = true;
            cbCorrect.Location = new Point(2161, 20);
            cbCorrect.Margin = new Padding(9, 10, 9, 10);
            cbCorrect.Name = "cbCorrect";
            cbCorrect.Size = new Size(195, 45);
            cbCorrect.TabIndex = 32;
            cbCorrect.Text = "Correction";
            cbCorrect.UseVisualStyleBackColor = true;
            cbCorrect.CheckedChanged += cbCorrect_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Name = "btnSave";
            btnSave.TabIndex = 33;
            btnSave.Text = "Goal Save\r\n0";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += click_GoalSaveMade;
            // 
            // btnAssist
            // 
            btnAssist.Name = "btnAssist";
            btnAssist.Dock = DockStyle.Fill;
            btnAssist.TabIndex = 0;
            btnAssist.Click += click_AssistMade;
            // 
            // btnSteals
            // 
            
            btnSteals.Name = "btnSteals";
            btnSteals.Dock = DockStyle.Fill;
            btnSteals.TabIndex = 0;
            btnSteals.Click += click_StealMade;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            tableLayoutPanel1.Controls.Add(btnGoalMade, 0, 0);
            tableLayoutPanel1.Controls.Add(btnShotTaken, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPassMade, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDefPress, 3, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 4, 0);
            tableLayoutPanel1.Controls.Add(btnSports, 5, 0);
            tableLayoutPanel1.Controls.Add(btnCommitFoul, 6, 0);
            tableLayoutPanel1.Controls.Add(btnCommitTurnOver, 7, 0);
            tableLayoutPanel1.Location = new Point(260, 9);
            tableLayoutPanel1.Margin = new Padding(0, 0, 0, 0);
            tableLayoutPanel1.Padding = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1879, 162);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // btnDefPress
            // 
            btnDefPress.Dock = DockStyle.Fill;
            
            btnDefPress.Name = "btnDefPress";
            btnDefPress.TabIndex = 38;
            btnDefPress.Text = "Defense";
            btnDefPress.UseVisualStyleBackColor = true;
            btnDefPress.Click += button2_Click_1;
            // 
            // btnSports
            // 
            btnSports.Dock = DockStyle.Fill;
            btnSports.Name = "btnSports";
            btnSports.TabIndex = 39;
            btnSports.Text = "Sportsmanship\r\n0";
            btnSports.UseVisualStyleBackColor = true;
            btnSports.Click += btnSports_Click;
            // 
            // PlayerStatPanel
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblMin);
            Controls.Add(cbCorrect);
            Controls.Add(btnIn);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Margin = new Padding(5, 5, 5, 5);
            Name = "PlayerStatPanel";
            Size = new Size(2563, 202);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblNumber;
        private Button btnIn;
        private Label lblMin;
        private Button btnGoalMade;
        private Button btnShotTaken;
        private Button btnPassMade;
        private Button btnSteals;
        private Button btnCommitTurnOver;
        private Button btnAssist;
        private Button btnCommitFoul;
        private CheckBox cbCorrect;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button btnDefPress;
        private Button btnSports;
    }
}
