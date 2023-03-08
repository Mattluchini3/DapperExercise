using System;
namespace DapperExercise
{
	public interface IProductRepository
	{
		IEnumerable<Products> GetAllProducts();

		void CreateProduct(string Name, double price, int CategoryID);
	}
}

