<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" 
    AutoEventWireup="true" CodeBehind="GH.aspx.cs" Inherits="BIT.WebUI.Admin.GH" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="wrapper">
        <section class="panel">
            <header class="panel-heading">
                <h3>New Get Donation</h3>
            </header>
            <div class="panel-body">
                <div class="form">
                    <form enctype="multipart/form-data" novalidate="novalidate" action="/account/creategdlink" method="POST" class="cmxform form-horizontal tasi-form">
                        <div class="form-group col-lg-12">
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-5" for="firstname">Avaiable BTC Amount </label>
                                <div class="col-lg-5">
                                    <span class="badge">
                                        <asp:Label runat="server" ID="lblAmount"></asp:Label>
                                        BTC
                                    </span>
                                </div>
                            </div>
                        </div>
<%--                        <div class="form-group col-lg-12">
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-5" for="firstname">Avaiable PH Amount in month</label>
                                <div class="col-lg-5">
                                    <span class="badge">
                                        <asp:Label runat="server" ID="lblAmountPHRemain"></asp:Label>
                                        BTC
                                    </span>
                                </div>
                            </div>
                        </div>--%>
                        <div class="form-group col-lg-12">
                            <label class="control-label col-lg-3" for="firstname">Choose wallet PH</label>
                            <div class="col-lg-6">
                                <div class="radio">
                                    <asp:RadioButtonList runat="server" ID="radSelectWallet" RepeatDirection="Horizontal">
                                        <asp:ListItem Text="B Wallet" Value="B"></asp:ListItem>
                                        <asp:ListItem Text="Blockchain Wallet" Value="BLC"></asp:ListItem>
                                    </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="form-group col-lg-12">
                            <label class="control-label col-lg-3" for="firstname">Amount *</label>
                            <div class="col-lg-6">
                                <asp:TextBox runat="server" id="txtPHNumber" class=" form-control" />
                            </div>
                        </div>
                        <div class="form-group col-lg-12">
                            <div style="text-align: center;" class="col-lg-12">
                                <asp:Button runat="server" ID="btnCreateGH" class="btn btn-info" OnClick="btnCreateGH_Click" Text="Create GH" />
                            </div>
                        </div>
                    </form>

                </div>
            </div>
        </section>
        <section class="panel">
            <asp:DataList runat="server" ID="dtlGH"  class="table table-hover p-table">
                <HeaderTemplate>
                    <table class="table table-hover p-table">
                        <thead>
                            <tr>
                                <th>GH id</th>
                                <th>GH Time</th>
                                <th>Amount</th>
                                <th>Status</th>
                                <th>GH To</th>
                                <th>Transaction</th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblGHID"><%#Eval("ID") %></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblGHTime"><%# Eval("Date_Receive") %></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblGHAmount"><%# Eval("Amount") %></asp:Label>
                                BTC</td>
                            <td>
                                <span class="label label-success"><%# getGHStatus(Eval("status")) %></span>
                            </td>
                            <td>
                                <span class="label label-success"><%# GHTo(Eval("wReceive")) %></span>
                            </td>
                            <td>
                                <a href="#">
                                    <asp:LinkButton runat="server" ID="btnTransaction" type="submit" class="btn btn-success" Visible='<%# getTransactionVisible(Eval("wReceive")) %>' Text="Transaction" /></a>
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