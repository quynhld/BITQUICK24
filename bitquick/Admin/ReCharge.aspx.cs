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
    public partial class ReCharge : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!Singleton<BITCurrentSession>.Inst.isLoginUser)
        //    {
        //        Response.Redirect("~/Admin/Login.aspx");
        //    }
        //    else
        //    {
        //        if (Singleton<BITCurrentSession>.Inst.SessionMember.ID != 1)
        //        {
        //            if (!this.IsPostBack)
        //            {
        //                //load recharge history
        //                //getCurrentPHAvailable();
        //                //loadGH();
        //                string strAAA = abc();
        //                imgQRCode.ImageUrl = string.Format("http://chart.googleapis.com/chart?chs=200x200&cht=qr&chl={0}", abc());

        //                lblSyswallet.Text = abc();
        //                bindDLRecharge();
        //            }
        //        }
        //        else
        //        {
        //            Response.Redirect("~/Admin/ReChargeAdmin.aspx");
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
        //    if(txtAmount.Text == string.Empty )
        //    {
        //        string notInsAmount = string.Format("alert('Please input amount BTC Recharge !');");
        //        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", notInsAmount, true);
        //        return;
        //    }
        //    if(txtTrans.Text == string.Empty)
        //    {
        //        string notInsertTransaction = string.Format("alert('Please input transaction string !');");
        //        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", notInsertTransaction, true);
        //        return;
        //    }

        //    RECHARGE obj = new RECHARGE();
        //    obj.Amount = Convert.ToDecimal(txtAmount.Text);
        //    obj.CodeId = Singleton<BITCurrentSession>.Inst.SessionMember.CodeId;
        //    obj.CreateDate = DateTime.Now;
        //    obj.ReceiveWallet = Singleton<BITCurrentSession>.Inst.SessionMember.Sys_Wallet;
        //    obj.SendWallet = Singleton<BITCurrentSession>.Inst.SessionMember.Wallet;
        //    obj.Status = 0;
        //    obj.Transaction = txtTrans.Text;
        //    //insert wallet

        //    Singleton<RECHARGE_BC>.Inst.InsertItem(obj);
        //    string strPHComplete = string.Format("alert('Recharge {0} BTC Successful !');", obj.Amount);
        //    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", strPHComplete, true);
        //    bindDLRecharge();
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
        //public bool getConfirmVisible()
        //{
        //    if (Singleton<BITCurrentSession>.Inst.SessionMember.ID == 1)
        //        return true;
        //    else
        //        return false;
        //}
    }
}