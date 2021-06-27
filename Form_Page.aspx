<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Page.aspx.cs" Inherits="Defakto_Project.Form_Page" %> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EMAIL A CAT!</title>
<link rel="stylesheet" type="text/css" href="main.css">
</head>
<body>
    
    
    
     
    

    <form id="form1" runat="server">
       
        <div id="body">
          
        </div>
        <div id="LeftColumn">
          
        </div>
        <div id="RightColumn">
        
        <script>
        var text = "</br></br> Fill out the form below";
        var i;
        for (i = 0; i < 24; i++) {
        text += "</br>";
        }
        document.getElementById("RightColumn").innerHTML = text;
        </script>
        </div>
        
        <asp:TextBox ID="txtFirstName" runat="server" Height="31px" Width="21%" placeholder="First Name"  AutoPostBack="false" style="position: absolute; top: 22%; left: 72%;" autocomplete="off" AutoCompleteType="Disabled" ></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" Text="" AutoPostBack="true"  style="position: absolute; top: 26%; left: 72%;"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" Height="31px" Width="21%" placeholder="Last Name"  AutoPostBack="false" style="position: absolute; top: 32%; left: 72%;" autocomplete="off" AutoCompleteType="Disabled"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" Text="" AutoPostBack="true"  style="position: absolute; top: 36%; left: 72%;"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Height="31px" Width="21%" placeholder="Email Address"  AutoPostBack="false" style="position: absolute; top: 42%; left: 72%;" autocomplete="off" AutoCompleteType="Disabled"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" Text="" AutoPostBack="true"  style="position: absolute; top: 46%; left: 72%;"></asp:Label>

        <asp:ImageButton ID="btnSendCat" runat="server" AutoPostBack="false" style="position: absolute; top: 58%; left: 79%;" OnClick="btnSendCat_Click"  ImageUrl="~/images/button-submit-cat.png"> </asp:ImageButton>

        <asp:Label ID="lblF1" runat="server" Text="" AutoPostBack="true"  style="position: absolute; top: 21%; left: 94%;"></asp:Label>
        <asp:Label ID="lblF2" runat="server" Text="" AutoPostBack="true"  style="position: absolute; top: 31%; left: 94%;"></asp:Label>
        <asp:Label ID="lblF3" runat="server" Text="" AutoPostBack="true"  style="position: absolute; top: 41%; left: 94%;"></asp:Label>

       <img src="images/banner-cat.png" width="64%" height="33%"/>
        <div id="CatBannerTitle">
        EMAIL A CAT!
       </div>
        <div id="CatBannerCopy">
        Email someone you know a free trial
        </br>
        cat today! 
        </div>
        <div id="BodyHeader1">
        Libero Cattvs Diem!
        </div>         
        <div id="BodyCopy">
        </br>
        Ut feugait facilisis magna pneum ut esca utrum quidem pecus aliquam sagaciter. Lobortis tation quibus inhibeo
        </br>
        utrum et suscipit nisl eros tego. Commoveo nisl, praesent  quadrum ut quod et delenit hendrerit plaga utinam
        </br>
        iusto. Virtus, illum gemino neque iaceo adpiscing commoveo enim. Incassum, minim, accumsan fatua incassum
        </br>
        foras.  
        </br>
        </br>
        Eum eros eligo adipiscing mara, commodo. Consequat augue defui si imputo, natu camur dolus adipiscing uxor
        </br>
        hendrerit melior nimis. Exerci damnum, ullamcorper wisi, humo verto regula, paratus tation proprius suscipit.
        </br>
        Suscipit autem appellatio tego, validus ea et luctus si duis iusto praesent, laoreet eu defui.
        </br>
        </br>
        Fere nibh aliquip utrum ventosus foras imputo sit macto caecus saluto ullamcorper. Ut volutpat nullus mauris bis
        </br>
        loquor, hendrerit et sed duis vel. Consequat in molior vicis, tincidunt pertineo distineo. Minim, quod vulputate at 
        </br>
        consequat ludus pneum consequat qui mauris. Uxor in singularis wisi quis plaga rusticus scisco bis regula in
        </br>
        vulpes sit.  
        <hr id="footer"/>
        </div>
        <div id="CopyrightCopy">
        
        &copy Copyright 2021.  All Cats Reserved.
       
        </div> 
        
           
    </form>
</body>
 
      
</html>
