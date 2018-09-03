using IDomain.Abstract.Entitys;
using IDomain.Abstract.Enums;
using System.Threading.Tasks;

namespace IServices.Abstract
{
	public interface ISalesService
	{
		Task<SalesState> ProcessAsync(ISales sales);
		Task<SalesState> CheckStateAsync(string UUID);
	}
}
