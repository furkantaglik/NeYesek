using Core.Entities.Concrete;

namespace Core.Utilites.Security.Jwt;

public interface ITokenHelper
{
	AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
}