﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersAndActions.Controllers
{
    public class BasicController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string controller = (string)requestContext.RouteData.Values["controller"];
            string action = (string)requestContext.RouteData.Values["action"];

            if (action.ToLower() == "redirect")
            {
                requestContext.HttpContext.Response.Redirect("/Derived/Index");
            }
            else
            {
                requestContext.HttpContext.Response.Write(
                    string.Format("Контроллер: {0}, Метод действия: {1}",
                    controller, action));
            }

        }
    }
}