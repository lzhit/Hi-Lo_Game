//
// NAME            : MaxNumInput.aspx.cs
// PROJECT         : PROG2001 - A6
// PROGRAMMER      : Lidiia Zhitova
// FIRST VERSION   : 2019-11-15
// DESCRIPTION     : this page prompts the user for the maximum number for the guessing range
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a6_zhitova_l.MorePages
{
    public partial class MaxNumInput : System.Web.UI.Page
    {

        // METHOD       : Page_Load
        // DESCRIPTION  : greets the user by their name, adds the event handler when the web page loads
        // PARAMETERS   : object sender, EventArgs e
        // RETURNS      : void
        protected void Page_Load(object sender, EventArgs e)
        {
            //use the session variable to greet the user and prompt them for a number
            string s = "Hey, " + Session["userName"] + ", enter a maximum guess number";
            inputPrompt.Text = s;

            // add validation method to the range validator event handler
            CustomRangeValidator.ServerValidate += new System.Web.UI.WebControls.ServerValidateEventHandler(ServerValidation);

        }



        // METHOD       : submitButton_Click
        // DESCRIPTION  : sets such session variables as maxNum, minNum, and target and then redirects the user
        // PARAMETERS   : object sender, EventArgs e
        // RETURNS      : void
        protected void submitButton_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                //create session variables for the maximum guessing number...
                Session["maxNum"] = inputBox.Text;
                //the minimum guessing number...
                Session["minNum"] = 1;
                //and finally the target random number
                Session["target"] = (new Random()).Next(1, (Convert.ToInt32(inputBox.Text)));

                //send the user to the next page
                Server.Transfer("NumberGuessing.aspx");
            }

        }



        // METHOD       : ServerValidation
        // DESCRIPTION  : validates user input
        // PARAMETERS   : object source, ServerValidateEventArgs args
        // RETURNS      : void
        void ServerValidation(object source, ServerValidateEventArgs args)
        {
            //if the number entered by the user is less than 2, the input is invalid
            if (Convert.ToInt32(inputBox.Text) < 2)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}