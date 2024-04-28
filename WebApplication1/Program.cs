using Microsoft.Extensions.Hosting;
using Kitap.arama.MüþteriConstract;
using Kitap.arama.MüþteriAbstract;
using Kitap.arama;
using Kitap.arama.SubeAbstarct;
using Kitap.arama.SubeConstract;
using Kitap.arama.Abstarct;
using Kitap.arama.Constract;
using Kitap.arama.Constract;
using Kitap.arama.ConstractWorker;
using Kitap.arama.AbstractWorker;
using MüþteriService = Kitap.arama.MüþteriConstract.MüþteriService;
using Sube = Kitap.arama.SubeConstract.Sube;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddScoped<IMüþteri, MüþteriService>();
builder.Services.AddScoped<ISubeler,Sube >();
builder.Services.AddScoped<IKitap,KitapService >();
builder.Services.AddScoped<IWorker, Worker>();
builder.Services.AddScoped<KütüphaneContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
