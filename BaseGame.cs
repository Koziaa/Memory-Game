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
    public partial class BaseGame : Form
    {
        // Variables for game logic
        private Button firstCard = null;
        private Button secondCard = null;
        private int turns = 0;
        private int pairsFound = 0;
        //Documentation requirements
        private const int TotalCards = 32;
        private const int TotalPairs = 16;
        private List<Button> cardButtons = new List<Button>(); 
        private List<string> cardValues = new List<string>();
        private Form launcherForm;
        public BaseGame(Form launcher)
        {
            InitializeComponent();
            
 


        }
        private void CreateCardButtons()
        {
            for (int i = 0; i < TotalCards; i++)
            {
                Button card = new Button();
                card.Size = new Size(115, 115);
                card.Font = new Font("Windings", 48, FontStyle.Bold);
                card.ForeColor = Color.White;
                card.BackColor = Color.DarkRed;
                card.Text = string.Empty;
                card.Enabled = false;
                
                cardButtons.Add(card);
                this.gamePanel.Controls.Add(card);
            }

        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            turns = 0;
            pairsFound = 0;
            //Updating Labels
            this.lblStatus.Text = "In Game";
            this.lblTurnsCount.Text = "0";
            this.lblPairsCount.Text = "0";
            firstCard = null;
            secondCard = null;
            // Creating cards
            cardValues.Clear();
            var symbols = new List<string>
            {
                "A", "B", "C", "D", "E", "F","R", "Q",
                "H", "I", "X", "Y", "Z", "O", "P", "M"
            };
            foreach (var item in symbols)
            {
                cardValues.Add(item);
                cardValues.Add(item);
            }
            //Shuffling Cards
            Random rand = new Random();
            cardValues = cardValues.OrderBy(x => rand.Next()).ToList();
            // Giving meaning to cards
            for (int i = 0; i < cardValues.Count; i++)
            {
                cardButtons[i].Enabled = true;
                cardButtons[i].Text = string.Empty; 
                cardButtons[i].BackColor = Color.DodgerBlue;
                cardButtons[i].Tag = cardValues[i];

            }
        }


        private void  Card_Click(object sender, EventArgs e)
        {
            Button clickedCard = sender as Button;
            if (secondCard != null || !clickedCard.Enabled || clickedCard == firstCard)
            {
                return;
            }
            clickedCard.Text = clickedCard.Tag.ToString();
            clickedCard.BackColor = Color.White;
            clickedCard.ForeColor = Color.Black;
            if(firstCard == null)
            {
                firstCard = clickedCard;
                return;
            }
            secondCard = clickedCard;
            turns++;
            this.lblTurnsCount.Text = turns.ToString();
            if( firstCard.Tag.ToString() == secondCard.Tag.ToString() )
            {
                pairsFound++;
                lblPairsCount.Text = pairsFound.ToString();
                firstCard.Enabled = false;
                secondCard.Enabled = false;
                firstCard.BackColor = Color.LightBlue;
                secondCard.BackColor = Color.LightBlue;
                firstCard = null;
                secondCard = null;
            }
            if(pairsFound == TotalPairs)
            {
                this.lblStatus.Text = "Victory!";
            }
        }
    }
 }
 



