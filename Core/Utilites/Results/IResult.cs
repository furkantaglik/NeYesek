namespace Core.Utilites.Results;

public interface IResult
{
	bool Success { get; }
	string Message { get; }
}