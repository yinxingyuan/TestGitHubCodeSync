using MetaShare.Common.Core.Daos;
using TestGithubCodeSync.Daos.Interfaces;

namespace TestGithubCodeSync.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(IProductDao), new ProductDaoMock(), isRegister);
		}
	}
}
