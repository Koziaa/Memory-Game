using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Memory_Game
{
    public partial class ScalableCardGames : Form
    {
        private Button firstCard = null;
        private Button secondCard = null;
        private System.Windows.Forms.Timer gameTimer;
        private int turns = 0;
        private int pairsFound = 0;
        private int totalPairs = 0;
        private int currentCardCount = 0;
        private int timeCount = 0;
        private bool gameWon = false;
        private List<Button> cardButtons = new List<Button>();
        private List<string> cardValues = new List<string>();
        private string imagesFolderPath = Path.Combine(Application.StartupPath, "Images"); // Way to pictures
        private List<string> imagePaths = new List<string>();
        private Form launcherForm;
        public ScalableCardGames(Form laucher)
        {
            InitializeComponent();
            launcherForm = laucher;
            SetupScalableGame();
        }
        private void SetupScalableGame()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            // Timer Settings
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000; // 1 sec
            gameTimer.Tick += GameTimer_Tick; // 

            // Combo box settings according to documentation
            this.cmbCardsCount.Items.Add("Kartenanzahl auswählen...");
            this.cmbCardsCount.Items.Add("40 Karten (20 Paare)");
            this.cmbCardsCount.Items.Add("48 Karten (24 Paare)");
            this.cmbCardsCount.Items.Add("56 Karten (28 Paare)");
            this.cmbCardsCount.Items.Add("64 Karten (32 Paare)");
            this.cmbCardsCount.SelectedIndex = 0;
            // Connecting event handlers
            this.cmbCardsCount.SelectedIndexChanged += SelectedIndexChanged;
            this.btnStart.Click += BtnStart_Click;
            this.btnReset.Click += BtnReset_Click;
            this.btnBack.Click += BtnBack_Click;
            this.btnExit.Click += BtnExit_Click;
            // Reseting buttons according to documentation
            ResetGameUI(false);
            // Opening launcher
            this.FormClosed += (s, e) => launcherForm.Show();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCardsCount.SelectedIndex > 0)
            {
                //Enabling buttons according to documentation
                btnStart.Enabled = true;
                btnReset.Enabled = true;

                string selection = this.cmbCardsCount.SelectedItem.ToString();
                if (selection.StartsWith("40"))
                {
                    currentCardCount = 40;
                }
                else if (selection.StartsWith("48"))
                {
                    currentCardCount = 48;
                }
                else if (selection.StartsWith("56"))
                {
                    currentCardCount = 56;
                }
                else
                {
                    currentCardCount = 64;
                }
                totalPairs = currentCardCount / 2;
                lblStatus.Text = "Status: Bereit";
            }
        }
        private void LoadImagePaths()
        {
            imagePaths.Clear();
            if (Directory.Exists(imagesFolderPath))
            {
                // Загружаем все .jpg и .png файлы
                imagePaths = Directory.GetFiles(imagesFolderPath, "*.jpg")
                                    .Concat(Directory.GetFiles(imagesFolderPath, "*.png"))
                                    .ToList();
            }
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            LoadImagePaths();
            gameWon = false;
            turns = 0;
            pairsFound = 0;
            timeCount = 0;
            //Updating Labels
            this.lblStatus.Text = "In Game";
            this.lblTurnsCount.Text = "0";
            this.lblPairsCount.Text = "0";
            firstCard = null;
            secondCard = null;
            gamePanel.Controls.Clear();
            cardButtons.Clear();
            //Blocking Combo Box according to documentation
            this.cmbCardsCount.Enabled = false;
            CreateCardButtons();

            cardValues.Clear();
            Random rand = new Random();
            // Adding images for cards randomly
            List<string> selectedImages = imagePaths.OrderBy(x => rand.Next()).Take(totalPairs).ToList();
            foreach (string imgPath in selectedImages)
            {
                cardValues.Add(imgPath); // path2
                cardValues.Add(imgPath); // path2
            }

            cardValues = cardValues.OrderBy(x => rand.Next()).ToList();

            for (int i = 0; i < cardButtons.Count; i++)
            {
                cardButtons[i].Enabled = true;
                cardButtons[i].Text = string.Empty; //  face
                cardButtons[i].BackColor = Color.DarkGray;
                cardButtons[i].Tag = cardValues[i]; // putting path into tag
                cardButtons[i].BackgroundImage = null; // showing face of the card
            }
            gameTimer.Start();
        }

        private void CreateCardButtons()
        {
            int size = 120;
            if (currentCardCount > 48)
            {
                size = 100;
            }
            else if (currentCardCount > 56)
            {
                size = 75;
            }
            for (int i = 0; i < currentCardCount; i++)
            {
                Button card = new Button();
                card.Size = new Size(size, size);
                card.BackColor = Color.Black;
                card.Text = string.Empty;
                card.Enabled = false;
                card.Click += Card_Click;
                //Setting vision acc. to documantation
                card.BackgroundImageLayout = ImageLayout.Zoom;

                cardButtons.Add(card);
                gamePanel.Controls.Add(card);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetGameUI(true);

        }
        private void ResetGameUI(bool stopTimer)
        {
            if (stopTimer) gameTimer.Stop();
            gamePanel.Controls.Clear();
            this.cmbCardsCount.Enabled = true;
            this.cmbCardsCount.SelectedIndex = 0;
            btnReset.Enabled = false;
            btnStart.Enabled = false;
            lblStatus.Text = "Status: Wählen die Anzahl ";
            lblTurnsCount.Text = "0";
            lblPairsCount.Text = "0";
            lblTime.Text = "0";
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeCount++; // + 1 second
            lblTime.Text = timeCount.ToString(); // Updating Label
        }
        private async void Card_Click(object sender, EventArgs e)
        {
            Button clickedCard = sender as Button;

            // Ignoring unnessesery clicks
            if (gameWon ||secondCard != null || !clickedCard.Enabled || clickedCard == firstCard)
            {
                return;
            }

            // Uploading picture from Tag
            clickedCard.BackgroundImage = Image.FromFile(clickedCard.Tag.ToString()); //
            clickedCard.BackColor = Color.White;

            if (firstCard == null)
            {
                firstCard = clickedCard;
                return;
            }

            secondCard = clickedCard;
            turns++;
            lblTurnsCount.Text = turns.ToString();

            if (firstCard.Tag.ToString() == secondCard.Tag.ToString())
            {
                // Match
                pairsFound++;
                lblPairsCount.Text = pairsFound.ToString();
                firstCard.Enabled = false;
                secondCard.Enabled = false;
                firstCard.BackColor = Color.LightGreen;
                secondCard.BackColor = Color.LightGreen;
                firstCard = null;
                secondCard = null;

                // Looking for victory
                if (pairsFound == totalPairs)
                {
                    gameWon = true;
                    gameTimer.Stop();
                    lblStatus.Text = "Status: Victory!";


                    ShowSaveDialog(); //
                }
            }
            else
            {
                // No match
                await Task.Delay(1000);
                if (firstCard == null) return;

                // Hiding face of the card
                clickedCard.BackgroundImage = null;
                clickedCard.BackColor = Color.DarkOrange;
                firstCard.BackgroundImage = null;
                firstCard.BackColor = Color.DarkOrange;

                firstCard = null;
                secondCard = null;
            }
        }
        private void ShowSaveDialog()
        {


            StatisticsSaveDialog saveDialog = new StatisticsSaveDialog(currentCardCount, timeCount);
            saveDialog.ShowDialog();



        }
    }
}
