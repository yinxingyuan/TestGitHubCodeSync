using System;
using System.Web.Http;
using System.Collections.Generic;
using TestGithubCodeSync.Entities;
using TestGithubCodeSync.Services.Interfaces;
using TestGithubCodeSync.WebApi.Models;

namespace TestGithubCodeSync.WebApi.Controllers
{
	public class ProductApiController : CommonApiController<Product, IProductService>
	{


	}
}
