namespace ProfeMon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JOUEUR1 = new System.Windows.Forms.Label();
            this.Joueur2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TITRE = new System.Windows.Forms.PictureBox();
            this.VALIDER = new System.Windows.Forms.Button();
            this.Tom = new System.Windows.Forms.RadioButton();
            this.Pluquet = new System.Windows.Forms.RadioButton();
            this.Wilfart = new System.Windows.Forms.RadioButton();
            this.Chot = new System.Windows.Forms.RadioButton();
            this.Gosseye = new System.Windows.Forms.RadioButton();
            this.VDH = new System.Windows.Forms.RadioButton();
            this.Bivort = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TITRE)).BeginInit();
            this.SuspendLayout();
            // 
            // JOUEUR1
            // 
            this.JOUEUR1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JOUEUR1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.JOUEUR1.ForeColor = System.Drawing.Color.Red;
            this.JOUEUR1.Location = new System.Drawing.Point(42, 116);
            this.JOUEUR1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JOUEUR1.Name = "JOUEUR1";
            this.JOUEUR1.Size = new System.Drawing.Size(209, 64);
            this.JOUEUR1.TabIndex = 3;
            this.JOUEUR1.Text = "Joueur 1";
            this.JOUEUR1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Joueur2
            // 
            this.Joueur2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Joueur2.AutoSize = true;
            this.Joueur2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Joueur2.Location = new System.Drawing.Point(358, 111);
            this.Joueur2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Joueur2.Name = "Joueur2";
            this.Joueur2.Size = new System.Drawing.Size(227, 54);
            this.Joueur2.TabIndex = 4;
            this.Joueur2.Text = "Joueur 2";
            this.Joueur2.Click += new System.EventHandler(this.Joueur2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 363);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TITRE
            // 
            this.TITRE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TITRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TITRE.ErrorImage = null;
            this.TITRE.Image = global::ProfeMon.Properties.Resources.profémon_le_vrai1;
            this.TITRE.ImageLocation = "";
            this.TITRE.InitialImage = global::ProfeMon.Properties.Resources.Profémon_légendes2;
            this.TITRE.Location = new System.Drawing.Point(42, -7);
            this.TITRE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TITRE.Name = "TITRE";
            this.TITRE.Size = new System.Drawing.Size(526, 120);
            this.TITRE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TITRE.TabIndex = 13;
            this.TITRE.TabStop = false;
            this.TITRE.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // VALIDER
            // 
            this.VALIDER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VALIDER.Location = new System.Drawing.Point(487, 293);
            this.VALIDER.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VALIDER.Name = "VALIDER";
            this.VALIDER.Size = new System.Drawing.Size(155, 69);
            this.VALIDER.TabIndex = 14;
            this.VALIDER.Text = "VALIDER";
            this.VALIDER.UseVisualStyleBackColor = true;
            this.VALIDER.Click += new System.EventHandler(this.VALIDER_Click);
            // 
            // Tom
            // 
            this.Tom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tom.AutoSize = true;
            this.Tom.Location = new System.Drawing.Point(143, 199);
            this.Tom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tom.Name = "Tom";
            this.Tom.Size = new System.Drawing.Size(59, 24);
            this.Tom.TabIndex = 15;
            this.Tom.TabStop = true;
            this.Tom.Text = "Tom";
            this.Tom.UseVisualStyleBackColor = true;
            this.Tom.CheckedChanged += new System.EventHandler(this.Tom_CheckedChanged_1);
            // 
            // Pluquet
            // 
            this.Pluquet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pluquet.AutoSize = true;
            this.Pluquet.Location = new System.Drawing.Point(346, 199);
            this.Pluquet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pluquet.Name = "Pluquet";
            this.Pluquet.Size = new System.Drawing.Size(80, 24);
            this.Pluquet.TabIndex = 16;
            this.Pluquet.TabStop = true;
            this.Pluquet.Text = "Pluquet";
            this.Pluquet.UseVisualStyleBackColor = true;
            this.Pluquet.CheckedChanged += new System.EventHandler(this.Pluquet_CheckedChanged_1);
            // 
            // Wilfart
            // 
            this.Wilfart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Wilfart.AutoSize = true;
            this.Wilfart.Location = new System.Drawing.Point(143, 256);
            this.Wilfart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Wilfart.Name = "Wilfart";
            this.Wilfart.Size = new System.Drawing.Size(75, 24);
            this.Wilfart.TabIndex = 17;
            this.Wilfart.TabStop = true;
            this.Wilfart.Text = "Wilfart";
            this.Wilfart.UseVisualStyleBackColor = true;
            this.Wilfart.CheckedChanged += new System.EventHandler(this.Wilfart_CheckedChanged_1);
            // 
            // Chot
            // 
            this.Chot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Chot.AutoSize = true;
            this.Chot.Location = new System.Drawing.Point(346, 256);
            this.Chot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chot.Name = "Chot";
            this.Chot.Size = new System.Drawing.Size(61, 24);
            this.Chot.TabIndex = 18;
            this.Chot.TabStop = true;
            this.Chot.Text = "Chot";
            this.Chot.UseVisualStyleBackColor = true;
            this.Chot.CheckedChanged += new System.EventHandler(this.Chot_CheckedChanged_1);
            // 
            // Gosseye
            // 
            this.Gosseye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gosseye.AutoSize = true;
            this.Gosseye.Location = new System.Drawing.Point(143, 316);
            this.Gosseye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gosseye.Name = "Gosseye";
            this.Gosseye.Size = new System.Drawing.Size(84, 24);
            this.Gosseye.TabIndex = 19;
            this.Gosseye.TabStop = true;
            this.Gosseye.Text = "Gosseye";
            this.Gosseye.UseVisualStyleBackColor = true;
            this.Gosseye.CheckedChanged += new System.EventHandler(this.Gosseye_CheckedChanged);
            // 
            // VDH
            // 
            this.VDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VDH.AutoSize = true;
            this.VDH.Location = new System.Drawing.Point(346, 319);
            this.VDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VDH.Name = "VDH";
            this.VDH.Size = new System.Drawing.Size(61, 24);
            this.VDH.TabIndex = 20;
            this.VDH.TabStop = true;
            this.VDH.Text = "VDH";
            this.VDH.UseVisualStyleBackColor = true;
            this.VDH.CheckedChanged += new System.EventHandler(this.VDH_CheckedChanged_1);
            // 
            // Bivort
            // 
            this.Bivort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bivort.AutoSize = true;
            this.Bivort.Location = new System.Drawing.Point(487, 199);
            this.Bivort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bivort.Name = "Bivort";
            this.Bivort.Size = new System.Drawing.Size(69, 24);
            this.Bivort.TabIndex = 21;
            this.Bivort.TabStop = true;
            this.Bivort.Text = "Bivort";
            this.Bivort.UseVisualStyleBackColor = true;
            this.Bivort.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.Bivort);
            this.Controls.Add(this.VDH);
            this.Controls.Add(this.Gosseye);
            this.Controls.Add(this.Chot);
            this.Controls.Add(this.Wilfart);
            this.Controls.Add(this.Pluquet);
            this.Controls.Add(this.Tom);
            this.Controls.Add(this.VALIDER);
            this.Controls.Add(this.Joueur2);
            this.Controls.Add(this.JOUEUR1);
            this.Controls.Add(this.TITRE);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TITRE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label JOUEUR1;
        private Label Joueur2;
        private PictureBox pictureBox1;
        private PictureBox TITRE;
        private Button VALIDER;
        private RadioButton Tom;
        private RadioButton Pluquet;
        private RadioButton Wilfart;
        private RadioButton Chot;
        private RadioButton Gosseye;
        private RadioButton VDH;
        private RadioButton Bivort;
    }
}