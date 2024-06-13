namespace _7
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altıÇiziliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalınToolStripMenuItem,
            this.eğikToolStripMenuItem,
            this.altıÇiziliToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.düzenToolStripMenuItem.Text = "düzen";
            // 
            // kalınToolStripMenuItem
            // 
            this.kalınToolStripMenuItem.Name = "kalınToolStripMenuItem";
            this.kalınToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kalınToolStripMenuItem.Text = "kalın";
            this.kalınToolStripMenuItem.Click += new System.EventHandler(this.kalınToolStripMenuItem_Click);
            // 
            // eğikToolStripMenuItem
            // 
            this.eğikToolStripMenuItem.Name = "eğikToolStripMenuItem";
            this.eğikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğikToolStripMenuItem.Text = "eğik";
            this.eğikToolStripMenuItem.Click += new System.EventHandler(this.eğikToolStripMenuItem_Click);
            // 
            // altıÇiziliToolStripMenuItem
            // 
            this.altıÇiziliToolStripMenuItem.Name = "altıÇiziliToolStripMenuItem";
            this.altıÇiziliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altıÇiziliToolStripMenuItem.Text = "altı çizili";
            this.altıÇiziliToolStripMenuItem.Click += new System.EventHandler(this.altıÇiziliToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 181);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altıÇiziliToolStripMenuItem;
    }
}

