﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantChargoon.Domain.DataModels
{
    public class Restaurant : BaseEntity, IDataModel
    {
        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(50, ErrorMessage = "تعداد کاراکترهای {1} باید حداکثر {0} حرف باشد")]
        [MinLength(2, ErrorMessage = "تعداد کاراکترهای {1} باید حداقل {0} حرف باشد")]
        public string Name { get; set; }

        [MaxLength(20, ErrorMessage = "تعداد کاراکترهای {1} باید حداکثر {0} حرف باشد")]
        public string StartTime { get; set; }

        [MaxLength(20, ErrorMessage = "تعداد کاراکترهای {1} باید حداکثر {0} حرف باشد")]
        public string EndTime { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(2, ErrorMessage = "تعداد کاراکترهای {1} باید حداقل {0} حرف باشد")]
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}