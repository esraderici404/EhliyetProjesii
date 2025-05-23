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

builder.Services.AddScoped<IHakk�m�zdaDal,EfHakk�m�zdaDal>();
builder.Services.AddScoped<IHakk�m�zdaService,Hakk�m�zdaManeger>();

builder.Services.AddScoped<IKursDal,EfKursDal>();
builder.Services.AddScoped<IKursService,KursManeger>();

builder.Services.AddScoped<IRandevuDal,EfRandevuDal>();
builder.Services.AddScoped<IRandevuService,RandevuManeger>();

builder.Services.AddScoped<I�al��anDal, Ef�al��anDal>();
builder.Services.AddScoped<I�al��anService,�al��anManeger>();

builder.Services.AddScoped<IYorumlarDal,EfYorumlarDal>();
builder.Services.AddScoped<IYorumlarService,YorumlarManeger>();

builder.Services.AddScoped<I�zelliklerDal,Ef�zelliklerDal>();
builder.Services.AddScoped<I�zelliklerService,OzelliklerManeger>();


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
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
