var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

var supportedLanguages = new[] { "en", "tr", "ru" };


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Anasayfa}/{id?}");

app.MapControllerRoute(
    name: "localizedDefault",
            pattern: "{lang}/{action}/{id?}",
            constraints: new { lang = string.Join("|", supportedLanguages) },
            defaults: new { controller = "Home", action = "HomePage" });

app.MapControllerRoute(
    name: "default",
    pattern: "{action=Anasayfa}",
    defaults: new { controller = "Home" });

app.Run();
