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
        obj.FillGrid("select * from shop,login where shop.Uname=login.Uname and login.Status='Pending'", GridView1);
    }
    protected void ImageButton1_Command(object sender, CommandEventArgs e)
    {
        obj.writedata("update login set Status='Approved' where Uname='" + e.CommandArgument.ToString() + "'");
        Response.Write("<script>alert('Approved Successfully')</script>");
        Server.Transfer("ShopVerification.aspx");
    }
    protected void ImageButton2_Command(object sender, CommandEventArgs e)
    {
        obj.writedata("update login set Status='Disapproved' where Uname='" + e.CommandArgument.ToString() + "'");
        Response.Write("<script>alert('Disapproved Successfully')</script>");
        Server.Transfer("ShopVerification.aspx");
    }
}