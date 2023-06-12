using Modules.OrderManagement.Data;

namespace Modules.OrderManagement.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder AddOrderManagement(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers()
                        .AddApplicationPart(typeof(WebApplicationBuilderExtensions).Assembly);

        builder.Services.AddSingleton<IOrders, Orders>();

        return builder;
    }
}
