using IDomain.Abstract.Entitys;

namespace Domain
{
	public class ItemSales : IItemsSales
	{
		public string ProductUUID { get; }
		public double UnitPrice { get; }
		public double Quantity { get; }

		public double Total()
		{
			return UnitPrice * Quantity;
		}
	}
}
