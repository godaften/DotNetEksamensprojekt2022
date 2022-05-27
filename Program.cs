//using cbsStudents.Data;
using CbsStudents.Data;
using cbsStudents.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CbsStudentsContext>(options =>
     // options.UseSqlite(builder.Configuration.GetConnectionString("CbsStudentsContext")));
      options.UseSqlServer(builder.Configuration.GetConnectionString("CbsStudentsContextConnection")));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
.AddDefaultUI()
.AddEntityFrameworkStores<CbsStudentsContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Add services to the container.
builder.Services.AddControllersWithViews();

//var appservice = builder.Build();

//using (var scope = appservice.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;

//    SeedDataPosts.Initialize(services);
//}









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
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
