<%@ Page Title="Меню Механика" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="MechanicPage.aspx.cs" Inherits="Traffic.MechanicPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:Title %>.</h2>

    <div class="jumbotron">
        <h4>Доступны следующие операции</h4>
        <asp:Button ID="btn_1" runat="server" Text="Данные о допуске к международным перевозкам"  class="btn btn-primary btn-large" Width="500px" PostBackUrl="~/Web_Forms/InternationalCards.aspx" ></asp:Button>
        <br />
        <asp:Button ID="btn_2" runat="server" Text="Данные о прохождении технических осмотров"  class="btn btn-primary btn-large" Width="500px" PostBackUrl="~/Web_Forms/TechnicalInspection.aspx" ></asp:Button>
        <br />
        <asp:Button ID="btn_3" runat="server" Text="Отчет о сотоянии транспорта"  class="btn btn-primary btn-large" Width="500px" PostBackUrl="~/Web_Forms/TransportStaterReport.aspx" ></asp:Button>
        <br />
        <asp:Button ID="btn_4" runat="server" Text="Карточка технического обслуживания"  class="btn btn-primary btn-large" Width="500px" PostBackUrl="~/Web_Forms/Maintenance.aspx" ></asp:Button>
        <br />
        <asp:Button ID="btn_5" runat="server" Text="Транспорт"  class="btn btn-primary btn-large" PostBackUrl="~/Web_Forms/Transport.aspx" Width="500px" ></asp:Button>
        <br />
        <br />
        <br />
    </div>
    </asp:Content>
