using IDomain.Abstract.Enums;
using System;
using Xunit;

namespace Domain.Test
{
	public class SalesTest
	{
		[Fact]
		public void The_State_Sales_Should_Be_Processed()
		{
			var sales = new Sales(string.Empty, null);
			sales.SetUUID(Guid.NewGuid().ToString());
			Assert.Equal(SalesState.Processed, sales.State);
		}
	}
}
