using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Core.Utilites.Security.Encryption;
using Core.Utilites.Security.Jwt;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlContext>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
			   .ConfigureContainer<ContainerBuilder>(builder =>
			   {
				   builder.RegisterModule(new AutofacBusinessModule());
			   });

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			  .AddJwtBearer(options =>
			  {
				  options.TokenValidationParameters = new TokenValidationParameters
				  {
					  ValidateIssuer = true,
					  ValidateAudience = true,
					  ValidateLifetime = true,
					  ValidIssuer = tokenOptions.Issuer,
					  ValidAudience = tokenOptions.Audience,
					  ValidateIssuerSigningKey = true,
					  IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
				  };
			  });

//builder.Services.AddControllers().AddJsonOptions(x =>
//   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

//app.ConfigureCustomExceptionMiddleware();

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();