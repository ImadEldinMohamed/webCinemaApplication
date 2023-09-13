<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cinema.aspx.cs" Inherits="webCinemaApplication.cinema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">


        <h2 id="bentornato" runat="server"></h2>
        <div>nome</div>
        <asp:TextBox ID="nome" runat="server"></asp:TextBox>
        <div>cognome</div>
        <asp:TextBox ID="cognome" runat="server"></asp:TextBox>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">

                  <asp:ListItem Value="nord" Text="SALA NORD"></asp:ListItem>
                <asp:ListItem Value="est" Text="SALA EST"></asp:ListItem>
                <asp:ListItem Value="sud" Text="SALA SUD"></asp:ListItem>



            </asp:DropDownList>
                 <div >
                    <asp:CheckBoxList ID="CheckBoxList1"  runat="server">
                        <asp:ListItem Value="ridotto" Text="Ticket ridotto"></asp:ListItem>
                    </asp:CheckBoxList>
                </div>

            <asp:Button ID="Button1" runat="server" Text="compra e paga" OnClick="Button1_Click" />
            <asp:Label ID="esito" runat="server" Text=""></asp:Label>

            <div class="container d-flex flex-column ">
     <asp:Label ID="nord" runat="server" Text="Sala Nord -Biglietti Venduti: 0 - Ridotti: 0"></asp:Label>
     <asp:Label ID="est" runat="server" Text="Sala Est - Biglietti Venduti: 0 - Ridotti: 0"></asp:Label>
     <asp:Label ID="sud" runat="server" Text="Sala Sud - Biglietti Venduti: 0 - Ridotti: 0"></asp:Label>

        </div>

  </div>




    </div>
</asp:Content>
