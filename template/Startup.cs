using System;

namespace NancyApplication3
{
	using Owin;

	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseNancy();
		}
	}
}

