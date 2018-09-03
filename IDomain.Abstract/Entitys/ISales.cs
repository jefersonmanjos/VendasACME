using IDomain.Abstract.Enums;
using System.Collections.Generic;

namespace IDomain.Abstract.Entitys
{
	public interface ISales
	{
		SalesState State { get; }
		string ClientUUID { get; }
		IEnumerable<IItemsSales> Items { get; }
		string UUID { get; set; }

		double Total();
		double Quantity();
		void SetUUID(string v);
	}
}
