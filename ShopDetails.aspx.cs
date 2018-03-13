using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ShopVerification : System.Web.UI.Page
{
    DigiMed obj = new DigiMed();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ShopDetails();
        }
    }
    protected void ShopDetails()
    {
        obj.FillGrid("select * from shop,login where shop.Uname=login.Uname and login.Status='Approved'", GridView1);
    }
}