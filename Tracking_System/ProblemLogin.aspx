<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProblemLogin.aspx.cs" Inherits="ProblemLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <table>
       <tr>

           <td><asp:Label  runat="server" Text="ProblemCategory"  ID="lblProblemCategory"></asp:Label></td>
           <td><asp:DropDownList ID="ddlPCategory" runat="server">
               <asp:ListItem Value="0">NetWorkIssues</asp:ListItem>
               </asp:DropDownList></td>

       </tr>
       <tr>

           <td><asp:Label  runat="server" Text="ProblemSeviority" ID="lblPSiviority"></asp:Label></td>
           <td><asp:DropDownList ID="ddlPSiviority" runat="server">
               <asp:ListItem Value="0">Low</asp:ListItem>
               <asp:ListItem Value="1">Medium</asp:ListItem>
               <asp:ListItem Value="2">Critical</asp:ListItem>
               <asp:ListItem Value="3">High</asp:ListItem>
               </asp:DropDownList></td>

       </tr>
       <tr>

           <td><asp:Label  runat="server" Text="Problem Description" ID="Label1"></asp:Label></td>
           <td><asp:TextBox ID="txtPDescription" TextMode="MultiLine" runat="server"></asp:TextBox></td>

       </tr>
       
        <tr>

           <td><asp:Label  runat="server" Text="WorkStationNumber" ID="Label4"></asp:Label></td>
           <td><asp:TextBox ID="txtWorkStationNo"  runat="server"></asp:TextBox></td>

       </tr>
       <tr>

           <td><asp:Label  runat="server" Text="AssignedTo" ID="Label5"></asp:Label></td>
           <td><asp:DropDownList ID="ddlSme" runat="server" OnSelectedIndexChanged="ddlSme_SelectedIndexChanged" Width="69px" AutoPostBack="True"></asp:DropDownList></td>
           <td><asp:Label  runat="server" Text="SmeName" ID="Label6"></asp:Label></td>
           <td><asp:TextBox ID="txtSmeName"  runat="server" ReadOnly="True"></asp:TextBox></td>

       </tr>
       <tr>

           <td><asp:Button ID="btnCreateSr" runat="server"  Text="CreateSr" OnClick="btnCreateSr_Click"/></td>
            <td><asp:Label ID="lblStatus" runat="server"></asp:Label></td>
       </tr>

   </table>
        
            </div>
   
    </form>
    </body>
</html>
