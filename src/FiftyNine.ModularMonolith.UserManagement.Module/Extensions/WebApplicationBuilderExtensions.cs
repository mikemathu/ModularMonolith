using Module.UserManagement.Repositories;

namespace Modules.UserManagement.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder AddUserManagement(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers()
                        .AddApplicationPart(typeof(WebApplicationBuilderExtensions).Assembly);

        builder.Services.AddSingleton<IUsersRepository>()
                        .AddSingleton<Module.UserManagement.Services.IUsers>(x => x.GetRequiredService<IUsersRepository>())
                        .AddSingleton<Integration.UserManagement.Services.IUsers>(x => x.GetRequiredService<IUsersRepository>());

        return builder;
    }
}
