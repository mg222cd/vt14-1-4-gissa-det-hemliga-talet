﻿    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="_1DV406S1L04.Defualt" ViewStateMode="Disabled" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Gissa det hemliga talet</title>
        <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
        <script src="Scripts/JScript.js"></script>
    </head>

    <body>
        <form id="form1" runat="server"> 
            <div id="container">
                <div id="HeaderDiv">
                    <p id="HeaderText">ASP.NET WebForms / 1DV406 -> Steg 1 -> Laborationsuppgift4</p>
                    <h1>Gissa det hemliga talet</h1>
                </div>
                <div id="GreyDiv">
                    </div>
                    <%-- Felmeddelanden --%>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Fel i formuläret:" />
                    <%-- Inmatning --%>
                    <div id="InputDiv">
                        <asp:PlaceHolder ID="InputPlaceHolder" runat="server">
                        <asp:Label ID="InfoLabel" runat="server" Text="Ange ett tal mellan 1 och 100: "></asp:Label>
                        <asp:TextBox ID="TextBox" runat="server" CssClass="TextField" TextMode="SingleLine"></asp:TextBox>
                        </asp:PlaceHolder>
                    <%-- Validering --%>
                        <%-- Required Field --%>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Fältet får inte lämnas tomt." 
                            Text="*" ForeColor="Red" ControlToValidate="TextBox"></asp:RequiredFieldValidator>
                        <%-- RangeValidator --%>
                        <asp:RangeValidator ID="RangeValidator" runat="server" ErrorMessage="Ange ett heltal mellan 1-100" ControlToValidate="TextBox" 
                            Text="*" ForeColor="Red" Type="Integer" MaximumValue="100" MinimumValue="1"></asp:RangeValidator>
                    <%-- Knapp --%>
                        <asp:Button ID="SendButton" runat="server" Text="Skicka gissning" OnClick="SendButton_Click" />
                    </div>
                <%-- Gissningshistorik --%>
                <asp:PlaceHolder ID="GuessesPlaceHolder" runat="server" Visible="false">
                    <asp:Literal ID="GuessesLiteral" runat="server">{0}</asp:Literal>
                </asp:PlaceHolder>
                <div id="NewGuessDiv">
                <%-- Ny gissning --%>
                <asp:PlaceHolder ID="ResultPlaceHolder" runat="server" Visible="false">
                    <asp:Literal ID="ResultLiteral" runat="server">Du har inga gissningar kvar. Det hemliga talet var {o}.</asp:Literal>
                </asp:PlaceHolder>
                <asp:Button ID="NewButton" runat="server" CssClass="NewButton" Visible="false" Text="Slumpa nytt hemligt tal" OnClick="NewButton_Click" />
                </div>
            </div>
        </form>

    </body>
    </html>
