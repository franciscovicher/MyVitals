namespace MyVitals.API.Interfaces
{
    public interface IIndicator
    {
        int Id { get; init; }
        string Name { get; set; }
        string Abbreviature { get; set; }
    }
}
