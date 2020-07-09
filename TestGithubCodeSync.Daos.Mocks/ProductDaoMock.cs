using MetaShare.Common.Core.Daos;
using TestGithubCodeSync.Entities;
using TestGithubCodeSync.Daos.Interfaces;
using TestGithubCodeSync.TestData;

namespace TestGithubCodeSync.Daos.Mocks
{
	public class ProductDaoMock : MockDao<Product>, IProductDao
	{
		public ProductDaoMock() : base(ProductTestData.CreateProduct())
		{
		}
	}
}
