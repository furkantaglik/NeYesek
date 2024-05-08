using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Abstract.ImageServices;
using Business.Concrete;
using Business.Concrete.ImageManagers;
using Castle.DynamicProxy;
using Core.Utilites.FileHelper;
using Core.Utilites.Interceptors;
using Core.Utilites.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Reflection;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		builder.RegisterType<ProductManager>().As<IProductService>();
		builder.RegisterType<EfProductDal>().As<IProductDal>();

		builder.RegisterType<MenuManager>().As<IMenuService>();
		builder.RegisterType<EfMenuDal>().As<IMenuDal>();

		builder.RegisterType<CommentManager>().As<ICommentService>();
		builder.RegisterType<EfCommentDal>().As<ICommentDal>();

		builder.RegisterType<RestaurantManager>().As<IRestaurantService>();
		builder.RegisterType<EfRestaurantDal>().As<IRestaurantDal>();

		builder.RegisterType<CategoryManager>().As<ICategoryService>();
		builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

		builder.RegisterType<AuthManager>().As<IAuthService>();
		builder.RegisterType<JwtHelper>().As<ITokenHelper>();

		builder.RegisterType<UserManager>().As<IUserService>();
		builder.RegisterType<EfUserDal>().As<IUserDal>();

		//images
		builder.RegisterType<FileHelper>().As<IFileHelper>();

		builder.RegisterType<MenuImageManager>().As<IMenuImageService>();
		builder.RegisterType<EfMenuImageDal>().As<IMenuImageDal>();

		builder.RegisterType<ProductImageManager>().As<IProductImageService>();
		builder.RegisterType<EfProductImageDal>().As<IProductImageDal>();

		builder.RegisterType<RestaurantImageManager>().As<IRestaurantImageService>();
		builder.RegisterType<EfRestaurantImageDal>().As<IRestaurantImageDal>();

		builder.RegisterType<CategoryImageManager>().As<ICategoryImageService>();
		builder.RegisterType<EfCategoryImageDal>().As<ICategoryImageDal>();




		var assembly = Assembly.GetExecutingAssembly();

		builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
			.EnableInterfaceInterceptors(new ProxyGenerationOptions
			{
				Selector = new AspectInterceptorSelector()
			}).SingleInstance();
	}
}