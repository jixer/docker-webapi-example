using System.Web.Http;
using Owin;

namespace Poc.Docker.OrderApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var httpConfiguration = new HttpConfiguration();
            Config.Register(httpConfiguration);
            appBuilder.UseWebApi(httpConfiguration);
        }
    }
}
