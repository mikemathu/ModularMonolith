using Module.OrderManagement.Repositories;
using Module.OrderManagement.Services;

namespace Modules.OrderManagement.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder AddOrderManagement(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers()
                        .AddApplicationPart(typeof(WebApplicationBuilderExtensions).Assembly);

        builder.Services.AddSingleton<IOrders, IOrdersRepository>();

        return builder;
    }
}
