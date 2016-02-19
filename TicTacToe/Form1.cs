using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        bool playerSelector = true;
        string mark = "";
        int turns = 0;
        private string PlayerSelector()
        {
            if (playerSelector)
            {
                mark = "X";
            }
            else
            {
                mark = "O";
            }

            playerSelector = !playerSelector;

            return mark;
        }

        private void StartNewGame()
        {
            try
            {
                foreach (var control in Controls)
                {
                    Button button = (Button)control;
                    turns = 0;
                    button.Text = "";
                    button.Enabled = true;
                }
            }
            catch (Exception e) { }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            turns++;
            mark = PlayerSelector();
            Button button = (Button)sender;
            button.Text = mark;
            button.Enabled = false;
            CheckForWinner();

            if (turns == 9)
            {
                MessageBox.Show("Draw!");
                StartNewGame();
            }
        }

        private void DisableButtons()
        {
            foreach (Control control in Controls)
            {
                try
                {

                    Button button = (Button)control;
                    button.Enabled = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void CheckForWinner()
        {

            //horizontal checks
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "") 
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }

            if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }

            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }

            //vertical checks
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }

            if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }

            if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }

            //diagonal checks
            if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }
            if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
            {
                MessageBox.Show("Player who used " + mark + " is the winner!");
                StartNewGame();
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Late night Tic Tac Toe by Nikolay Kolibarov feat Daniel & Gonzi");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
