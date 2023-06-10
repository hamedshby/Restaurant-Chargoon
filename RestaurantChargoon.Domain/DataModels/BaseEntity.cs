namespace RestaurantChargoon.Domain.Entities
{
	public class BaseEntity
	{
		public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
	}

	public interface IDataModel
	{
		bool IsDeleted { get; set; }
	}
}
