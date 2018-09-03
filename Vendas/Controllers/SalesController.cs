using Domain;
using Infra;
using IServices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;

namespace Vendas.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SalesController : ControllerBase
	{
		private ISalesService salesService;
		public SalesController()
		{
			salesService = new SalesServices(new SalesRepository());
		}
		[HttpGet]
		[Route("{uuid}")]
		public async Task<ActionResult> Get(string uuid)
		{
			var state = await salesService.CheckStateAsync(uuid);
			return Ok(state.ToString());
		}
		[HttpPost]
		public async Task<ActionResult> Post(SalesModel salesModel)
		{
			var itemSales = salesModel.ItemSalesModels.Select(s => new ItemSales(s.ProductUUID, s.UnitPrice, s.Quantity));
			var sales = new Sales(salesModel.ClientUUID, itemSales);
			await salesService.ProcessAsync(sales);
			return Ok();
		}
	}
}
