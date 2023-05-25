using onticket.data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.RateLimiting;
using Microsoft.EntityFrameworkCore;
using System.Configuration;




      

var builder = WebApplication.CreateBuilder(args);






    // Add services to the container.
    builder.Services.AddControllersWithViews();

    builder.Services.AddDbContext<appdbcontext>(option => option.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString"))
    );

    builder.Services.AddMvc();

    builder.Services.AddControllersWithViews();



    //db context confi



    var app = builder.Build();



    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();


