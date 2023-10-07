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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PlayerVSPlayerMode(object sender, EventArgs e)
        {
            Form1 playForm = new Form1(false);
            playForm.Show();
            Hide();
        }

        private void PlayerVSCPUMode(object sender, EventArgs e)
        {
            Form1 form = new Form1(true);
            form.Show();
            Hide();
        }
    }
}
