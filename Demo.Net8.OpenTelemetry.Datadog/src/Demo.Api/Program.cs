using Npgsql;
using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var resourceBuilder = ResourceBuilder.CreateDefault()
                                     .AddEnvironmentVariableDetector();

// logging configuration
builder.Logging.AddOpenTelemetry(options =>
    {
        options.IncludeScopes = true;
        options.SetResourceBuilder(resourceBuilder);
        options.AddConsoleExporter();
    });

// metrics configuration
builder.Services.AddOpenTelemetry()
      .WithMetrics(metrics => metrics
          .AddAspNetCoreInstrumentation()
          .SetResourceBuilder(resourceBuilder));

// tracing configuration
builder.Services.AddOpenTelemetry()
      .WithTracing(tracing => tracing
          .AddAspNetCoreInstrumentation()
          .AddHttpClientInstrumentation()
          .AddEntityFrameworkCoreInstrumentation(options =>
          {
              options.SetDbStatementForText = true;
          })
          .AddNpgsql()
          .SetResourceBuilder(resourceBuilder));

builder.Services.AddOpenTelemetry().UseOtlpExporter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
