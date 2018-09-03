using IDomain.Abstract.Entitys;
using IDomain.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Domain
{
	public class Sales : ISales
	{
		public SalesState State { get; private set; } = SalesState.InProcess;
		public string ClientUUID { get; }
		public IEnumerable<IItemsSales> Items { get; }
		public string UUID { get; private set; }

		public Sales(string clientUUID, IEnumerable<IItemsSales> items)
		{
			ClientUUID = clientUUID;
			Items = items;
		}
		public double Quantity()
		{
			return (from item in Items select item.Quantity).Sum();
		}

		public void SetUUID(string uuid)
		{
			if (string.IsNullOrWhiteSpace(uuid))
			{
				throw new ArgumentException("uuid can not be null or empty or white space", nameof(uuid));
			}
			State = SalesState.Processed;
			UUID = uuid;
		}

		public double Total()
		{
			return Items.Sum(c => c.Total());
		}
	}
}
