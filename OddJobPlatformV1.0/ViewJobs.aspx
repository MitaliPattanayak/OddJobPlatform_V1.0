<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ViewJobs.aspx.cs" Inherits="OddJobPlatformV1._0.ViewJobs" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3 style="margin-left: 280px">View Jobs</h3>
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:GridView ID="grdJobs" runat="server" AutoGenerateColumns="False" style="margin-left: 75px"
                         OnRowDataBound="grdJobs_RowDataBound" OnRowCommand="grdJobs_RowCommand" DataKeyNames="JobID"
                       >
                        <Columns>
                            <asp:TemplateField HeaderText="Serial number">
    <ItemTemplate>
        <asp:Label ID="lblSerial" runat="server"></asp:Label>
    </ItemTemplate>
</asp:TemplateField>
                            <asp:BoundField DataField="jobname" HeaderText="Job Name" />
                            <asp:BoundField DataField="address" HeaderText="Address" />
                            <asp:BoundField DataField="jobtype" HeaderText="Job Type" />
                            <asp:BoundField DataField="ContactEmail" HeaderText="Contact Email" />
                            <asp:TemplateField>
                              <ItemTemplate>
                                <asp:Button ID="Apply" runat="server" CommandName="ApplyJob" CommandArgument='<%#Eval("JobID")%>' Text="Apply" />
                              </ItemTemplate> 
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
<address>
        &nbsp;</address>

    </asp:Content>
