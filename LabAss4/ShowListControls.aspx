<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowListControls.aspx.cs" Inherits="LabAss4.ShowListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>ListBox<asp:ListBox runat="server" ID="ListBox1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource2"></asp:ListBox><asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString="<%$ ConnectionStrings:SimpleDatabaseConnectionString2 %>" SelectCommand="SELECT [UserName], [password] FROM [Logon]"></asp:SqlDataSource>
            
        </h1></div>
        <div><h1>DropDownList<asp:DropDownList runat="server" ID="DropDownList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource2"></asp:DropDownList></h1></div>
        <div><h1>BulletedList<asp:BulletedList runat="server" ID="BulletedList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource2"></asp:BulletedList></h1></div>
        <div><h1>CheckBoxList<asp:CheckBoxList runat="server" ID="CheckBoxList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource2"></asp:CheckBoxList></h1></div>
        <div><h1>RadioButtonList
            <asp:RadioButtonList runat="server" ID="RadioButtonList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource2"></asp:RadioButtonList>
        </h1></div>
    </form>
</body>
</html>
