<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Traffic._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Автоматизированная система &quot;Учет автотранспорта&quot;</h1>
        <p class="MsoNormal" style="font-size: medium">
            <b><span>Система &quot;Учет автотранспорта&quot;</span></b><span> - предназначена для
                комплексной автоматизации учета транспорта в автотранспортных предприятиях, 
            организациях, которые имеют автопарки, а также и для частных лиц, имеющих личные 
            авто и желающих вести полный контроль расходов и ремонтов по ним.</span>
        </p>
        <h4>Войти в систему как</h4>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1">
                <asp:ListItem>Директор</asp:ListItem>
                <asp:ListItem>Механик</asp:ListItem>
                <asp:ListItem>Логист</asp:ListItem>
                <asp:ListItem>Водитель</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Button ID="btn_Enter" runat="server" Text="Войти"  class="btn btn-primary btn-large" OnClick="btn_Enter_Click"></asp:Button></div>

    <div class="row">
        <div class="col-md-4">
            <h2>Данные по автомобилям</h2>
            <p>
                Получить даннные по автомобилям предприятия
            </p>
            <p>
                <a class="btn btn-default" href="Web_Forms/Transport.aspx">Начать &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Данные о сотрудниках</h2>
            <p>
                Получить данные о сотрудниках
            </p>
            <p>
                <a class="btn btn-default" href="Web_Forms/EmployeePage.aspx">Начать &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Организации</h2>
            <p>
                Получить отчеты об организациях</p>
            <p>
                <a class="btn btn-default" href="Web_Forms/Organizations.aspx">Начать &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
