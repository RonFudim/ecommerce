using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ECommerce.Api.Products.Db.Interfaces
{
	public interface IProductsProvider
	{
		Task<(bool IsSuccess, IEnumerable<Models.Product> Products, string ErrorMessage)> GetProductsAsync();
		Task<(bool IsSuccess, Models.Product Product, string ErrorMessage)> GetProductAsync(int id);
	}
}
