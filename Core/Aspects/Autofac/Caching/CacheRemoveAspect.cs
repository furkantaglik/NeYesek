﻿using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilites.Interceptors;
using Core.Utilites.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching;

public class CacheRemoveAspect : MethodInterception
{
	private readonly ICacheManager _cacheManager;
	private readonly string _pattern;

	public CacheRemoveAspect(string pattern)
	{
		_pattern = pattern;
		_cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
	}

	protected override void OnSuccess(IInvocation invocation)
	{
		_cacheManager.RemoveByPattern(_pattern);
	}
}