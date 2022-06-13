using System;
namespace Moth_Note.Models
{
	public class User
	{
		public User(int Id, string FirstName, string LastName, string Email)
		{
			this.Id = Id;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Email = Email;
		}

		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
	}
}

