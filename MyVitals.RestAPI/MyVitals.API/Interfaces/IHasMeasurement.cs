namespace MyVitals.API.Interfaces
{
    public interface IHasMeasurement
    {
        IMeasurement Measurement { get; set; }
    }
}
