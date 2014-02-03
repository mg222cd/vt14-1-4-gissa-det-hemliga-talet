    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="_1DV406S1L04.Defualt" ViewStateMode="Disabled" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Gissa det hemliga talet</title>
        <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
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
                        <asp:Label ID="InfoLabel" runat="server" Text="Ange ett tal mellan 1 och 100:"></asp:Label>
                        <asp:TextBox ID="TextBox" runat="server" CssClass="TextField" TextMode="SingleLine"></asp:TextBox>
                    <%-- Validering --%>
                        <%-- Required Field --%>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Fältet får inte lämnas tomt." 
                            Text="*" ForeColor="Red" ControlToValidate="TextBox"></asp:RequiredFieldValidator>
                        <%-- RangeValidator --%>
                        <asp:RangeValidator ID="RangeValidator" runat="server" ErrorMessage="Ange ett heltal mellan 1-100" ControlToValidate="TextBox" 
                            Text="*" ForeColor="Red" Type="Integer" MaximumValue="100" MinimumValue="1"></asp:RangeValidator>
                    <%-- Knapp --%>
                        <asp:Button ID="SendButton" runat="server" Text="Skicka gissning" />
                    </div>
                <%-- Gissningshistorik --%>
                <asp:PlaceHolder ID="GuessesPlaceHolder" runat="server" Visible="false">
                    <asp:Literal ID="GuessesLiteral" runat="server">{0}</asp:Literal>
                </asp:PlaceHolder>
                <%-- Ny gissning --%>
                <asp:PlaceHolder ID="ResultPlaceHolder" runat="server" Visible="false">
                    <asp:Literal ID="ResultLiteral" runat="server">Du har inga gissningar kvar. Det hemliga talet var {o}.</asp:Literal>
                    <asp:Button ID="NewButton" runat="server" Text="Slumpa nytt hemligt tal" />
                </asp:PlaceHolder>

            </div>
        </form>
    </body>
    </html>
