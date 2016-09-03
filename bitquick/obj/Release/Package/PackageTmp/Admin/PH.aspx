<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" 
    AutoEventWireup="true" CodeBehind="PH.aspx.cs" Inherits="BIT.WebUI.Admin.PH" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="wrapper">
        <!---ss PH-->
        <section class="panel">
            <header class="panel-heading">
                <h3>PH - Provide Help</h3>
            </header>
            <div class="panel-body">
                <div class="form">
                    <form enctype="multipart/form-data" class="cmxform form-horizontal tasi-form">
                        <div class="form-group col-lg-12">
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-5" for="firstname">Avaiable BTC Amount </label>
                                <div class="col-lg-5">
                                    <span class="badge">
                                        <asp:Label runat="server" ID="lblAmount"></asp:Label>
                                        BTC
                                    </span>
                                </div>
                                <div>
                                    <asp:ImageButton ID="imgReloadBTC" runat="server" ImageUrl="~/images/bitplusOrange.png" Width="32px" Height="32px" OnClick="imgReloadBTC_Click" />
                                </div>
                            </div>
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-5" for="firstname">Avaiable Pin Amount </label>
                                <div class="col-lg-5">
                                    <span class="badge">
                                        <asp:Label runat="server" ID="lblPinAmout" Text="5"></asp:Label>
                                        PIN
                                    </span>
                                </div>
                            </div>
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-4" for="firstname">Amount *</label>
                                <div class="col-lg-5">
                                    <asp:DropDownList ID="ddlBTCPin" runat="server" class=" form-control" />
                                </div>
                            </div>
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-4" for="firstname">Current avaiable PH Amount:</label>
                                <div class="col-lg-5">
                                    <span class="badge">
                                        <asp:Label runat="server" ID="lblRemainAmount" />BTC
                                    </span>
                                </div>
                            </div>
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-4" for="firstname">Transaction Pass:</label>
                                <div class="col-lg-5">
                                    <asp:TextBox runat="server" ID="txtTransPass" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group col-lg-12">
                            <div style="text-align: center;" class="col-lg-12">
                                <asp:Button runat="server" ID="btnCreatePH" class="btn btn-info" Text="Create PH" OnClick="btnCreatePH_Click" />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </section>
        <!---End Of ss PH-->
        <!--ss Gridview PH-->
        <section class="panel">
            <asp:DataList ID="grdListPH" runat="server" class="table table-hover p-table">
                <HeaderTemplate>
                    <table class="table table-hover p-table">
                            <tr>
                                <th>PD Time</th>
                                <th>Amount</th>
                                <th>Date Count</th>
                                <th>Receive</th>
                                <th>Status</th>
                                <th>GH</th>
                            </tr>
                </HeaderTemplate>
                <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblPHTime" Text=' <%#Eval("Date_Send")%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblAmount" Text=' <%#Eval("Amount")%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblDateCount" Text='<%# dateCount(Eval("Date_send")) %>' />
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblFull" Text='<%# getfund(Eval("Amount"),dateCount(Eval("Date_send"))) %>'></asp:Label>
                            </td>
                            <td>
                                <span class="label label-primary">
                                    <asp:Label runat="server" ID="lblStatus" Text='<%# getStatus(Eval("Status").ToString())%> '></asp:Label>
                                </span>
                            </td>
                            <td>
                                <a href="#">
                                    <asp:LinkButton runat="server" ID="btnReceive" Visible='<%# enableGH(Eval("Date_send"),Eval("Status")) %>'  OnClick="btnReceive_Click" CommandArgument='<%# Eval("ID") %>' type="submit" class="btn btn-success" Text="Receive" />
                                </a>
                            </td>
                        </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:DataList>
            
        </section>
        <!--end of ss Gridview PH-->
        <div class="pagination"></div>
    </section>
</asp:Content>
