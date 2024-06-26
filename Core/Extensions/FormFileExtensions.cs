﻿using Microsoft.AspNetCore.Http;

namespace Core.Extensions
{
	public static class FormFileExtensions
	{
		public static async Task<byte[]> GetBytes(this IFormFile formFile)
		{
			using (var ms = new MemoryStream())
			{
				await formFile.CopyToAsync(ms);
				return ms.ToArray();
			}
		}
	}
}
