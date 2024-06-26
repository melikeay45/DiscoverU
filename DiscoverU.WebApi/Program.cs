using DiscoverU.Application.Services;
using DiscoverU.Infrastructure.Persistence.Contexts;
using DiscoverU.Infrastructure.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using OpenAI.Extensions;
using OpenAI.Managers;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});



builder.Services.AddDbContext<DiscoverUDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL"));
});

builder.Services.AddScoped<IQuestionService, QuestionService>();

builder.Services.AddScoped<IOptionService, OptionService>();

builder.Services.AddScoped<ISurveyService, SurveyService>();

//builder.Services.AddOpenAIService(settings => settings.ApiKey = "OpenAIApiKey:ApiKey");

var openAiApiKey = builder.Configuration["OpenAIApiKey:ApiKey"];
if (string.IsNullOrEmpty(openAiApiKey))
{
    throw new ArgumentNullException("OpenAI API key is not configured.");
}
builder.Services.AddOpenAIService(settings => settings.ApiKey = openAiApiKey);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
