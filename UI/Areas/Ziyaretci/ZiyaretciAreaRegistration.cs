using System.Web.Mvc;

namespace UI.Areas.Ziyaretci
{
    public class ZiyaretciAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Ziyaretci";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Ziyaretci_default",
                "Ziyaretci/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}