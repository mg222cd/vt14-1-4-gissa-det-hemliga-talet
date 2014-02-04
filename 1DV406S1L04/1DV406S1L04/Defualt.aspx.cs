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
                    //lagarar i variabel.
                    var theGuess = Session["theGuess"] as SecretNumber;
                }
            }
        }



    }
}