
namespace Tápanyag_kalkulátor
{
    partial class Tapanyag_kalkulator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alapanyagokÉlelmiszerekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulátorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alapanyagokÉlelmiszerekToolStripMenuItem,
            this.kalkulátorToolStripMenuItem,
            this.receptekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alapanyagokÉlelmiszerekToolStripMenuItem
            // 
            this.alapanyagokÉlelmiszerekToolStripMenuItem.Name = "alapanyagokÉlelmiszerekToolStripMenuItem";
            this.alapanyagokÉlelmiszerekToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.alapanyagokÉlelmiszerekToolStripMenuItem.Text = "Alapanyagok, élelmiszerek";
            this.alapanyagokÉlelmiszerekToolStripMenuItem.Click += new System.EventHandler(this.alapanyagokÉlelmiszerekToolStripMenuItem_Click);
            // 
            // kalkulátorToolStripMenuItem
            // 
            this.kalkulátorToolStripMenuItem.Name = "kalkulátorToolStripMenuItem";
            this.kalkulátorToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kalkulátorToolStripMenuItem.Text = "Kalkulátor";
            this.kalkulátorToolStripMenuItem.Click += new System.EventHandler(this.kalkulátorToolStripMenuItem_Click);
            // 
            // receptekToolStripMenuItem
            // 
            this.receptekToolStripMenuItem.Name = "receptekToolStripMenuItem";
            this.receptekToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.receptekToolStripMenuItem.Text = "Receptek";
            this.receptekToolStripMenuItem.Click += new System.EventHandler(this.receptekToolStripMenuItem_Click);
            // 
            // Tapanyag_kalkulator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1160, 600);
            this.Name = "Tapanyag_kalkulator";
            this.Text = "Tápanyag kalkulátor";
            this.Load += new System.EventHandler(this.Tapanyag_kalkulator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alapanyagokÉlelmiszerekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalkulátorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptekToolStripMenuItem;
    }
}

