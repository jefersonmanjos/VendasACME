using System.Collections.Generic;

namespace Vendas.Models
{
	public class SalesModel
	{
		public string ClientUUID { get; set; }
		public List<ItemSalesModel> ItemSalesModels { get; set; }
	}

	public class ItemSalesModel
	{
		public string ProductUUID { get; set; }
		public double UnitPrice { get; set; }
		public double Quantity { get; set; }
	}
}
