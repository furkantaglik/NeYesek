using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete.DTOs.CommentDto
{
	public class CommentDetailDto : IDto
	{
		public Comment comment { get; set; }
		public Restaurant restaurant { get; set; }
		public User user { get; set; }
	}
}
