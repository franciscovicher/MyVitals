using MyVitals.API.Interfaces;

namespace MyVitals.API.Entities
{
    public class Unit: IUnit, IIsActivable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbrebiature { get; set; }
        public bool IsActive { get; set; }
    }
}
