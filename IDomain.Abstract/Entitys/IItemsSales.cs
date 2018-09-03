namespace IDomain.Abstract.Entitys
{
	public interface IItemsSales
	{
		string ProductUUID { get; }
		double UnitPrice { get; }
		double Quantity { get; }
		double Total();
	}
}
