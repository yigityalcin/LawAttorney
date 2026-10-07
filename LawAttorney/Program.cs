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
// Retired Russian URLs keep their corresponding Turkish destination.
var retiredPages = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
{
    ["HomePageRu"] = "/Anasayfa", ["CorporateRu"] = "/Kurumsal",
    ["OurTeamRu"] = "/Ekibimiz", ["PracticeAreasRu"] = "/CalismaAlanlarimiz",
    ["ArticlesRu"] = "/Makaleler", ["ContactRu"] = "/iletisim",
    ["Article1Ru"] = "/Makale1", ["Article5Ru"] = "/Makale5",
    ["Article6Ru"] = "/Makale6", ["Article7Ru"] = "/Makale7",
    ["Article8Ru"] = "/Makale8", ["Article9Ru"] = "/Makale9"
};
app.Use(async (context, next) =>
{
    var segments = (context.Request.Path.Value ?? "").Split('/', StringSplitOptions.RemoveEmptyEntries);
    var retiredLanguage = segments.Length > 0 && segments[0].Equals("ru", StringComparison.OrdinalIgnoreCase);
    var legacyAction = segments.Length == 1 || (segments.Length == 2 && segments[0].Equals("Home", StringComparison.OrdinalIgnoreCase));
    if (retiredLanguage || (legacyAction && retiredPages.ContainsKey(segments[^1])))
    {
        var destination = retiredPages.GetValueOrDefault(segments[^1], "/Anasayfa");
        context.Response.Redirect(destination + context.Request.QueryString, permanent: true);
        return;
    }
    await next();
});

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

var supportedLanguages = new[] { "en", "tr" };


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

app.MapGet("/sitemap.xml", () => Results.Text(LawAttorney.Models.SeoPages.Sitemap(), "application/xml; charset=utf-8"));

app.Run();

