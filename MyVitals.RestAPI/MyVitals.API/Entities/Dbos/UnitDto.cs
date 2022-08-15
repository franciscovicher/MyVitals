using System;
using Mapster;
using MyVitals.API.Interfaces.Persistence;

namespace MyVitals.API.Entities.Dto
{
    public class UnitDto:IUnit, IDbObject, IIsActivable
    {
        [UseDestinationValue]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public DateTime Created { get; init; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
    }
}
