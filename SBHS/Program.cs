using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using Microsoft.AspNetCore.Identity;
using SBHS.Services;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SBHSDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SBHSDb")));



builder.Services.AddDefaultIdentity<IdentityUser>(options => 
{ 
    options.Password.RequiredLength = 6;
    options.SignIn.RequireConfirmedAccount = true; // Disable email confirmation requirement


    // Configure user validation rules
    options.User = new UserOptions
    {
        // Add your customization here
        AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+",
        RequireUniqueEmail = true,
    };
})
    .AddDefaultTokenProviders()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SBHSDbContext>();


builder.Services.ConfigureApplicationCookie(options =>
{
    //Cookie settings
    options.ExpireTimeSpan = TimeSpan.FromDays(90);
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});



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

app.MapControllers(); 

app.MapRazorPages();

app.Run();

