using System;

namespace WingsOnApiCore.Models
{
    public class FlightModel : BaseModel
    {
        public string Number { get; set; }

        public AirlineModel Carrier { get; set; }

        public AirportModel DepartureAirport { get; set; }

        public DateTime DepartureDate { get; set; }

        public AirportModel ArrivalAirport { get; set; }

        public DateTime ArrivalDate { get; set; }

        public decimal Price { get; set; }
    }
}