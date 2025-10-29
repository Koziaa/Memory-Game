namespace Memory_Game
{
    public partial class GameLauncher : Form
    {
        public GameLauncher()
        {
            InitializeComponent();
            SetupLauncher();
        }
        private void SetupLauncher()
        {
            this.btnExit.Click += BtnExit_Click;
            this.btnBaseGame.Click += BtnBaseGame_Click;
            // Design 
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.TopMost = true;
            //TipTool
            ToolTip toolTipForButtons = new ToolTip();
            toolTipForButtons.SetToolTip(this.btnBaseGame, "Start BaseGame");
            toolTipForButtons.SetToolTip(this.btnGameDetails, "Show Details");
            toolTipForButtons.SetToolTip(this.btnGameStatistics, "Show Statistics");
            toolTipForButtons.SetToolTip(this.btnMultiModalGame, "Start MultiModalGame");
            toolTipForButtons.SetToolTip(this.btnScalableGame, "Start ScalableCardsGame");
            //Status of Buttons
            this.btnBaseGame.Enabled = true;
            this.btnGameDetails.Enabled = false;
            this.btnMultiModalGame.Enabled = false;
            this.btnScalableGame.Enabled = true;
            this.btnGameStatistics.Enabled = false;


        }






        private void BtnBaseGame_Click(object sender, EventArgs e)
        {
            BaseGame gameForm = new BaseGame(this);
            gameForm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        private void BtnScalableCardsGame_Click(object sender, EventArgs e)
        {
            ScalableCardGames gameForm = new ScalableCardGames(this);
            gameForm.Show();
            this.Hide();
        }
    }
}
