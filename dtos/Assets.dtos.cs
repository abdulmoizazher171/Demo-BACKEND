namespace ERP_BACKEND.dtos;

public record AssetReadDto(
int ItemId,
string ItemName,
string CategoryName,
string? SystemNumber,

List<string> AttachmentUrls
);

public record AssetCreateDto(
    string ItemName,
    int CategoryId,
    int TurbineId,
    int StoreId,
    int rackid,
    string Description
);