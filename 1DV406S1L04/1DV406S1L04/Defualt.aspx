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

            <%-- Inmatning --%>
            <div id="InputDiv">
                <asp:Label ID="InfoLabel" runat="server" Text="Ange ett tal mellan 1 och 100:"></asp:Label>
                <asp:TextBox ID="TextBox" runat="server" CssClass="TextField" TextMode="SingleLine"></asp:TextBox>
                <asp:Button ID="SendButton" runat="server" Text="Skicka gissning" />
            <%-- Validering --%>
                <%-- Required Field --%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Ett tal måste anges." 
                    Text="*" ForeColor="Red" ControlToValidate="TextBox"></asp:RequiredFieldValidator>
                <%-- RangeValidator --%>
                <asp:RangeValidator ID="RangeValidator" runat="server" ErrorMessage="RangeValidator" ControlToValidate="TextBox" 
                    ForeColor="Red"></asp:RangeValidator>
            </div>
            <%-- Gissningshistorik --%>

            <%-- Ny gissning --%>

        </div>
    </form>
</body>
</html>
