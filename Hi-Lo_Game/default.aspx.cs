/*
    NAME : default.aspx.cs
    PROJECT : PROG2001 - A6
    PROGRAMMER : Lidiia Zhitova
    FIRST VERSION : 2019-11-15
    DESCRIPTION : the code behind default.aspx
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a6_zhitova_l
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        // METHOD       : submitButton_Click
        // DESCRIPTION  : creates a new session variable and redirects the user to the next page
        // PARAMETERS   : object sender, EventArgs e
        // RETURNS      : void
        protected void submitButton_Click(object sender, EventArgs e)
        {
            //create a session variable for the username
            Session["userName"] = inputBox.Text;

            //send the user to the next page
            Server.Transfer("MorePages/MaxNumInput.aspx");

        }
    }
}