namespace Memory_Game
{
    partial class BaseGame
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
            lblTitle = new Label();
            lblGameType = new Label();
            btnExit = new Button();
            btnBack = new Button();
            btnStart = new Button();
            gamePanel = new FlowLayoutPanel();
            lblStatus = new Label();
            lblTurnsCount = new Label();
            lblPairsCount = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(184, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
           
            // 
            // lblGameType
            // 
            lblGameType.AutoSize = true;
            lblGameType.Location = new Point(313, 82);
            lblGameType.Name = "lblGameType";
            lblGameType.Size = new Size(50, 20);
            lblGameType.TabIndex = 1;
            lblGameType.Text = "label2";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(102, 158);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "button1";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(263, 166);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "button2";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(434, 191);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "button3";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            gamePanel.Location = new Point(228, 286);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(250, 125);
            gamePanel.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(492, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "label1";
            // 
            // lblTurnsCount
            // 
            lblTurnsCount.AutoSize = true;
            lblTurnsCount.Location = new Point(509, 117);
            lblTurnsCount.Name = "lblTurnsCount";
            lblTurnsCount.Size = new Size(50, 20);
            lblTurnsCount.TabIndex = 7;
            lblTurnsCount.Text = "label2";
            // 
            // lblPairsCount
            // 
            lblPairsCount.AutoSize = true;
            lblPairsCount.Location = new Point(620, 93);
            lblPairsCount.Name = "lblPairsCount";
            lblPairsCount.Size = new Size(50, 20);
            lblPairsCount.TabIndex = 8;
            lblPairsCount.Text = "label3";
            // 
            // BaseGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPairsCount);
            Controls.Add(lblTurnsCount);
            Controls.Add(lblStatus);
            Controls.Add(gamePanel);
            Controls.Add(btnStart);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(lblGameType);
            Controls.Add(lblTitle);
            Name = "BaseGame";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblGameType;
        private Button btnExit;
        private Button btnBack;
        private Button btnStart;
        private FlowLayoutPanel gamePanel;
        private Label lblStatus;
        private Label lblTurnsCount;
        private Label lblPairsCount;
    }
}