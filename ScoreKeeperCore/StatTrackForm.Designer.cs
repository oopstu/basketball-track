namespace ScoreKeeper
{
    partial class StatTrackForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblViewGames = new System.Windows.Forms.Label();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblPickTeam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbBtnSort = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnSort)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 1198);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(2430, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSaveClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2430, 1131);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pbBtnSort);
            this.panel1.Controls.Add(this.lblViewGames);
            this.panel1.Controls.Add(this.lblNewGame);
            this.panel1.Controls.Add(this.lblPickTeam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2430, 67);
            this.panel1.TabIndex = 0;
            // 
            // lblViewGames
            // 
            this.lblViewGames.AutoSize = true;
            this.lblViewGames.Enabled = false;
            this.lblViewGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewGames.Location = new System.Drawing.Point(496, 12);
            this.lblViewGames.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblViewGames.Name = "lblViewGames";
            this.lblViewGames.Size = new System.Drawing.Size(208, 37);
            this.lblViewGames.TabIndex = 2;
            this.lblViewGames.Text = "View Games";
            this.lblViewGames.Click += new System.EventHandler(this.lblViewGames_Click);
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Enabled = false;
            this.lblNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewGame.Location = new System.Drawing.Point(246, 12);
            this.lblNewGame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(185, 37);
            this.lblNewGame.TabIndex = 1;
            this.lblNewGame.Text = "New Game";
            this.lblNewGame.Click += new System.EventHandler(this.lblCreateGameClicked);
            // 
            // lblPickTeam
            // 
            this.lblPickTeam.AutoSize = true;
            this.lblPickTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPickTeam.Location = new System.Drawing.Point(6, 12);
            this.lblPickTeam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPickTeam.Name = "lblPickTeam";
            this.lblPickTeam.Size = new System.Drawing.Size(177, 37);
            this.lblPickTeam.TabIndex = 0;
            this.lblPickTeam.Text = "Pick Team";
            this.lblPickTeam.Click += new System.EventHandler(this.lblPickTeam_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2430, 1198);
            this.panel2.TabIndex = 3;
            // 
            // pbBtnSort
            // 
            this.pbBtnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnSort.Location = new System.Drawing.Point(2368, 7);
            this.pbBtnSort.Name = "pbBtnSort";
            this.pbBtnSort.Size = new System.Drawing.Size(50, 51);
            this.pbBtnSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBtnSort.TabIndex = 3;
            this.pbBtnSort.TabStop = false;
            this.pbBtnSort.Click += new System.EventHandler(this.pbBtnSort_Click);
            // 
            // StatTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2430, 1242);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StatTrackForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnSort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPickTeam;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblViewGames;
        private System.Windows.Forms.PictureBox pbBtnSort;
    }
}

