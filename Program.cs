using System.Text.Json.Serialization;
using GestaoDeProjetos.Api.Extensions;
using GestaoDeProjetos.Api.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddRouting(opt => opt.LowercaseQueryStrings = true);

builder.Services.AddMvc(opt => opt.Filters.Add<ExceptionFilter>());


builder.Services.AddApplication(builder.Configuration);

builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        //Server para ser possivel enviar o enum como string
        //Exemplo: "status": "Pending" e não "status": 0 
        opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
