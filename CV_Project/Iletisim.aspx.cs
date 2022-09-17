﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV_Project
{
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();
            var mesajlar = db.TBLILETISIM.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}