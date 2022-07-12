namespace MyVitals.API.Interfaces
{
    public interface IMeasurement
    {
        Guid Id { get; init; }
        decimal Value { get; set; }
        DateTime MeasuredAt { get; set; }
    }
}
