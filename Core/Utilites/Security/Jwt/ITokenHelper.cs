using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Core.Utilites.Security.Jwt;

public interface ITokenHelper
{
	AccessToken CreateToken(IEntity entity, List<OperationClaim> operationClaims);
}