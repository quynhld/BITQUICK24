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
    public partial class GH : System.Web.UI.Page
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
        //            getCurrentPH();
        //            //getCurrentPHAvailable();
        //            loadGH();
        //        }
        //    }
        //}

        //private void loadGH()
        //{
        //    List<RECEIVE> lst = Singleton<RECEIVE_BC>.Inst.SelectAllItems(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //    dtlGH.DataSource = lst;
        //    dtlGH.DataBind();
        //}

        //private void getCurrentPH()
        //{
        //   WALLET currentWallet = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //   lblAmount.Text= currentWallet.R_Wallet.ToString();
        //}
        ////private void getCurrentPHAvailable()
        ////{
        ////    decimal phRemain = Singleton<RECEIVE_BC>.Inst.getGHRemain(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId, DateTime.Now);
        ////    lblAmountPHRemain.Text = phRemain.ToString();
        ////}

        //protected void btnCreateGH_Click(object sender, EventArgs e)
        //{
        //    //check dieu kien
        //    WALLET userWallet = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //    decimal amountPH = Convert.ToDecimal(txtPHNumber.Text);
        //    if(amountPH > userWallet.R_Wallet)
        //    {
        //        string strPHComplete = string.Format("alert('Not enough BTC to PH, you only have {0} BTC !');", userWallet.R_Wallet);
        //        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", strPHComplete, true);
        //        return;
        //    }
            
        //    //------------update Bwallet
        //    //WALLET userWallet = Singleton<WALLET_BC>.Inst.SelectItemByCodeId(Singleton<BITCurrentSession>.Inst.SessionMember.CodeId);
        //    RECEIVE userReceive = new RECEIVE();
        //    userReceive.Amount = amountPH;
        //    userReceive.CodeId = Singleton<BITCurrentSession>.Inst.SessionMember.CodeId;
        //    userReceive.Date_Receive = DateTime.Now;

        //    switch(radSelectWallet.SelectedValue)
        //    {
        //        case"B":
        //            //------------update Bwallet
        //            //add to Bwallet
        //            userWallet.B_Wallet = userWallet.B_Wallet + amountPH;
        //            //minus rwallet
        //            userWallet.R_Wallet = userWallet.R_Wallet - amountPH;
        //            //update
        //            //-------------------------------insert Receive
        //            //create obj
        //            userReceive.Status = 1;//1:success 0:waitting
        //            userReceive.Send_ID = 0;
        //            userReceive.wReceive = "Bwallet";
        //            //Singleton<RECEIVE_BC>.Inst.InsertItem(userReceive);
        //            break;
        //        case"BLC":
        //            //------------update Bwallet
        //            //minus rwallet
        //            userWallet.R_Wallet = userWallet.R_Wallet - amountPH;
        //            //update
        //            //Singleton<WALLET_BC>.Inst.UpdateItem(userWallet);
        //            //insert Receive
        //            //create obj
        //            userReceive.Status = 0;//1:success 0:waitting
        //            userReceive.Send_ID = 0;
        //            userReceive.wReceive = Singleton<BITCurrentSession>.Inst.SessionMember.Wallet;
                    
        //            break;
        //    }
        //    Singleton<WALLET_BC>.Inst.UpdateItem(userWallet);
        //    Singleton<RECEIVE_BC>.Inst.InsertItem(userReceive);

        //    //alert ph success
        //    string phSuccess = string.Format("alert('GH Successful !'");
        //    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", phSuccess, true);
        //    //reload amount
        //    getCurrentPH();
        //}

        //public string GHTo(object wReceive)
        //{
        //    string ghToWallet = string.Empty;
        //    if (wReceive.ToString() == "Bwallet")
        //    {
        //        ghToWallet = "B Wallet";
        //    }
        //    else
        //        ghToWallet = "Blockchain Wallet";
        //    return ghToWallet;
        //}

        //public string getGHStatus(object status)
        //{
        //    string ghStatus = string.Empty;
        //    if (status.ToString() == "1")
        //        ghStatus = "Success";
        //    else
        //        ghStatus = "Pending";
        //    return ghStatus;
        //}
        
        //public bool getTransactionVisible(object wReceive)
        //{
        //    bool b = false;
        //    if (wReceive.ToString() == "Bwallet")
        //        b = false;
        //    else
        //        b = true;
        //    return b;
        //}

    }
}