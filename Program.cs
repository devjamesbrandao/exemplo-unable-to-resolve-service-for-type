using teste.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Injeção de dependência
builder.Services.AddScoped<IServicoExemplo, ServicoExemplo>();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
