using Root;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//// Add services to the container.
CompositionRoot.InjectDependencies(builder.Services, builder.Configuration.GetConnectionString("GestRDVDb"));

//// add mediatR
//builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssemblies(typeof(Program).Assembly, typeof(ServicePattern<object>).Assembly));

//// add autoMapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
