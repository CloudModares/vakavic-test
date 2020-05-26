using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Cors;

namespace vakavic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjVlY2NhYTEyNWJlMWU1MzIzN2IzNDU4NSIsInZlcnNpb24iOjEsImlhdCI6MTU5MDQ3MTE4Nn0.kIBMtqi7JMXYjUxwwqf_3gR65ruRxQfYBRYcssNmhpk";
            return View((object)token);
        }
    }
}