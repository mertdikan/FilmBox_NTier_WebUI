<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Webkullanici.aspx.cs" Inherits="WEBUI.Webkullanici" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <style type="text/css">
            .auto-style1 {
                border: 7px solid;
                /* background-image: url("image/harrypotter.jpg")*/
                color: antiquewhite;
                margin: auto;
                text-align: center;
                align-items: center;
            }
            .auto-style1:hover {
                box-shadow:0px 0px 10px 5px
            }

            #lblFilm {
                margin-left: 200px;
                font-size: 20px;
            }

            #btnGiris {
                margin-top: 20px;
                margin-left: 120px;
            }

            #btnKayit {
                margin-top: auto;
            }

            .auto-style2 {
                margin-top: 120px;
                margin-left: 10px;
            }

            .auto-style3 {
                margin-top: 25px;
                margin-left: 95px;
            }

            .auto-style4 {
                
                margin-left: 5px;
                margin-top: 50px;
                font-size: x-large;
            }

            .auto-style5 {
                margin-left: 40px;
                margin-top: 50px;
                font-size: x-large;
            }

            .kullanicics {
                height: 450px;
                width: 337px;
                margin: auto;
                text-align: center;
                margin-top: 300px;
                margin-bottom: 550px;
                font-size: 25px;
            }
        </style>
    </header>
    <html>



    <body>

        <div>
        </div>
        <table class="kullanicics">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblFilm" runat="server" Text="Film Projesi" Font-Size="XX-Large"></asp:Label>
                    <br />
                    <asp:Label ID="lblKullaniciAdi" runat="server" Text="Kullanıcı Adı" ></asp:Label>
                    <asp:TextBox ID="txtKullaniciAdi" runat="server" Height="25" Font-Size="X-Large" Width="136px" CssClass="auto-style2"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblSifre" runat="server" Text="Şifre"></asp:Label>
                    <asp:TextBox ID="txtSifre" runat="server" Width="136px" Height="25" Font-Size="X-Large" CssClass="auto-style3" TextMode="Password"></asp:TextBox><br />
                    <asp:Button ID="btnKayit" runat="server" Text="Yeni Kayıt" CssClass="auto-style4" OnClick="btnKayit_Click" />
                    <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" CssClass="auto-style5" OnClick="btnGiris_Click" />



                </td>
            </tr>
        </table>

    </body>
    </html>
</asp:Content>
