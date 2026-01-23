using System.Text.Json.Serialization;

namespace ERP_BACKEND.constracts;

public class Shelf
{
    public int SHELF_ID { get; set; }
    public string SHELF_NAME { get; set; } =string.Empty;
    
    
    
    [JsonIgnore]
    public virtual ICollection<AssetPlacement> Placements { get; set; }
}