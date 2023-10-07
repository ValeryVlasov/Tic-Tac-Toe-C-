using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void PlayerVSPlayerMode(object sender, EventArgs e)
        {
            GameForm playForm = new GameForm(false);
            playForm.Show();
            Hide();
        }

        private void PlayerVSCPUMode(object sender, EventArgs e)
        {
            GameForm form = new GameForm(true);
            form.Show();
            Hide();
        }
    }
}
