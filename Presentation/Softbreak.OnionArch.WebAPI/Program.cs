using Softbreak.OnionArch.APPLICATION.DependencyResolvers;
using Softbreak.OnionArch.Persistence.DependencyResolvers;
using Softbreak.OnionArch.InnerInfrastructure.DependencyResolvers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationMapperService();
builder.Services.AddRepositoryServices();
builder.Services.AddDbContextService();
builder.Services.AddManagerService();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
