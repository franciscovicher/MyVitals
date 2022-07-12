using MyVitals.API.Interfaces;

namespace MyVitals.API.Entities
{
    public class Measurement : IMeasurement,IHasIndicator
    {
        public Guid Id { get; init; }
        public decimal Value { get; set; }
        public DateTime MeasuredAt { get; set; }
        public IIndicator Indicator { get; set; }
    }
}
