using MyVitals.API.Interfaces;
using MyVitals.API.Interfaces.Persistence;

namespace MyVitals.API.Entities
{
    public class Indicator:IIndicator, IHasUnit, IIsActivable
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Abbreviature { get; set; }
        public IUnit Unit { get; set; }
        public bool IsActive { get; set; }
    }
}
