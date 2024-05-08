namespace Core.Utilites.FileHelper
{
	public class GuidHelper
	{
		public static string CreateGuid()
		{
			return Guid.NewGuid().ToString();
		}
	}
}
