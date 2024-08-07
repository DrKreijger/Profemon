namespace ProfeMon
{
    partial class Form3
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
            this.Winner = new System.Windows.Forms.Label();
            this.WinnerName = new System.Windows.Forms.Label();
            this.WinnerImage = new System.Windows.Forms.PictureBox();
            this.Trophy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trophy)).BeginInit();
            this.SuspendLayout();
            // 
            // Winner
            // 
            this.Winner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Winner.AutoSize = true;
            this.Winner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Winner.Font = new System.Drawing.Font("Showcard Gothic", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Winner.ForeColor = System.Drawing.Color.Yellow;
            this.Winner.Location = new System.Drawing.Point(152, 9);
            this.Winner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(489, 135);
            this.Winner.TabIndex = 2;
            this.Winner.Text = "WINNER";
            this.Winner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinnerName
            // 
            this.WinnerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinnerName.AutoSize = true;
            this.WinnerName.Font = new System.Drawing.Font("Showcard Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinnerName.Location = new System.Drawing.Point(240, 411);
            this.WinnerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WinnerName.Name = "WinnerName";
            this.WinnerName.Size = new System.Drawing.Size(311, 124);
            this.WinnerName.TabIndex = 3;
            this.WinnerName.Text = "text";
            this.WinnerName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WinnerImage
            // 
            this.WinnerImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinnerImage.BackColor = System.Drawing.Color.Transparent;
            this.WinnerImage.Location = new System.Drawing.Point(110, 147);
            this.WinnerImage.Name = "WinnerImage";
            this.WinnerImage.Size = new System.Drawing.Size(262, 198);
            this.WinnerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinnerImage.TabIndex = 4;
            this.WinnerImage.TabStop = false;
            // 
            // Trophy
            // 
            this.Trophy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trophy.BackColor = System.Drawing.Color.Transparent;
            this.Trophy.Image = global::ProfeMon.Properties.Resources.Trophy;
            this.Trophy.Location = new System.Drawing.Point(431, 147);
            this.Trophy.Name = "Trophy";
            this.Trophy.Size = new System.Drawing.Size(262, 198);
            this.Trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Trophy.TabIndex = 5;
            this.Trophy.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 588);
            this.Controls.Add(this.Trophy);
            this.Controls.Add(this.WinnerImage);
            this.Controls.Add(this.WinnerName);
            this.Controls.Add(this.Winner);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.WinnerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Winner;
        private Label WinnerName;
        private PictureBox WinnerImage;
        private PictureBox Trophy;
    }
}