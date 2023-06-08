using RestaurantChargoon.Domain.Contracts;

namespace RestaurantChargoon.Services.CommonServices
{
	public class InMemoryRepository<T>: IInMemoryRepository<T>
	{
		private List<T> _items;

		public InMemoryRepository()
		{
			_items = new List<T>();
		}

		public void Add(T item)
		{
			_items.Add(item);
		}

		public void Remove(T item)
		{
			_items.Remove(item);
		}

		public T Get()
		{
			return _items.FirstOrDefault();
		}
	}
}


