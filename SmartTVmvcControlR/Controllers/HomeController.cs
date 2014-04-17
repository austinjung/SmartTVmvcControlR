using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartTVmvcControlR.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chat()
        {
            var ip_address = Request.ServerVariables["REMOTE_ADDR"];
            ViewBag.ip_address = ip_address.ToString();
            var ip_address1 = Request.UserHostAddress;
            ViewBag.ip_address1 = ip_address1.ToString();
            var browserName = Request.Browser.Browser; // Would return IE, etc
            var browserType = Request.Browser.Type; // Would return IE7, IE8, etc.
            var browserMajor = Request.Browser.MajorVersion;
            var browserMinor = Request.Browser.MinorVersion;

            var supportsActiveX = Request.Browser.ActiveXControls;
            var inputType = Request.Browser.InputType;
            ViewBag.inputType = inputType.ToString();
            var supportsColours = Request.Browser.IsColor;
            var isMobileDevice = Request.Browser.IsMobileDevice;
            var supportsJavaApplets = Request.Browser.JavaApplets;

            string strUserAgent = Request.UserAgent.ToString().ToLower();
            if (strUserAgent != null)
            {
                ViewBag.UserAgent = strUserAgent;
                if (Request.Browser.IsMobileDevice == true || strUserAgent.Contains("iphone") ||
                         strUserAgent.Contains("blackberry") || strUserAgent.Contains("mobile") ||
                         strUserAgent.Contains("windows ce") || strUserAgent.Contains("opera mini") ||
                         strUserAgent.Contains("palm"))
                {
                    //Request from Mobile Device
                    ViewBag.DeviceType = "Mobile";
                }
                else
                {
                    //Request from Computer
                    ViewBag.DeviceType = "Computer";
                }
            }
            return View();
        }

        public ActionResult ChatAnother()
        {
            return View();
        }

        public ActionResult Remocon()
        {
            return View();
        }
    }
}