<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WaybillControl.ascx.cs"
    Inherits="Traffic.WaybillControl" %>

<asp:Table ID="Table1" runat="server" HorizontalAlign="Left" BorderColor="#999999"
    BorderStyle="Solid" BorderWidth="2px" CellPadding="1" CellSpacing="1" Font-Bold="False"
    Font-Names="Segoe UI" Height="589px" Font-Size="Small" Width="458px" OnLoad="Page_Load" style="margin-right: 23px; margin-top: 0px">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label16" runat="server" Text="ID Путевого Листа"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_0" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="ID Путевого Листа: поле не заполнено"
                Text="*" ControlToValidate="txt_1" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_1" runat="server" Text="Номер Путевого Листа"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_1" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_1" runat="server" ErrorMessage="Номер Путевого Листа: поле не заполнено"
                Text="*" ControlToValidate="txt_1" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">

        <asp:TableCell runat="server">
            <asp:Label ID="lbl_2" runat="server" Text="Дата"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_2" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_2" runat="server" ErrorMessage="Дата: поле не заполнено"
                Text="*" ControlToValidate="txt_2" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_3" runat="server" Text="Транспорт(ID)"
                Width="200px"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_3" runat="server" Width="200px" MaxLength="50" ></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_3" runat="server" ErrorMessage="Транспорт(ID): поле не заполнено"
                Text="*" Display="Static" ControlToValidate="txt_3"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>



    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_4" runat="server" Text="Прицеп(ID)"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_4" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_4" runat="server" ErrorMessage="Прицеп(ID): поле не заполнено"
                ControlToValidate="txt_4" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>


    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_5" runat="server" Text="Табельный номер водителя"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_5" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_5" runat="server" ErrorMessage="Табельный номер водителя: поле не заполнено"
                ControlToValidate="txt_5" Text="*"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label1" runat="server" Text="Показания спидометра до выезда"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_6" runat="server" Width="200px" MaxLength="100"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Показания спидометра до выезда: поле не заполнено"
                ControlToValidate="txt_6" Text="*"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label2" runat="server" Text="Показания спидометра по возвращению"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_7" runat="server" Width="200px" MaxLength="100"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label3" runat="server" Text="Дата выезда по графику"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_8" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Дата выезда по графику: поле не заполнено"
                ControlToValidate="txt_8" Text="*"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label4" runat="server" Text="Время выезда по графику"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_9" runat="server" Width="200px" TextMode="Time"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Время выезда по графику: поле не заполнено"
                ControlToValidate="txt_9" Text="*"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label5" runat="server" Text="Дата выезда фактически"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_10" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label6" runat="server" Text="Время выезда фактически"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_11" runat="server" Width="200px" TextMode="Time"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

        <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label7" runat="server" Text="Дата возвращения по графику"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_12" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label8" runat="server" Text="Время возвращения по графику"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_13" runat="server" Width="200px" TextMode="Time"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label9" runat="server" Text="Дата возвращения фактически"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_14" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label10" runat="server" Text="Время возвращения фактически"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_15" runat="server" Width="200px" TextMode="Time"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label11" runat="server" Text="Нулевой пробег (км)"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_16" runat="server" Width="200px" ></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label12" runat="server" Text="Время работы двигателя (ч)"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_17" runat="server" Width="200px" ></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label13" runat="server" Text="Время работы спецоборудования (ч)"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_18" runat="server" Width="200px" ></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label14" runat="server" Text="Остаток ТСМ при выезде (л)"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_19" runat="server" Width="200px" ></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
        </asp:TableCell>
    </asp:TableRow>

    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="Label15" runat="server" Text="Остаток ТСМ по возвращению (л)"></asp:Label>
        </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_20" runat="server" Width="200px" ></asp:TextBox>
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




