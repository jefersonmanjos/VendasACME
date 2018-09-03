using Infra;
using IServices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Threading.Tasks;

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

		[HttpPost]
		public async Task<ActionResult> Post()
		{
			await salesService.ProcessAsync(null);
			return Ok();
		}
	}
}
