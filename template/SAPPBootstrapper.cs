namespace SAPPNancy
{
    using Nancy;
    using System;
    public class SAPPBootstrapper : DefaultNancyBootstrapper
    {
        protected override IRootPathProvider RootPathProvider
        {
            get { return string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DNX_RUNTIME_BIN")) ? base.RootPathProvider : new SAPPRootPathProvider(); }
        }
    }
}
