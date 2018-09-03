using IDomain.Abstract.Entitys;
using IDomain.Abstract.Enums;
using System.Threading.Tasks;

namespace IInfra.Abstract
{
	public interface ISalesRepository
	{
		Task<string> SaveAsync(ISales sales);
		Task<SalesState> CheckStateAsync(string uuid);
	}
}
