namespace Forms
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
            this.lCount2 = new System.Windows.Forms.Label();
            this.lCount1 = new System.Windows.Forms.Label();
            this.lTurnName = new System.Windows.Forms.Label();
            this.bDiscard = new System.Windows.Forms.Button();
            this.bAsk = new System.Windows.Forms.Button();
            this.cbQuestion = new System.Windows.Forms.ComboBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lPlayer2 = new System.Windows.Forms.Label();
            this.pPlayer2 = new System.Windows.Forms.TableLayoutPanel();
            this.pPlayer1 = new System.Windows.Forms.TableLayoutPanel();
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.bPass = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.TextBox();
            this.bResolve = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bResolve);
            this.mainPanel.Controls.Add(this.lCount2);
            this.mainPanel.Controls.Add(this.lCount1);
            this.mainPanel.Controls.Add(this.lTurnName);
            this.mainPanel.Controls.Add(this.bDiscard);
            this.mainPanel.Controls.Add(this.bAsk);
            this.mainPanel.Controls.Add(this.cbQuestion);
            this.mainPanel.Controls.Add(this.pb2);
            this.mainPanel.Controls.Add(this.pb1);
            this.mainPanel.Controls.Add(this.lPlayer2);
            this.mainPanel.Controls.Add(this.pPlayer2);
            this.mainPanel.Controls.Add(this.pPlayer1);
            this.mainPanel.Controls.Add(this.lPlayer1);
            this.mainPanel.Controls.Add(this.bPass);
            this.mainPanel.Controls.Add(this.infoText);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1754, 920);
            this.mainPanel.TabIndex = 0;
            // 
            // lCount2
            // 
            this.lCount2.AutoSize = true;
            this.lCount2.Location = new System.Drawing.Point(1115, 66);
            this.lCount2.Name = "lCount2";
            this.lCount2.Size = new System.Drawing.Size(51, 20);
            this.lCount2.TabIndex = 12;
            this.lCount2.Text = "label2";
            // 
            // lCount1
            // 
            this.lCount1.AutoSize = true;
            this.lCount1.Location = new System.Drawing.Point(594, 67);
            this.lCount1.Name = "lCount1";
            this.lCount1.Size = new System.Drawing.Size(51, 20);
            this.lCount1.TabIndex = 11;
            this.lCount1.Text = "label1";
            // 
            // lTurnName
            // 
            this.lTurnName.AutoSize = true;
            this.lTurnName.Location = new System.Drawing.Point(664, 563);
            this.lTurnName.Name = "lTurnName";
            this.lTurnName.Size = new System.Drawing.Size(51, 20);
            this.lTurnName.TabIndex = 10;
            this.lTurnName.Text = "label1";
            // 
            // bDiscard
            // 
            this.bDiscard.Location = new System.Drawing.Point(368, 799);
            this.bDiscard.Name = "bDiscard";
            this.bDiscard.Size = new System.Drawing.Size(237, 41);
            this.bDiscard.TabIndex = 9;
            this.bDiscard.Text = "DISCARD SELECTEDS";
            this.bDiscard.UseVisualStyleBackColor = true;
            this.bDiscard.Click += new System.EventHandler(this.bDiscard_Click);
            // 
            // bAsk
            // 
            this.bAsk.Location = new System.Drawing.Point(137, 799);
            this.bAsk.Name = "bAsk";
            this.bAsk.Size = new System.Drawing.Size(211, 41);
            this.bAsk.TabIndex = 8;
            this.bAsk.Text = "MAKE QUESTION";
            this.bAsk.UseVisualStyleBackColor = true;
            this.bAsk.Click += new System.EventHandler(this.bAsk_Click);
            // 
            // cbQuestion
            // 
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Location = new System.Drawing.Point(137, 765);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(468, 28);
            this.cbQuestion.TabIndex = 7;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(1639, 765);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 140);
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(19, 765);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 140);
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            // 
            // lPlayer2
            // 
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.Location = new System.Drawing.Point(1688, 67);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(51, 20);
            this.lPlayer2.TabIndex = 4;
            this.lPlayer2.Text = "label1";
            // 
            // pPlayer2
            // 
            this.pPlayer2.ColumnCount = 6;
            this.pPlayer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.pPlayer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.pPlayer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.pPlayer2.Location = new System.Drawing.Point(1115, 101);
            this.pPlayer2.Name = "pPlayer2";
            this.pPlayer2.RowCount = 4;
            this.pPlayer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pPlayer2.Size = new System.Drawing.Size(639, 629);
            this.pPlayer2.TabIndex = 3;
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
            this.bPass.Location = new System.Drawing.Point(664, 22);
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
            this.infoText.Location = new System.Drawing.Point(664, 101);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoText.Size = new System.Drawing.Size(445, 442);
            this.infoText.TabIndex = 0;
            // 
            // bResolve
            // 
            this.bResolve.Location = new System.Drawing.Point(413, 858);
            this.bResolve.Name = "bResolve";
            this.bResolve.Size = new System.Drawing.Size(302, 46);
            this.bResolve.TabIndex = 13;
            this.bResolve.Text = "RESOLVE";
            this.bResolve.UseVisualStyleBackColor = true;
            this.bResolve.Click += new System.EventHandler(this.bResolve_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.Button bPass;
        private System.Windows.Forms.Label lPlayer1;
        private System.Windows.Forms.TableLayoutPanel pPlayer1;
        private System.Windows.Forms.TableLayoutPanel pPlayer2;
        private System.Windows.Forms.Label lPlayer2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button bDiscard;
        private System.Windows.Forms.Button bAsk;
        private System.Windows.Forms.ComboBox cbQuestion;
        private System.Windows.Forms.Label lTurnName;
        private System.Windows.Forms.Label lCount2;
        private System.Windows.Forms.Label lCount1;
        private System.Windows.Forms.Button bResolve;
    }
}

