namespace Memory_Game
{
    partial class ScalableCardGames
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
            btnStart = new Button();
            btnReset = new Button();
            lblTitle = new Label();
            lblGameType = new Label();
            lblStatus = new Label();
            lblPairsCount = new Label();
            lblTurnsCount = new Label();
            lblTime = new Label();
            gamePanel = new FlowLayoutPanel();
            cmbCardsCount = new ComboBox();
            btnBack = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(0, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(99, 43);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(277, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "MatchingGame";
            // 
            // lblGameType
            // 
            lblGameType.AutoSize = true;
            lblGameType.Location = new Point(388, 21);
            lblGameType.Name = "lblGameType";
            lblGameType.Size = new Size(141, 20);
            lblGameType.TabIndex = 3;
            lblGameType.Text = "ScalableCardsGame";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(357, 98);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblPairsCount
            // 
            lblPairsCount.AutoSize = true;
            lblPairsCount.Location = new Point(510, 67);
            lblPairsCount.Name = "lblPairsCount";
            lblPairsCount.Size = new Size(80, 20);
            lblPairsCount.TabIndex = 5;
            lblPairsCount.Text = "Paaranzahl";
            // 
            // lblTurnsCount
            // 
            lblTurnsCount.AutoSize = true;
            lblTurnsCount.Location = new Point(429, 67);
            lblTurnsCount.Name = "lblTurnsCount";
            lblTurnsCount.Size = new Size(78, 20);
            lblTurnsCount.TabIndex = 6;
            lblTurnsCount.Text = "Zuganzahl";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(483, 114);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(35, 20);
            lblTime.TabIndex = 7;
            lblTime.Text = "Zeit";
            // 
            // gamePanel
            // 
            gamePanel.Location = new Point(301, 261);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(250, 125);
            gamePanel.TabIndex = 8;
            // 
            // cmbCardsCount
            // 
            cmbCardsCount.FormattingEnabled = true;
            cmbCardsCount.Location = new Point(99, 207);
            cmbCardsCount.Name = "cmbCardsCount";
            cmbCardsCount.Size = new Size(151, 28);
            cmbCardsCount.TabIndex = 0;
            cmbCardsCount.Text = "Kartenanzahl";
            cmbCardsCount.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(174, 150);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Zurück";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(55, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // ScalableCardGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(cmbCardsCount);
            Controls.Add(gamePanel);
            Controls.Add(lblTime);
            Controls.Add(lblTurnsCount);
            Controls.Add(lblPairsCount);
            Controls.Add(lblStatus);
            Controls.Add(lblGameType);
            Controls.Add(lblTitle);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Name = "ScalableCardGames";
            Text = "ScalableCardGames";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnReset;
        private Label lblTitle;
        private Label lblGameType;
        private Label lblStatus;
        private Label lblPairsCount;
        private Label lblTurnsCount;
        private Label lblTime;
        private FlowLayoutPanel gamePanel;
        private ComboBox cmbCardsCount;
        private Button btnBack;
        private Button btnExit;
    }
}