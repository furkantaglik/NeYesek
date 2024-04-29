﻿using Core.Entities.Concrete;
using Entities.Concrete.DTOs.RestaurantDto;
using Entities.Concrete.DTOs.UserDto;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context;

public class SqlContext : DbContext
{
	public DbSet<Product> Products { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<Restaurant> Restaurants { get; set; }
	public DbSet<User> Users { get; set; }
	public DbSet<Comment> Comments { get; set; }
	public DbSet<Menu> Menus { get; set; }
	public DbSet<OperationClaim> OperationClaims { get; set; }
	public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
	public DbSet<RestaurantOperationClaim> RestaurantOperationClaims { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NeYesek;Trusted_Connection=true");
	}
}