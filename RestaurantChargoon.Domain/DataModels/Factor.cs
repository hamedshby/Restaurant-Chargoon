using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantChargoon.Domain.DataModels
{
    public class Factor : BaseEntity
	{
		public int RestaurantId { get; set; }
		[Column(TypeName = "nvarchar(50)")]
		public string? RestaurantName { get; set; }

        public int test { get; set; }
        public string test2 { get; set; }
        public int UserId { get; set; }
		public User User { get; set; }
		public ICollection<FactorDetail> FactorDetails { get; set; }


	}
}
