<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="Commission.aspx.cs" Inherits="BIT.WebUI.Admin.Commission" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="wrapper">
        <section class="panel">
            <header class="panel-heading">
                <h3>Commission</h3>
            </header>
            <table class="table table-hover p-table">
                <thead>
                    <tr>
                        <th>Receive</th>
                        <th>Amount</th>
                        <th>Title</th>
                        <th>Created</th>

                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </section>
        <div class="pagination"></div>
    </section>
</asp:Content>
