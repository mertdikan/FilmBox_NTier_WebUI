﻿using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBUI
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        FilmRepository fr = new FilmRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = fr.GetAll();
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }
    }

    
    
}