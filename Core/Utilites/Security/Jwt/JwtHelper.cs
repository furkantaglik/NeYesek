using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilites.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Core.Utilites.Security.Jwt;

public class JwtHelper : ITokenHelper
{
	private TokenOptions _tokenOptions;
	private DateTime _accessTokenExpiration;

	public JwtHelper(IConfiguration configuration)
	{
		Configuration = configuration;
		_tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
	}

	public IConfiguration Configuration { get; }

	public AccessToken CreateToken(IEntity entity, List<OperationClaim> operationClaims)
	{
		if (entity is User user)
		{
			_accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
			var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
			var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
			var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
			var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
			var token = jwtSecurityTokenHandler.WriteToken(jwt);

			return new AccessToken
			{
				UserId = user.Id,
				Token = token,
				Expiration = _accessTokenExpiration
			};
		}
		else if (entity is Restaurant restaurant)
		{
			_accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
			var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
			var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
			var jwt = CreateJwtSecurityToken(_tokenOptions, restaurant, signingCredentials, operationClaims);
			var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
			var token = jwtSecurityTokenHandler.WriteToken(jwt);

			return new AccessToken
			{
				RestaurantId = restaurant.Id,
				Token = token,
				Expiration = _accessTokenExpiration
			};
		}
		else
		{
			throw new ArgumentException("Entity type is not supported");
		}
	}

	public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, IEntity entity,
		SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
	{
		if (entity is User user)
		{
			var jwt = new JwtSecurityToken(
				tokenOptions.Issuer,
				tokenOptions.Audience,
				expires: _accessTokenExpiration,
				notBefore: DateTime.Now,
				claims: SetClaims(user, operationClaims),
				signingCredentials: signingCredentials
			);
			return jwt;
		}
		else if (entity is Restaurant restaurant)
		{
			var jwt = new JwtSecurityToken(
				tokenOptions.Issuer,
				tokenOptions.Audience,
				expires: _accessTokenExpiration,
				notBefore: DateTime.Now,
				claims: SetClaims(restaurant, operationClaims),
				signingCredentials: signingCredentials
			
			);
			return jwt;
		}
		else
		{
			throw new ArgumentException("Entity type is not supported");
		}
	}

	private IEnumerable<Claim> SetClaims(IEntity entity, List<OperationClaim> operationClaims)
	{
		if (entity is User user)
		{
			var claims = new List<Claim>();
			claims.AddNameIdentifier(user.Id.ToString());
			claims.AddEmail(user.Email);
			claims.AddName($"{user.FirstName} {user.LastName}");
			claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

			return claims;
		}
		else if (entity is Restaurant restaurant)
		{
			var claims = new List<Claim>();
			claims.AddNameIdentifier(restaurant.Id.ToString());
			claims.AddEmail(restaurant.Email);
			claims.AddName($"{restaurant.Name}");
			claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

			return claims;
		}
		else
		{
			throw new ArgumentException("Entity type is not supported");
		}
	}
}