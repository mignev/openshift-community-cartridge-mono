namespace SAPPNancy
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy()).UseFileServer();
        }
    }

    // public class CustomBootstrapper : DefaultNancyBootstrapper
    // {
    //     protected override IRootPathProvider RootPathProvider
    //     {
    //         get { return new CustomRootPathProvider(); }
    //     }
    // }
}
