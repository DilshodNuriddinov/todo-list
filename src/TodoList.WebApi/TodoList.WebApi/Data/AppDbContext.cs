using System;
using Microsoft.EntityFrameworkCore;
using TodoList.WebApi.Models;

namespace TodoList.WebApi.Data
{
	public class AppDbContext :  DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{

		}

		public virtual DbSet<ToDo> ToDos { get; set; }
	}
}

