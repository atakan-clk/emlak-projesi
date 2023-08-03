namespace emlak_projesi
{
    partial class Form8
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            aNASAYFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            satılıkDaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new System.Drawing.Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(414, 214);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download1;
            pictureBox2.Location = new System.Drawing.Point(12, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(414, 213);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(574, 141);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 28);
            label1.TabIndex = 2;
            label1.Text = "Odasayısı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(574, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 28);
            label2.TabIndex = 3;
            label2.Text = "metre2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(574, 229);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 28);
            label3.TabIndex = 4;
            label3.Text = "fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(574, 269);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 28);
            label4.TabIndex = 5;
            label4.Text = "blok";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { aNASAYFAToolStripMenuItem, satılıkDaireToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            aNASAYFAToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            aNASAYFAToolStripMenuItem.Click += aNASAYFAToolStripMenuItem_Click;
            // 
            // satılıkDaireToolStripMenuItem
            // 
            satılıkDaireToolStripMenuItem.Name = "satılıkDaireToolStripMenuItem";
            satılıkDaireToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            satılıkDaireToolStripMenuItem.Text = "Satılık Daire";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Orange;
            button1.Location = new System.Drawing.Point(497, 375);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 46);
            button1.TabIndex = 7;
            button1.Text = "İleri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Wheat;
            ClientSize = new System.Drawing.Size(800, 494);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılıkDaireToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}