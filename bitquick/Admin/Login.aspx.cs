using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BIT.Objects;
//using BIT.Controller;
//using BIT.Common;
using Newtonsoft.Json;

namespace BIT.WebUI.Admin
{
    public class ReCaptchaClass
    {
        public static string Validate(string EncodedResponse)
        {
            var client = new System.Net.WebClient();

            string PrivateKey = "6LcH-v8SerfgAPlLLffghrITSL9xM7XLrz8aeory";

            var GoogleReply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", PrivateKey, EncodedResponse));

            var captchaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ReCaptchaClass>(GoogleReply);

            return captchaResponse.Success;
        }

        [JsonProperty("success")]
        public string Success
        {
            get { return m_Success; }
            set { m_Success = value; }
        }

        private string m_Success;
        [JsonProperty("error-codes")]
        public List<string> ErrorCodes
        {
            get { return m_ErrorCodes; }
            set { m_ErrorCodes = value; }
        }


        private List<string> m_ErrorCodes;
    }

    //public partial class Login : System.Web.UI.Page
    //{
    //    protected void btnLogin_Click(object sender, EventArgs e)
    //    {
    //        if (Page.IsValid)
    //        {
    //            string EncodedResponse = Request.Form["g-Recaptcha-Response"];
                
    //            bool IsCaptchaValid = (ReCaptchaClass.Validate(EncodedResponse) == "True" ? true : false);

    //            if (IsCaptchaValid)
    //            {
    //                //Valid Request
    //            }

    //            var login_info = Singleton<MEMBERS_BC>.Inst.SelectItemByUserPass(txtUserName.Text, txtPassword.Text);

    //            if (login_info != null)
    //            {
    //                Singleton<BITCurrentSession>.Inst.SessionMember = login_info;
    //                lblMessage.Visible = false;
    //                Response.Redirect("~/Admin/Dashboard.aspx");
    //            }
    //            else
    //            {
    //                lblMessage.Text = "*Username or password incorrect";
    //                lblMessage.Visible = true;
    //            }
    //        }
    //    }
    //}
}