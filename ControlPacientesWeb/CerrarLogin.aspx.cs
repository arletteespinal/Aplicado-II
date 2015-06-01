﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlPacientesWeb
{
    public partial class CerrarLogin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
           Session.Abandon();
           FormsAuthentication.SignOut();
            HttpContext.Current.Response.Redirect("Login.aspx", true);
        }
    }
}