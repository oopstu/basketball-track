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
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblPickTeam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblViewGames = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1215, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1215, 588);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblViewGames);
            this.panel1.Controls.Add(this.lblNewGame);
            this.panel1.Controls.Add(this.lblPickTeam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Enabled = false;
            this.lblNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewGame.Location = new System.Drawing.Point(123, 6);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(96, 20);
            this.lblNewGame.TabIndex = 1;
            this.lblNewGame.Text = "New Game";
            this.lblNewGame.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPickTeam
            // 
            this.lblPickTeam.AutoSize = true;
            this.lblPickTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPickTeam.Location = new System.Drawing.Point(3, 6);
            this.lblPickTeam.Name = "lblPickTeam";
            this.lblPickTeam.Size = new System.Drawing.Size(91, 20);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 623);
            this.panel2.TabIndex = 3;
            // 
            // lblViewGames
            // 
            this.lblViewGames.AutoSize = true;
            this.lblViewGames.Enabled = false;
            this.lblViewGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewGames.Location = new System.Drawing.Point(248, 6);
            this.lblViewGames.Name = "lblViewGames";
            this.lblViewGames.Size = new System.Drawing.Size(109, 20);
            this.lblViewGames.TabIndex = 2;
            this.lblViewGames.Text = "View Games";
            this.lblViewGames.Click += new System.EventHandler(this.lblViewGames_Click);
            // 
            // StatTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Name = "StatTrackForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

