namespace Memory_Game
{
    partial class GameDetails
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
            btnBack = new Button();
            btnExit = new Button();
            lblGameType = new Label();
            lblTitle = new Label();
            listBoxTitles = new ListBox();
            lblDetails = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(518, 406);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Zurück";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(675, 402);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 36);
            btnExit.TabIndex = 1;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // lblGameType
            // 
            lblGameType.AutoSize = true;
            lblGameType.Location = new Point(12, 21);
            lblGameType.Name = "lblGameType";
            lblGameType.Size = new Size(94, 20);
            lblGameType.TabIndex = 2;
            lblGameType.Text = "GameDetails";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(633, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 20);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "MatchingGame";
            // 
            // listBoxTitles
            // 
            listBoxTitles.FormattingEnabled = true;
            listBoxTitles.Location = new Point(12, 63);
            listBoxTitles.Name = "listBoxTitles";
            listBoxTitles.Size = new Size(270, 384);
            listBoxTitles.TabIndex = 4;
            // 
            // lblDetails
            // 
            lblDetails.BorderStyle = BorderStyle.FixedSingle;
            lblDetails.Location = new Point(330, 63);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(439, 336);
            lblDetails.TabIndex = 5;
            lblDetails.Text = "Titles";
            // 
            // GameDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDetails);
            Controls.Add(listBoxTitles);
            Controls.Add(lblTitle);
            Controls.Add(lblGameType);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Name = "GameDetails";
            Text = "GameDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnExit;
        private Label lblGameType;
        private Label lblTitle;
        private ListBox listBoxTitles;
        private Label lblDetails;
    }
}