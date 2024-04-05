using System.ComponentModel;
using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool turn = true;// true = x turn false = o turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kitr made this also its literally tic tac toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";


                MessageBox.Show(winner + " wins! very kitr moment :D", "kitr moment");



            }// end if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("draw! not very kitr moment :(", "not kitr moment");
            }

        }// end checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }// end foreach
            }// end try
            catch { }



        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }// end foreach
            }// end try
            catch { }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1 - Kitr's Tic Tac Toe", "Other");
        }

        private void tgdfdsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
