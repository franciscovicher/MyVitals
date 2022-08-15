namespace MyVitals.API.Interfaces.Persistence
{
    public interface IDbObject
    {
        DateTime Created { get; init; }
        DateTime Updated { get; set; }
    }
}
