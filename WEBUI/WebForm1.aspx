<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WEBUI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 114px;
            width: 337px;
        }
        #lblFilm{
           margin-left: 100px;
        }
         #btnGiris{
           margin-top: 20px;
           margin-left: 120px;
        }
          #btnKayit{
           margin-top: auto;
           
        }
        .auto-style2 {
             margin-top: 20px;
            margin-left: 10px;
        }
        .auto-style3 {
            margin-top: 10px;
            margin-left: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <table>
                <tr>
                    <td class="auto-style1"> 
                        <asp:Label  ID="lblFilm" runat="server" Text="Film Projesi" ></asp:Label> <br />
                        <asp:Label ID="lblKullaniciAdi" runat="server" Text="Kullanıcı Adı"></asp:Label>
                        <asp:TextBox ID="txtKullaniciAdi" runat="server" Width="136px" CssClass="auto-style2"></asp:TextBox> <br />
                         <asp:Label ID="lblSifre" runat="server" Text="Şifre"></asp:Label>
                        <asp:TextBox ID="txtSifre" runat="server" Width="136px" CssClass="auto-style3"></asp:TextBox><br />
                         <asp:Button ID="btnKayit" runat="server" Text="Yeni Kayıt" OnClick="btnKayit_Click" />
                        <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" OnClick="btnGiris_Click" />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                       

                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
