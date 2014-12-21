<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TransportStaterReportControl.ascx.cs"
    Inherits="Traffic.TransportStaterReportControl" %>

<asp:Table ID="Table1" runat="server" HorizontalAlign="Left" BorderColor="#999999"
    BorderStyle="Solid" BorderWidth="2px" CellPadding="1" CellSpacing="1" Font-Bold="False"
    Font-Names="Segoe UI" Height="550px" Font-Size="Small" Width="450px" OnLoad="Page_Load">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label1" runat="server" Text="ID Отчета"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">

            <asp:TextBox ID="txt_0" runat="server" Width="200px" Enabled="false"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_1" runat="server" Text="ID Организации"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">

            <asp:TextBox ID="txt_1" runat="server" Width="200px" Enabled="True"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_1" runat="server" ErrorMessage="ID Организации: поле не заполнено"
                Text="*" ControlToValidate="txt_1" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">

        <asp:TableCell runat="server">
            <asp:Label ID="lbl_2" runat="server" Text="ID Маршрута"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_2" runat="server" Width="200px" MaxLength="50" ></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_2" runat="server" ErrorMessage="ID Маршрута: поле не заполнено"
                Text="*" ControlToValidate="txt_2" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_3" runat="server" Text="ID Транспорта"
                Width="200px"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_3" runat="server" Width="200px"   MaxLength="50" ></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_3" runat="server" ErrorMessage="ID Транспорта: поле не заполнено"
                Text="*" Display="Static" ControlToValidate="txt_3"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_4" runat="server" Text="Табельный номер"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_4" runat="server" Width="200px"   MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_4" runat="server" ErrorMessage="Табельный номер: поле не заполнено"
                ControlToValidate="txt_4" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_5" runat="server" Text="Состояние"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_5" runat="server" Width="200px" MaxLength="50" TextMode="MultiLine"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_5" runat="server" ErrorMessage="Состояние: поле не заполнено"
                ControlToValidate="txt_5" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_6" runat="server" Text="Обратная загрузка"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_6" runat="server" Height="75px"  Width="200px" TextMode="MultiLine"  MaxLength="250"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Примечания: поле не заполнено"
                ControlToValidate="txt_6" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_7" runat="server" Text="Местонахождение"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_7" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Местонахождение: поле не заполнено"
                ControlToValidate="txt_7" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label2" runat="server" Text="Дата отправления"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_8" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label3" runat="server" Text="Срок поставки"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_9" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

   <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label4" runat="server" Text="Отправитель"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_10" runat="server" Width="200px" MaxLength="150"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label5" runat="server" Text="Пункт отправления"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_11" runat="server" Width="200px" MaxLength="150"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label6" runat="server" Text="Пункт назначения"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_12" runat="server" Width="200px" MaxLength="150"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label7" runat="server" Text="Заказчик"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_13" runat="server" Width="200px" MaxLength="150"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label8" runat="server" Text="Груз"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_14" runat="server" Width="200px" MaxLength="150"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server" ColumnSpan="3" VerticalAlign="Top">
            <asp:ValidationSummary runat="server" ID="valr_Summary"></asp:ValidationSummary>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
        <asp:TableCell runat="server">
            <asp:Button ID="btn_AddEdit" runat="server" Text="Add" Width="100" OnClick="btn_AddEdit_Click"/>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" Width="100" OnClick="btn_Cancel_Click"
                ValidationGroup="No_Validation" />

        </asp:TableCell>
    </asp:TableRow>
</asp:Table>




