namespace Forms
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bResolve = new System.Windows.Forms.Button();
            this.lCount2 = new System.Windows.Forms.Label();
            this.lCount1 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tableLayoutPanel3);
            this.mainPanel.Controls.Add(this.tableLayoutPanel2);
            this.mainPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainPanel.Controls.Add(this.pPlayer2);
            this.mainPanel.Controls.Add(this.pPlayer1);
            this.mainPanel.Controls.Add(this.infoText);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1754, 920);
            this.mainPanel.TabIndex = 0;
            // 
            // bResolve
            // 
            this.bResolve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.bResolve, 2);
            this.bResolve.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResolve.Image = ((System.Drawing.Image)(resources.GetObject("bResolve.Image")));
            this.bResolve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bResolve.Location = new System.Drawing.Point(6, 129);
            this.bResolve.Name = "bResolve";
            this.bResolve.Size = new System.Drawing.Size(445, 46);
            this.bResolve.TabIndex = 13;
            this.bResolve.Text = "RESOLVE";
            this.bResolve.UseVisualStyleBackColor = true;
            this.bResolve.Click += new System.EventHandler(this.bResolve_Click);
            // 
            // lCount2
            // 
            this.lCount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCount2.AutoSize = true;
            this.lCount2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount2.Location = new System.Drawing.Point(5, 18);
            this.lCount2.Name = "lCount2";
            this.lCount2.Size = new System.Drawing.Size(150, 109);
            this.lCount2.TabIndex = 12;
            this.lCount2.Text = "24";
            // 
            // lCount1
            // 
            this.lCount1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCount1.AutoSize = true;
            this.lCount1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount1.Location = new System.Drawing.Point(486, 18);
            this.lCount1.Name = "lCount1";
            this.lCount1.Size = new System.Drawing.Size(150, 109);
            this.lCount1.TabIndex = 11;
            this.lCount1.Text = "24";
            // 
            // bDiscard
            // 
            this.bDiscard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDiscard.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiscard.Image = ((System.Drawing.Image)(resources.GetObject("bDiscard.Image")));
            this.bDiscard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDiscard.Location = new System.Drawing.Point(232, 71);
            this.bDiscard.Name = "bDiscard";
            this.bDiscard.Size = new System.Drawing.Size(223, 41);
            this.bDiscard.TabIndex = 9;
            this.bDiscard.Text = "DISCARD SELECTEDS";
            this.bDiscard.UseVisualStyleBackColor = true;
            this.bDiscard.Click += new System.EventHandler(this.bDiscard_Click);
            // 
            // bAsk
            // 
            this.bAsk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAsk.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAsk.Image = ((System.Drawing.Image)(resources.GetObject("bAsk.Image")));
            this.bAsk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAsk.Location = new System.Drawing.Point(3, 71);
            this.bAsk.Name = "bAsk";
            this.bAsk.Size = new System.Drawing.Size(223, 41);
            this.bAsk.TabIndex = 8;
            this.bAsk.Text = "ASK";
            this.bAsk.UseVisualStyleBackColor = true;
            this.bAsk.Click += new System.EventHandler(this.bAsk_Click);
            // 
            // cbQuestion
            // 
            this.cbQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.cbQuestion, 2);
            this.cbQuestion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Location = new System.Drawing.Point(10, 16);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(437, 35);
            this.cbQuestion.TabIndex = 7;
            // 
            // pb2
            // 
            this.pb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb2.Location = new System.Drawing.Point(511, 3);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 140);
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb1.Location = new System.Drawing.Point(30, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 140);
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            // 
            // lPlayer2
            // 
            this.lPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayer2.Location = new System.Drawing.Point(252, 54);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(137, 37);
            this.lPlayer2.TabIndex = 4;
            this.lPlayer2.Text = "Player 2";
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
            this.pPlayer2.Location = new System.Drawing.Point(1115, 166);
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
            this.pPlayer1.Location = new System.Drawing.Point(6, 166);
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
            this.lPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayer1.Location = new System.Drawing.Point(255, 54);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(130, 37);
            this.lPlayer1.TabIndex = 0;
            this.lPlayer1.Text = "Player 1";
            // 
            // bPass
            // 
            this.bPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.bPass, 2);
            this.bPass.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPass.Image = ((System.Drawing.Image)(resources.GetObject("bPass.Image")));
            this.bPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPass.Location = new System.Drawing.Point(5, 194);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(448, 41);
            this.bPass.TabIndex = 1;
            this.bPass.Text = "NEXT TURN";
            this.bPass.UseVisualStyleBackColor = true;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.infoText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.infoText.Location = new System.Drawing.Point(651, 3);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoText.Size = new System.Drawing.Size(458, 540);
            this.infoText.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pb1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lPlayer1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lCount1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 146);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbQuestion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bAsk, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bResolve, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bDiscard, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bPass, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(651, 549);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(458, 246);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.lPlayer2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lCount2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pb2, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1109, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(642, 146);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 944);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Who?";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.Label lCount2;
        private System.Windows.Forms.Label lCount1;
        private System.Windows.Forms.Button bResolve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

