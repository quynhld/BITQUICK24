<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master"
     AutoEventWireup="true" CodeBehind="ReCharge.aspx.cs" Inherits="BIT.WebUI.Admin.ReCharge"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="wrapper">
        <br />
        <section class="panel">
                        <header class="panel-heading">
                <h3>ReCharge</h3>
            </header>
            <div class="form">
                    <form enctype="multipart/form-data" class="cmxform form-horizontal tasi-form">
                        <div class="form-group col-lg-12">
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-5" for="firstname">Scan QR code or insert wallet address below</label>
                                <div class="col-lg-5">
                                    <span class="badge">
                                        <asp:Image ID="imgQRCode" Width="200" Height="200" runat="server"  />
                                    </span>
                                    <asp:Label runat="server" ID="lblSyswallet" ></asp:Label>
                                </div>
                            </div>
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-5" for="firstname">Amount </label>
                                         <div class="col-lg-5">
                                    <asp:TextBox runat="server" ID="txtAmount" TextMode="Number"></asp:TextBox>
                                </div>
                            </div> 
                            <div class="col-md-6 col-md-offset-3">
                                <label class="control-label col-lg-5" for="firstname">Transaction </label>
                                         <div class="col-lg-5">
                                    <asp:TextBox runat="server" ID="txtTrans"></asp:TextBox>
                                </div>
                            </div>                           
                        </div>
                        <div class="form-group col-lg-12">
                            <div style="text-align: center;" class="col-lg-12">
                                <asp:Button runat="server" ID="btnSave" class="btn btn-info" Text="Save" OnClick="btnSave_Click" />
                            </div>
                        </div>
                    </form>
                </div>
            <label></label>
        </section>
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
                            <asp:LinkButton ID="lbkBtnConfirm" runat="server" Visible='<%# getConfirmVisible() %>' Text="Confirm" CommandArgument='<%# Eval("ID") %>'></asp:LinkButton>
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
