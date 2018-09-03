using IDomain.Abstract.Entitys;
using IDomain.Abstract.Enums;
using IInfra.Abstract;
using IServices.Abstract;
using System.Threading.Tasks;

namespace Services
{
	public class SalesServices : ISalesService
	{
		private readonly ISalesRepository salesRepository;

		public SalesServices(ISalesRepository salesRepository)
		{
			this.salesRepository = salesRepository;
		}
		public async Task<SalesState> CheckStateAsync(string UUID)
		{
			return await salesRepository.CheckStateAsync(UUID);
		}

		public async Task<SalesState> ProcessAsync(ISales sales)
		{
			var uuid = await salesRepository.SaveAsync(sales);
			return string.IsNullOrEmpty(uuid) ? SalesState.InProcess : SalesState.Processed;
		}
	}
}
