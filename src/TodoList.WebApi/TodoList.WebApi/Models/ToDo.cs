using System;
namespace TodoList.WebApi.Models
{
	public class ToDo
	{
		public int Id { get; set; }

		public string Title { get; set; } = string.Empty;

		public string Definition { get; set; } = string.Empty;

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }
	}
}

