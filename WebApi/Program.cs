using Core.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Root;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

#region generating random key


/*
var key = new byte[32];
using (var rng = RandomNumberGenerator.Create())
{
    rng.GetBytes(key);
}
var secretKey = Convert.ToBase64String(key); // Store this securely

*/

#endregion






// Add services to the container.

//// Add services to the container.
CompositionRoot.InjectDependencies(builder.Services, builder.Configuration.GetConnectionString("GestRDVDb"));


// add authentication middleware
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = false,
            //ValidIssuer = "yourdomain.com",
            //ValidAudience = "yourdomain.com",
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    builder.Configuration
                    .GetSection("myConfiguration")
                    .GetSection("ApiSecretKey")
                    .Value)
                )
        };
    }


    );

builder.Services.AddAuthorization();

// cors origin

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder                        
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .SetIsOriginAllowed(origin => true) // allow any origin
                        .AllowCredentials();
                         
                    });
});


//// add mediatR
//builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssemblies(typeof(Program).Assembly, typeof(ServicePattern<object>).Assembly));

//// add autoMapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




// registerConfiguration
builder.Services.AddSingleton(builder.Configuration.GetSection("myConfiguration").Get<MyConfiguration>());



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
