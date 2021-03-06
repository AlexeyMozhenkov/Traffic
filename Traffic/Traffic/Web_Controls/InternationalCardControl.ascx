<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InternationalCardControl.ascx.cs"
    Inherits="Traffic.InternationalCardControl" %>

<asp:Table ID="Table1" runat="server" HorizontalAlign="Left" BorderColor="#999999"
    BorderStyle="Solid" BorderWidth="2px" CellPadding="1" CellSpacing="1" Font-Bold="False"
    Font-Names="Segoe UI" Height="550px" Font-Size="Small" Width="450px" OnLoad="Page_Load">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_1" runat="server" Text="��������������� ID"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">

            <asp:TextBox ID="txt_1" runat="server" Width="200px"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_1" runat="server" ErrorMessage="��������������� ID: ���� �� ���������"
                Text="*" ControlToValidate="txt_1" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">

        <asp:TableCell runat="server">
            <asp:Label ID="lbl_2" runat="server" Text="������"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_2" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_2" runat="server" ErrorMessage="������: ���� �� ���������"
                Text="*" ControlToValidate="txt_2" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_3" runat="server" Text="���� ������"
                Width="200px"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_3" runat="server" Width="200px"  TextMode="Date" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_3" runat="server" ErrorMessage="���� ������: ���� �� ���������"
                Text="*" Display="Static" ControlToValidate="txt_3"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_4" runat="server" Text="���� �����"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_4" runat="server" Width="200px"  TextMode="Date" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_4" runat="server" ErrorMessage="���� �����: ���� �� ���������"
                ControlToValidate="txt_4" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_5" runat="server" Text="ID ����������"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_5" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_5" runat="server" ErrorMessage="ID ����������: ���� �� ���������"
                ControlToValidate="txt_5" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_6" runat="server" Text="ID �����������"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_6" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_6" runat="server" ErrorMessage="ID �����������: ���� �� ���������"
                ControlToValidate="txt_6" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
   
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" ColumnSpan="3" VerticalAlign="Top">
            <asp:ValidationSummary runat="server" ID="valr_Summary"></asp:ValidationSummary>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
        <asp:TableCell runat="server">
            <asp:Button ID="btn_AddEdit" runat="server" Text="Add" Width="100" OnClick="btn_AddEdit_Click" />

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" Width="100" OnClick="btn_Cancel_Click"
                ValidationGroup="No_Validation" />

        </asp:TableCell>
    </asp:TableRow>
</asp:Table>




