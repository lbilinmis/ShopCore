using Autofac;
using Autofac.Extensions.DependencyInjection;
using ShopCore.Business.DependecyResolvers.Autofac;
using ShopCore.DataAccess.Concrete.EntityFramework.Seeds;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));



// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

SeedDatabase.Seed();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting(); ;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
