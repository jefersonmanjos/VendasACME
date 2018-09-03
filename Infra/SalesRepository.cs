using IDomain.Abstract.Entitys;
using IDomain.Abstract.Enums;
using IInfra.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra
{
	public class SalesRepository : ISalesRepository
	{
		private static IList<ISales> salesList = new List<ISales>();
		public Task<SalesState> CheckStateAsync(string uuid)
		{
			return Task.FromResult(salesList.Where(c => c.UUID == uuid).FirstOrDefault().State);
		}

		public Task<string> SaveAsync(ISales sales)
		{
			var uuid = Guid.NewGuid().ToString();
			sales.SetUUID(uuid);
			salesList.Add(sales);
			return Task.FromResult(uuid);

		}
	}
}
