using Mapster;
using MyVitals.API.Interfaces.Persistence;

namespace MyVitals.API.ViewModels
{
    public class UnitViewModel: IUnit, IIsActivable
    {
        [UseDestinationValue]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }
    }
}
