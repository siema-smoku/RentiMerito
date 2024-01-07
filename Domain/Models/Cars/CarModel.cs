using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Cars
{
    public class CarModel
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarName { get; set; }
        public bool IsRented { get; set; }
        public DateTime? RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public int? RentUserId { get; set; }
    }
}
