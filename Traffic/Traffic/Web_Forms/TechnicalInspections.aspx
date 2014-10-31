<%@ Page Title="Технические Осмотры" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TechnicalInspections.aspx.cs" Inherits="Traffic.TechnicalInspections" %>

<%@ Register Src="~/Web_Controls/TechnicalInspectionControl.ascx" TagPrefix="uc1" TagName="DetailedInfo" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div id="container">
        <asp:MultiView ID="mv_Main" runat="server" ActiveViewIndex="0">
            <asp:View ID="view_DataGrid" runat="server">
                <asp:GridView ID="DataGrid" runat="server" AllowPaging="True"
                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20" Width="100%" OnSelectedIndexChanged="DataGrid_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <%--<asp:BoundField DataField="addressID" HeaderText="Address ID " />
                        <asp:BoundField DataField="organizationID" HeaderText="Organization ID" />
                        <asp:BoundField DataField="tableNumber" HeaderText="Table Number " />
                        <asp:BoundField DataField="FirstName" HeaderText="First Name " />
                        <asp:BoundField DataField="LastName" HeaderText="Last Name " />
                        <asp:BoundField DataField="ParentName" HeaderText="Parent Name " />
                        <asp:BoundField DataField="BirthDay" HeaderText="Birth Day" />
                        <asp:BoundField DataField="IDnumber" HeaderText="ID Number" />
                        <asp:BoundField DataField="PassportSerie" HeaderText="Passport Serie" />
                        <asp:BoundField DataField="PassportNumber" HeaderText="Passport Number" />
                        <asp:BoundField DataField="DatePassportUntil" 
                            HeaderText="Date Passport Until" />
                        <asp:BoundField DataField="DatePassportFrom" HeaderText="Date Passport From" />
                        <asp:BoundField DataField="position" HeaderText="Position" />--%>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                <hr />
                <div id="filter">
                    <asp:Label ID="lbl_Filter" runat="server" Text="Filter"></asp:Label>
                    <br />
                    <asp:RadioButton ID="rbtn_AllUsers" runat="server" AutoPostBack="True" Checked="True"
                        GroupName="Filter" Text="All records" />
                    <br />
                    <asp:RadioButton ID="rbtn_Filtered" runat="server" AutoPostBack="True" GroupName="Filter"
                        Text="Name contains" />
                    <br />
                    <asp:TextBox ID="txt_Filter" runat="server" Width="210px" Enabled="False"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_Show" runat="server" Text="Show" Width="120px" CssClass="btnAlign"
                        Enabled="False" />
                    <br />
                </div>
                <div id="modify">
                    <asp:Button ID="btn_Add" runat="server" Text="Add" Width="120px" CssClass="btnAlign"
                        OnClick="btn_Add_Click" />
                    <br />
                    <asp:Button ID="btn_Edit" runat="server" Text="Edit" Width="120px" CssClass="btnAlign" OnClick="btn_Edit_Click"/>
                    <br />
                    <asp:Button ID="btn_Delete" runat="server" Text="Delete" Width="120px" CssClass="btnAlign" OnClick="btn_Delete_Click"
                        Font-Names="Segoe UI" />
                    <br />
                </div>
                <br />
            </asp:View>

            <asp:View ID="view_Detailed" runat="server">
                <div class="detailedInfo">
                    <uc1:DetailedInfo runat="server" ID="DetailedInfoForm" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </div>
            </asp:View>

        </asp:MultiView>
    </div>
</asp:Content>
