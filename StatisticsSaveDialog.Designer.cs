namespace Memory_Game
{
    partial class StatisticsSaveDialog
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
            btnSave = new Button();
            btnCancel = new Button();
            textBox1 = new TextBox();
            lblName = new Label();
            lblStats = new Label();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(226, 200);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Speichern";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Abbrechnen";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 73);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Ihre Name: ";
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(113, 143);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(50, 20);
            lblStats.TabIndex = 4;
            lblStats.Text = "label2";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(42, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(237, 20);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Victory! Ihre Ergebnisse speichern?";
            // 
            // StatisticsSaveDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 253);
            Controls.Add(lblInfo);
            Controls.Add(lblStats);
            Controls.Add(lblName);
            Controls.Add(textBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "StatisticsSaveDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox textBox1;
        private Label lblName;
        private Label lblStats;
        private Label lblInfo;
    }
}