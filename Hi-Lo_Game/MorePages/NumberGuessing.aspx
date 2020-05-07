<%--
    NAME            : NumberGuessing.aspx
    PROJECT         : PROG2001 - A6
    PROGRAMMER      : Lidiia Zhitova
    FIRST VERSION   : 2019-11-17
    DESCRIPTION     : this page lets the user guess the target number
--%>

<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="NumberGuessing.aspx.cs" Inherits="a6_zhitova_l.MorePages.NumberGuessing" %>

<asp:Content ID="nameValFunc" ContentPlaceHolderID="javasFunctionPH" runat="server"> 
    <script type="text/javascript">
        // NAME        : validateNumber
        // DESCRIPTION : validates the input the user enters when entering the maximum number
        function validateNumber(source, arguments)
        {
            //store user input in a variable first
            var maxNum = document.getElementById("<%=inputBox.ClientID%>").value;

            //check if the input contains only numeric characters
            if (/^[0-9]+$/.test(maxNum))
            {
                //the string will pass the validation if it contains only 
                //numeric chars
                arguments.IsValid = true;
                arguments.value = maxNum;
            }
            else if (maxNum < 0)
            {
                //client-side validation will also accept negative numbers
                arguments.IsValid = true;
                arguments.value = maxNum;
            }
            else
            {
                //it will not pass if it contains any other type of chars
                arguments.IsValid = false;
            }
        }


        </script>
    </asp:Content>

    <asp:Content ID="prompt" ContentPlaceHolderID="promptPH" runat="server">
        <asp:Label ID="inputPrompt" 
            runat="server" 
            class="labels">
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
            ClientValidationFunction = "validateNumber"
            Text = "<-- Input required. Please only enter values in allowable range. ">
        </asp:CustomValidator>

        <asp:CustomValidator ID="CustomRangeValidator"
             class="errorMsg"
             runat="server" >
        </asp:CustomValidator>

        <asp:Label ID="range" class="errorMsg" style="color:whitesmoke" runat="server"></asp:Label>
    </asp:Content>

     <asp:Content ID="button" ContentPlaceHolderID="buttonPH" runat="server">
        <asp:Button ID="submitButton" 
            runat="server" 
            onclick="submitButton_Click"
            Text="GUESS!"
            class="buttons buttonTransition">
        </asp:Button>
     </asp:Content>
