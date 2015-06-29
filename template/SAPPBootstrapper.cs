namespace SAPPNancy
{
    using Nancy;
    using System;
    public class SAPPBootstrapper : DefaultNancyBootstrapper
    {
        protected override IRootPathProvider RootPathProvider
        {
            get { return string.IsNullOrEmpty(Environment.GetEnvironmentVariable("OPENSHIFT_REPO_DIR")) ? base.RootPathProvider : new SAPPRootPathProvider(); }
        }
    }
}
