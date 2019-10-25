namespace Forms
{
    partial class MainForm
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
            this.bColor1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bColor2 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.tbUser1 = new System.Windows.Forms.TextBox();
            this.tbUser2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUser1 = new System.Windows.Forms.ComboBox();
            this.cbUser2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "START!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bColor1
            // 
            this.bColor1.Location = new System.Drawing.Point(12, 103);
            this.bColor1.Name = "bColor1";
            this.bColor1.Size = new System.Drawing.Size(131, 45);
            this.bColor1.TabIndex = 1;
            this.bColor1.Text = "Color Player 1";
            this.bColor1.UseVisualStyleBackColor = true;
            this.bColor1.Click += new System.EventHandler(this.bColor1_Click);
            // 
            // bColor2
            // 
            this.bColor2.Location = new System.Drawing.Point(12, 267);
            this.bColor2.Name = "bColor2";
            this.bColor2.Size = new System.Drawing.Size(131, 45);
            this.bColor2.TabIndex = 2;
            this.bColor2.Text = "Color Player 2";
            this.bColor2.UseVisualStyleBackColor = true;
            this.bColor2.Click += new System.EventHandler(this.bColor2_Click);
            // 
            // tbUser1
            // 
            this.tbUser1.Location = new System.Drawing.Point(13, 71);
            this.tbUser1.Name = "tbUser1";
            this.tbUser1.Size = new System.Drawing.Size(239, 26);
            this.tbUser1.TabIndex = 3;
            this.tbUser1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUser1_KeyUp);
            // 
            // tbUser2
            // 
            this.tbUser2.Location = new System.Drawing.Point(12, 235);
            this.tbUser2.Name = "tbUser2";
            this.tbUser2.Size = new System.Drawing.Size(240, 26);
            this.tbUser2.TabIndex = 4;
            this.tbUser2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUser2_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 2";
            // 
            // cbUser1
            // 
            this.cbUser1.FormattingEnabled = true;
            this.cbUser1.Location = new System.Drawing.Point(150, 119);
            this.cbUser1.Name = "cbUser1";
            this.cbUser1.Size = new System.Drawing.Size(121, 28);
            this.cbUser1.TabIndex = 7;
            this.cbUser1.SelectedIndexChanged += new System.EventHandler(this.cbUser1_SelectedIndexChanged);
            // 
            // cbUser2
            // 
            this.cbUser2.FormattingEnabled = true;
            this.cbUser2.Location = new System.Drawing.Point(150, 284);
            this.cbUser2.Name = "cbUser2";
            this.cbUser2.Size = new System.Drawing.Size(121, 28);
            this.cbUser2.TabIndex = 8;
            this.cbUser2.SelectedIndexChanged += new System.EventHandler(this.cbUser2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Who will start?";
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(150, 402);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(206, 28);
            this.cbStart.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUser2);
            this.Controls.Add(this.cbUser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUser2);
            this.Controls.Add(this.tbUser1);
            this.Controls.Add(this.bColor2);
            this.Controls.Add(this.bColor1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Guess Who?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bColor1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bColor2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.TextBox tbUser1;
        private System.Windows.Forms.TextBox tbUser2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUser1;
        private System.Windows.Forms.ComboBox cbUser2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStart;
    }
}