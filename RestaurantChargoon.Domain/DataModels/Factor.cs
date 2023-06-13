namespace RestaurantChargoon.Domain.Entities
{
	public class Factor : BaseEntity
	{
		public int RestaurantId { get; set; }
		public Restaurant Restaurant { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
        public DateTime Date { get; set; }
        public ICollection<FactorDetail> FactorDetails { get; set; }


	}
}
