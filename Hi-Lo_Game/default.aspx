<%--
    NAME            : default.aspx
    PROJECT         : PROG2001 - A6
    PROGRAMMER      : Lidiia Zhitova
    FIRST VERSION   : 2019-11-15
    DESCRIPTION     : this is the deafult page of the website, it prompts the user for their name and validates the input
--%>

<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="a6_zhitova_l._default"   %>


    <asp:Content ID="nameValFunc" ContentPlaceHolderID="javasFunctionPH" runat="server">
        <script type="text/javascript">

            // NAME        : validateName 
	        // DESCRIPTION : validates the input the user enters when entering the username
            function validateName(source, arguments)
            {
                //get the username from the text box
                var userName = document.getElementById("<%=inputBox.ClientID%>").value;

                //check if the input has only alphabetic characters
                if (/^[A-Za-z]+$/.test(userName)) 
                {
                    //the string will pass the validation if it contains only 
                    //alpha chars
                    arguments.IsValid = true;
                }
                else
                {
                    //it will not pass if it contains anything else
                    arguments.IsValid = false;
                }

            }
        </script>
    </asp:Content>

    <asp:Content ID="prompt" ContentPlaceHolderID="promptPH" runat="server">
        <asp:Label ID="inputPrompt" 
            runat="server" 
            class="labels"
            Text = "What is your name?">
        </asp:Label>
    </asp:Content>

    <asp:Content ID="input" ContentPlaceHolderID="inputBoxPH" runat="server">
        <asp:TextBox ID="inputBox" 
            autofocus=""
            class="textBoxes"
            runat="server">
        </asp:TextBox>
    </asp:Content>

    <asp:Content ID="validation" ContentPlaceHolderID="inputValidationPH" runat="server">
        <asp:CustomValidator ID="inputValidation" 
            class="errorMsg"
            runat="server"
            ClientValidationFunction = "validateName"
            Text = "<-- Please enter your name. Only alphabetic characters are accepted">
        </asp:CustomValidator>
    </asp:Content>

     <asp:Content ID="button" ContentPlaceHolderID="buttonPH" runat="server">
        <asp:Button ID="submitButton" 
            runat="server" 
            onclick="submitButton_Click" 
            Text="SUBMIT!"
            class="buttons buttonTransition">
        </asp:Button>
     </asp:Content>


