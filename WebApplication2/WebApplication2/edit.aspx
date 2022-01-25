<%@ Page Language="C#" EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="WebApplication2.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <title>Edit Customer</title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div class =" container">
        <div  class="position-absolute top-50 start-50 translate-middle row" style="text-align: center;">
             <h3> Edit Customer</h3>
             <div class="p-3 border bg-light">
           Customer Name:  <asp:TextBox ID="name" runat="server"></asp:TextBox>
             </div>
            <br />
             <div class="p-3 border bg-light">
           Customer Birth Date:  <asp:TextBox ID="date" runat="server"></asp:TextBox>
            </div>
            <br />
             <div class="p-3 border bg-light">
           Customer Phone Number:  <asp:TextBox ID="no" runat="server"></asp:TextBox>
           </div>
            <br />
             <div class="p-3 border bg-light">
           Customer Description:  <asp:TextBox ID="desc" runat="server"></asp:TextBox>
            </div>
            <br />
            <a  style =" text-decoration: none; color: black; border:2px solid #000; width: 100px; height: 40px; margin-left: 40%; margin-top: 2%;" href="WebForm2.aspx?id=<%# Eval("Id")%>&islem=sil"><h4>Edit</h4></a>

    </div>
    </div>   
        
    </form>
</body>
</html>
