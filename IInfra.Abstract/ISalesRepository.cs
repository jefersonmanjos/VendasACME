using IDomain.Abstract.Entitys;
using System.Threading.Tasks;

namespace IInfra.Abstract
{
	public interface ISalesRepository
	{
		Task<string> SaveAsync(ISales sales);
	}
}
