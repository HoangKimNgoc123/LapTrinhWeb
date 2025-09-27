// CaesarWeb/api.aspx.cs
using System;
using System.Web;
using CaesarLib;

namespace CaesarWeb
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input = "";
            string shiftStr = "0";

            if (Request.HttpMethod == "POST")
            {
                // Yêu cầu: dùng this.Request.Form cho POST
                input = this.Request.Form["text"];
                shiftStr = this.Request.Form["shift"];
            }
            else if (Request.HttpMethod == "GET")
            {
                // Yêu cầu: dùng Request.QueryString cho GET
                input = Request.QueryString["text"];
                shiftStr = Request.QueryString["shift"];
            }

            int shift = 0;
            if (!int.TryParse(shiftStr, out shift)) shift = 0;

            Response.ContentType = "application/json";

            CaesarCipher cc = new CaesarCipher();
            cc.InputText = input ?? "";
            cc.Shift = shift;
            bool ok = cc.Process();

            if (ok)
            {
                Response.Write(cc.OutputJson);
            }
            else
            {
                Response.Write("{\"error\":\"processing error\"}");
            }

            Response.End();
        }
    }
}
