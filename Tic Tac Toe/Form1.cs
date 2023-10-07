using System.Drawing.Design;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer = Player.X;
        Random random = new Random();
        int playerWinCount = 0;
        int secondPlayerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        bool IsPlayerVSCPU = true;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        public Form1(bool _IsPlayerVSCPU)
        {
            InitializeComponent();
            IsPlayerVSCPU = _IsPlayerVSCPU;
            RestartGame();
        }


        private void PlayerClickButton(object sender, EventArgs e)
        {
            if (IsPlayerVSCPU)
            {
                if (CPUTimer.Enabled) return;
                var button = (Button)sender;

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
                var button = (Button)sender;

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

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                if (IsPlayerVSCPU)
                {
                    CPUTimer.Stop();
                    MessageBox.Show("You Win!", "Player wins!");
                    playerWinCount++;
                    label1.Text = "Player Wins: " + playerWinCount;
                    RestartGame();
                }
                else
                {
                    MessageBox.Show("First player wins!", "Player1 wins!");
                    playerWinCount++;
                    label1.Text = "Player1 Wins: " + playerWinCount;
                    RestartGame();
                }
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                if (IsPlayerVSCPU)
                {
                    CPUTimer.Stop();
                    MessageBox.Show("You lost!", "CPU wins!");
                    CPUWinCount++;
                    label2.Text = "CPU Wins: " + CPUWinCount;
                    RestartGame();
                }
                else
                {
                    MessageBox.Show("Second player wins!", "Player2 wins!");
                    secondPlayerWinCount++;
                    label2.Text = "Player2 Wins: " + secondPlayerWinCount;
                    RestartGame();
                }
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
                label1.Text = "Player1 Wins: ";
                label2.Text = "Player2 Wins: ";
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