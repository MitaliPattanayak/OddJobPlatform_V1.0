<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateJob.aspx.cs" MasterPageFile="~/Site.Master" Inherits="OddJobPlatformV1._0.CreateJob" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Create New Job</h3>

    <table style="width: 100%;">
        <tr>
            <td>Job Name</td>
            <td>
                <asp:TextBox ID="txtJobName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Job Description</td>
            <td>
                <asp:TextBox ID="txtJobDesc" runat="server" Height="64px" Width="137px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" Height="40px" Width="137px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Contact Number</td>
            <td>
                <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Job Type</td>
            <td>
                <asp:DropDownList ID="ddlJobType" runat="server">
                    <asp:ListItem Selected="True" Value="0">Select</asp:ListItem>
                    <asp:ListItem>Permanent</asp:ListItem>
                    <asp:ListItem>Temporary</asp:ListItem>
                    <asp:ListItem>PartTime</asp:ListItem>
                           </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Salary</td>
            <td>
                <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="align-items:center">
                <asp:Button ID="Create" runat="server" Text="Button" OnClick="Create_Click" />
            &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="align-items:center">
                &nbsp;</td>
        </tr>
    </table>
    <address>
        &nbsp;</address>

    </asp:Content>

