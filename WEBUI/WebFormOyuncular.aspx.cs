using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBUI
{
    public partial class WebFormOyuncular : System.Web.UI.Page
    {
        ActorRepository ar = new ActorRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            GetirOyuncu();
        }
        private void GetirOyuncu()
        {
            DataList1.DataSource = ar.GetAll();
            DataList1.DataBind();
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }
    }
}