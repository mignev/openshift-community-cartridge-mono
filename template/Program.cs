namespace NancyApplication3
{
    using System;
	using Nancy;
    using Nancy.Hosting.Self;

    class Program
    {
        static void Main(string[] args)
        {
			try{
				string envierenmentDNS = System.Environment.GetEnvironmentVariable("OPENSHIFT_GEAR_DNS");
				string envierenmentIP = System.Environment.GetEnvironmentVariable("OPENSHIFT_MONO_IP");
				string envierenmentPort = System.Environment.GetEnvironmentVariable("OPENSHIFT_MONO_PORT");

				HostConfiguration hostConfigs = new HostConfiguration()
				{
					UrlReservations = new UrlReservations() { CreateAutomatically = true }
				};

				using (var host = new NancyHost(hostConfigs, new Uri("http://" + envierenmentIP + ":" + envierenmentPort), new Uri("http://" + envierenmentDNS + ":" + envierenmentPort)))
				{
	                host.Start();

	                Console.WriteLine("Your application is running");
	                Console.WriteLine("Press any [Enter] to close the host.");
	                Console.ReadLine();
					while (true) {
						System.Threading.Thread.Sleep (100);
					}
	            }
			}
			catch(Exception ex){
				Console.WriteLine (ex.Message);
				Console.ReadLine ();
			}
        }
    }
}
