using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BIT.Objects;
//using BIT.Common;
//using BIT.Controller;

namespace BIT.WebUI.Admin
{
    public partial class CommisionMonthly : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    //if (!IsPostBack)
        //    //{
        //    //    if (!Singleton<BITCurrentSession>.Inst.isLoginUser)
        //    //    {
        //    //        Response.Redirect("~/Admin/Login");
        //    //    }
        //    //    else
        //    //    {
        //    //        BindMonthlyCommision();
        //    //        BindCommision();
        //    //    }
        //    //}
        //}

        //protected void btnCalcCommision_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CalcCommision(DateTime.Today.Month, DateTime.Today.Year);

        //        BindCommision();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void CalcCommision(int month, int year)
        //{
        //    var ctlCom = new COMMISION_MONTHLY_BC();
        //    var ctlMember = new MEMBERS_BC();
        //    List<COMMISION_MONTHLY> lstCom = new List<COMMISION_MONTHLY>();
        //    List<MEMBERS> lstMember;
        //    bool check;

        //    check = ctlCom.IsExists(month, year);

        //    if (!check)
        //    {
        //        // get all member
        //        lstMember = ctlMember.getAllMemberForCalculateCommisionMonthly();

        //        // calc commision foreach member
        //        foreach (var o in lstMember)
        //        {
        //            var oCom = ctlCom.Calc(o.CodeId, month, year);

        //            oCom.CodeId = o.CodeId;
        //            oCom.Level = o.Level;
        //            oCom.Month = month;
        //            oCom.Year = year;

        //            lstCom.Add(oCom);
        //        }

        //        // inset commision
        //        foreach (var com in lstCom)
        //        {
        //            ctlCom.InsertItem(com);
        //        }

        //        lblResult.ForeColor = Color.Blue;
        //        lblResult.Text = String.Format("Calculate commision for time {0} - {1} success", month, year);
        //    }
        //    else
        //    {
        //        lblResult.ForeColor = Color.Blue;
        //        lblResult.Text = String.Format("Commision for time {0} - {1} is calculated", month, year);
        //    }

        //}

        //public void SetDefaultValueDropDownList(DropDownList ddl, string text = "", string value = "")
        //{
        //    ddl.Items.Insert(0, new ListItem { Text = text, Value = value });
        //}

        //public void BindCommision()
        //{
        //    var ctlCom = new COMMISION_MONTHLY_BC();
        //    var month = ddlMonthly.SelectedValue;

        //    var lstCom = ctlCom.SelectItemsByMonthly(month);

        //    var totalCommision = lstCom.Sum(m => m.HOA_HONG_CO_BAN);
        //    var totalDS_TRAI = lstCom.Sum(m => m.DOANH_SO_TRAI);
        //    var totalDS_PHAI = lstCom.Sum(m => m.DOANH_SO_PHAI);
        //    lblTotalCommision.Text = string.Format("Total Commision basic: {0}", totalCommision.ToString());
        //    lblTotalDOANH_SO_TRAI.Text = string.Format("Total Income left branch (BTC): {0}", totalDS_TRAI.ToString());
        //    lblTotalDOANH_SO_PHAI.Text = string.Format("Total Income right branch (BTC): {0}", totalDS_PHAI.ToString());

        //    grdCommision.DataSource = lstCom;
        //    grdCommision.DataBind();
        //}

        //public void BindMonthlyCommision()
        //{
        //    var ctlCom = new COMMISION_MONTHLY_BC();
        //    var lstMontly = ctlCom.GetAllMonthCommision();

        //    ddlMonthly.DataValueField = "DS_Value";
        //    ddlMonthly.DataTextField = "DS_Text";
        //    ddlMonthly.DataSource = lstMontly;
        //    ddlMonthly.DataBind();          
        //}

        //protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    var month = ddlMonthly.SelectedValue;

        //    grdCommision.PageIndex = e.NewPageIndex;
        //    BindCommision();
        //}

        //protected void ddlMonthly_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    BindCommision();
        //}
    }
}