<%@ Page Title="Меню Логиста Менеджера" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="LogistPage.aspx.cs" Inherits="Traffic.LogistPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:Title %>.</h2>

    <div class="jumbotron">
        <h4>Доступны следующие операции</h4>
        <asp:Button ID="btn_1" runat="server" Text=" Отчет о портфеле заказов"  class="btn btn-primary btn-large" Width="500px" ></asp:Button>
        <br />
        <asp:Button ID="btn_2" runat="server" Text="Регистрация движения груза "  class="btn btn-primary btn-large" Width="500px" ></asp:Button>
        <br />
        <asp:Button ID="btn_3" runat="server"  class="btn btn-primary btn-large" Width="500px" Text="Диспетчеризация клиентских отправлений " ></asp:Button>
        <br />
        <asp:Button ID="btn_4" runat="server"  class="btn btn-primary btn-large" Width="500px" Text="Регистрация грузов (накладных) в общей системе " PostBackUrl="~/Web_Forms/Acts.aspx" ></asp:Button>
        <br />
        <asp:Button ID="btn_5" runat="server"  class="btn btn-primary btn-large" Width="500px" Text="Заявки" PostBackUrl="~/Web_Forms/Requests.aspx" ></asp:Button>
        <br />
        <asp:Button ID="btn_6" runat="server"  class="btn btn-primary btn-large" Width="500px" Text="Контракты" PostBackUrl="~/Web_Forms/ContractsPage.aspx" ></asp:Button>
        <br />
        <asp:Button ID="btn_7" runat="server"  class="btn btn-primary btn-large" Width="500px" Text="Путевые листы" PostBackUrl="~/Web_Forms/WaybillsPrintPage.aspx" ></asp:Button>
        <br />
    </div>
    </asp:Content>
