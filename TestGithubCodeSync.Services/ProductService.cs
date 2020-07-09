using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using TestGithubCodeSync.Entities;
using MetaShare.Common.Core.Services;
using TestGithubCodeSync.Daos.Interfaces;
using TestGithubCodeSync.Services.Interfaces;


namespace TestGithubCodeSync.Services
{
	public class ProductService : Service<Product>, IProductService
	{
		public ProductService() : base(typeof (IProductDao))
		{
		}

	}
}
