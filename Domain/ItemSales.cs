using IDomain.Abstract.Entitys;

namespace Domain
{
	public class ItemSales : IItemsSales
	{
		public string ProductUUID { get; }
		public double UnitPrice { get; }
		public double Quantity { get; }
		public ItemSales(string productUUID, double unitPrice, double quantity)
		{
			ProductUUID = productUUID;
			UnitPrice = unitPrice;
			Quantity = quantity;
		}
		public double Total()
		{
			return UnitPrice * Quantity;
		}
	}
}
