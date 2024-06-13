namespace _10
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
            this.rightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "0,0";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // rightButton
            // 
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(654, 351);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(88, 33);
            this.rightButton.TabIndex = 12;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(552, 398);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(88, 33);
            this.downButton.TabIndex = 11;
            this.downButton.Text = "v";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(437, 351);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(88, 33);
            this.leftButton.TabIndex = 10;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(552, 308);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(88, 33);
            this.upButton.TabIndex = 9;
            this.upButton.Text = "^";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.Location = new System.Drawing.Point(552, 351);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(88, 33);
            this.randomButton.TabIndex = 8;
            this.randomButton.Text = "R";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "H";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.LocationChanged += new System.EventHandler(this.button1_LocationChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button button1;
    }
}

