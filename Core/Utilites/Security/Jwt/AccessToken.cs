namespace Core.Utilites.Security.Jwt;

public class AccessToken
{
	public string Token { get; set; }
	public DateTime Expiration { get; set; }
	public int? RestaurantId { get; set; }
	public int? UserId { get; set; }
}