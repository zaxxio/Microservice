using Autofac;
using Autofac.Extensions.DependencyInjection;
using Web.Configuration;
using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(AutofacModuleLoader.LoadModules);

var app = builder.Build();


app.UseRequestTiming();
app.UseRouting();

app.MapControllers();

app.Run();