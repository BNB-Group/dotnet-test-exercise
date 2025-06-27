using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bnb.CodeExercise.Domain;
using Bnb.CodeExercise.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOpenApi();
        builder.Services.AddControllers()
            .AddJsonOptions(opt =>
                opt.JsonSerializerOptions
                .Converters
                .Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase))
            );

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        app.MapControllers();
        app.Run();
    }
}