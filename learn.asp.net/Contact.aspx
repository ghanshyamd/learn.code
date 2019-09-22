<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="learn.asp.net.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <control>

        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvcandidate" 
   runat="server" ControlToValidate ="txt1"
   ErrorMessage="Please enter a value" 
   InitialValue="Please enter a value">
   
</asp:RequiredFieldValidator>



        <asp:DropDownList runat="server" ID="dd1" AutoPostBack="true">
            <asp:ListItem Value="1" Text="1" ></asp:ListItem>
            <asp:ListItem Value="2" Text="2" ></asp:ListItem>
        </asp:DropDownList>

         <asp:DropDownList runat="server" ID="dd2" AutoPostBack="true">
            <asp:ListItem Value="1" Text="1" ></asp:ListItem>
            <asp:ListItem Value="2" Text="2" ></asp:ListItem>
        </asp:DropDownList>

    </control>

    <asp:Button runat="server" Text="Submit" ID="btn1" />


    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
