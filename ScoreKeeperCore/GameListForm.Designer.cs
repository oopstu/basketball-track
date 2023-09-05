namespace ScoreKeeper
{
    partial class GameListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenReportForSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1681, 1000);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGenReportForSelected
            // 
            this.btnGenReportForSelected.Location = new System.Drawing.Point(1036, 1043);
            this.btnGenReportForSelected.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnGenReportForSelected.Name = "btnGenReportForSelected";
            this.btnGenReportForSelected.Size = new System.Drawing.Size(338, 56);
            this.btnGenReportForSelected.TabIndex = 1;
            this.btnGenReportForSelected.Text = "Generate Reports";
            this.btnGenReportForSelected.UseVisualStyleBackColor = true;
            this.btnGenReportForSelected.Click += new System.EventHandler(this.btnGenReportForSelected_Click);
            // 
            // GameListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 1107);
            this.Controls.Add(this.btnGenReportForSelected);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "GameListForm";
            this.Text = "GameListForm";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenReportForSelected;
    }
}