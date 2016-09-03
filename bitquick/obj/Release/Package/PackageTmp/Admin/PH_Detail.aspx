<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="PH_Detail.aspx.cs" Inherits="VIRGINBTC.Admin.PH_Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:DataList runat="server" ID="dtlDetailPH">
            <HeaderTemplate>
                <table class="table table-hover" style="overflow: auto;">
            <thead>
                <tr>
                    <th>Amount</th>
                    <th>ID GH</th>
                    <th>Wallet</th>
                    <th>Status</th>
                    <th>Dration</th>
                    <th>Linktransaction</th>
                </tr>
            </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                            <tbody>
                <tr>
                    <td><asp:Label runat="server" ID="lblAmount" Text="John"></asp:Label> </td>
                    <td><asp:Label runat="server" ID="lblIdGH" Text="Doe"></asp:Label> </td>
                    <td><asp:Label runat="server" ID="lblwallet" Text=" john@example.com"></asp:Label></td>
                    <td>
                        <asp:Button runat="server" ID="btnStatus" Text="Expired" CssClass="btn btn-warning" />
                        </td>
                    <td>
                        <asp:Label runat="server" ID="lblDuration">jcom</asp:Label> </td>
                    <td><asp:LinkButton runat="server" ID="btnLinkTrans">Doe</asp:LinkButton>

                        </td>
                </tr>
                <tr>
                    <td>Mary</td>
                    <td>Moe</td>
                    <td>mary@example.com</td>
                    <td>
                        <button type="button" class="btn btn-primary">Pending</button></td>
                    <td>e.com</td>
                    <td>e.com</td>
                </tr>
                <tr>
                    <td>July</td>
                    <td>Dooley</td>
                    <td>july@example.com</td>
                    <td>
                        <button type="button" class="btn btn-success">Finish</button></td>
                   <td>e.com</td>
                    <td>j.com</td>
                </tr>  
            </ItemTemplate>
            <FooterTemplate>
                            </tbody>
        </table>
            </FooterTemplate>
        </asp:DataList>
        <table class="table table-hover" style="overflow: auto;">
            <thead>
                <tr>
                    <th>Amount</th>
                    <th>ID GH</th>
                    <th>Wallet</th>
                    <th>Status</th>
                    <th>Dration</th>
                    <th>Linktransaction</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>John</td>
                    <td>Doe</td>
                    <td>john@example.com</td>
                    <td>
                        <button type="button" class="btn btn-warning">Expired</button></td>
                    <td>jcom</td>
                    <td>Doe</td>
                </tr>
                <tr>
                    <td>Mary</td>
                    <td>Moe</td>
                    <td>mary@example.com</td>
                    <td>
                        <button type="button" class="btn btn-primary">Pending</button></td>
                    <td>e.com</td>
                    <td>e.com</td>
                </tr>
                <tr>
                    <td>July</td>
                    <td>Dooley</td>
                    <td>july@example.com</td>
                    <td>
                        <button type="button" class="btn btn-success">Finish</button></td>
                   <td>e.com</td>
                    <td>j.com</td>
                </tr>
                
            </tbody>
        </table>
    </div>
</asp:Content>
