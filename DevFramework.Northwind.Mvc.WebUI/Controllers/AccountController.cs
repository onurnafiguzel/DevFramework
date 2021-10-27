using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public string Login()
        {
            //AuthenticationHelper.CreateAuthCookie(
            //    new Guid(), "onurguzel", "onur@gmail.com", DateTime.Now.AddDays(15), new[] { "Admin" }, false, "Onur", "Güzel"); İzin veriyor, beklendiği gibi
            //AuthenticationHelper.CreateAuthCookie(
            //    new Guid(), "onurguzel", "onur@gmail.com", DateTime.Now.AddDays(15), new[] { "Student" }, false, "Onur", "Güzel"); Hata veriyor, beklendiği gibi
            return "User is authenticated!";
        }
    }
}