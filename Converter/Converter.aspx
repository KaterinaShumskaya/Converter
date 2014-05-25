<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Converter.aspx.cs" Inherits="Converter.Converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 26px;
            width: 59px;
        }
        .auto-style3 {
            width: 59px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
        <table style="width:200px;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Исходная валюта"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="SourceCurrency" runat="server" OnSelectedIndexChanged="SourceCurrency_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Курс к рублю" Width="50"></asp:Label>
                </td>
                <td class="auto-style1">
                    
                    <asp:TextBox ID="SourceCourse" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Сумма"></asp:Label>
                </td>
                <td class="auto-style1" colspan="3">
                    <asp:TextBox ID="Sum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Целевая валюта"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DestinationCurrency" runat="server" OnSelectedIndexChanged="DestinationCurrency_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Курс к рублю"></asp:Label>
                </td>
                <td>
                    
                    <asp:TextBox ID="DestinationCourse" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td colspan="4">
                   
                    <asp:Button ID="Button1" runat="server" Text="Рассчитать" OnClick="Button1_Click" />
                   
                </td>
            </tr>
            <tr>
                <td colspan="4">
                 
                   
                    <asp:Label ID="ResultLabel" runat="server"></asp:Label>
                 
                   
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
