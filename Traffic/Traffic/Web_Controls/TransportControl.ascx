<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TransportControl.ascx.cs"
    Inherits="Traffic.TransportControl" %>

<asp:Table ID="Table1" runat="server" HorizontalAlign="Left" BorderColor="#999999"
    BorderStyle="Solid" BorderWidth="2px" CellPadding="1" CellSpacing="1" Font-Bold="False"
    Font-Names="Segoe UI" Height="589px" Font-Size="Small" Width="458px" OnLoad="Page_Load" style="margin-right: 23px; margin-top: 0px">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_transportID" runat="server" Text="Transport ID"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_01" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">

            <asp:RequiredFieldValidator ID="vldr_transportIDRequired" runat="server" ErrorMessage="Transport ID is required field"
                Text="*" ControlToValidate="txt_01" Display="Static" Enabled="True"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <%--<asp:TableRow runat="server">
        <asp:TableCell runat="server">
                          
             
            </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:DropDownList ID="txt_1" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="EventHandler" Visible="false" ></asp:DropDownList>

    </asp:TableCell>
        <asp:TableCell runat="server">
    </asp:TableCell>
    </asp:TableRow>--%>
    <asp:TableRow runat="server">

        <asp:TableCell runat="server">
            <asp:Label ID="lbl_model" runat="server" Text="Model"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_2" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server">
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_registrationNumber" runat="server" Text="Registration Number"
                Width="200px"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_3" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_registrationNumberRequired" runat="server" ErrorMessage="Registration Number is required field"
                Text="*" Display="Static" ControlToValidate="txt_3"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_VIN" runat="server" Text="VIN"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_4" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_VINrequired" runat="server" ErrorMessage="VIN is required field"
                ControlToValidate="txt_4" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_transportType" runat="server" Text="Transport Type"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_5" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_transportTypeRequired" runat="server" ErrorMessage="Transport Type is required field"
                ControlToValidate="txt_5" Text="*"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_transportCategory" runat="server" Text="Transport Category"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_6" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_transportCategoryRequired" runat="server" ErrorMessage="Transport Category field is required"
                ControlToValidate="txt_6" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_transportMakingYear" runat="server" Text="Transport Making Year"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_7" runat="server" TextMode="Number" Width="200px"
                MaxLength="2"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_transportMakingYearRequired" runat="server"
                ErrorMessage="Transport Making Year is required field" ControlToValidate="txt_7"
                Text="*"></asp:RequiredFieldValidator>


            <asp:RangeValidator ID="vldr_transportMakingYearRange" runat="server" ErrorMessage="Year should be between 1980 and 2014"
                ControlToValidate="txt_7" Display="Dynamic" MaximumValue="2014"
                MinimumValue="1980" Type="Integer" Text="*"></asp:RangeValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:Label ID="lbl_ecologyClass" runat="server" Text="Ecology Class"></asp:Label>

        </asp:TableCell>

        <asp:TableCell runat="server">
            <asp:TextBox ID="txt_8" runat="server" Width="200px" MaxLength="50"></asp:TextBox>

        </asp:TableCell>

        <asp:TableCell runat="server" >
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_maxWeight" runat="server" Text="Max Weight"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_9" runat="server" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_maxWeightRequired" runat="server" ErrorMessage="Max Weight is required field"
                Text="*" ControlToValidate="txt_9"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_Weight" runat="server" Text="Weight"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_10" runat="server" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_WeightRequired" runat="server" ErrorMessage="Weight is required field"
                Text="*" ControlToValidate="txt_10"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_engineType" runat="server" Text="Engine Type"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_11" runat="server" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_engineType" runat="server" ErrorMessage="Engine Type is required field"
                Text="*" ControlToValidate="txt_11"></asp:RequiredFieldValidator>

        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:Label ID="lbl_engineVolume" runat="server" Text="Engine Volume"></asp:Label>

        </asp:TableCell>
        <asp:TableCell runat="server" VerticalAlign="Top">
            <asp:TextBox ID="txt_12" runat="server" Width="200px" MaxLength="20"></asp:TextBox>

        </asp:TableCell>
        <asp:TableCell runat="server" ForeColor="#CC0000">
            <asp:RequiredFieldValidator ID="vldr_engineVolume" runat="server" ErrorMessage="Engine Volume is required field"
                Text="*" ControlToValidate="txt_12"></asp:RequiredFieldValidator>

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




