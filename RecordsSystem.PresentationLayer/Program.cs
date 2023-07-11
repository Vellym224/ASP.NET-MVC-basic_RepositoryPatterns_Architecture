using Microsoft.EntityFrameworkCore;
using RecodsSystem.BusinessLogicLayer.AddressDetailRepository;
using RecodsSystem.BusinessLogicLayer.CompanyDetailRepository;
using RecodsSystem.BusinessLogicLayer.EmployeeDetailRepository;
using RecodsSystem.BusinessLogicLayer.RecUserDetailRepository;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Interfaces;
using RecordsSystem.DataAccessLayer.Interfaces.AddressDetailRepository;
using RecordsSystem.DataAccessLayer.Interfaces.CompanyDetailRepository;
using RecordsSystem.DataAccessLayer.Interfaces.EmployeeDetailRepository;
using RecordsSystem.DataAccessLayer.Interfaces.RecUserDetailRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("ApplicationConnectionString")));

builder.Services.AddScoped<IRecUseDetailRepository, RecUserDetailRepository>();
builder.Services.AddScoped<IRecUserDetailService, RecUserDetailService>();

builder.Services.AddScoped<IEmployeeDetailRepository, EmployeeDetailRepository>();
builder.Services.AddScoped<IEmployeeDetailService, EmployeeDetailService>();


builder.Services.AddScoped<ICompanyDetailRepository, CompanyDetailRepository>();
builder.Services.AddScoped<ICompanyDetailService, CompanyDetailService>();

builder.Services.AddScoped<IAddressDetailRepository, AddressDetailRepository>();
builder.Services.AddScoped<IAddressDetailService, AddressDetailService>();

//builder.Services.AddScoped<>();


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
