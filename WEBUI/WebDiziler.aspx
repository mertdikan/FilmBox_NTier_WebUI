<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebDiziler.aspx.cs" Inherits="WEBUI.WebDiziler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <header>
        <style type="text/css">
            .auto-style1 {
                height: 114px;
                width: 337px;
                border: 2px solid;
                /*background-image: url("image/yeto.jpg")*/
                background-color: none;
                color: antiquewhite;
            }

            .ddd {
                background-color: transparent;
            }

            #lblFilm {
                margin-left: 200px;
            }

            #btnGiris {
                margin-top: 20px;
                margin-left: 120px;
            }

            #btnKayit {
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

            .auto-style4 {
                margin-top: 20px;
            }

            .auto-style5 {
                margin-left: 100px;
            }
   


            @media (orientation : portrait) {
                .ddd {
                    display: flex;
                    flex-direction: column;
                    margin-left: auto;
                }
            }

            @media (orientation : landscape) {
                .ddd {
                    flex-direction: row;
                    /* margin-left:auto;*/
                }
            }
        </style>
    </header>
    <article class="ddd">
        <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
                <div class="product">
                    <div class="imagec">
                        <asp:Image ID="Image1" ImageUrl='<%#Eval("images") %>' runat="server" Height="180" Width="175" />
                    </div>
                    <div class="productDetail">
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("SeriesName") %>'></asp:Label>
                    </div>
                    <div class="productDetail">
                        <asp:Label ID="Label2" runat="server" Text='<%#"IMBD :"+(Eval("Vote"))%>'></asp:Label>

                    </div>
                    <div class="productDetail">
                        <asp:Label ID="Label3" runat="server" Text='<%#"Views :"+(Eval("Views")) %>'></asp:Label>
                    </div>

                    <div class="productEditing">
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("SeriesId") %>' CommandName="Duzenle">Duzenle</asp:LinkButton>
                    </div>

                </div>
            </ItemTemplate>
            <EditItemTemplate>
                <div class="product">
                </div>

                <div class="productDetail">
                    <asp:TextBox ID="txtUrunAdi" runat="server" Text='<%#Eval("SeriesName") %>'></asp:TextBox>
                </div>
                <div class="productDetail">
                    <asp:TextBox ID="txtUrunFiyati" runat="server" Text='<%#Eval("Vote")%>'></asp:TextBox>
                </div>
                <div class="productDetail">
                    <asp:TextBox ID="txtStok" runat="server" Text='<%#Eval("Views") %>'></asp:TextBox>
                </div>
                <div class="productEditing">
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("SeriesId") %>' CommandName="Guncelle">Guncelle</asp:LinkButton>||
                             <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%#Eval("SeriesId") %>' CommandName="Iptal">Iptal</asp:LinkButton>
                </div>
            </EditItemTemplate>
        </asp:DataList>
    </article>
</asp:Content>
