<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleShoppingCart.Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContentPlaceHolder" runat="server">
<div id="header">
    	<div id="logo"><a href="Default.aspx"><img src="images/logo.gif" alt="" title="" border="0" /></a></div>
        
        <div id="menu">
            <ul>                                        
                <li><a class="current" href="Default.aspx" title="">home</a></li>
                <li><a href="Default.aspx" title="">Products</a></li>
                <li><a href="Categories.aspx" title="">Categories</a></li>
                <li><a href="About.aspx" title="">About</a></li>
                
            </ul>
        </div>
        
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
