namespace MauiBuberBreakfast2.Models
{
    public record Breakfast(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        Uri Image,
        List<string>Savory,
        List<string> Sweet
        );
    
}
