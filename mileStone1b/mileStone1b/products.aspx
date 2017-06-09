<%@ Page Title="" Language="C#" MasterPageFile="~/milestoneb1.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="mileStone1b.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:gridview runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="ProductNumber" HeaderText="ProductNumber" SortExpression="ProductNumber" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" SortExpression="ListPrice" />
            <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
            <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" />
        </Columns>
    </asp:gridview>
   
   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ProductID, Name, ProductNumber, Color, ListPrice, Size, Weight
 FROM SalesLT.Product 
WHERE (ProductCategoryID = @param)">
        <SelectParameters>
            <asp:QueryStringParameter Name="param" QueryStringField="categoryid" />
        </SelectParameters>
    </asp:SqlDataSource>
   
   
</asp:Content>
