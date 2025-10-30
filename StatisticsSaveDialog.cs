using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Memory_Game
{

    public partial class StatisticsSaveDialog : Form
    {
        private int cardCount;
        private int gameTimeInSeconds;
        private string gameDate;

        // Document for saving data acc doc.
        private string statisticsFileName = "GameStatistics.txt";
        public StatisticsSaveDialog(int cards, int time)
        {
            InitializeComponent();
            this.cardCount = cards;
            this.gameTimeInSeconds = time;
            this.gameDate = DateTime.Now.ToString("dd.MM.yyyy"); // "29.10.2025"

            // 2. Настраиваем форму
            SetupDialog();
        }
        private void SetupDialog()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ControlBox = false; // 
            this.Text = "Speichern";

            // Updating buttons
            this.lblStats.Text = $"Cards: {cardCount} | Time: {gameTimeInSeconds} sec. | Date: {gameDate}";


            

            // Connecting buttons
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string playerName = this.txtPlayerName.Text;
            string lineToSave = $"{playerName};{gameTimeInSeconds};{gameDate};{cardCount}";

            try
            {
                // 4. Добавляем (Append) строку в конец файла
                // (Path.Combine - чтобы путь к файлу был правильный)
                string filePath = Path.Combine(Application.StartupPath, statisticsFileName);

                // 'true' означает "добавить в конец", а не "перезаписать"
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(lineToSave);
                }

                // 5. Закрываем окно
                this.DialogResult = DialogResult.OK; // 
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show($"Didn't work out {ex.Message}");
            }
        }
    }
}

