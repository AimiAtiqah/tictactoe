using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X turn, False = Y turn
        int turn_count= 0;//initialize count for turns


        public Form1()
        {
            InitializeComponent();
        }
              
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Aimi 10 May 2020", "Tic Tac Toe 1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            //sender = b, object = button. passing sender object as the button
            Button b = (Button)sender;

            //when button is clicked
            if (turn)
                b.Text = "X"; //if its the person's turn, the text property of the button is X
            else
                b.Text = "O";//else, if not their turn, text will be O

            turn = !turn;
            //but when the button that's already been clicked, is clikced again, 
            //it changed the present value in the box to the opposite value
            //so, to control that:
            b.Enabled = false; //so when the button already clicked, it will be disabled

            checkforwin();//every loop will check if there is winner using the below function
        }

        private void checkforwin()
        {
            bool winnerishere = false;

            //horizontal checking
            if ((R1C1.Text == R1C2.Text) && (R1C2.Text == R1C3.Text) && (!R1C1.Enabled))//checks if R1C! is enabled. disabled means it si completed. can be any button in the row
                winnerishere = true;
            else if((R2C1.Text == R2C2.Text) && (R2C2.Text == R2C3.Text) && (!R2C1.Enabled))
                winnerishere = true;
            else if ((R3C1.Text == R3C2.Text) && (R3C2.Text == R3C3.Text) && (!R3C1.Enabled))
                winnerishere = true;


            if (winnerishere) //when winnerishere = true, then this is called
            {
                disableButtons();

                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins!", "Yay!");
            }//end winnerishere
        }//end checkforwin

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls) //for each button is our form1, we want to disable the buttons after there is winner
                {
                    Button b = (Button) c;
                    b.Enabled = false;
                }//end foreach

            } //endtry

            catch { }
            
        }//end disablebuttons
    }
}
