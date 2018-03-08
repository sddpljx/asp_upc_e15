<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MSForms.aspx.cs" Inherits="WebApplicationWeb1.MSForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        #form1 {
            width: 490px;
            height: 434px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button3" runat="server" Text="ASP.NET" Font-Size =" 56" Font-Names="Microsoft YaHei"  BorderWidth="0"  BackColor="White"/>
        </div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="Button1" runat="server" Height="85px" OnClick="Button1_Click" Text="电机拖动" Font-Names="Microsoft YaHei" Font-Size="49" Width="328px" ForeColor="Green" BorderWidth="0" BackColor ="White" />
        <p>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="Button2" runat="server" Text="实习补助" OnClick="Button2_Click" Font-Names="微软雅黑" Font-Size=" 49" Height="85px" Width="328px"  ForeColor ="Blue" BorderWidth="0"  BackColor =" White" />
        </p>
    </form>
</body>
</html>
