using MyVitals.API.Interfaces.Persistence;

namespace MyVitals.API.Interfaces
{
    public interface IHasUnit
    {
        IUnit Unit { get; set; }
    }
}
