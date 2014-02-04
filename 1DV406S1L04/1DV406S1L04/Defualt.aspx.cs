using _1DV406S1L04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1DV406S1L04
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kontroll att det är PageLoad och inte Postback
            if (!IsPostBack)
            {
                //Nytt SecretNumber
                Session["theGuess"] = new SecretNumber();
                //säkerhetskontroll att sessionsvariablen inte är null
                if (Session["theGuess"] != null)
                {
                    //sessions-objekt för SecretNumber-objekt
                    var theGuess = Session["theGuess"] as SecretNumber;
                }
            }
        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //sessionsobjekt för SecretNumber-objekt
                var theGuess = Session["theGuess"] as SecretNumber;

                //kontrollera resultatet av gissningen:
                Outcome result = theGuess.MakeGuess(int.Parse(TextBox.Text));

                //hämta tidigare gissningar:
                var writePrevious = "";
                foreach (var item in theGuess.PreviousGuess)
                {
                    writePrevious += string.Format("[{0}]", item);
                }

                //hanteing för vad som ska skrivas ut beroende på resultatet av gissningen:
                if (result == Outcome.Correct)
                {
                    GuessesPlaceHolder.Visible = true;
                    GuessesLiteral.Text = writePrevious;
                    ResultPlaceHolder.Visible = true;
                    ResultLiteral.Text = "Grattis! Rätt gissat!";
                    NewButton.Visible = true;
                    TextBox.Enabled = false;
                    SendButton.Enabled = false;
                    ResultPlaceHolder.Visible = true;
                    ResultLiteral.Text = String.Format("Det hemliga numret var {0}", theGuess.Number);
                    NewButton.Visible = true;
                    NewButton.ID = "SendButton";
                }
                else if (result == Outcome.High)
                {
                    GuessesPlaceHolder.Visible = true;
                    GuessesLiteral.Text = writePrevious;
                    GuessesLiteral.Text += "För högt.";
                }
                else if (result == Outcome.Low)
                {
                    GuessesPlaceHolder.Visible = true;
                    GuessesLiteral.Text = writePrevious;
                    GuessesLiteral.Text += "För lågt.";
                }
                else if (result == Outcome.PreviousGuesses)
                {
                    GuessesPlaceHolder.Visible = true;
                    GuessesLiteral.Text = writePrevious;
                    GuessesLiteral.Text += "Du har redan gissat på talet, försök igen.";
                }
                else if (result == Outcome.NoMoreGuesses)
                {
                    GuessesPlaceHolder.Visible = true;
                    GuessesLiteral.Text = writePrevious;
                    TextBox.Enabled = false;
                    SendButton.Enabled = false;
                    ResultPlaceHolder.Visible = true;
                    ResultLiteral.Text = String.Format(ResultLiteral.Text, theGuess.Number);
                    NewButton.Visible = true;
                    NewButton.ID = "SendButton";
                }




                
            }
        }



    }
}