using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
	public class Restaurant : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Adress { get; set; }
		public string TelNo { get; set; }
		public byte[] PasswordSalt { get; set; }
		public byte[] PasswordHash { get; set; }
		public bool Status { get; set; }
		public int CommentId { get; set; }
		public int CategoryId { get; set; }

	}
}
