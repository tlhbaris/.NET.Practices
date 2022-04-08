
using WebApplication8.Services.EmailService;
using SendGrid.Extensions.DependencyInjection;
using WebApplication8.Services.EmailService;
using WebApplication8.Services.SmsService;
using Mvc101.Services.EmailService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISmsService, WissenSmsService>();
//builder.Services.AddSendGrid(options =>
//{
//    options.ApiKey = "";
//});
builder.Services.AddScoped<IEmailServices, OutlookEmailService>();

builder.Services.AddControllersWithViews();

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
