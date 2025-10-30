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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(492, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MatchingGame";
            // 
            // lblGameType
            // 
            lblGameType.AutoSize = true;
            lblGameType.Location = new Point(548, 195);
            lblGameType.Name = "lblGameType";
            lblGameType.Size = new Size(79, 20);
            lblGameType.TabIndex = 1;
            lblGameType.Text = "BaseGame";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(803, 655);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(309, 655);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Zurück";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(533, 655);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += Btn_Start_Click;
            // 
            // gamePanel
            // 
            gamePanel.Location = new Point(230, 242);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(753, 407);
            gamePanel.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(70, 242);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // lblTurnsCount
            // 
            lblTurnsCount.AutoSize = true;
            lblTurnsCount.Location = new Point(887, 70);
            lblTurnsCount.Name = "lblTurnsCount";
            lblTurnsCount.Size = new Size(78, 20);
            lblTurnsCount.TabIndex = 7;
            lblTurnsCount.Text = "Zuganzahl";
            // 
            // lblPairsCount
            // 
            lblPairsCount.AutoSize = true;
            lblPairsCount.Location = new Point(887, 140);
            lblPairsCount.Name = "lblPairsCount";
            lblPairsCount.Size = new Size(80, 20);
            lblPairsCount.TabIndex = 8;
            lblPairsCount.Text = "Paaranzahl";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(492, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // BaseGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 711);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}