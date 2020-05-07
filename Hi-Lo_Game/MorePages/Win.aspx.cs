/*
    NAME : Win.aspx.cs
    PROJECT : PROG2001 - A6
    PROGRAMMER : Lidiia Zhitova
    FIRST VERSION : 2019-11-17
    DESCRIPTION : this code resets the session variables and sends the user back to the default.aspx

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a6_zhitova_l.MorePages
{
    public partial class Win : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        // METHOD       : resetGame_Click
        // DESCRIPTION  : resets session varaibles, redirects the user to default.aspx
        // PARAMETERS   : object sender, EventArgs e
        // RETURNS      : void
        protected void resetGame_Click(object sender, EventArgs e)
        {
            //reset the sesion variables
           // Session["userName"] = "";
            Session["maxNum"] = "";
            Session["minNum"] = "";
            Session["target"] = "";

            //redirect the user
            Server.Transfer("MaxNumInput.aspx");


        }
    }
}