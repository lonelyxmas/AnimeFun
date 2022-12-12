using AnimeFun.Service.DataFactory;
using AnimeFun.Service.Helpers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureService();

WebApplication app = builder.Build();
app.ConfigureApplication();

InitialAnimeFun.InitialData();

app.Run();