using DataStillCase.Core.Repository;
using DataStillCase.Core.Service;
using DataStillCase.Core.Service.Models.Tables;
using DataStillCase.Core.UnitOfWork;
using DataStillCase.Data;
using DataStillCase.Data.Repository;
using DataStillCase.Data.UnitOfWork;
using DataStillCase.Service.Service;
using DataStillCase.Service.Service.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

#region DI
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddScoped(typeof(IService<>), typeof(Service<>));

services.AddScoped(typeof(ICityService), typeof(CityService));
services.AddScoped(typeof(IInformationService), typeof(InformationService));
services.AddScoped(typeof(IVisitorHistoryService), typeof(VisitorHistoryService));

services.AddScoped<IUnitOfWork, UnitOfWork>();

services.AddDbContext<AppDbContext>(options =>
{
    options.UseLazyLoadingProxies(false);
    options.UseSqlServer(configuration.GetConnectionString("default"),
        x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo"));
});
#endregion

services.AddMvc()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


#region App Settings
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
});

app.Run();

#endregion