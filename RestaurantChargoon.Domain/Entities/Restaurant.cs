namespace RestaurantChargoon.Domain.Entities
{
	public class Restaurant: BaseEntity
	{
        public string RestaurantName { get; set; }
		public string ManagerName { get; set; }
		public int StartTime { get; set; }
		public int EndTime { get; set; }
		public string Address { get; set; }
        public User User { get; set; }
    }
}
