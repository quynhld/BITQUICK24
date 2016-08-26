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
    public partial class PH : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
            
        //        if (!Singleton<BITCurrentSession>.Inst.isLoginUser)
        //        {
        //            Response.Redirect("~/Admin/Login.aspx");
        //        }
        //        else
        //        {
        //            if (!this.IsPostBack)
        //            {
        //            MEMBERS_BC ctlMember = new MEMBERS_BC();
        //            MEMBERS obj = ctlMember.SelectItem(Singleton<BITCurrentSession>.Inst.SessionMember.ID);
        //            getPinWallet();
        //            getSysWalletBalance();
        //            bindDDLBTCPin();
        //            bindDataList(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //            lblRemainAmount.Text = getRemainPHAmount().ToString();
        //        }
        //    }
        //}

        //private void bindDataList(string codeID)
        //{
        //    //load bang send
        //    List<SEND> lstSend = Singleton<SEND_BC>.Inst.SelectAllItems(codeID);
        //    grdListPH.DataSource = lstSend;
        //    grdListPH.DataBind();

        //}

        //public string getStatus(string status)
        //{
        //    string stt = string.Empty;
        //    switch (status)
        //    {
        //        case "1":
        //            stt = " Waiting ";
        //            break;
        //        case "0":
        //            stt = "Completed";
        //            break;
        //        case "2":
        //            stt = "Canceled";
        //            break;
        //        case "3":
        //            stt = "Canceled";
        //            break;
        //        case "4":
        //            stt = "Canceled";
        //            break;
        //    }
        //    return stt;
        //}

        //private List<SPH> getlistSPH()
        //{
        //    List<SPH> lstPH = Singleton<SPH_BC>.Inst.SelectAllItems();
        //    return lstPH;
        //}

        //private void bindDDLBTCPin()
        //{
        //    ddlBTCPin.DataSource = getlistSPH();
        //    ddlBTCPin.DataValueField = "PH";
        //    ddlBTCPin.DataTextField = "PIN";
        //    ddlBTCPin.DataBind();
        //}

        //private decimal getWalletBalance(string walletAdd)
        //{
        //    //goi blockchain api de lay balance wallet
        //    decimal wBalance = 0;
        //    //WebRequest request = WebRequest.Create("http://blockchain.info/q/addressbalance/12sENwECeRSmTeDwyLNqwh47JistZqFmW8"+walletAdd);
        //    WebRequest request = WebRequest.Create("http://blockchain.info//q//addressbalance//15nwBBSsAxZrqJckfyKzehA9uv3hemCq8h");
        //    WebResponse response = request.GetResponse();
        //    Stream dataStream = response.GetResponseStream();
        //    StreamReader reader = new StreamReader(dataStream);
        //    wBalance = Convert.ToDecimal(reader.ReadToEnd()) / 100000000;
        //    return wBalance;
        //}
        //private void getSysWalletBalance()
        //{
        //    //B_Wallet - wallet
        //    WALLET wl = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //    lblAmount.Text = wl.B_Wallet.ToString();
        //}
        //private void getPinWallet()
        //{
        //    try
        //    {
        //        //lay ra so pin con trong db trong bang wallet, cot pinWallet
        //        WALLET wl = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //        lblPinAmout.Text = wl.PIN_Wallet.ToString();
        //    }
        //    catch
        //    {

        //    }
        //}

        //protected void btnCreatePH_Click(object sender, EventArgs e)
        //{
        //    if (IsPostBack)
        //    {

        //        #region check dieu kien

        //        //1. create pd 
        //        int selectedPHAmt = Convert.ToInt32(ddlBTCPin.SelectedValue);
        //        //check level min ph --> VIEC DEO PHAI SELECT TRONG DB
        //        //MEMBERS mem1 = Singleton<MEMBERS_BC>.Inst.SelectItem(Singleton<BITCurrentSession>.Inst.SessionMember.Level);
        //        switch (Singleton<BITCurrentSession>.Inst.SessionMember.Level)
        //        {
        //            case "V1":
        //                if (selectedPHAmt < 2)
        //                {
        //                    string script = string.Format("alert('You can not PH less than 2 BTC');");
        //                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //                    return;
        //                }
        //                break;
        //            case "V2":
        //                if (selectedPHAmt < 4)
        //                {
        //                    string script = string.Format("alert('You can not PH less than 4 BTC');");
        //                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //                    return;

        //                }
        //                break;
        //            case "V3":
        //                if (selectedPHAmt < 8)
        //                {
        //                    string script = string.Format("alert('You can not PH less than 8 BTC');");
        //                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //                    return;

        //                }
        //                break;
        //            case "V4":
        //                if (selectedPHAmt < 16)
        //                {
        //                    string script = string.Format("alert('You can not PH less than 8 BTC ');");
        //                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //                    return;

        //                }
        //                break;
        //            case "V5":
        //                if (selectedPHAmt < 20)
        //                {
        //                    string script = string.Format("alert('You can not PH less than 20 BTC Per month);");
        //                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //                    return;

        //                }
        //                break;

        //        }

        //        //.Check pass2 account : transaction pass // getfrom session
        //        string temptTransPass = Singleton<BITCurrentSession>.Inst.SessionMember.Password_PIN;
        //        if (txtTransPass.Text != temptTransPass)
        //        {
        //            string script = "alert('Wrong transaction password');";
        //            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //            return;
        //        }

        //        //check amount BTC remain PH in month  - 1 thang max duoc 20 bit
        //        if (selectedPHAmt > getRemainPHAmount())
        //        {

        //            string script = string.Format("alert('You can not PH more than 20 BTC Per month, remain amount of BTC you can PH is {0}');", getRemainPHAmount().ToString());
        //            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //            return;
        //        }
        //        //. check BTC amount get BTC Amount from session
        //        int curBTCAmt = (int)Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId).B_Wallet;//lay tu session current btc amount
        //        if (selectedPHAmt > curBTCAmt)
        //        {
        //            string script = "alert('Not enough BTC to create PH');";
        //            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //            return;
        //        }
        //        //c check Pin 
        //        SPH nSPH = Singleton<SPH_BC>.Inst.selectItem(selectedPHAmt);//lay pin tuong ung voi BTC PH
        //        int curPin = (int)Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId).PIN_Wallet;//get pin amt from session current pin
        //        if (Convert.ToInt32(nSPH.PIN) > curPin)
        //        {
        //            string script = "alert('Not enough PIN to create PH');";
        //            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        //            return;
        //        }


        //        #endregion
        //        //2. insert bảng send

        //        SEND objSend = new SEND();
        //        objSend.Date_Receive = DateTime.Now;
        //        objSend.Date_Send = DateTime.Now;
        //        objSend.Status = 1;
        //        objSend.TransactionId = string.Empty;
        //        objSend.Amount = Convert.ToInt32(ddlBTCPin.SelectedValue);
        //        objSend.CodeId = Singleton<BITCurrentSession>.Inst.SessionMember.CodeId;
        //        Singleton<SEND_BC>.Inst.InsertItem(objSend);
        //        //tach phan tru pin ra

        //        //insert PH done tinh hoa hong cho nguoi bao tro - codeid_sponsor
        //        COMMISSION cmss = new COMMISSION();
        //        cmss.CodeId = Singleton<BITCurrentSession>.Inst.SessionMember.CodeId_Sponsor;
        //        cmss.CodeIDFrom = Singleton<BITCurrentSession>.Inst.SessionMember.CodeId;
        //        cmss.CreateDate = DateTime.Now;
        //        cmss.Amount = objSend.Amount / 10;
        //        cmss.type = "10% Direct";
        //        cmss.SendID = Singleton<SEND_BC>.Inst.SelectItemByCodeId(objSend).ID;

        //        Singleton<COMMISSION_BC>.Inst.InsertItem(cmss);
        //        //update Bwallet cho sponsor
        //        //get sponsorwallet
        //        //WALLET sponsorWallet = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId_Sponsor);
        //        //sponsorWallet.B_Wallet = sponsorWallet.B_Wallet + cmss.Amount;
        //        ////update sponsorwallet
        //        //Singleton<WALLET_BC>.Inst.UpdateItem(sponsorWallet);

        //        string strPHComplete = string.Format("alert('PH {0} BTC Successful !');", objSend.Amount.ToString());
        //        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", strPHComplete, true);

        //        //3. update trạng thái member - update status = 1
        //        MEMBERS mem = Singleton<MEMBERS_BC>.Inst.SelectItem(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //        mem.Status = 1;
        //        Singleton<MEMBERS_BC>.Inst.UpdateLevelAndStatus(mem);
        //        //update level upline
        //        //if upline has amount of downline ph success - update level upline
        //        //get number of downline ph success

        //        int memsDownline = Singleton<MEMBERS_BC>.Inst.getNumberOfDownlineActive(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId_Sponsor);
        //        //create upline members object
        //        MEMBERS upline = Singleton<MEMBERS_BC>.Inst.SelectItem(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId_Sponsor);

        //        if (memsDownline >= 5)
        //            upline.Level = Constants.MEMBERS_LEVEL_V1;
        //        if (memsDownline >= 15)
        //            upline.Level = Constants.MEMBERS_LEVEL_V2;
        //        if (memsDownline >= 30)
        //            upline.Level = Constants.MEMBERS_LEVEL_V3;
        //        if (memsDownline >= 60)
        //            upline.Level = Constants.MEMBERS_LEVEL_V4;
        //        if (memsDownline >= 90)
        //            upline.Level = Constants.MEMBERS_LEVEL_V5;
        //        //update level upline
        //        Singleton<MEMBERS_BC>.Inst.UpdateLevelAndStatus(upline);

        //        bindDataList(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //        getPinWallet();
        //        getSysWalletBalance();
        //        bindDDLBTCPin();
        //        lblRemainAmount.Text = getRemainPHAmount().ToString();
        //    }
        //}

        //public string getfund(object amount, int datecount)
        //{
        //    int sAmount = Convert.ToInt32(amount);
        //    string sfund = string.Empty;
        //    sfund = (sAmount + (sAmount * datecount * 0.012)).ToString();
        //    return sfund;
        //}

        //public int dateCount(object dateSend)
        //{
        //    int dateC = DateTime.Now.DayOfYear - Convert.ToDateTime(dateSend).DayOfYear;
        //    if (dateC > 30)
        //        return 30;
        //    else
        //        return DateTime.Now.DayOfYear - Convert.ToDateTime(dateSend).DayOfYear;
        //}

        //public bool enableGH(object dateSend,object status)
        //{
        //    if( (dateCount(dateSend) == 30 ) && (int)(status)==1)
        //        return true;
        //    else
        //        return false;

        //}

        //public int getRemainPHAmount()
        //{
        //    //count ph remain in a month
        //    int phRemain = 20;
        //    return phRemain - Singleton<SEND_BC>.Inst.getPHRemain(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId, DateTime.Now);
        //}

        //public void tempGH(string sendID)
        //{
        //    //update status of PH to 0 - complete
        //    SEND objSendComplete = Singleton<SEND_BC>.Inst.SelectItem(Convert.ToInt32( sendID));
        //   //update
        //    objSendComplete.Status = 0;
        //    Singleton<SEND_BC>.Inst.UpdateItem(objSendComplete);
        //    //update Rwallet 
        //    WALLET userWallet = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //    userWallet.R_Wallet = objSendComplete.Amount + objSendComplete.Amount * 30 * Convert.ToDecimal(0.012);
        //    //update userwallet - rwallet
        //    Singleton<WALLET_BC>.Inst.UpdateItem(userWallet);
        //}

        //protected void btnReceive_Click(object sender, EventArgs e)
        //{
        //    LinkButton btn = (LinkButton)(sender);
        //    string yourValue = btn.CommandArgument;
        //    tempGH(yourValue);

        //    bindDataList(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //    getPinWallet();
        //    getSysWalletBalance();
        //    bindDDLBTCPin();
        //    lblRemainAmount.Text = getRemainPHAmount().ToString();
        //}
        // protected void imgReloadBTC_Click(object sender, EventArgs e) 
        //{
        //    Response.Redirect("ReCharge.aspx");
        // }
   
    }
}