using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class GameDetails : Form
    {
        private Form launcherForm;
        public GameDetails(Form launcher)
        {
            InitializeComponent();
            launcherForm = launcher;
            SetupDetailsForm();
        }
        private void SetupDetailsForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.Text = "Game Details";

            // --- Подключение обработчиков ---
            this.btnBack.Click += BtnBack_Click;
            this.btnExit.Click += BtnExit_Click;
            this.listBoxTitles.SelectedIndexChanged += ListBoxTitles_SelectedIndexChanged; // <-- ГЛАВНАЯ ЛОГИКА

            // Показываем лончер при закрытии
            this.FormClosed += (s, e) => launcherForm.Show();

            // --- Заполняем ListBox ---
            PopulateTitles();

            // Выбираем первый элемент по умолчанию
            if (this.listBoxTitles.Items.Count > 0)
            {
                this.listBoxTitles.SelectedIndex = 0;
            }
        }

        // --- Заполнение списка ---
        private void PopulateTitles()
        {
            // (В соответствии с документацией)
            this.listBoxTitles.Items.Add("Spielübersicht");         // Индекс 0
            this.listBoxTitles.Items.Add("Regeln: BaseGame");       // Индекс 1
            this.listBoxTitles.Items.Add("Regeln: ScalableGame");   // Индекс 2
        }

        // --- Логика выбора в ListBox (Главная функция) ---
        private void ListBoxTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.listBoxTitles.SelectedIndex;

            switch (selectedIndex)
            {
                // --- Случай 0: Обзор Игры ---
                case 0:
                    this.lblDetails.Text = "Das MatchingGame ist eine digitale Version des klassischen 'Memory'-Spiels.\n\n" +
                                           "Ziel ist es, alle Paare von übereinstimmenden Karten auf dem Spielfeld zu finden.\n\n" +
                                           "Die Anwendung umfasst mehrere Spielmodi, Statistiken und Spielinformationen.";
                    break;

                // --- Случай 1: BaseGame ---
                case 1:
                    this.lblDetails.Text = "BaseGame ist der klassische Modus.\n\n" +
                                           "Regeln:\n" +
                                           "- Kartenanzahl: 32 (16 Paare).\n" +
                                           "- Kartentyp: Symbole (Schriftart 'Wingdings').\n" +
                                                       "- Zeitmessung: NEIN.\n" +
                                           "- Punkte speichern: NEIN.\n\n" +
                                           "Ziel: Alle 16 Paare finden.";
                    break;

                // --- Случай 2: ScalableCardsGame ---
                case 2:
                    this.lblDetails.Text = "ScalableCardsGame ist ein fortgeschrittener, zeitgesteuerter Modus.\n\n" +
                                           "Regeln:\n" +
                                           "- Kartenanzahl: Wählbar (40, 48, 56 oder 64).\n" +
                                           "- Kartentyp: Bilder (aus dem Ordner 'Images').\n" +
                                           "- Zeitmessung: JA (Stoppuhr).\n" +
                                           "- Punkte speichern: JA (Task G).\n\n" +
                                           "Ziel: Alle Paare so schnell wie möglich finden.";
                    break;

                // --- Случай по умолчанию ---
                default:
                    this.lblDetails.Text = "Bitte wählen Sie ein Thema aus der Liste auf der linken Seite.";
                    break;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
