<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeControl.ascx.cs"
    Inherits="Traffic.EmployeeControl" %>

<asp:Table ID="Table1" runat="server" HorizontalAlign="Left" BorderColor="#999999"
    BorderStyle="Solid" BorderWidth="2px" CellPadding="1" CellSpacing="1" Font-Bold="False"
    Font-Names="Segoe UI" Height="550px" Font-Size="Small" Width="450px" OnLoad="Page_Load">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_1" runat="server" Text="Address ID"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">

            <asp:TextBox ID="txt_1" runat="server" Width="200px"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_1" runat="server" ErrorMessage="Address ID is required field"
                Text="*" ControlToValidate="txt_1" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">

        <asp:TableCell runat="server">
            <asp:Label ID="lbl_2" runat="server" Text="Organization ID"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_2" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_2" runat="server" ErrorMessage="Organization ID is required field"
                Text="*" ControlToValidate="txt_2" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_3" runat="server" Text="Table Number"
                Width="200px"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_3" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_3" runat="server" ErrorMessage="Table Number is required field"
                Text="*" Display="Static" ControlToValidate="txt_3"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_4" runat="server" Text="First Name"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_4" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_4" runat="server" ErrorMessage="First Name is required field"
                ControlToValidate="txt_4" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_5" runat="server" Text="Last Name"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_5" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_5" runat="server" ErrorMessage="Last Name is required field"
                ControlToValidate="txt_5" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_6" runat="server" Text="Parent Name"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_6" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_6" runat="server" ErrorMessage="Parent Name field is required"
                ControlToValidate="txt_6" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_7" runat="server" Text="BirthDay"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_7" runat="server" TextMode="Date" Width="200px"
                MaxLength="2"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_7" runat="server"
                ErrorMessage="BirthDay is required field" ControlToValidate="txt_7"
                Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_8" runat="server" Text="ID Number"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_8" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

         <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_8" runat="server"
                ErrorMessage="ID Number is required field" ControlToValidate="txt_8"
                Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_9" runat="server" Text="Passport Serie"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_9" runat="server" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_9" runat="server" ErrorMessage="Passport Serie is required field"
                Text="*" ControlToValidate="txt_9"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_10" runat="server" Text="Passport Number"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_10" runat="server" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_10" runat="server" ErrorMessage="Passport Number is required field"
                Text="*" ControlToValidate="txt_10"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_11" runat="server" Text="Date Passport Until"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_11" runat="server" TextMode="Date" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_11" runat="server" ErrorMessage="Date Passport Until is required field"
                Text="*" ControlToValidate="txt_11"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_12" runat="server" Text="Date Passport From"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_12" runat="server" TextMode="Date" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_12" runat="server" ErrorMessage="Date Passport From is required field"
                Text="*" ControlToValidate="txt_12"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_13" runat="server" Text="Position "></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_13" runat="server" Width="200px" Height="50px" TextMode="MultiLine"  MaxLength="100"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_13" runat="server" ErrorMessage="Position is required field"
                Text="*" ControlToValidate="txt_13"></asp:RequiredFieldValidator>

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




