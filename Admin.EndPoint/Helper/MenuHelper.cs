using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace Admin.EndPoint.Helper
{
    public static class MenuHelper
    {
        public static string ActiveClass(this IHtmlHelper htmlHelper, string controllers = null, string actions = null, string cssClass = "active")
        {
            var currentController = htmlHelper?.ViewContext.RouteData.Values["controller"] as string;
            var currentAction = htmlHelper?.ViewContext.RouteData.Values["action"] as string;

            var acceptedControllers = (controllers ?? currentController ?? "").Split(',');
            var acceptedActions = (actions ?? currentAction ?? "").Split(',');

            return acceptedControllers.Contains(currentController) && acceptedActions.Contains(currentAction)
                ? cssClass
                : "";
        }
        public static string TrueAriaExpandedClass(this IHtmlHelper htmlHelper, string controllers = null, string controllers2 = "", string cssClass = "true")
        {
            var currentController = htmlHelper?.ViewContext.RouteData.Values["controller"] as string;
           

          
            if (controllers.ToLower() == currentController.ToLower() || controllers2.ToLower() == currentController.ToLower())
            {
                return cssClass;
            }

            return "";
        }
     
    }
}
