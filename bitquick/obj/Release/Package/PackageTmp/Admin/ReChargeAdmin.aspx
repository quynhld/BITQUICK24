<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master"
     AutoEventWireup="true" CodeBehind="ReChargeAdmin.aspx.cs" Inherits="BIT.WebUI.Admin.ReChargeAdmin"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="wrapper">
        <br />
        <section class="panel">
            <header class="panel-heading">
                <h3>ReCharge List</h3>
            </header>
            <asp:DataList runat="server" ID="dtlRecharge"  class="table table-hover p-table">
                <HeaderTemplate>
                                <table class="table table-hover p-table">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Create Date</th>
                        <th>Receive Wallet</th>
                        <th>Amount</th>
                        <th>Transaction</th>
                        <th>Status</th>
                    </tr>
                </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody>
                    <tr>
                        <td class="p-name"><%# Eval("ID") %>
                        </td>
                        <td> <%# Eval("CreateDate") %>                          
                        </td>
                        <td>
                            <%# Eval("ReceiveWallet") %> 
                        </td>
                        <td>
                            <%# Eval("Amount") %> </span>
                        </td>
                        <td>
                            <span class="label label-primary">
                            <%# Eval("Transaction") %></span>
                        </td>
                        <td><span class="label label-primary">
                            <%# getStatus(Eval("status")) %>
                            </span>
                            <asp:LinkButton ID="lbkBtnConfirm" runat="server" Visible='<%# getConfirmVisible(Eval("Status")) %>' Text="Confirm" CommandArgument='<%# Eval("ID") %>' class="btn btn-success" OnClick="lbkBtnConfirm_Click"></asp:LinkButton>
                        </td>
                    </tr>
                </tbody>
                </ItemTemplate>
                <FooterTemplate>
                                </table>
                </FooterTemplate>
            </asp:DataList>
        </section>
        <div class="pagination"></div>
    </section>
</asp:Content>
