namespace ERP_BACKEND.dtos;

public record readShelfDto
(
    int Shelf_Id,
    string? Shelf_Name
);

public record createShelfDto
(
  
    string? ShelfName
);