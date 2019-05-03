<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoderEncoderApp.aspx.cs"%>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
  <title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
<div class="jumbotron text-center">
    <div id="Tittle">
        <h1>Coder-Encoder App</h1>
    </div>
</div>
  
<div class="container">
  <div class="row">
    <div class="col-sm-4">
      <h3>Coder</h3>
    <div id="Coder">
      <asp:Label ID="labeltext" runat="server" Text="Text: "></asp:Label>
      <asp:TextBox ID="TextField" runat="server" size="50"></asp:TextBox>
        <br />
        <br />
      <asp:Label ID="labelkey" runat="server" Text="Key Letter: "></asp:Label>
        <asp:DropDownList ID="keyDropdown" runat="server" style="width:200px;">
            <asp:ListItem Value="a"></asp:ListItem>
            <asp:ListItem Value="b"></asp:ListItem>
            <asp:ListItem Value="c"></asp:ListItem>
            <asp:ListItem Value="d"></asp:ListItem>
            <asp:ListItem Value="e"></asp:ListItem>
            <asp:ListItem Value="f"></asp:ListItem>
            <asp:ListItem Value="g"></asp:ListItem>
            <asp:ListItem Value="h"></asp:ListItem>
            <asp:ListItem Value="i"></asp:ListItem>
            <asp:ListItem Value="j"></asp:ListItem>
            <asp:ListItem Value="k"></asp:ListItem>
            <asp:ListItem Value="l"></asp:ListItem>
            <asp:ListItem Value="m"></asp:ListItem>
            <asp:ListItem Value="n"></asp:ListItem>
            <asp:ListItem Value="ñ"></asp:ListItem>
            <asp:ListItem Value="o"></asp:ListItem>
            <asp:ListItem Value="p"></asp:ListItem>
            <asp:ListItem Value="q"></asp:ListItem>
            <asp:ListItem Value="r"></asp:ListItem>
            <asp:ListItem Value="s"></asp:ListItem>
            <asp:ListItem Value="t"></asp:ListItem>
            <asp:ListItem Value="u"></asp:ListItem>
            <asp:ListItem Value="v"></asp:ListItem>
            <asp:ListItem Value="w"></asp:ListItem>
            <asp:ListItem Value="x"></asp:ListItem>
            <asp:ListItem Value="y"></asp:ListItem>
            <asp:ListItem Value="z"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="EncryptButton" runat="server" Text="Encrypt String"/>

        <br />
        <br />
      <asp:TextBox ID="EncryptedString" runat="server" size="50" Height="85px" Width="434px"></asp:TextBox>
        <br />
        <br />

    </div>
    </div>
    <div class="col-sm-4">
      <h3>Decoder</h3>
    <div id="Decoder">
      <asp:Label ID="codeslabel" runat="server" Text="Encrypted codes: "></asp:Label>
      <asp:TextBox ID="encryptedcodes" runat="server" size="50"></asp:TextBox>
        <br />
        <br />
      <asp:Label ID="labelkey2" runat="server" Text="Key Letter: "></asp:Label>
        :
        <asp:DropDownList ID="keydropdown2" runat="server" style="width:200px;">
            <asp:ListItem Value="a"></asp:ListItem>
            <asp:ListItem Value="b"></asp:ListItem>
            <asp:ListItem Value="c"></asp:ListItem>
            <asp:ListItem Value="d"></asp:ListItem>
            <asp:ListItem Value="e"></asp:ListItem>
            <asp:ListItem Value="f"></asp:ListItem>
            <asp:ListItem Value="g"></asp:ListItem>
            <asp:ListItem Value="h"></asp:ListItem>
            <asp:ListItem Value="i"></asp:ListItem>
            <asp:ListItem Value="j"></asp:ListItem>
            <asp:ListItem Value="k"></asp:ListItem>
            <asp:ListItem Value="l"></asp:ListItem>
            <asp:ListItem Value="m"></asp:ListItem>
            <asp:ListItem Value="n"></asp:ListItem>
            <asp:ListItem Value="ñ"></asp:ListItem>
            <asp:ListItem Value="o"></asp:ListItem>
            <asp:ListItem Value="p"></asp:ListItem>
            <asp:ListItem Value="q"></asp:ListItem>
            <asp:ListItem Value="r"></asp:ListItem>
            <asp:ListItem Value="s"></asp:ListItem>
            <asp:ListItem Value="t"></asp:ListItem>
            <asp:ListItem Value="u"></asp:ListItem>
            <asp:ListItem Value="v"></asp:ListItem>
            <asp:ListItem Value="w"></asp:ListItem>
            <asp:ListItem Value="x"></asp:ListItem>
            <asp:ListItem Value="y"></asp:ListItem>
            <asp:ListItem Value="z"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="decodeButton" runat="server" Text="Decode"/>

        <br />
        <br />
      <asp:Label ID="stringlabel" runat="server" Text="Original String: "></asp:Label>
      <asp:TextBox ID="originalString" runat="server" size="50"></asp:TextBox>
        <br />
        <br />

    </div>
    </div>
    <div class="col-sm-4">
      <h3>Chat</h3>        
    </div>
    <div id="Chatbox">
        <br />
        <br />

    </div>
  </div>
</div>
</body>
</html>
