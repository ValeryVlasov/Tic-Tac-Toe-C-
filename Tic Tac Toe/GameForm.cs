using System.Drawing.Design;

namespace Tic_Tac_Toe
{
    public partial class GameForm : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer = Player.X;
        Random random = new Random();
        int playerOneWinCount = 0;
        int PlayerTwoOrCPUWinCount = 0;
        List<Button> buttons;
        bool IsPlayerVSCPU = true;


        public GameForm(bool _IsPlayerVSCPU)
        {
            InitializeComponent();
            IsPlayerVSCPU = _IsPlayerVSCPU;
            if (!IsPlayerVSCPU)
                SecondPlayerOrCPULabel.Left = SecondPlayerOrCPULabel.Location.X - 15;
            RestartGame();
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (IsPlayerVSCPU)
            {
                if (CPUTimer.Enabled) return;

                currentPlayer = Player.X;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Cyan;
                buttons.Remove(button);
                CheckGame();
                CPUTimer.Start();
            }
            else
            {
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                if (currentPlayer.Equals(Player.X))
                {
                    button.BackColor = Color.Cyan;
                    currentPlayer = Player.O;
                }
                else
                {
                    button.BackColor = Color.DarkSalmon;
                    currentPlayer = Player.X;
                }
                buttons.Remove(button);
                CheckGame();
            }
        }
        private void CPUMove(object sender, EventArgs e)
        {
            if (buttons.Count <= 0) return;

            int index = random.Next(buttons.Count);
            buttons[index].Enabled = false;
            currentPlayer = Player.O;
            buttons[index].Text = currentPlayer.ToString();
            buttons[index].BackColor = Color.DarkSalmon;
            buttons.RemoveAt(index);
            CheckGame();
            CPUTimer.Stop();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private bool checkCombinationsToWin(string player)
        {
            return button1.Text == player && button2.Text == player && button3.Text == player
                || button4.Text == player && button5.Text == player && button6.Text == player
                || button7.Text == player && button8.Text == player && button9.Text == player
                || button1.Text == player && button4.Text == player && button7.Text == player
                || button2.Text == player && button5.Text == player && button8.Text == player
                || button3.Text == player && button6.Text == player && button9.Text == player
                || button1.Text == player && button5.Text == player && button9.Text == player
                || button3.Text == player && button5.Text == player && button7.Text == player;
        }

        private void CheckGame()
        {
            if (checkCombinationsToWin("X"))
            {
                playerOneWinCount++;
                if (IsPlayerVSCPU)
                {
                    CPUTimer.Stop();
                    MessageBox.Show("You Win!", "Player wins!");
                }
                else
                    MessageBox.Show("First player wins!", "Player1 wins!");
                PlayerOneWinCounter.Text = playerOneWinCount.ToString();
                RestartGame();
            }
            else if (checkCombinationsToWin("O"))
            {
                PlayerTwoOrCPUWinCount++;
                if (IsPlayerVSCPU)
                {
                    CPUTimer.Stop();
                    MessageBox.Show("You lost!", "CPU wins!");
                }
                else
                    MessageBox.Show("Second player wins!", "Player2 wins!");
                PlayerTwoOrCPUWinCounter.Text = PlayerTwoOrCPUWinCount.ToString();
                RestartGame();
            }
            else if (buttons.Count == 0)
            {
                MessageBox.Show("Draw!", "Sometimes there is no winner");
                RestartGame();
            }
        }

        private void RestartGame()
        {
            if (!IsPlayerVSCPU)
            {
                FirstPlayerLabel.Text = "Player1 Wins: ";
                SecondPlayerOrCPULabel.Text = "Player2 Wins: ";
            }
            buttons = new List<Button> { button1, button8, button5,
                                                         button2, button9, button4,
                                                         button6, button3, button7};
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
                button.BackColor = DefaultBackColor;
            }
        }

    }
}