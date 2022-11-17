using Microsoft.EntityFrameworkCore;
using MillionaireWeb;
using MillionaireWeb.Entities;
using MillionaireWeb.MappingProfiles;
using MillionaireWeb.Repositories;
using MillionaireWeb.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GameDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IQuestionsRepository, QuestionsRepository>();
builder.Services.AddScoped<IAnswersRepository, AnswersRepository>();
builder.Services.AddScoped<IPrizeLevelsRepository, PrizeLevelsRepository>();
builder.Services.AddScoped<QuestionsSeeder>();
builder.Services.AddScoped<PrizeLevelSeeder>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IQuestionsService, QuestionsService>();

var app = builder.Build();

// Question seeder
var scope = app.Services.CreateScope();
scope.ServiceProvider.GetRequiredService<PrizeLevelSeeder>().Seed();
scope.ServiceProvider.GetRequiredService<QuestionsSeeder>().Seed();

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
