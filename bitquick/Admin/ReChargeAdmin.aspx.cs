using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Net;
using System.Text;

//using BIT.Objects;
//using BIT.Controller;
//using BIT.Common;

namespace BIT.WebUI.Admin
{
    public partial class ReChargeAdmin : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!Singleton<BITCurrentSession>.Inst.isLoginUser)
        //    {
        //        Response.Redirect("~/Admin/Login.aspx");
        //    }
        //    else
        //    {
        //        if (!this.IsPostBack)
        //        {
        //            //load recharge history
        //            //getCurrentPHAvailable();
        //            //loadGH();
        //            bindDLRecharge();
        //        }
        //    }
        //}

        //public string abc()
        //{
        //    string sysWalletAddress = string.Empty;

        //    return sysWalletAddress = Singleton<BITCurrentSession>.Inst.SessionMember.Sys_Wallet;
        //}

        //protected void btnSave_Click(object sender, EventArgs e)
        //{

            
        //    //insert wallet

            
        //    //string strPHComplete = string.Format("alert('Recharge {0} BTC Successful !');", obj.Amount);
        //    //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", strPHComplete, true);
        //    //bindDLRecharge();
        //}

        //private void bindDLRecharge()
        //{
        //    List<RECHARGE> lstRecharges = Singleton<RECHARGE_BC>.Inst.SelectAllItems(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //    dtlRecharge.DataSource = lstRecharges;
        //    dtlRecharge.DataBind();
        //}

        //public string getStatus(object status)
        //{
        //    string stts = string.Empty;
        //    switch(status.ToString())
        //    {
        //        case "0":
        //            stts = "Pending";
        //            break;
        //        case "1":
        //            stts = "Completed";
        //            break;    
        //        case "2":
        //            stts = "Cancelled";
        //            break;
        //    }
        //    return stts;
        //}
        //public bool getConfirmVisible(object status)
        //{
        //    if (status.ToString()=="1")
        //        return false;
        //    else
        //        return true;
        //}

        //protected void lbkBtnConfirm_Click(object sender, EventArgs e)
        //{
        //    LinkButton btn = (LinkButton)(sender);
        //    string yourValue = btn.CommandArgument;
        //    RECHARGE obj = Singleton<RECHARGE_BC>.Inst.SelectItem(Convert.ToInt32(yourValue));
        //    obj.Status = 1;

        //    MEMBERS mem = Singleton<MEMBERS_BC>.Inst.SelectItem(obj.CodeId);

        //    Singleton<RECHARGE_BC>.Inst.UpdateItem(obj);
        //    //update bwallet user
        //    WALLET userWallet = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(obj.CodeId);
        //    userWallet.B_Wallet = userWallet.B_Wallet + obj.Amount; 
        //    //update 
        //    Singleton<WALLET_BC>.Inst.UpdateItem(userWallet);

        //    string strPHComplete = string.Format("alert('Confirmed {0} BTC for user {1} !');", obj.Amount,mem.Username);
        //    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", strPHComplete, true);
        //    bindDLRecharge();
        //}
    }
}