using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Core.Extensions;
using DataAccess.Concrete.EntityFramework.Context;

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
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.ConfigureCustomExceptionMiddleware();

app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();