<%@ Page Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="CommisionMonthly.aspx.cs" Inherits="BIT.WebUI.Admin.CommisionMonthly" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .rounded_corners {
            /*border: 1px solid #A1DCF2;
            -webkit-border-radius: 8px;
            -moz-border-radius: 8px;
            border-radius: 8px;
            overflow: hidden;*/
        }

            .rounded_corners td, .rounded_corners th {
                border: 1px solid #A1DCF2;
                font-family: Arial;
                font-size: 10pt;
                /*text-align: center;*/
                padding: 5px;
            }

            .rounded_corners table table td {
                border-style: none;
            }

    </style>


    <!-- This is your Javascript function that will display your image -->
    <script type='text/javascript'>
        function DisplayLoadingImage() {
            document.getElementById("HiddenLoadingImage").style.display = "block";
        }
    </script>


    <section class="wrapper">
        <br />
        <section class="panel">
            <header class="panel-heading">
                <h3>Calculate commision monthly</h3>
            </header>
            <div class="panel-body">
                  <div class="container">
        <div class="row">
            <div class="text-danger"><b>Execute this command at the end of the month</b></div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-5">
                <!-- Your Button -->
                <asp:Button ID="btnCalcCommision" runat="server" OnClientClick="DisplayLoadingImage();" Text="Calculate commision monthly" CssClass="btn btn-info" OnClick="btnCalcCommision_Click" />
            </div>

            <div class="col-md-2">
                <!-- Your initially hidden loading image -->
                <img id='HiddenLoadingImage' src='/images/loading.gif' style='display: none;' />
            </div>
        </div>
        <br />
        <div class="row">
            <asp:Label ID="lblResult" runat="server" ForeColor="Blue"></asp:Label>
        </div>

    </div>

    <div class="row">
        <div class="col-md-2">
            <asp:DropDownList ID="ddlMonthly" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlMonthly_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="rounded_corners">
                <asp:GridView ID="grdCommision" runat="server" HeaderStyle-BackColor="#3AC0F2"
                    HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White"
                    RowStyle-ForeColor="#3A3A3A" AutoGenerateColumns="false" AllowPaging="true" PageSize="30"
                    OnPageIndexChanging="OnPageIndexChanging">
                    <Columns>
                        <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="Username" HeaderText="Username">
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FullName" HeaderText="FullName">
                            <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>

                        <asp:BoundField DataField="Month" HeaderText="Month">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Year" HeaderText="Year">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="SO_THANH_VIEN_MOI_TRAI" HeaderText="New member left branch">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="SO_THANH_VIEN_MOI_PHAI" HeaderText="New member right branch">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DOANH_SO_TRAI" HeaderText="Income left branch (BTC)" DataFormatString="{0:N8}">
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DOANH_SO_PHAI" HeaderText="Income right branch (BTC)" DataFormatString="{0:N8}">
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="HOA_HONG_CO_BAN" HeaderText="Commision basic (BTC)" DataFormatString="{0:N8}">
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>

                        <%--<asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton ID="cmdView" runat="server" CausesValidation="false" CommandName="cmdView"
                                    CommandArgument='<%# Eval("ID") %>' ImageUrl="/Images/view_detail.png" ToolTip="View details"
                                    OnClientClick='<%# String.Format("return view_Data({0});", Eval("ID"))%>' />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <br />
        <div class="col-md-12">
            <div class="col-md-4"><asp:Label ID="lblTotalDOANH_SO_TRAI" runat="server" ForeColor="Blue"></asp:Label></div>
            <div class="col-md-4"><asp:Label ID="lblTotalDOANH_SO_PHAI" runat="server" ForeColor="Blue"></asp:Label></div>
            <div class="col-md-4"><asp:Label ID="lblTotalCommision" runat="server" ForeColor="Blue"></asp:Label></div>
            
        </div>
    </div>
			</div>
        </section>
    </section>


  

</asp:Content>
