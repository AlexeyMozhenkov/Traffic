<%@ Page Title="Меню Заместителя Директора" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BossPage.aspx.cs" Inherits="Traffic.BossPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:Title %>.</h2>

    <div class="jumbotron">
        <h4>Доступны следующие операции</h4>
        <asp:Button ID="btn_1" runat="server" Text="Формирование плановой калькуляции доходов "  class="btn btn-primary btn-large" Width="500px" ></asp:Button>
        <br />
        <asp:Button ID="btn_2" runat="server" Text="Статистические отчеты по данным Gurtam.by "  class="btn btn-primary btn-large" Width="500px" ></asp:Button>
        <br />
        <asp:Button ID="btn_3" runat="server"  class="btn btn-primary btn-large" Width="500px" ></asp:Button>
        <br />
        <asp:Button ID="btn_4" runat="server"  class="btn btn-primary btn-large" Width="500px" ></asp:Button>
        <br />
        <asp:Button ID="btn_5" runat="server"  class="btn btn-primary btn-large" Width="500px" ></asp:Button>
        <br />
        <br />
        <br />
    </div>
    </asp:Content>
