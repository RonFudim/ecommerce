namespace ECommerce.Api.Products.Db.Models.Profiles
{
	public class ProductProfile: AutoMapper.Profile
	{
		public ProductProfile()
		{
			CreateMap<Db.Product, Models.Product>();
		}
	}
}
