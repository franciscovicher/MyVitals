namespace MyVitals.API.Interfaces.Persistence
{
    public interface IUnit
    {
        int Id { get; set; }
        string Name { get; set; }
        string Symbol { get; set; }
    }
}
