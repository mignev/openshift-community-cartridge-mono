namespace NancyApplication3
{
    using System;
    using Nancy.Hosting.Self;

    class Program
    {
        static void Main(string[] args)
        {
            string envierenmentUrl = System.Environment.GetEnvironmentVariable("OPENSHIFT_MONO_IP") + System.Environment.GetEnvironmentVariable("OPENSHIFT_MONO_PORT");
            var uri =
                new Uri("http://" + envierenmentUrl);

            using (var host = new NancyHost(uri))
            {
                host.Start();

                Console.WriteLine("Your application is running on " + uri);
                Console.WriteLine("Press any [Enter] to close the host.");
                Console.ReadLine();
            }
        }
    }
}
