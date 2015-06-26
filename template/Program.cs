namespace NancyApplication3
{
    using System;
    using Nancy.Hosting.Self;

    class Program
    {
        static void Main(string[] args)
        {
			try{
				string envierenmentIP = System.Environment.GetEnvironmentVariable("OPENSHIFT_GEAR_DNS");
				string envierenmentPort = System.Environment.GetEnvironmentVariable("OPENSHIFT_MONO_PORT");

//				envierenmentIP = "127.0.0.1";
//				envierenmentPort = "19032";

				using (var host = new NancyHost(new HostConfiguration{RewriteLocalhost=true}, new Uri("http://" + envierenmentIP + ":" + envierenmentPort)))
				{
	                host.Start();

	                Console.WriteLine("Your application is running");
	                Console.WriteLine("Press any [Enter] to close the host.");
	                Console.ReadLine();
//					while (true) {
//						System.Threading.Thread.Sleep (100);
//					}
	            }
			}
			catch(Exception ex){
				Console.WriteLine (ex.Message);
				Console.ReadLine ();
			}
        }
    }
}
