﻿using Mapster;
using MyVitals.API.Interfaces.Persistence;

namespace MyVitals.API.Entities
{
    public class Unit: IUnit, IIsActivable
    {
        [UseDestinationValue]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }
    }
}
