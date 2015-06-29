namespace SAPPNancy
{
    using System;
    using Nancy;
    public class SAPPRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Environment.GetEnvironmentVariable("OPENSHIFT_REPO_DIR");
        }
    }
}
