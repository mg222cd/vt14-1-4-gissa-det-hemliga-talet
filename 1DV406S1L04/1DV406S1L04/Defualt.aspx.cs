﻿using _1DV406S1L04.Model;
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
            // Kontroll att det ej är Postback
            if (!IsPostBack)
            {
                Session["theGuess"] = new SecretNumber();

            }
        }
    }
}