using Fiap.Grupo10.BrizolaJiuJitsu.CrossCutting;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = configuration.GetValue<string>("ConnectionString");

builder.Services.AddDbDependency(connectionString);
builder.Services.AddRepositoriesDependency();
builder.Services.AddServicesDependency();
builder.Services.AddApplicationDependency();

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
