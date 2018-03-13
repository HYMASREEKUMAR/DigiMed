<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ShopDetails.aspx.cs" Inherits="Admin_ShopVerification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="3">SHOP&nbsp; DETAILS</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="shop_name" HeaderText="Shop Name" />
                        <asp:BoundField DataField="reg_no" HeaderText="Register No." />
                        <asp:BoundField DataField="owner_name" HeaderText="Owner Name" />
                        <asp:BoundField DataField="location" HeaderText="Location" />
                        <asp:BoundField DataField="Landmark" HeaderText="Landmark" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone No." />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content> 

