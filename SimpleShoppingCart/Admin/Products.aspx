﻿<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="SimpleShoppingCart.Admin.Products" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>View/Edit Products</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="NavigationPlaceHolder" runat="server">
<!-- Navigation -->
	
		    <div class="navigation">
				<ul>
					<li><a href="Default.aspx">Home</a></li>
					<li><a href="Products.aspx" class="active">Products</a></li>
					<li><a href="Categories.aspx">Categories</a></li>
					<li><a href="Users.aspx">Users</a></li>
					<li><a href="Stats.aspx">Stats</a></li>
				</ul>
			
				<div id="searchform">
					<form method="get" action="">
					<input type="text" value="find something good..." class="search_box" name="search" onclick="this.value='';"  />
					<input type="submit" class="search_btn" value="SEARCH" />
					</form>
				</div>
			
		    </div>

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>