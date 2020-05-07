//
//NAME            : NumberGuessing.aspx.cs
//PROJECT         : PROG2001 - A6
//PROGRAMMER      : Lidiia Zhitova
//FIRST VERSION   : 2019-11-17
//DESCRIPTION     : this code behind NumberGuessing.aspx mainly contains the game logic, server-side user input validation
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a6_zhitova_l.MorePages
{
    public partial class NumberGuessing : System.Web.UI.Page
    {
        private bool didUserWin = false;


        // METHOD       : Page_Load
        // DESCRIPTION  : loads the page with the specified settings
        // PARAMETERS   : object sender, EventArgs e
        // RETURNS      : void
        protected void Page_Load(object sender, EventArgs e)
        {
            inputPrompt.Text = "What is Your Current Guess?";
            inputBox.Focus();

            // add validation method to the range validator event handler
            CustomRangeValidator.ServerValidate += new System.Web.UI.WebControls.ServerValidateEventHandler(ServerValidation);


            //if it's the first time when the user visits the page, display the following guessing range reminder
            if(!IsPostBack)
            {
                range.Text = "Allowable guessing range is from " + Session["minNum"] + " to " + Session["maxNum"];
            }
        }



        // METHOD       : submitButton_Click
        // DESCRIPTION  : executes the game logic (if the user input was valid) on the button click
        // PARAMETERS   : object sender, EventArgs e
        // RETURNS      : void
        protected void submitButton_Click(object sender, EventArgs e)
        {
            //check if the user input was valid
            if (Page.IsValid)
            {
                //execute the game logic
                GameEngine();

                //if the user wins...
                if (didUserWin)
                {
                    //send them to the next page
                    Server.Transfer("Win.aspx");
                }
            }

        }




        // METHOD       : ServerValidation
        // DESCRIPTION  : validates user input
        // PARAMETERS   : object source, ServerValidateEventArgs args
        // RETURNS      : void
        void ServerValidation(object source, ServerValidateEventArgs args)
        {
            int maxNum = Convert.ToInt32(Session["maxNum"]);
            int minNum = Convert.ToInt32(Session["minNum"]);
            int guess  = Convert.ToInt32(inputBox.Text);

            //if the guess is outside the allowed range, the it is invalid
            if (guess > maxNum || guess < minNum)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }



        // METHOD       : GameEngine
        // DESCRIPTION  : game logic
        // PARAMETERS   : none
        // RETURNS      : void
        void GameEngine()
        {
            
            int target = Convert.ToInt32(Session["target"]); //target number
            int guess  = Convert.ToInt32(inputBox.Text);     //user guess

            //if the guess and target numbers are the same...
            if (guess == target)
            {
                //... the user wins
                didUserWin = true;
            }
            //if the guess is greater than the target, guess becomes the maxNum
            else if (guess > target)
            {
                Session["maxNum"] = guess;
            }
            //if the guess is less than the target, guess becomes the minNum
            else
            {
                Session["minNum"] = guess;
            }

            //update the allowable range reminder
            range.Text = "Allowable guessing range is from " + Session["minNum"] + " to " + Session["maxNum"];
        }
    }
}