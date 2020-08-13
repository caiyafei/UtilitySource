using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using System.Reflection;
using System.Reflection.Metadata;

namespace WebApiAndSocketServer.WebSocketManager
{
    public static class SocketExtension
    {
        public static IServiceCollection AddWebSocketManager(this IServiceCollection services)
        {
            services.AddTransient<ConnectionManager>();
            foreach (var item in Assembly.GetEntryAssembly().GetExportedTypes())
            {
                if (item.BaseType == typeof(SocketHandler))
                    services.AddSingleton(item);
            }
            return services;
        }

        public static IApplicationBuilder MapWebSocket(this IApplicationBuilder app,PathString path,SocketHandler handler)
        {

            return app.Map(path,x=> x.UseMiddleware<SocketMiddleware>(handler));
        }
    }
}
