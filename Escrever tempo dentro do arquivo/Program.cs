// See https://aka.ms/new-console-template for more information
using Escrever_tempo_dentro_do_arquivo_;
using Microsoft.Graph;

StreamWriterTwo streamWriterTwo = new StreamWriterTwo();
await streamWriterTwo.ExampleAsync();

var uploader = new UploadFileSample();
Console.WriteLine("Escrevendo no bucket");
uploader.UploadFile("2f9224c0-660c-424c-8621-0759ee5871b3", @$"/home/gabrielgsdevbr/tf-tutorial/WriteLines2.txt", "WriteLines2.txt");


var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";
var target = Environment.GetEnvironmentVariable("TARGET") ?? "World";

var app = builder.Build();

app.MapGet("/", () => $"Hello {target}!");

app.Run(url);