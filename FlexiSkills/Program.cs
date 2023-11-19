using FlexiSkills.Models;
using FlexiSkills.Utilities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

builder.Services.AddScoped<IPaymentService, PaymentService>();

builder.Services.AddDbContext<EBPortalDbContext>(options =>
{
    //IConfiguration config = provider.GetRequiredService<IConfiguration>();
    options.UseSqlServer(builder.Configuration.GetConnectionString("EBPortalDb"));
});

builder.Services.AddDbContext<FlexiDbContext>(options =>
{
    //IConfiguration config = provider.GetRequiredService<IConfiguration>();
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlexiDb"));
});

builder.Services.AddDbContext<StudentDbContext>(options =>
{
    //IConfiguration config = provider.GetRequiredService<IConfiguration>();
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDb"));
});

// register payment service class

//builder.Services.AddScoped<FlexiDbContext>();

//builder.Services.AddDbContext<EBPortalDbContext>(options => options.UseSqlServer("ConnectionStrings:EBPortalDb"));

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

app.UseAuthentication();

app.UseAuthorization();


app.MapRazorPages();

app.Run();
