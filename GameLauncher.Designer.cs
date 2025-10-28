namespace Memory_Game
{
    partial class GameLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            picLogo = new PictureBox();
            btnExit = new Button();
            btnBaseGame = new Button();
            btnScalableGame = new Button();
            btnMultiModalGame = new Button();
            btnGameDetails = new Button();
            btnGameStatistics = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(107, 130);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MatchingGame";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(149, 23);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(125, 62);
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(84, 198);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // btnBaseGame
            // 
            btnBaseGame.Location = new Point(223, 197);
            btnBaseGame.Name = "btnBaseGame";
            btnBaseGame.Size = new Size(94, 29);
            btnBaseGame.TabIndex = 3;
            btnBaseGame.Text = "BaseGame";
            btnBaseGame.UseVisualStyleBackColor = true;
            btnBaseGame.Click += BtnBaseGame_Click;
            // 
            // btnScalableGame
            // 
            btnScalableGame.Location = new Point(59, 283);
            btnScalableGame.Name = "btnScalableGame";
            btnScalableGame.Size = new Size(152, 29);
            btnScalableGame.TabIndex = 4;
            btnScalableGame.Text = "ScalableCardsGame";
            btnScalableGame.UseVisualStyleBackColor = true;
            // 
            // btnMultiModalGame
            // 
            btnMultiModalGame.Location = new Point(217, 270);
            btnMultiModalGame.Name = "btnMultiModalGame";
            btnMultiModalGame.Size = new Size(137, 29);
            btnMultiModalGame.TabIndex = 5;
            btnMultiModalGame.Text = "MultiModalGame";
            btnMultiModalGame.UseVisualStyleBackColor = true;
            // 
            // btnGameDetails
            // 
            btnGameDetails.Location = new Point(360, 339);
            btnGameDetails.Name = "btnGameDetails";
            btnGameDetails.Size = new Size(105, 29);
            btnGameDetails.TabIndex = 6;
            btnGameDetails.Text = "GameDetails";
            btnGameDetails.UseVisualStyleBackColor = true;
            // 
            // btnGameStatistics
            // 
            btnGameStatistics.Location = new Point(197, 339);
            btnGameStatistics.Name = "btnGameStatistics";
            btnGameStatistics.Size = new Size(120, 29);
            btnGameStatistics.TabIndex = 7;
            btnGameStatistics.Text = "GameStatistics";
            btnGameStatistics.UseVisualStyleBackColor = true;
            // 
            // GameLauncher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGameStatistics);
            Controls.Add(btnGameDetails);
            Controls.Add(btnMultiModalGame);
            Controls.Add(btnScalableGame);
            Controls.Add(btnBaseGame);
            Controls.Add(btnExit);
            Controls.Add(picLogo);
            Controls.Add(lblTitle);
            Name = "GameLauncher";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox picLogo;
        private Button btnExit;
        private Button btnBaseGame;
        private Button btnScalableGame;
        private Button btnMultiModalGame;
        private Button btnGameDetails;
        private Button btnGameStatistics;
    }
}
