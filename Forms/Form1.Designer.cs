﻿namespace Forms
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pPlayer1 = new System.Windows.Forms.TableLayoutPanel();
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.bPass = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pPlayer1);
            this.mainPanel.Controls.Add(this.lPlayer1);
            this.mainPanel.Controls.Add(this.bPass);
            this.mainPanel.Controls.Add(this.infoText);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1754, 920);
            this.mainPanel.TabIndex = 0;
            // 
            // pPlayer1
            // 
            this.pPlayer1.ColumnCount = 6;
            this.pPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.pPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.pPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer1.Location = new System.Drawing.Point(19, 101);
            this.pPlayer1.Name = "pPlayer1";
            this.pPlayer1.RowCount = 4;
            this.pPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer1.Size = new System.Drawing.Size(639, 629);
            this.pPlayer1.TabIndex = 2;
            // 
            // lPlayer1
            // 
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.Location = new System.Drawing.Point(30, 67);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(51, 20);
            this.lPlayer1.TabIndex = 0;
            this.lPlayer1.Text = "label1";
            // 
            // bPass
            // 
            this.bPass.Location = new System.Drawing.Point(504, 22);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(234, 41);
            this.bPass.TabIndex = 1;
            this.bPass.Text = "NEXT TURN";
            this.bPass.UseVisualStyleBackColor = true;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.SystemColors.InfoText;
            this.infoText.ForeColor = System.Drawing.SystemColors.Info;
            this.infoText.Location = new System.Drawing.Point(664, 352);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoText.Size = new System.Drawing.Size(445, 442);
            this.infoText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 944);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Guess Who?";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.Button bPass;
        private System.Windows.Forms.Label lPlayer1;
        private System.Windows.Forms.TableLayoutPanel pPlayer1;
    }
}
