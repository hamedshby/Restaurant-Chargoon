using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantChargoon.Domain.Contracts
{
	public interface IInMemoryRepository<T>
	{
		public void Add(T item);

		public void Remove(T item);

		public T Get();
	}
}


