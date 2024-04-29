using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilites.IoC;

public interface ICoreModule
{
	void Load(IServiceCollection collection);
}