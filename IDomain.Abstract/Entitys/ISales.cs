using System.Collections.Generic;

namespace IDomain.Abstract.Entitys
{
	public interface ISales
	{
		string ClientUUID { get; }
		IEnumerable<IItemsSales> Items { get; }
		double Total();
		double Quantity();

	}
}
