using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/tasks", (Func<string>)(() => "Hello World!"));
app.MapGet("/tasks/{id:int}", (Func<int, string>)(id => $"Requested with {id}"));

app.MapGet("/targets", (Func<string>)(() => "Hello World!"));
app.MapGet("/targets/{id:int}", (Func<string>)(() => "Hello World!"));

app.MapGet("/bulk", (Func<string>)(() => "Hello World!"));
app.MapGet("/bulk/{id:int}", (Func<string>)(() => "Hello World!"));

app.MapGet("/settings", (Func<string>)(() => "Hello World!"));
app.MapGet("/settings/{id:int}", (Func<string>)(() => "Hello World!"));

app.MapGet("/results", (Func<string>)(() => "Hello World!"));
app.MapGet("/results/{id:int}", (Func<string>)(() => "Hello World!"));

await app.RunAsync();
