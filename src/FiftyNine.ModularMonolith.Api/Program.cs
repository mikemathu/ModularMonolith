using Modules.OrderManagement.Extensions;
using Modules.UserManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.AddOrderManagement();
builder.AddUserManagement();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

// Required for testing...
public partial class ApiProgram
{

}