﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;

namespace BIT.WebUI.Admin
{
    public partial class Memberprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //if (!Singleton<BITCurrentSession>.Inst.isLoginUser)
                //{
                //    Response.Redirect("~/Admin/Login");
                //}
                //else
                //{
                //    LoadUserInfor();

                //    txtUserName.Attributes.Add("readonly", "readonly");
                //    txtEmail.Attributes.Add("readonly", "readonly");
                //    txtSysWallet.Attributes.Add("readonly", "readonly");
                //}
            }
        }

        //public void LoadUserInfor()
        //{
        //    //MEMBERS_BC ctlMember = new MEMBERS_BC();

        //    //MEMBERS obj = ctlMember.SelectItem(Singleton<BITCurrentSession>.Inst.SessionMember.ID);

        //    txtUserName.Text = obj.Username;
        //    txtEmail.Text = obj.Email;
        //    txtFullName.Text = obj.Fullname;
        //    txtPhone.Text = obj.Phone;
        //    txtWallet.Text = obj.Wallet;
        //    txtSysWallet.Text = obj.Sys_Wallet;
        //}

        //public MEMBERS GetDataOnForm()
        //{
        //    MEMBERS obj = new MEMBERS();

        //    obj.CodeId = Singleton<BITCurrentSession>.Inst.SessionMember.CodeId;
        //    obj.Fullname = txtFullName.Text.Trim();
        //    obj.Phone = txtPhone.Text.Trim();
        //    obj.Wallet = txtWallet.Text.Trim();
        //    obj.Password_PIN = txtPasswordPIN.Text.Trim();
        //    return obj;
        //}

        //public void UpdateProfile()
        //{
        //    MEMBERS_BC ctlMember = new MEMBERS_BC();

        //    MEMBERS obj = GetDataOnForm();

        //    //Tung: Them doan check Password 2
        //    if (obj.Password_PIN == Singleton<BITCurrentSession>.Inst.SessionMember.Password_PIN)
        //    {
        //        ctlMember.UpdateItem(obj);
        //        ShowMessageError(lblMessage, "Update profile member successful", true);
        //    }
        //    else
        //    {
        //        ShowMessageError(lblMessage, "Password PIN is invalid! ", true);
        //    }
            

            
        //}

        //public void ReloadSeasion()
        //{            
        //    var login_info = Singleton<MEMBERS_BC>.Inst.SelectItemByUserName(txtUserName.Text);

        //    if (login_info != null)
        //    {
        //        Singleton<BITCurrentSession>.Inst.SessionMember = login_info;
        //    }
        //}

        //public void ShowMessageError(Label lblMsgErr, string sMsgErr = "", bool bVisible = false)
        //{
        //    lblMsgErr.Text = sMsgErr;
        //    lblMsgErr.Visible = bVisible;
        //}

        //protected void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (Page.IsValid)
        //    {
        //        try
        //        {
        //            UpdateProfile();

        //            ReloadSeasion();
        //        }
        //        catch (Exception ex)
        //        {
        //            ShowMessageError(lblMessage, ex.ToString(), true);
        //        }
        //    }
        //}
    }
}