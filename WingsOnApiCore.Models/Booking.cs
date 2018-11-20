using System;
using System.Collections.Generic;

namespace WingsOnApiCore.Models
{
    public class Booking : BaseModel
    {
        public string Number { get; set; }

        public Flight Flight { get; set; }

        public PersonModel Customer { get; set; }

        public IEnumerable<PersonModel> Passengers { get; set; }

        public DateTime DateBooking { get; set; }
    }
}