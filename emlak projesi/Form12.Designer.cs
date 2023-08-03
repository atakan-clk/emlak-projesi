namespace emlak_projesi
{
    partial class Form12
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            gÜVENLİÇIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fİTNESSÜYEOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(54, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(783, 429);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(260, -2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(315, 81);
            label1.TabIndex = 1;
            label1.Text = "AİDATLAR";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { gÜVENLİÇIKIŞToolStripMenuItem, fİTNESSÜYEOLToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(861, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // gÜVENLİÇIKIŞToolStripMenuItem
            // 
            gÜVENLİÇIKIŞToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            gÜVENLİÇIKIŞToolStripMenuItem.Name = "gÜVENLİÇIKIŞToolStripMenuItem";
            gÜVENLİÇIKIŞToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            gÜVENLİÇIKIŞToolStripMenuItem.Text = "GÜVENLİ ÇIKIŞ";
            gÜVENLİÇIKIŞToolStripMenuItem.Click += gÜVENLİÇIKIŞToolStripMenuItem_Click;
            // 
            // fİTNESSÜYEOLToolStripMenuItem
            // 
            fİTNESSÜYEOLToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            fİTNESSÜYEOLToolStripMenuItem.Name = "fİTNESSÜYEOLToolStripMenuItem";
            fİTNESSÜYEOLToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            fİTNESSÜYEOLToolStripMenuItem.Text = "FİTNESS ÜYE OL ";
            fİTNESSÜYEOLToolStripMenuItem.Click += fİTNESSÜYEOLToolStripMenuItem_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.OldLace;
            ClientSize = new System.Drawing.Size(861, 539);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gÜVENLİÇIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fİTNESSÜYEOLToolStripMenuItem;
    }
}