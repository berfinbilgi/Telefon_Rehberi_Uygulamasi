<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="new.aspx.cs" Inherits="WebApplication2._new" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <title>New Customer</title>
</head>
<body>
    <form id="form1" runat="server">
       
      <div class =" container">
        <div  class="position-absolute top-50 start-50 translate-middle row" style="text-align: center;">
             <h3> New Customer</h3>
            <div class="p-3 border bg-light">
           Name: <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </div>
            <br />
            <div class="p-3 border bg-light">
           Birth Date(MM.DD.YYYY): <asp:TextBox ID="date" runat="server"></asp:TextBox>
                </div>
            <br />
            <div class="p-3 border bg-light">
           Phone Number: <asp:TextBox ID="no" runat="server"></asp:TextBox>
                </div>
            <br />
            <div class="p-3 border bg-light">
           Description: <asp:TextBox ID="desc" runat="server"></asp:TextBox>
                </div>
            <br />
            <div class="p-3 border bg-light">
            <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
                <br />
            <asp:Label style="color:#FF0000 ;"  ID="message" runat="server" Text=""></asp:Label>
            </div>
        </div>
          </div>
    </form>
</body>
</html>
