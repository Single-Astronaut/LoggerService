using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.Elasticsearch;
using System;

var builder = WebApplication.CreateBuilder(args);

// Настройка Serilog
builder.Host.UseSerilog((context, config) =>
{
    config.Enrich.FromLogContext()
          .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://localhost:9200"))
          {
              AutoRegisterTemplate = true,
              IndexFormat = "user-logs-{0:yyyy.MM.dd}"
          })
          .WriteTo.Console();
});

// Регистрация контроллеров
builder.Services.AddControllers();
builder.Services.AddElasticSearch("http://localhost:9200");

var app = builder.Build();

// Подключение middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();