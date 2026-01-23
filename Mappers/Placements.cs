namespace ERP_BACKEND.mappers;

public class PlacementMapper
{
    public int PlacementId { get; set; }
    public string ItemName { get; set; } = string.Empty;
    public string RackNumber { get; set; } = string.Empty;
    public string ShelfName { get; set; } = string.Empty;
    public DateTime PlacedDate { get; set; }
    public string? PlacedBy { get; set; } 
    public string Location { get; set; } = string.Empty;
    public string? WithdrawnBy { get; set; }
}