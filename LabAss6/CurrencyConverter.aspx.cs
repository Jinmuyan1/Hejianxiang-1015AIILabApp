﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabAss6
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double d=Convert.ToDouble(TextBox1.Text);
            double con = d * 0.15;
            Label1.Text =con.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}