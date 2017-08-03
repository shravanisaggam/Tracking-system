<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SplashScreen.aspx.cs" Inherits="Tracking_System.SplashScreen" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PTS Home</title>

      <style type="text/css">
   
          body
        {
        background-image:url('Images/114.jpg');
              color: #660033;
              height: 107px;
              text-align: center;
              margin-top: 181px;
          }
          .auto-style1
          {
              font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
              font-size: 48pt;
              font-weight: bold;
              text-align: center;
          }
        </style>

</head>

   
<body>

  
        <span class="auto-style1">Welcome to <br />
    Problem Tracking
    Utility 
    <br />
    for Technical Support
    System</span>
</body>

    <script runat="server">
    
   
       
 protected override void OnLoad(EventArgs e)
 {
     Response.AppendHeader("Refresh", "10; url=Login.aspx");
  }
</script>

</html>
