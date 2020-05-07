<%--    
    NAME : Win.aspx.cs
    PROJECT : PROG2001 - A6
    PROGRAMMER : Lidiia Zhitova
    FIRST VERSION : 2019-11-17
    DESCRIPTION : this page is displayed when the user wins the gussing game
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Win.aspx.cs" Inherits="a6_zhitova_l.MorePages.Win" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>YOU WON!</title>
    <style>
        input.winButton {
            border: 0 none;
            text-align: center;
            padding-left: 35px;
            padding-right: 35px;
            display: inline-block;
            font-size: 16px;
            font-family: Courier New, Courier, monospace;
            margin: 0;
            transition-duration: 0.4s;
            cursor: pointer;
            height: 40px;
            width: 170px;
            font-weight: 700;
        }

        .winPageButtonTransition {
            background-color:cornsilk;
            color: #575656;
        }

        .winPageButtonTransition:hover {
            background-color:darkred;
            color:cornsilk;
        }
    </style>
</head>
<body style="background-color:darkorange">
    <form id="form1" runat="server">
        <asp:Label runat="server"
            style="display:block; font-size:500%; font-stretch:condensed; text-align:center;">
            YOU WIN!! YOU GUESSED THE NUMBER!!
        </asp:Label>

        <div style="display:block; text-align:center;">
        <asp:Button ID="resetGame"
            class="winButton winPageButtonTransition"
            text="PLAY AGAIN!"
            onclick="resetGame_Click"
            runat="server"
            >
        </asp:Button>
            </div>
    </form>
</body>
</html>
