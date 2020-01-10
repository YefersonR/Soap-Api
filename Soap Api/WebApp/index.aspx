<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id: <asp:Label ID="Lid" runat="server" Text="Label"></asp:Label>
            <br/>
            Nombre: <asp:Label ID="Lnombre" runat="server" Text="Label"></asp:Label>
            <br/>
            Direccion: <asp:Label ID="Ldireccion" runat="server" Text="Label"></asp:Label> 
            <br/>
            Telefono: <asp:Label ID="Ltelefono" runat="server" Text="Label"></asp:Label>
            

        </div>
    </form>
</body>
</html>
