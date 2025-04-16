using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IAnasayfaDal, EfAnasayfaDal>();
builder.Services.AddScoped<IAnasayfaService,AnasayfaManeger>();

builder.Services.AddScoped<IHizmetDal,EfHizmetDal>();
builder.Services.AddScoped<IHizmetService,HizmetManeger>();

builder.Services.AddScoped<IHakkýmýzdaDal,EfHakkýmýzdaDal>();
builder.Services.AddScoped<IHakkýmýzdaService,HakkýmýzdaManeger>();


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
