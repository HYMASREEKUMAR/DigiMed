using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for Class1
/// </summary>
public class DigiMed
{
    public SqlConnection con = new SqlConnection();
    public SqlCommand cmd = new SqlCommand();
    public SqlDataReader dr;
    public SqlDataAdapter da;
    public DataTable dt = new DataTable();
    public void dbconnection()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.ConnectionString = WebConfigurationManager.AppSettings["dbconnect"];
        con.Open();
    }
    public void writedata(string sql)
    {
        dbconnection();
        cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();
    }
    public void readdata(string sql)
    {
        dbconnection();
        cmd = new SqlCommand(sql, con);
        dr = cmd.ExecuteReader();
    }
    public void adapter(string sql)
    {
        dt.Rows.Clear();
        dbconnection();
        cmd = new SqlCommand(sql, con);
        da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        con.Close();

    }
    public void FillDropDownList(string Text, string Value, string Table, string Condition, DropDownList ddllst)
    {
        dt.Rows.Clear();
        if (Condition == " ")
        {
            string sql = "select " + Value + "," + Text + " from " + Table + " ";
            adapter(sql);
            if (dt.Rows.Count > 0)
            {
                ddllst.DataSource = dt;
                ddllst.DataTextField = Text;
                ddllst.DataValueField = Value;
                ddllst.DataBind();
            }
        }
        else
        {
            string sql = "select " + Text + "," + Value + " from " + Table + " where " + Condition + "";
            adapter(sql);
            if (dt.Rows.Count > 0)
            {
                ddllst.DataSource = dt;
                ddllst.DataTextField = Text;
                ddllst.DataValueField = Value;
                ddllst.DataBind();
            }
        }

        ddllst.Items.Insert(0, "--SELECT--");
    }
    public void FillGrid(string sql, GridView grdvw)
    {
        adapter(sql);
        if (dt.Rows.Count > 0)
        {
            grdvw.DataSource = dt;
            grdvw.DataBind();
        }
    }
}
	