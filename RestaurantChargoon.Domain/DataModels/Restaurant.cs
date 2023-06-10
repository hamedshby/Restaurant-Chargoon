namespace RestaurantChargoon.Domain.Entities
{
	public class Restaurant: BaseEntity, IDataModel
	{
        public string Name { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
		public string Address { get; set; }
		public bool IsDeleted { get; set; }
		public int UserId { get; set; }
        public User User { get; set; }
    }
}