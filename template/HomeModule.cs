namespace SAPPNancy
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.html"];
            };
        }
    }
}
